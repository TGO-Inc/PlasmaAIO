using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaDevToolkit.Overrides;
using _WorldController = PlasmaAPI.GameClass.WorldController;
using UnityEngine;
using Console = PlasmaDevToolkit.Overrides.Console;

namespace PlasmaDevToolkit.Patches
{
    internal class WorldController
    { 
        [HarmonyPatch(typeof(_WorldController), nameof(_WorldController.Init))]
        public class Init
        {
            public static void Postfix(_WorldController __instance)
            {
                __instance.disableGuruMeditation = true;
                __instance.skipLoadingScreen = true;
            }
        }
        [HarmonyPatch(typeof(_WorldController), nameof(_WorldController.ShouldOpenExceptionPopup))]
        public class ShouldOpenExceptionPopup
        {
            public static bool Prefix(ref bool __result)
            {
                __result = false;
                return false;
            }
        }
    }
}
