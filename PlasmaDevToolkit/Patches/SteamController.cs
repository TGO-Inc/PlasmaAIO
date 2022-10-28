using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _SteamController = PlasmaAPI.GameClass.SteamController;
using PlasmaDevToolkit.Overrides;
using Console = PlasmaDevToolkit.Overrides.Console;

namespace PlasmaDevToolkit.Patches
{
    internal class SteamController
    {
        [HarmonyPatch(typeof(_SteamController), nameof(_SteamController.Init))]
        public class Init
        {
            public static bool Prefix(ref bool ___skipSteamInitialization)
            {
                ___skipSteamInitialization = true;
                return true;
            }
        }
        [HarmonyPatch(typeof(_SteamController), nameof(_SteamController.RequestUserInformation))]
        public class RequestUserInformation
        {
            public static bool Prefix(ref bool __result, out string userName)
            {
                userName = "Dev";
                __result = true;
                return false;
            }
        }
        [HarmonyPatch(typeof(_SteamController), "Update")]
        public class Update
        {
            public static bool Prefix()
            {
                while (Console.Busy())
                    Task.Delay(1).Wait();
                return true;
            }
        }
    }
}
