using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using _LoggerController = PlasmaAPI.GameClass.LoggerController;
using Console = PlasmaDevToolkit.Overrides.Console;
using System.Diagnostics;
using UnityEngine;
using static PlasmaAPI.GameClass.LoggerController;

namespace PlasmaDevToolkit.Patches
{
    class LoggerController
    {
        public enum LogDetail
        {
            Minimal,
            Default,
            All
        }
        static Dictionary<string, DateTime> last_console_times = new Dictionary<string, DateTime>();
        static string[] DefaultFilter = new string[]
        {
            "lateupdate",
            "processoperations",
            "handleonpreupdatedevices",
            "schedulecopytexture",
            "scheduleadvancedcopytexture",
            "schedulecleartexture"
        };
        static bool PassesGarbage(LogDetail detail, LogClass logclass, string msg)
        {
            if (Time.frameCount > 0)
            {
                if (!detail.Equals(LogDetail.All))
                {
                    if (logclass.Equals(LogClass.Sketch)) return false;

                    string name = new StackTrace().GetFrame(4).GetMethod().Name.ToLower().Trim();
                    
                    if (DefaultFilter.Contains(name)) return false;
                    
                    if (detail.Equals(LogDetail.Minimal))
                    {
                        DateTime now = DateTime.UtcNow;
                        bool key = last_console_times.ContainsKey(name);
                        if (key)
                        {
                            TimeSpan diff = now - last_console_times[name];
                            if (Math.Abs(diff.TotalMilliseconds) < 50) return false;
                            last_console_times[name] = now;
                        }
                        else
                        {
                            last_console_times.Add(name, now);
                        }
                    }
                }
            }
            return true;
        }
        [HarmonyPatch(typeof(_LoggerController), nameof(_LoggerController.Log))]
        class Log
        {
            static bool Prefix(_LoggerController __instance, LogClass logClass, string message, string id)
            {
                if (PassesGarbage(LogDetail.Minimal, logClass, message))
                {
                    Console.FormatMessage(LogType.Log, logClass, message);
                }
                return true;
            }
        }
        [HarmonyPatch(typeof(_LoggerController), nameof(_LoggerController.LogVerbose))]
        class LogVerbose
        {
            static bool Prefix(_LoggerController __instance, LogClass logClass, string message, string id)
            {
                if (PassesGarbage(LogDetail.Minimal, logClass, message))
                {
                    Console.FormatMessage(LogType.Log, logClass, message);
                }
                return true;
            }
        }
        [HarmonyPatch(typeof(_LoggerController), nameof(_LoggerController.LogWarning))]
        class LogWarning
        {
            static bool Prefix(_LoggerController __instance, ref _LoggerController.LogClass logClass, string message)
            {
                if (PassesGarbage(LogDetail.Minimal, logClass, message))
                {
                    Console.FormatMessage(LogType.Warning, logClass, message);
                }
                return true;
            }
        }
        public class LogMessage
        {
            public static bool Prefix(ref bool ___showCaller, ref bool ___showFrame)
            {
                ___showCaller = true;
                ___showFrame = true;
                return true;
            }
        }
    }
}
