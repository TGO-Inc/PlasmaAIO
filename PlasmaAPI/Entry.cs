using PlasmaAPI.Application;
using PlasmaAPI.GameClass;
using PlasmaAPI.PatchUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine;

namespace Doorstop
{
    public class Entrypoint
    {
        private static Assembly CurrentAssembly;
        private static Assembly DevToolkit;
        private static Assembly MapAssembly;
        private static object DevToolkitInstance;
        private static AppDomain CurrentDomain;

        [STAThread]
        public static void Start()
        {
            CurrentAssembly = Assembly.GetExecutingAssembly();
            CurrentDomain = AppDomain.CurrentDomain;
            var preloaded_assemblies = CurrentDomain.GetAssemblies();
            CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
            CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            foreach (Assembly preloaded in preloaded_assemblies)
            {
                string name = preloaded.GetName().Name;
                if (name.Equals("PlasmaMap"))
                    MapAssembly = preloaded;
                AssemblyManager.UpdateAssemblyInfo(name, preloaded);
            }

            PatchManager.Initialize();

            ImportDevToolkit(CurrentDomain.Load(new AssemblyName("Assembly-CSharp")));
        }
        private static void ImportDevToolkit(object assembly)
        {
            string dir = Path.GetDirectoryName(CurrentAssembly.Location);
            foreach (string file in Directory.GetFiles(dir))
            {
                if (Path.GetFileName(file).Equals("DevToolkit.dll"))
                {
                    byte[] bytes = File.ReadAllBytes(file);
                    DevToolkit = CurrentDomain.Load(bytes);
                    Type @class = DevToolkit.GetTypes().Where(t => t.Namespace.Equals("PlasmaDevToolkit") && t.Name.Equals("Entry")).FirstOrDefault();
                    DevToolkitInstance = Activator.CreateInstance(@class, CurrentAssembly, (Assembly)assembly, MapAssembly);
                    MethodInfo method = @class.GetRuntimeMethods().Where(m => m.Name.Equals("Start")).FirstOrDefault();
                    method.Invoke(DevToolkitInstance, null);
                }
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs a)
        {
            Exception e = (Exception)a.ExceptionObject;
            File.WriteAllText("crash-" + DateTime.Now.Ticks + ".log", string.Join("\r\n", e.Message, e.StackTrace));
        }
        private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            string name = args.LoadedAssembly.GetName().Name;
            AssemblyManager.UpdateAssemblyInfo(name, args.LoadedAssembly);
        }
    }
}