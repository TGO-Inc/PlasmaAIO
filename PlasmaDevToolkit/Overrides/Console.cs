using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;
using Color = UnityEngine.Color;
using System.Drawing;
using Sirenix.Utilities;
using System.Reflection;
using System.Collections.Concurrent;
using Random = System.Random;
using System.Runtime.InteropServices;
using System.Timers;
using static PlasmaAPI.GameClass.LoggerController;
using System.Runtime.ExceptionServices;

namespace PlasmaDevToolkit.Overrides
{
    public class Console
    {
        private volatile static bool IsBusy = false;
        public static bool Busy()
        {
            if (!IsBusy)
                FreezeContext.Enqueue(' ');
            return IsBusy;
        }
        private static readonly ConcurrentQueue<char> FreezeContext = new ConcurrentQueue<char>();
        private static readonly ConcurrentQueue<(LogType, LogClass, StackTrace, string)> LogContext = new ConcurrentQueue<(LogType, LogClass, StackTrace, string)>();
        private volatile static TextWriter Out;
        private volatile static ConsoleColor DefaultColor;
        private static Task WriteStream;
        private static Timer CheckFreeze;
        public static void Init()
        {
            if (GetConsoleWindow() == IntPtr.Zero)
                AllocConsole();

            Out = System.Console.Out;
            System.Console.ResetColor();
            DefaultColor = System.Console.ForegroundColor;

            System.Console.Title = "Plasma Debug Console";
            System.Console.Clear();

            CheckFreeze = new Timer()
            {
                AutoReset = true,
                Enabled = true,
                Interval = 100
            };
            CheckFreeze.Elapsed += CheckFreeze_Elapsed;

            WriteStream = new Task(BeginWrite);
            WriteStream.Start();
        }
        private static async void CheckFreeze_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (FreezeContext.TryDequeue(out char x))
            {
                Task Timeout = Task.Delay(TimeSpan.FromMilliseconds(50));
                Task Write = Task.Run(() =>
                {
                    Console.Write(x);
                    System.Console.CursorLeft--;
                });
                if (await Task.WhenAny(Timeout, Write) == Timeout)
                {
                    IsBusy = true;
                    while (FreezeContext.TryDequeue(out char _)) { }
                }
                await Write;
                IsBusy = false;
            }
        }
        public static void ResetColor()
        {
            System.Console.ForegroundColor = DefaultColor;
        }
        public static void Write(object @log)
        {
            Out.Write(log.ToString());
        }
        public static void Write(object @log, ConsoleColor @color)
        {
            System.Console.ForegroundColor = color;
            Out.Write(log.ToString());
            ResetColor();
        }
        public static void WriteLine(object @log)
        {
            Out.WriteLine(log.ToString());
        }
        public static void WriteLine(object @log, ConsoleColor @color)
        {
            System.Console.ForegroundColor = color;
            Out.WriteLine(log.ToString());
            ResetColor();
        }
        internal static void WriteLineIf(object @log, bool @can_log)
        {
            if (can_log) WriteLine(@log);
        }
        internal static void WriteIf(object @log, bool @can_log)
        {
            if (can_log) Write(@log);
        }
        private static void BeginWrite()
        {
            while (true)
            {
                if (LogContext.TryDequeue(out (LogType Type, LogClass Class, StackTrace Trace, string Message) data))
                {
                    TryWrite(data.Type, data.Class, data.Trace, data.Message);
                }
            }
        }
        private static void TryWrite(LogType? type, LogClass? logClass, StackTrace trace, string message)
        {
            ConsoleColor color;
            MethodBase method = trace.GetFrame(Math.Min(4, trace.FrameCount - 1)).GetMethod();
            string @class = method.ReflectedType.Name;
            string name = method.Name;

            if (name.Equals("LogFormat"))
            {
                method = trace.GetFrame(trace.FrameCount - 1).GetMethod();
                @class = method.ReflectedType.Name;
                name = method.Name;
            }

            Console.Write("[");
            Console.Write(TimeUtil.GetFrame(), ConsoleColor.Cyan);
            Console.Write("] ");

            color = Console.ClosestConsoleColor(Color.HSVToRGB((float)logClass / 10f * 0.5f + 0.5f, 0.6f, 0.8f, false));

            Console.Write("[");
            Console.Write(logClass.ToString(), color);
            Console.Write("] ");

            color = Console.ClosestConsoleColor(Color.HSVToRGB(name.GetHashCode() / 2.1474836E+09f * 0.5f + 0.5f, 0.6f, 0.8f, false), true);

            /*
            if (type.Equals(LogType.Exception) || type.Equals(LogType.Error))
            {
                string method_class = message.Split('\n')[6].Split(' ')[0].Trim();
                var ar = method_class.Split('.');
                name = ar[ar.Length - 1];
                ar[ar.Length - 1] = null;
                @class = string.Join(".", ar.Where(x => x != null));
                color = ConsoleColor.DarkYellow;
            }
            */

            Console.Write(@class + ".", ConsoleColor.DarkGray);
            Console.Write(name, color);
            Console.Write("() ", ConsoleColor.DarkGray);

            color = System.Console.ForegroundColor;
            if (type.Equals(LogType.Warning))
                color = ConsoleColor.Yellow;
            if (type.Equals(LogType.Exception) || type.Equals(LogType.Error))
                color = ConsoleColor.DarkRed;
            if (type.Equals(LogType.Assert))
                color = ConsoleColor.DarkBlue;

                Console.WriteLine(message, color);
        }
        public static void FormatMessage(LogType type, LogClass logClass, string message)
        {
            LogContext.Enqueue((type, logClass, new StackTrace(), message));
        }
        public static void FormatMessage(string message)
        {
            LogContext.Enqueue((LogType.Log, LogClass.Generic, new StackTrace(), message));
        }
        public static void FormatMessage(string message, LogType type)
        {
            LogContext.Enqueue((type, LogClass.Generic, new StackTrace(), message));
        }
        public static void FormatMessage(Exception exception)
        {
            LogContext.Enqueue((LogType.Exception, LogClass.Generic, new StackTrace(), exception.Message));
            LogContext.Enqueue((LogType.Warning, LogClass.Generic, new StackTrace(), exception.StackTrace));
        }
        private static ConsoleColor ClosestConsoleColor(Color _c, bool shift = false)
        {
            // conversion nessesary for correct colors for some reason
            string hex = ColorUtility.ToHtmlStringRGB(_c);
            var nc = ColorTranslator.FromHtml("#" + hex);
            ConsoleColor ret = 0;
            double rr = nc.R, gg = nc.G, bb = nc.B, delta = double.MaxValue;

            if (shift)
            {
                rr += 75;
                gg += 40;
            }

            foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
            {
                var n = Enum.GetName(typeof(ConsoleColor), cc);
                var c = System.Drawing.Color.FromName(n == "DarkYellow" ? "Orange" : n); // bug fix
                var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
                if (t == 0.0)
                    return cc;
                if (t < delta)
                {
                    delta = t;
                    ret = cc;
                }
            }

            if (shift && ret.Equals(ConsoleColor.DarkGray))
                ret = ConsoleColor.Blue;

            return ret;
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int FreeConsole();
    }
    public static class TimeUtil
    {
        private static bool IsLoaded = false;
        private static int Frame()
        {
            return Time.frameCount;
        }
        public static int GetFrame()
        {
            if (IsLoaded)
                return Frame();
            return 0;
        }
        internal static void UpdateLoad()
        {
            IsLoaded = true;
        }
    }
}
