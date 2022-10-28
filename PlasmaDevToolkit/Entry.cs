using HarmonyLib;
using Microsoft.Win32;
using Sirenix.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using Console = PlasmaDevToolkit.Overrides.Console;
using static PlasmaDevToolkit.Patches.LoggerController;
using static PlasmaDevToolkit.Patches.SteamController;
using static PlasmaDevToolkit.Patches.Controllers;
using PlasmaDevToolkit.DevToolkit;
using PlasmaAPI.GameClass;
using PlasmaAPI.Application;

namespace PlasmaDevToolkit
{
    public class Entry
    {
        internal Harmony Patch;
        internal readonly List<Tuple<Tuple<Type, string, Type[]>, Tuple<Type, string, Type[]>, PatchType>> ManualPatches = new List<Tuple<Tuple<Type, string, Type[]>, Tuple<Type, string, Type[]>, PatchType>>()
        {
            new Tuple<Tuple<Type, string, Type[]>, Tuple<Type, string, Type[]>, PatchType>(
                new Tuple<Type, string, Type[]>(typeof(LoggerController), "LogMessage", new Type[] { typeof(LogType), typeof(LoggerController.LogClass), typeof(string) }),
                new Tuple<Type, string, Type[]>(typeof(LogMessage), "Prefix", new Type[] { typeof(bool).MakeByRefType(), typeof(bool).MakeByRefType() }),
                PatchType.Prefix
            )
        };
        internal CommandCommunication CommandHandler;
        public Entry()
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            File.WriteAllText(dir + "\\log.txt", "ASAGFS");
            /*
            Console.Init();
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("[Debug Console Initialized]");
            System.Console.ResetColor();

            AssemblyManager.OnAssemblyLoad("PlasmaLibrary", ContinuePatching);
            AssemblyManager.OnAssemblyLoad("netstandard", StartComServer);

            Patch = new Harmony("tgo.mod.loader");
            Patch.CreateClassProcessor(typeof(Init)).Patch();
            Patch.CreateClassProcessor(typeof(RequestUserInformation)).Patch();
            Patch.CreateClassProcessor(typeof(Update)).Patch();*/
        }
        private void StartComServer()
        {
            CommandHandler = new CommandCommunication();
        }
        private void ContinuePatching()
        {
            MethodInfo original0 = typeof(Holder).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
            MethodInfo prefix0 = typeof(Awake).GetMethod("Prefix", BindingFlags.Static | BindingFlags.Public, null, new Type[] { }, null);
            Patch.Patch(original0, new HarmonyMethod(prefix0));

            Patch.PatchAll(Assembly.GetExecutingAssembly());

            foreach (var patch in ManualPatches)
            {
                try
                {
                    MethodInfo original = patch.Item1.Item1.GetMethod(patch.Item1.Item2, BindingFlags.NonPublic | BindingFlags.Instance, null, patch.Item1.Item3, null);
                    MethodInfo prefix = patch.Item2.Item1.GetMethod(patch.Item2.Item2, BindingFlags.Static | BindingFlags.Public, null, patch.Item2.Item3, null);
                    switch (patch.Item3)
                    {
                        case PatchType.Prefix:
                            Patch.Patch(original, new HarmonyMethod(prefix));
                            break;
                        case PatchType.Postfix:
                            Patch.Patch(original, null, new HarmonyMethod(prefix));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(ex.Message);
                    System.Console.ResetColor();
                }
            }

            Application.logMessageReceived -= LogMessageReceived;
            Application.logMessageReceived += LogMessageReceived;
        }
        private void LogMessageReceived(string condition, string stackTrace, LogType type)
        {
            if (condition.StartsWith("<color")) return;
            if (type.Equals(LogType.Exception | LogType.Error))
                Console.FormatMessage(type, LoggerController.LogClass.Generic, "\n\n" + condition + "\n\n" + stackTrace);
            else
                Console.FormatMessage(type, LoggerController.LogClass.Generic, condition);
        }
    }
    internal enum PatchType
    {
        Prefix,
        Postfix
    }
}
