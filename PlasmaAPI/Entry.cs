
extern alias GameClass;
using HarmonyLib;
using Plasma.API.GameHooks;
using Plasma.API.Patches;
using Plasma.Application;
using Plasma.PatchUtil;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using UnityEngine;
using System;
using System.Security;
using System.Runtime.CompilerServices;
using Plasma.API.Classes;
using PrefabUtil.Extensions;
using Plasma.Mods;

namespace Doorstop
{
    public class Entrypoint
    {

        private static Assembly DevToolkit;
        private static object DevToolkitInstance;
        private static DirectoryInfo BaseDirectory;
        private static Assembly CurrentAssembly;
        private static Assembly MapAssembly;
        private static string _nameSpace = null;
        internal static string NameSpace => _nameSpace ??= typeof(ModContainer_EMPTY_).Namespace.Split('.').MaxLength(2).Join(".");
        internal static Assembly AssemblyCSharp;
        internal static AppDomain CurrentDomain;


        [STAThread]
        public static void Start()
        {
            CurrentAssembly = Assembly.GetExecutingAssembly();
            BaseDirectory = Directory.GetParent(Path.GetDirectoryName(CurrentAssembly.Location));
            CurrentDomain = AppDomain.CurrentDomain;
            /*try
            {
                // Maybe not needed anymore?
                // CurrentDomain.Load(File.ReadAllBytes(Path.Combine(BaseDirectory.FullName, "ModLoader", "Microsoft.CSharp.dll")));
            }
            catch (Exception e)
            {
                CrashHandle(e);
            }*/
            try
            {
                var preloaded_assemblies = CurrentDomain.GetAssemblies();
                CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
                CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                foreach (Assembly preloaded in preloaded_assemblies)
                {
                    string name = preloaded.GetName().Name;
                    if (name.Equals("PlasmaMap")) MapAssembly = preloaded;
                    AssemblyManager.UpdateAssemblyInfo(name, preloaded);
                }

                PatchManager.Initialize();

                // need to wait, lucky number is 60? idek
                AssemblyManager.OnAssemblyLoad(60, () =>
                {
                    InitializeAPI();

                    LoadMods();
                });
            }
            catch (Exception e)
            {
                CrashHandle(e);
            }

        }

        public static void CrashHandle(Exception e)
        {
            File.WriteAllText("crash-" + (DateTime.Now.Ticks + new System.Random().Next(999)) + ".log", e.ToString());
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

                    PatchManager.CreatePatch<Plasma.API.Patches.Resources>("UnityEngine.CoreModule", PatchType.Postfix);
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
        private static void ImportDevToolkit(Assembly assembly)
        {
            string path = Path.GetDirectoryName(CurrentAssembly.Location);
            foreach (FileInfo file in new DirectoryInfo(path).GetFiles())
            {
                if (file.Name.Equals("DevToolkit.dll"))
                {
                    DevToolkit = CurrentDomain.Load(File.ReadAllBytes(file.FullName));
                    Type @class = DevToolkit.GetTypes().Where(t => t.Namespace.Equals("PlasmaDevToolkit") && t.Name.Equals("Entry")).FirstOrDefault();
                    DevToolkitInstance = Activator.CreateInstance(@class, CurrentAssembly, assembly, MapAssembly);
                    MethodInfo method = @class.GetRuntimeMethods().Where(m => m.Name.Equals("Start")).FirstOrDefault();
                    method.Invoke(DevToolkitInstance, null);
                }
            }
        }
        private static void LoadMods()
        {
            string path = Path.Combine(Entrypoint.BaseDirectory.FullName, "Mods");
            DirectoryInfo mods = new DirectoryInfo(path);

            if (!mods.Exists)
                mods.Create();

            foreach (FileInfo file in mods.GetFiles())
            {
                if (!file.Extension.ToLower().Equals(".dll"))
                    continue;

                if (File.Exists(Path.Combine(BaseDirectory.FullName, "Plasma_Data", "Managed", file.Name)))
                    continue;

                Log(Path.Combine(BaseDirectory.FullName, "Plasma_Data", "Managed", file.Name));

                LoadModFromFile(file);
            }
        }
        internal static void Log(string message)
        {
            if (DevToolkit != null)
            {
                Type @class = DevToolkit.GetTypes().Where(t => t.Namespace.Equals("PlasmaDevToolkit.Overrides") && t.Name.Equals("Console")).FirstOrDefault();
                MethodInfo logger = @class.GetRuntimeMethods().Where(m => m.Name.Equals("FormatMessage")).FirstOrDefault();
                logger.Invoke(DevToolkitInstance, new object[] { LogType.Log, GameClass.LoggerController.LogClass.Generic, message });

                // File.AppendAllText("log.txt", message + Environment.NewLine);
            }
        }

        private static void LoadModFromFile(FileInfo file)
        {
            try
            {
                var asm = CurrentDomain.Load(File.ReadAllBytes(file.FullName));

                Log("Loaded DLL: " + file.Name);
                string modNS = Entrypoint.NameSpace + '.' + Path.GetFileNameWithoutExtension(file.Name);

                Type entry_class = asm.GetTypes().Where(t =>
                    t.Namespace.Equals(modNS)
                    && t.Name.Equals("Initialization")
                ).FirstOrDefault() ?? throw new Exception("class is null");

                var ModInstance = Activator.CreateInstance(entry_class) ?? throw new Exception("instance is null");

                MethodInfo method = entry_class.GetRuntimeMethods()
                    .Where(m => m.Name.Equals("Start"))
                    .FirstOrDefault() ?? throw new Exception("method is null");

                method.Invoke(ModInstance, new object[0]);

                Log("Mod Initialized: " + file.Name);
            }
            catch (Exception e)
            {
                try
                {
                    AssemblyName.GetAssemblyName(file.FullName);
                    Log(e.ToString());
                }
                catch { }
                // this could be normal, an example is when loading non NET dll files on accident
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
            // File.AppendAllText("asm.txt", name + "\n");
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