using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaDevToolkit.ModLoader
{
    internal static class Extensions
    {
        public static void Add(this ConcurrentDictionary<string, AssemblyContainer> dictionary, string name, AssemblyContainer assembly)
        {
            dictionary.TryAdd(name, assembly);
        }
    }
}
