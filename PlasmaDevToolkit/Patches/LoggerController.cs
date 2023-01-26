extern alias GameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using Console = PlasmaDevToolkit.Overrides.Console;
using System.Diagnostics;
using UnityEngine;
using PlasmaDevToolkit.Overrides;
using static GameClass::LoggerController;

namespace PlasmaDevToolkit.Patches
{
    internal class LoggerController
    {
        public static bool Log(LogClass logClass, string message, string id)
        {
            if (LoggerUtil.PassesGarbage(LogDetail.Default, logClass, message))
            {
                Console.FormatMessage(LogType.Log, logClass, message);
            }
            return true;
        }

        public static bool LogVerbose(LogClass logClass, string message, string id)
        {
            if (LoggerUtil.PassesGarbage(LogDetail.Default, logClass, message))
            {
                Console.FormatMessage(LogType.Log, logClass, message);
            }
            return true;
        }

        public static bool LogWarning(ref LogClass logClass, string message)
        {
            if (LoggerUtil.PassesGarbage(LogDetail.Default, logClass, message))
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
    internal static class LoggerUtil
    {
        private static readonly Dictionary<string, DateTime> last_console_times = new Dictionary<string, DateTime>();
        private static readonly string[] DefaultFilter = new string[]
        {
            "lateupdate",
            //"processoperations",
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

                    if (DefaultFilter.Contains(name) && TimeUtil.GetFrame() > 0) return false;

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
