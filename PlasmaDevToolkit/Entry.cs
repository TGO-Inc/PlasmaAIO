using System;
using System.Reflection;
using Console = PlasmaDevToolkit.Overrides.Console;
using PlasmaDevToolkit.Patches;
using PlasmaDevToolkit.DevToolkit;
using PlasmaAPI.Application;
using GameClass = PlasmaAPI.GameClass;
using UnityEngine;
using PlasmaAPI.PatchUtil;
using PlasmaAPI.GameClass.Visor;

namespace PlasmaDevToolkit
{
    public class Entry
    {
        internal static CommandCommunication CommandHandler;
        internal Assembly CurrentAssembly;
        internal Assembly AssemblyCSharp;
        internal Assembly AssemblyMap;
        internal Type[] Types;
        public Entry(Assembly baseAsm, Assembly CSharpAsm, Assembly assemblyMap)
        {
            CurrentAssembly = baseAsm;
            AssemblyCSharp = CSharpAsm;
            AssemblyMap = assemblyMap;
        }

        [STAThread]
        public void Start()
        {
            Console.Init();
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("[Debug Console Initialized]");
            System.Console.ResetColor();

            AssemblyManager.OnAssemblyLoad("PlasmaLibrary", ContinuePatching);
            AssemblyManager.OnAssemblyLoad("netstandard", StartComServer);
            
            // AssemblyManager.OnAssemblyLoad("QFSW.QC", () => PatchManager.CreatePatch<QuantumConsole>("QFSW.QC", PatchType.Postfix));
            
            PatchManager.CreatePatch<SteamController>("Assembly-CSharp", PatchType.Prefix);
        }
        private static void StartComServer()
        {
            CommandHandler = new CommandCommunication();
        }
        private void ContinuePatching()
        {
            PatchManager.CreatePatch<LoggerController>("Assembly-CSharp", PatchType.Prefix);
            PatchManager.CreatePatch<WorldController>("Assembly-CSharp", PatchType.Prefix);

            Application.logMessageReceived -= LogMessageReceived;
            Application.logMessageReceived += LogMessageReceived;

            
        }
        private void LogMessageReceived(string condition, string stackTrace, LogType type)
        {
            if (condition.StartsWith("<color")) return;
            if (type.Equals(LogType.Exception | LogType.Error))
                Console.FormatMessage(type, GameClass.LoggerController.LogClass.Generic, "\n\n" + condition + "\n\n" + stackTrace);
            else
                Console.FormatMessage(type, GameClass.LoggerController.LogClass.Generic, condition);
        }
    }
}
