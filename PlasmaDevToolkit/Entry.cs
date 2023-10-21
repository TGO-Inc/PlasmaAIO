extern alias GameClass;
using System;
using System.Reflection;
using Console = PlasmaDevToolkit.Overrides.Console;
using PlasmaDevToolkit.Patches;
using PlasmaDevToolkit.DevToolkit;
using Plasma.Application;
using Plasma.PatchUtil;
using UnityEngine;
using System.Threading.Tasks;
using Plasma.Mods.RuntimeUnityEditor.Core;
using Plasma.Mods.RuntimeUnityEditor.Core.Utils;
using Plasma.Mods.RuntimeUnityEditor.Core.Utils.Abstractions;

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
            try
            {
                Console.Init();
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("[Debug Console Initialized]: " + (Environment.Is64BitProcess ? "Plasma x64" : "Plasma x32"));
                System.Console.ResetColor();

                // Old? I think
                // AssemblyManager.OnAssemblyLoad("PlasmaLibrary", ContinuePatching);
                AssemblyManager.OnAssemblyLoad("FMODUnity", PatchLogging);

                // Optional
                // AssemblyManager.OnAssemblyLoad("netstandard", StartComServer);
                AssemblyManager.OnAssemblyLoad("mcs", () => PatchManager.CreatePatch<QuantumConsole>("QFSW.QC", PatchType.Postfix));

                PlasmaGame.OnGameInitialization += PlasmaGame_OnGameInitialization;
            }
            catch(Exception e)
            {
                Doorstop.Entrypoint.CrashHandle(e);
            }
        }

        private void PlasmaGame_OnGameInitialization()
        {
            Creator.Create();
        }

        private void PatchLogging()
        {
            Application.logMessageReceived -= LogMessageReceived;
            Application.logMessageReceived += LogMessageReceived;
            
            PatchManager.CreatePatch<LoggerController>("Assembly-CSharp", PatchType.Prefix);
            PatchManager.CreatePatch<WorldController>("Assembly-CSharp", PatchType.Prefix);
        }

        private static void StartComServer()
        {
            CommandHandler = new CommandCommunication();
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
    internal class Creator
    {
        public static void Create()
        {
            GameObject go1 = new GameObject();
            go1.AddComponent(typeof(RuntimeUnityEditor5));
            UnityEngine.Object.DontDestroyOnLoad(go1);
            go1 = UnityEngine.Object.Instantiate(go1);
        }
    }
    
    internal class RuntimeUnityEditor5 : MonoBehaviour
    {
        public static RuntimeUnityEditorCore Instance { get; private set; }

        private void Start()
        {
            if (!TomlTypeConverter.CanConvert(typeof(Rect)))
            {
                var converter = TomlTypeConverter.GetConverter(typeof(Rect));
                TomlTypeConverter.AddConverter(typeof(Rect), new TomlTypeConverter.TypeConverter { ConvertToObject = converter.ConvertToObject, ConvertToString = converter.ConvertToString });
            }
            if (Instance == null)
                Instance = new RuntimeUnityEditorCore(new Bep5InitSettings(this));
        }

        private void Update()
        {
            Instance.Update();
        }

        private void LateUpdate()
        {
            Instance.LateUpdate();
        }

        private void OnGUI()
        {
            Instance.OnGUI();
        }

        void OnDestroy()
        {
            Task.Run(() =>
            {
                Task.Delay(1000).Wait();
                Creator.Create();
            });
        }

        private sealed class Bep5InitSettings : InitSettings
        {
            MonoBehaviour instance;
            public Bep5InitSettings(MonoBehaviour m)
            {
                instance = m;
            }

            public override Action<T> RegisterSetting<T>(string category, string name, T defaultValue, string description, Action<T> onValueUpdated)
            {
                //var s = instance.Config.Bind(category, name, defaultValue, description);
                //s.SettingChanged += (sender, args) => onValueUpdated(s.Value);
                //onValueUpdated(s.Value);
                return (T e) => { }; //x => s.Value = x;
            }

            public override MonoBehaviour PluginMonoBehaviour => instance;
            public override ILoggerWrapper LoggerWrapper { get; }
            public override string ConfigPath => "";
        }

    }
}
