using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaDevToolkit.Overrides;
using UnityEngine;
using System;
using Console = PlasmaDevToolkit.Overrides.Console;

namespace PlasmaDevToolkit.Patches
{
    public class Controllers
    {
        public class Awake
        {
            public static void Prefix()
            {
                Console.FormatMessage(LogType.Log, global::LoggerController.LogClass.Generic, "LOAD AWAKE");
                //Doorstop.Entrypoint.GameLoaded();
            }
        }
    }
}
