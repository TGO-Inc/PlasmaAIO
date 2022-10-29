using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _SteamController = PlasmaAPI.GameClass.SteamController;
using PlasmaDevToolkit.Overrides;
using Console = PlasmaDevToolkit.Overrides.Console;
using System.IO;

namespace PlasmaDevToolkit.Patches
{
    internal class SteamController
    {
        public static bool Init() => true;
        public static bool Init(ref bool ___skipSteamInitialization)
        {
            ___skipSteamInitialization = true;
            return true;
        }
        public static bool RequestUserInformation() => true;
        public static bool RequestUserInformation(ref bool __result, out string userName)
        {
            userName = "Dev";
            __result = true;
            return false;
        }
        /*
        public static bool Update()
        {
            while (Console.Busy())
                Task.Delay(1).Wait();
            return true;
        }*/
    }
}
