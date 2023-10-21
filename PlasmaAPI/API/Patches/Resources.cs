extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using Plasma.Application.Game;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;
using static GameClass::VFXComponent;
using System.Collections.Concurrent;
using Plasma.API.Classes;
using Plasma.Application.InternalClass;
using Newtonsoft.Json;
using System.IO;

namespace Plasma.API.Patches
{
    internal class Resources : MonoBehaviour
    {
        public static ConcurrentBag<Type> Components = new ConcurrentBag<Type>();
        public static ConcurrentBag<(object[] Data, Func<DynamicGestalt, object[], bool> Callback)> DyanmicComponents
            = new ConcurrentBag<(object[] Data, Func<DynamicGestalt, object[], bool> Callback)>();
        public static void LoadAll(string path, Type systemTypeInstance, ref UnityEngine.Object[] __result)
        {
            if (path.Equals(ComponentType.Component.String()))
            {
                var newAry = __result.ToList();
                ComponentManager.UpdateStaticReference(((AgentGestalt)newAry[0]).componentPrefab);
                /*
                foreach (var Gestalt in Resources.Components)
                {
                    AbstractGestalt new_comp = (AbstractGestalt)ScriptableObject.CreateInstance(Gestalt);                    
                    ComponentManager.ModdedComponents.TryAdd(new_comp);
                    newAry.Add(new_comp);
                }
                */
                foreach (var container in Resources.DyanmicComponents)
                {
                    DynamicGestalt new_comp = (DynamicGestalt)ScriptableObject.CreateInstance(typeof(DynamicGestalt));
                    if (container.Callback(new_comp, container.Data))
                    {
                        ComponentManager.ModdedComponents.TryAdd(new_comp);
                        newAry.Add(new_comp);
                    }
                }
                
                __result = newAry.ToArray();
            }
        }
    }
}
