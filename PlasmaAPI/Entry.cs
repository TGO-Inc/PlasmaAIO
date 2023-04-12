extern alias GameClass;
using HarmonyLib;
using PlasmaAPI.API.GameHooks;
using PlasmaAPI.API.Patches;
using PlasmaAPI.Application;
using PlasmaAPI.PatchUtil;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Doorstop
{
    public class Entrypoint
    {
        private static DirectoryInfo BaseDirectory;
        private static Assembly CurrentAssembly;
        private static Assembly DevToolkit;
        private static Assembly MapAssembly;
        internal static Assembly AssemblyCSharp;
        private static object DevToolkitInstance;
        internal static AppDomain CurrentDomain;
        
        [STAThread]
        public static void Start()
        {
            CosturaUtility.Initialize();

            CurrentAssembly = Assembly.GetExecutingAssembly();
            BaseDirectory = Directory.GetParent(Path.GetDirectoryName(CurrentAssembly.Location));
            CurrentDomain = AppDomain.CurrentDomain;
            CurrentDomain.Load(File.ReadAllBytes(Path.Combine(BaseDirectory.FullName, "ModLoader", "Microsoft.CSharp.dll")));
            
            var preloaded_assemblies = CurrentDomain.GetAssemblies();
            CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
            CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            foreach (Assembly preloaded in preloaded_assemblies)
            {
                string name = preloaded.GetName().Name;
                //File.AppendAllText("asm.txt", name+"\n");
                if (name.Equals("PlasmaMap"))
                    MapAssembly = preloaded;
                AssemblyManager.UpdateAssemblyInfo(name, preloaded);
            }

            PatchManager.Initialize();

            InitializeAPI();

            LoadMods();
        }

        private static void CrashHandle(Exception e)
        {
            File.WriteAllText("crash-" + DateTime.Now.Ticks + ".log", e.ToString());
        }

        private static void InitializeAPI()
        {
            AssemblyCSharp = CurrentDomain.Load(new AssemblyName("Assembly-CSharp"));
            
            Type EnumResult = typeof(Enum).GetNestedType("EnumResult", BindingFlags.NonPublic);
            var original = typeof(Enum).GetRuntimeMethods().Where(m => m.Name.Equals("TryParseEnum")).FirstOrDefault();
            var target = typeof(EnumPatch).GetRuntimeMethods().Where(m => m.Name.Equals("TryParseEnum")).FirstOrDefault();
            var tinfo = target.MakeGenericMethod(EnumResult);
            PatchManager.Patch.Patch(original, postfix: new HarmonyMethod(tinfo));
                
            original = typeof(Enum).GetRuntimeMethods().Where(m => m.Name.Equals("GetNames")).FirstOrDefault();
            target = typeof(EnumPatch).GetRuntimeMethods().Where(m => m.Name.Equals("GetNames")).FirstOrDefault();
            PatchManager.Patch.Patch(original, postfix: new HarmonyMethod(target));

            //AssemblyManager.OnAssemblyLoad(, ContinuePatching);

            ImportDevToolkit(AssemblyCSharp);

            ContinuePatching();
        }
        private static void ContinuePatching()
        {
            PlasmaGame.OnGameInitialization += InitializeUpdateHandle;

            AssemblyManager.OnAssemblyLoad("UnityEngine.UI", () =>
            {
                try
                {
                    PatchManager.CreatePatch<Holder>("Assembly-CSharp", PatchType.Prefix);

                    PatchManager.Patch.CreateClassProcessor(typeof(ObjectPatchClass)).Patch();

                    PatchManager.CreatePatch<ProcessorUICategoryItem>("Assembly-CSharp", PatchType.Prefix);

                    PatchManager.CreatePatch<ComponentItem>("Assembly-CSharp", PatchType.Prefix);
                    PatchManager.CreatePatch<Device>("Assembly-CSharp", PatchType.Prefix);

                    PatchManager.CreatePatch<PlasmaAPI.API.Patches.Resources>("UnityEngine.CoreModule", PatchType.Postfix);
                    PatchManager.CreatePatch<VFXComponent>("Assembly-CSharp", PatchType.Prefix);
                    PatchManager.CreatePatch<FemaleSocketPoint>("Assembly-CSharp", PatchType.Prefix);

                    PatchManager.CreatePatch<ComponentHandler>("Assembly-CSharp", PatchType.Prefix);

                    // Get the generic method definition of Instantiate
                    var originalMethod = AccessTools.FirstMethod(typeof(UnityEngine.Object), m =>
                        m.Name == "Instantiate" &&
                        m.IsGenericMethodDefinition &&
                        m.GetParameters().Length == 1 &&
                        m.GetParameters()[0].ParameterType.IsGenericParameter
                    );
                    // Make it a generic method for Object (or any other specific type if needed)
                    var originalMethodGeneric = originalMethod.MakeGenericMethod(typeof(UnityEngine.Object));

                    // Get the non-generic wrapper method for patching
                    var prefixMethod = AccessTools.Method(typeof(ObjectPatchClass), "InstantiatePrefixNonGeneric");

                    PatchManager.Patch.Patch(originalMethodGeneric, prefix: new HarmonyMethod(prefixMethod));
                }
                catch (Exception ex)
                {
                    Entrypoint.Log(ex.ToString());
                }
            });
        }
        private static void InitializeUpdateHandle()
        {
            PlasmaGame.UpdateHandle = new GameObject("UpdateHandle");
            PlasmaGame.UpdateHandle.AddComponent<UpdateHandle>();
        }
        private static void ImportDevToolkit(object assembly)
        {
            string path = Path.GetDirectoryName(CurrentAssembly.Location);
            foreach (FileInfo file in new DirectoryInfo(path).GetFiles())
            {
                if (file.Name.Equals("DevToolkit.dll"))
                {
                    DevToolkit = CurrentDomain.Load(File.ReadAllBytes(file.FullName));
                    Type @class = DevToolkit.GetTypes().Where(t => t.Namespace.Equals("PlasmaDevToolkit") && t.Name.Equals("Entry")).FirstOrDefault();
                    DevToolkitInstance = Activator.CreateInstance(@class, CurrentAssembly, (Assembly)assembly, MapAssembly);
                    MethodInfo method = @class.GetRuntimeMethods().Where(m => m.Name.Equals("Start")).FirstOrDefault();
                    method.Invoke(DevToolkitInstance, null);
                }
            }
        }
        private static void LoadMods()
        {
            DirectoryInfo mods = Directory.CreateDirectory(Path.Combine(BaseDirectory.FullName, "Mods"));
            
            foreach(FileInfo file in mods.EnumerateFiles())
                if (file.Extension.ToLower().Equals(".dll"))
                    if(!File.Exists(Path.Combine(BaseDirectory.FullName, "Plasma_Data", "Managed", file.Name)))
                        LoadModFromFile(file);
        }
        internal static void Log(string message)
        {
            if (DevToolkit != null)
            {
                Type @class = DevToolkit.GetTypes().Where(t => t.Namespace.Equals("PlasmaDevToolkit.Overrides") && t.Name.Equals("Console")).FirstOrDefault();
                MethodInfo logger = @class.GetRuntimeMethods().Where(m => m.Name.Equals("FormatMessage")).FirstOrDefault();
                logger.Invoke(DevToolkitInstance, new object[] { LogType.Log, GameClass.LoggerController.LogClass.Generic, message });
            }
        }
        private static void LoadModFromFile(FileInfo file)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(file.FullName);
                var asm = CurrentDomain.Load(bytes);

                Log("Loaded DLL: " + file.Name);

                Type entry_class = asm.GetTypes().Where(t =>
                    t.Namespace.Equals("PlasmaAPI.Mods." + Path.GetFileNameWithoutExtension(file.Name))
                    && t.Name.Equals("Initialization")
                ).FirstOrDefault();

                if (entry_class == null) throw new Exception("class is null");
                var ModInstance = Activator.CreateInstance(entry_class);
                if (ModInstance == null) throw new Exception("instance is null");
                MethodInfo method = entry_class.GetRuntimeMethods().Where(m => m.Name.Equals("Start")).FirstOrDefault();
                if (method == null) throw new Exception("method is null");
                method.Invoke(ModInstance, null);

                Log("Mod Initialized: " + file.Name);
            }
            catch (Exception e)
            {
                // File.WriteAllText("mod_load_error.txt", e.ToString());
            }
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs a)
        {
            CrashHandle((Exception)a.ExceptionObject);
        }
        private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            string name = args.LoadedAssembly.GetName().Name;
            //File.AppendAllText("asm.txt", name + "\n");
            try
            {
                AssemblyManager.UpdateAssemblyInfo(name, args.LoadedAssembly);
            }
            catch (Exception e)
            {
                File.WriteAllText("assembly.log", e.ToString());
            }
        }
    }
}