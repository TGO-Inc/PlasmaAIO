using PlasmaAPI.Application;
using PlasmaAPI.GameClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Doorstop
{
    public static class Entrypoint
    {
        private static Assembly DevToolkit;
        private static object DevToolkitInstance;
        private static AppDomain currentDomain;
        [STAThread]
        public static void Start()
        {
            currentDomain = AppDomain.CurrentDomain;
            var preloaded_assemblies = currentDomain.GetAssemblies();
            currentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
            currentDomain.UnhandledException += CurrentDomain_UnhandledException;

            foreach (Assembly preloaded in preloaded_assemblies)
            {
                string name = preloaded.GetName().Name;
                File.AppendAllLines("start.txt", new string[] { name });
                AssemblyManager.UpdateAssemblyInfo(name, preloaded);
            }

            AssemblyManager.OnAssemblyLoad("Assembly-CSharp", ImportDevToolkit);
        }

        private static void ImportDevToolkit()
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string file in Directory.GetFiles(dir))
            {
                if (Path.GetFileName(file).Equals("DevToolkit.dll"))
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(file);
                        DevToolkit = currentDomain.Load(bytes);
                        Type @class = DevToolkit.GetTypes().Where(t => t.Namespace.Equals("PlasmaDevToolkit") && t.Name.Equals("Entry")).FirstOrDefault();
                        DevToolkitInstance = @class.GetConstructor(new Type[0]).Invoke(new object[0]);
                    }
                    catch (Exception e)
                    {
                        File.AppendAllLines("error.txt", new string[] { e.InnerException.Message });
                    }
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
            File.AppendAllLines("added.txt", new string[] { name });
            AssemblyManager.UpdateAssemblyInfo(name, args.LoadedAssembly);
        }
    }
}