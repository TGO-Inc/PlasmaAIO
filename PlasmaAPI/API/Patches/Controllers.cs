using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System;
using PlasmaAPI.Application;

namespace PlasmaAPI.API.Patches
{
    internal class Controllers
    {
        public static void Awake()
        {
            PlasmaGame.OnGameInit();
        }
    }
}
