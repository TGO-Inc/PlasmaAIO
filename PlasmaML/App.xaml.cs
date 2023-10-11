using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Media;
using System.IO.Pipes;
using System.Security.RightsManagement;
using Hardcodet.Wpf.TaskbarNotification;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace PlasmaML
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static App self;
        public static App GetApp() => self;
        DirectoryInfo CurrentDirectory;
        Task DebugHandler;
        string GameDir;
        Process Game;
        static IntPtr handle;
        TaskbarIcon tray;
        public App()
        {
            self = this;
            this.CurrentDirectory = new DirectoryInfo(Assembly.GetExecutingAssembly().Location);
            this.GameDir = GetGameDir();
            //handle = GetConsoleWindow();
            //ShowWindow(handle, SW_HIDE);
            //_handler += new EventHandler(Handler);
            //SetConsoleCtrlHandler(_handler, true);
            AppDomain.CurrentDomain.ProcessExit += EndGame;
            this.tray = new TaskbarIcon();
            string lp = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(n => n.EndsWith("icon.ico")).FirstOrDefault();
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(lp));
            var ico = bitmap.GetHicon();
            this.tray.Icon = System.Drawing.Icon.FromHandle(ico);
            this.tray.Visibility = Visibility.Visible;
            this.tray.ToolTip = new TextBlock() { Text = "Plasma UnityEngine.Debug" };
            var menu = new ContextMenu();
            var close = new MenuItem() { Header = "Exit" };
            close.Click += Close_Click;
            menu.Items.Add(close);
            this.tray.ContextMenu = menu;
            new PatchGame(this.GameDir);
            this.StartGame();
            //new MainWindow().Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            EndGame(sender, e);
        }

        private void EndGame(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Plasma"))
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                }
                catch { }
            }
            Environment.Exit(0);
        }
        public void StartGame()
        {
            string outputDir = this.CurrentDirectory.Parent.FullName;
            string dll = Path.Combine(outputDir, "ModLoader.dll");
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\DryLicorice\\Plasma", "ModLoader", dll);

            this.Game = Process.Start(new ProcessStartInfo()
            {
                FileName = Path.Combine(this.GameDir, "Plasma.exe"),
                WorkingDirectory = this.GameDir,
            });
            Task.Run(() =>
            {
                this.Game.WaitForExit();
                this.EndGame(null, null);
            });
        }

        private static string GetGameDir()
        {
            var paths = new List<string>()
            {
                (string)Registry.LocalMachine?.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam")?.GetValue("InstallPath")
            };
            if (paths[0] == null || !Directory.Exists(paths[0])) return null;

            string config = File.ReadAllText($"{paths[0]}\\config\\config.vdf");
            foreach (Match match in Regex.Matches(config, "\"BaseInstallFolder_[0-9]\"\\s+\"([^\"]+)\""))
                paths.Add(match.Groups[1].Value.Replace("\\\\", "\\"));
            
            string startVDF = File.ReadAllText($"{paths[0]}\\steamapps\\libraryfolders.vdf");
            foreach (Match match in Regex.Matches(startVDF, "\"path\"\\s+\"([^\"]+)\""))
                paths.Add(match.Groups[1].Value.Replace("\\\\", "\\"));
            
            foreach (string path in paths)
            {
                string assembliesPath = $"{path}\\steamapps\\common\\Plasma";
                if (Directory.Exists(assembliesPath)) return assembliesPath;
            }
            return null;
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        #region Trap application termination
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

        private delegate bool EventHandler(CtrlType sig);
        static EventHandler _handler;

        enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        private static bool Handler(CtrlType sig)
        {
            App.self.EndGame(null,null);

            //shutdown right away so there are no lingering threads
            Environment.Exit(-1);

            return true;
        }
        #endregion
    }
}
