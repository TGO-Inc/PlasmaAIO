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
        public static bool Init(_WorldController __instance)
        {
            __instance.disableGuruMeditation = true;
            __instance.skipLoadingScreen = true;
            return true;
        }
        public static bool ShouldOpenExceptionPopup(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
