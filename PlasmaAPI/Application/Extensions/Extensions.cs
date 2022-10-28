using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.Application.Extensions
{
    internal static class Extensions
    {
        public static void Add(this ConcurrentDictionary<string, AssemblyContainer> dictionary, string name, AssemblyContainer assembly)
        {
            dictionary.TryAdd(name, assembly);
        }
        public static bool ContainsValue(this ConcurrentDictionary<Guid, Delegate> dictionary, Delegate d, out Guid id)
        {
            foreach (var i in dictionary)
            {
                if (i.Value.Equals(d))
                {
                    id = i.Key;
                    return true;
                }
            }
            id = Guid.Empty;
            return false;
        }
    }
}
