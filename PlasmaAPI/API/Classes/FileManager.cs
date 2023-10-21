extern alias GameClass;
using Doorstop;
using GameClass;
using GameClass::TheraBytes.BetterUi;
using Plasma.API.Classes;
using Plasma.Application.InternalClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Plasma.API
{
    public class FileManager
    {
        private static readonly char[] IsNumber = new char[]
        {
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
        };
        public static IEnumerable<(string Path, ResourceStream Stream)> GetFilesInPath(string relativePath, Guid guid, object t)
         => GetFilesInPath(relativePath, guid.ToString(), t.GetType());
        public static IEnumerable<(string Path, ResourceStream Stream)> GetFilesInPath(string relativePath, string guid, object t)
         => GetFilesInPath(relativePath, guid, t.GetType());
        public static IEnumerable<(string Path, ResourceStream Stream)> GetFilesInPath(string relativePath, string guid, Type t)
        {
            guid = guid.Replace("-", "_");

            if (IsNumber.Contains(guid[0]))
                guid = "_" + guid;

            Assembly assembly = t.Assembly;
            string assemblyName = "PlasmaAPI.Mods." + assembly.GetName().Name;

            var fileList = assembly.GetManifestResourceNames()
                .Where(name =>
                name.StartsWith(assemblyName, StringComparison.InvariantCultureIgnoreCase)
                && name.Contains(guid)
                && name.Contains(relativePath));

            foreach (var item in fileList)
                yield return (GetFileName(item), new ResourceStream(assembly.GetManifestResourceStream(item)));
        }
        internal static string GetFileName(string n)
        {
            var r = n.Split('.');
            return r[r.Length - 2];
        }
        internal static ResourceStream LoadFile(string file, Assembly asm)
        {
            var resourceName = string.Empty;
            foreach (var assemblyName in asm.GetManifestResourceNames())
            {
                if (assemblyName.EndsWith(file))
                {
                    resourceName = assemblyName;
                }
            }
            return new ResourceStream(asm.GetManifestResourceStream(resourceName));
        }
    }
}
