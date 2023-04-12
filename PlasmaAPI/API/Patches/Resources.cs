extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using PlasmaAPI.Application.Game;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;
using static GameClass::VFXComponent;
using System.Collections.Concurrent;
using PlasmaAPI.API.Classes;
using PlasmaAPI.Application.InternalClass;
using Newtonsoft.Json;
using System.IO;

namespace PlasmaAPI.API.Patches
{
    internal class Resources : MonoBehaviour
    {
        public static ConcurrentBag<Type> Components = new ConcurrentBag<Type>();
        public static void LoadAll(string path, Type systemTypeInstance, ref UnityEngine.Object[] __result)
        {
            if (path.Equals(ComponentType.Component.String()))
            {
                var newAry = __result.ToList();
                ComponentManager.UpdateStaticReference(((AgentGestalt)newAry[0]).componentPrefab);

                foreach (var item in Resources.Components)
                {
                    AbstractGestalt new_comp = (AbstractGestalt)ScriptableObject.CreateInstance(item);
                    ComponentManager.ModdedComponents.TryAdd(new_comp);
                    newAry.Add(new_comp);
                }
                
                __result = newAry.ToArray();
            }
        }
    }
}
