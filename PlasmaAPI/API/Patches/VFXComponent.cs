extern alias GameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.API.Patches
{
    internal class VFXComponent
    {
        public static void Awake(GameClass.VFXComponent __instance)
        {
            if (__instance.gameObject.GetComponent<GameClass.ComponentHandler>() == null)
            {
                __instance.gameObject.AddComponent<GameClass.ComponentHandler>();
            }
        }
    }
}
