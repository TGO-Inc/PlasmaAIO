extern alias GameClass;
using GameClass;
using HarmonyLib;
using Plasma.API.Classes;
using System;
using System.Linq;
using UnityEngine;

namespace Plasma.API.Patches
{
    [HarmonyPatch(typeof(UnityEngine.Object))]
    internal class ObjectPatchClass
    {
        [HarmonyPrefix]
        [HarmonyReversePatch]
        [HarmonyPatch("Instantiate")]
        [HarmonyPatch(new Type[] { typeof(UnityEngine.Object), typeof(UnityEngine.Transform), typeof(bool) })]
        public static bool Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, bool instantiateInWorldSpace, ref UnityEngine.Object __result)
        {
            if (Guid.TryParse(original.name.Replace("(Clone)", "").Trim(), out Guid trace))
            {
                var tmp = ComponentManager.ModdedComponents.Where(c => c.Key.AgentGuid.Equals(trace));
                if (tmp.Count() > 0)
                {
                    var gobj = ComponentManager.InstantiatePrefab(ComponentManager.StaticReference, tmp.FirstOrDefault().Value);
                    if (parent != null) gobj.transform.parent = parent;
                    __result = gobj;
                    return false;
                }
            }
            return true;
        }
        public static bool InstantiatePrefix<T>(T original, ref UnityEngine.Object __result) where T : UnityEngine.Object
        {
            if (Guid.TryParse(original.name.Replace("(Clone)", "").Trim(), out Guid trace))
            {
                var tmp = ComponentManager.ModdedComponents.Where(c => c.Key.AgentGuid.Equals(trace));
                if (tmp.Count() > 0)
                {
                    __result = ComponentManager.InstantiatePrefab(ComponentManager.StaticReference, tmp.FirstOrDefault().Value);
                    return false;
                }
            }
            return true;
        }

        public static bool InstantiatePrefixNonGeneric(object original, ref UnityEngine.Object __result)
        {
            return InstantiatePrefix((UnityEngine.Object)original, ref __result);
        }
    }
}
