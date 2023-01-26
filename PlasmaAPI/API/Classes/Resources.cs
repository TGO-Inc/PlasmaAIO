extern alias GameClass;
using GameClass;
using HarmonyLib;
using PlasmaAPI.Application;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PlasmaAPI.API
{
    public class ResourceManager
    {
        private static ConcurrentDictionary<string, Object> cloned_gestalts;
        internal static ConcurrentDictionary<string, Object> CloneObjects
        {
            get
            {
                return cloned_gestalts ??= new ConcurrentDictionary<string, Object>();
            }
            private set
            {
                cloned_gestalts = value;
            }
        }
        private static ConcurrentDictionary<string, ConcurrentBag<Object>> modded_gestalts;
        internal static ConcurrentDictionary<string, ConcurrentBag<Object>> ModdedResources
        {
            get
            {
                return modded_gestalts ??= new ConcurrentDictionary<string, ConcurrentBag<Object>>();
            }
            private set
            {
                modded_gestalts = value;
            }
        }
        public static void AddToResources(string path, AgentGestalt obj)
        {
            //ModdedResources ??= new ConcurrentDictionary<string, ConcurrentBag<Object>>();

            if (ModdedResources.TryGetValue(path, out ConcurrentBag<Object> list))
            {
                list.Add(obj);
            }
            else
            {
                ModdedResources.TryAdd(path, new ConcurrentBag<Object>() { obj });
            }
        }
    }
}
