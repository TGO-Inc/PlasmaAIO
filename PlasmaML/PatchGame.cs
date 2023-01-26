#define HIDE_VERBOSE
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PlasmaML
{
    sealed class PatchGame
    {
        public PatchGame(string game_dir)
        {
            // Load doorstop
            Assembly _asm = Assembly.GetExecutingAssembly();
            string config = "PlasmaML.Doorstop.doorstop_config.ini";
#if x64
#if DEBUG && !HIDE_VERBOSE
            string assembly = "PlasmaML.Doorstop.x64-DEBUG.dll";
#else
            string assembly = "PlasmaML.Doorstop.x64.dll";
#endif
#elif AnyCPU
#if DEBUG
            string assembly = "PlasmaML.Doorstop.x86-DEBUG.dll";
#else
            string assembly = "PlasmaML.Doorstop.x86.dll";
#endif
#endif
            Process[] plasma_instances = Process.GetProcesses().Where(p => p.ProcessName.Equals("Plasma") || p.ProcessName.Equals("UnityCrashHandler64")).ToArray();
            int processes = plasma_instances.Length;
            if (processes > 0)
            {
                foreach(Process plasma in plasma_instances)
                {
                    try
                    {
                        plasma.Kill();
                        plasma.WaitForExit();
                    }
                    catch { }
                }
            }

            using (Stream stream = _asm.GetManifestResourceStream(assembly))
            {
                using var memoryStream = new MemoryStream();
                stream.CopyTo(memoryStream);
                var fileContents = memoryStream.ToArray();
                File.WriteAllBytes(Path.Combine(game_dir, "version.dll"), fileContents);
            }

            using (Stream stream = _asm.GetManifestResourceStream(config))
            {
                using StreamReader reader = new StreamReader(stream);
                string result = reader.ReadToEnd();
                File.WriteAllText(Path.Combine(game_dir, "doorstop_config.ini"), result);
            }

            game_dir = Path.Combine(game_dir, "ModLoader");
            Directory.CreateDirectory(game_dir);

            File.Copy(Path.Combine(Path.GetDirectoryName(_asm.Location), "ModLoader.dll"), Path.Combine(game_dir, "ModLoader.dll"), true);
            
            File.Copy("C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.8\\Microsoft.CSharp.dll", Path.Combine(game_dir, "Microsoft.CSharp.dll"), true);

            string debug = Path.Combine(Path.GetDirectoryName(_asm.Location), "DevToolkit.dll");
            if(File.Exists(debug))
                File.Copy(debug, Path.Combine(game_dir, "DevToolkit.dll"), true);

            string path = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(n => n.EndsWith("0Harmony.dll")).FirstOrDefault();
            var harmony = File.OpenWrite(Path.Combine(game_dir, "0Harmony.dll"));
            Assembly.GetExecutingAssembly().GetManifestResourceStream(path).CopyTo(harmony);
            harmony.Flush();
            harmony.Close();
        }
    }
}
