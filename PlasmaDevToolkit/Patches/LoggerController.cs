using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using _LoggerController = PlasmaAPI.GameClass.LoggerController;
using Console = PlasmaDevToolkit.Overrides.Console;
using System.Diagnostics;
using UnityEngine;
using static PlasmaAPI.GameClass.LoggerController;
using PlasmaDevToolkit.Overrides;

namespace PlasmaDevToolkit.Patches
{
    internal class LoggerController
    {
        public static bool Log(_LoggerController __instance, LogClass logClass, string message, string id)
        {
            if (LoggerUtil.PassesGarbage(LogDetail.Minimal, logClass, message))
            {
                Console.FormatMessage(LogType.Log, logClass, message);
            }
            return true;
        }

        public static bool LogVerbose(_LoggerController __instance, LogClass logClass, string message, string id)
        {
            if (LoggerUtil.PassesGarbage(LogDetail.Minimal, logClass, message))
            {
                Console.FormatMessage(LogType.Log, logClass, message);
            }
            return true;
        }

        public static bool LogWarning(_LoggerController __instance, ref LogClass logClass, string message)
        {
            if (LoggerUtil.PassesGarbage(LogDetail.Minimal, logClass, message))
            {
                Console.FormatMessage(LogType.Warning, logClass, message);
            }
            return true;
        }

        public static bool LogMessage(ref bool ___showCaller, ref bool ___showFrame)
        {
            ___showCaller = true;
            ___showFrame = true;
            return true;
        }
    }
    public static class LoggerUtil
    {
        static readonly Dictionary<string, DateTime> last_console_times = new Dictionary<string, DateTime>();
        static readonly string[] DefaultFilter = new string[]
        {
            "lateupdate",
            "processoperations",
            "handleonpreupdatedevices",
            "schedulecopytexture",
            "scheduleadvancedcopytexture",
            "schedulecleartexture"
        };
        public static bool PassesGarbage(LogDetail detail, LogClass logclass, string msg)
        {
            if (TimeUtil.GetFrame() > 0)
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
    }
    public enum LogDetail
    {
        Minimal,
        Default,
        All
    }
}
