using Doorstop;
using HarmonyLib;
using PlasmaAPI.Application;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PlasmaAPI.PatchUtil
{
    public static class PatchManager
    {
        public delegate bool HarmonyPatchBool();
        public delegate void HarmonyPatchVoid();
        internal static Harmony Patch;
        internal static void Initialize()
        {
            Patch = new Harmony("tgo.mod.loader");
        }
        public static void CreatePatch<T>(string assemblyName, PatchType type)
        {
            Type BaseClass = typeof(T);
            List<MethodInfo> methods = BaseClass.GetRuntimeMethods().Where(m=>m.DeclaringType == BaseClass).ToList();

            foreach (var method in methods)
            {
                MethodInfo[] duplicates = methods.Where(m => m.Name.Equals(method.Name)).ToArray();
                if (duplicates.Count() > 1)
                {
                    bool found = false;
                    foreach (MethodInfo mi in duplicates)
                    {
                        if (mi.GetParameters().Length <= 0 || found)
                        {
                            methods.Remove(mi);
                        }
                        else
                        {
                            found = true;
                        }
                    }
                }
            }

            methods.ForEach(m => CreatePatch(assemblyName, type, m, false));
        }
        public static void CreatePatch(string assemblyName, PatchType type, HarmonyPatchVoid PatchMethod)
        {
            CreatePatch(assemblyName, type, PatchMethod.Method);
        }
        public static void CreatePatch(string assemblyName, PatchType type, HarmonyPatchBool PatchMethod)
        {
            CreatePatch(assemblyName, type, PatchMethod.Method);
        }
        private static void CreatePatch(string assemblyName, PatchType type, MethodInfo method, bool check = true)
        {
            if (AssemblyManager.LoadedAssemblies.TryGetValue(assemblyName, out AssemblyContainer asmc))
            {
                if (asmc.IsLoaded)
                {
                    Type[] Types = asmc.Assembly.GetTypes();
                    string TargetClassName = method.DeclaringType.Name;

                    Type TargetClass = Types.Where(t => t.FullName.EndsWith(TargetClassName)).FirstOrDefault();
                    MethodInfo TargetMethod = TargetClass.GetRuntimeMethods().Where(m => m.Name.Equals(method.Name)).FirstOrDefault();
                    if (check)
                    {
                        IEnumerable<MethodInfo> methods = method.DeclaringType.GetRuntimeMethods().Where(m => m.Name.Equals(method.Name));
                        if (methods.Count() > 1)
                            foreach (MethodInfo info in methods)
                                if (info.GetParameters().Length > 0)
                                    method = info;
                    }
                    try
                    {
                        switch (type)
                        {
                            case PatchType.Prefix:
                                Patch.CreateProcessor(TargetMethod).AddPrefix(new HarmonyMethod(method)).Patch();
                                Entrypoint.Log("Created PREFIX for: " + TargetMethod.DeclaringType.Name + "." + TargetMethod.Name);
                                break;
                            case PatchType.Postfix:
                                Patch.CreateProcessor(TargetMethod).AddPostfix(new HarmonyMethod(method)).Patch();
                                Entrypoint.Log("Created POSTFIX for: " + TargetMethod.DeclaringType.Name + "." + TargetMethod.Name);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Entrypoint.Log(e.ToString());
                    }
                    return;
                }
            }
            AssemblyManager.OnAssemblyLoad(assemblyName, () => CreatePatch(assemblyName, type, method, check));
        }
    }
    public enum PatchType
    {
        Prefix,
        Postfix
    }
}
