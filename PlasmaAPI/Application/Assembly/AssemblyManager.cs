extern alias GameClass;

using Doorstop;
using PlasmaAPI.Application.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static GameClass::VFXComponent;

namespace PlasmaAPI.Application
{
    public static class AssemblyManager
    {
        public delegate void OnLoadedArg(params object[] args);
        public delegate void OnLoaded();

        internal static ConcurrentDictionary<string, AssemblyContainer> LoadedAssemblies = new ConcurrentDictionary<string, AssemblyContainer>()
        {
            /*
            /// PRE LOADED SECTION
            { "mscorlib", new AssemblyContainer(null, AssemblyType.System) },
            { "ModLoader", new AssemblyContainer(null, AssemblyType.Modded) },
            { "PlasmaMap", new AssemblyContainer(null, AssemblyType.Modded) },
            /// END PRE LOADED SECTION
            { "0Harmony", new AssemblyContainer(null, AssemblyType.Modded) },
            { "Assembly-CSharp", new AssemblyContainer(null, AssemblyType.Game) },
            { "Sirenix.Serialization", new AssemblyContainer(null, AssemblyType.Sirenix) },
            { "UnityEngine", new AssemblyContainer(null, AssemblyType.CriticalUnity) },
            { "UnityEngine.CoreModule", new AssemblyContainer(null, AssemblyType.CriticalUnity) },
            { "Sirenix.Serialization.Config", new AssemblyContainer(null, AssemblyType.Sirenix) },
            { "System", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Core", new AssemblyContainer(null, AssemblyType.System) },
            { "Mono.Security", new AssemblyContainer(null, AssemblyType.Modded) },
            { "HarmonySharedState", new AssemblyContainer(null, AssemblyType.Modded) },
            { "MonoMod.Utils.Cil.ILGeneratorProxy", new AssemblyContainer(null, AssemblyType.Modded) },
            { "Assembly-CSharp-firstpass", new AssemblyContainer(null, AssemblyType.Game) },
            { "UnityEngine.AIModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ARModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.AccessibilityModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.AndroidJNIModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.AnimationModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.AssetBundleModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.AudioModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ClothModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ClusterInputModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ClusterRendererModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.CrashReportingModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.DSPGraphModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.DirectorModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.GIModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.GameCenterModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.GridModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.HotReloadModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.IMGUIModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ImageConversionModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.InputModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.InputLegacyModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.JSONSerializeModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.LocalizationModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ParticleSystemModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.PerformanceReportingModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.PhysicsModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.Physics2DModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ProfilerModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.ScreenCaptureModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.SharedInternalsModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.SpriteMaskModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.SpriteShapeModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.StreamingModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.SubstanceModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.SubsystemsModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.TLSModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.TerrainModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.TerrainPhysicsModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.TextCoreModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.TextRenderingModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.TilemapModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UIModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UIElementsModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UIElementsNativeModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UNETModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UmbraModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityAnalyticsModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityConnectModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityCurlModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityTestProtocolModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityWebRequestModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityWebRequestAssetBundleModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityWebRequestAudioModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityWebRequestTextureModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.UnityWebRequestWWWModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.VFXModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.VRModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.VehiclesModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.VideoModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.VirtualTexturingModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.WindModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "UnityEngine.XRModule", new AssemblyContainer(null, AssemblyType.Unity) },
            { "ZFBrowser", new AssemblyContainer(null, AssemblyType.Game) },
            { "QFSW.QC.Serializers", new AssemblyContainer(null, AssemblyType.Game) },
            { "Unity.Timeline", new AssemblyContainer(null, AssemblyType.Unity) },
            { "Sirenix.OdinInspector.CompatibilityLayer", new AssemblyContainer(null, AssemblyType.Sirenix) },
            { "Unity.TextMeshPro", new AssemblyContainer(null, AssemblyType.Unity) },
            { "USD.NET.Unity", new AssemblyContainer(null, AssemblyType.Game) },
            { "com.studioevil.editortools", new AssemblyContainer(null, AssemblyType.Game) },
            { "QFSW.QC.Grammar", new AssemblyContainer(null, AssemblyType.Game) },
            { "QFSW.QC", new AssemblyContainer(null, AssemblyType.Game) },
            { "QFSW.QC.UI", new AssemblyContainer(null, AssemblyType.Game) },
            { "UnityEngine.UI", new AssemblyContainer(null, AssemblyType.Unity) },
            { "QFSW.QC.Parsers", new AssemblyContainer(null, AssemblyType.Game) },
            { "USD.NET", new AssemblyContainer(null, AssemblyType.Game) },
            { "Unity.Analytics.DataPrivacy", new AssemblyContainer(null, AssemblyType.Unity) },
            { "Unity.Polybrush", new AssemblyContainer(null, AssemblyType.Unity) },
            { "QFSW.QC.ScanRules", new AssemblyContainer(null, AssemblyType.Game) },
            { "PlasmaLibrary", new AssemblyContainer(null, AssemblyType.Game) },
            { "Unity.Postprocessing.Runtime", new AssemblyContainer(null, AssemblyType.Unity) },
            { "GlitchLibraryAssembly", new AssemblyContainer(null, AssemblyType.Game) },
            { "MeshBakerCore", new AssemblyContainer(null, AssemblyType.Game) },
            { "FMODUnity", new AssemblyContainer(null, AssemblyType.Game) },
            { "com.studioevil.core", new AssemblyContainer(null, AssemblyType.Game) },
            { "Tayx.Graphy", new AssemblyContainer(null, AssemblyType.Game) },
            { "Unity.Formats.USD.Runtime", new AssemblyContainer(null, AssemblyType.Unity) },
            { "QFSW.QC.Demo", new AssemblyContainer(null, AssemblyType.Game) },
            { "FMODUnityResonance", new AssemblyContainer(null, AssemblyType.Game) },
            { "Rewired_Windows_Functions", new AssemblyContainer(null, AssemblyType.Game) },
            { "AIToASE", new AssemblyContainer(null, AssemblyType.Game) },
            { "QFSW.QC.Extras", new AssemblyContainer(null, AssemblyType.Game) },
            { "jianglong.library.gif-player", new AssemblyContainer(null, AssemblyType.Game) },
            { "QFSW.QC.Suggestors", new AssemblyContainer(null, AssemblyType.Game) },
            { "AmplifyImpostors", new AssemblyContainer(null, AssemblyType.Game) },
            { "Sirenix.OdinInspector.Attributes", new AssemblyContainer(null, AssemblyType.Sirenix) },
            { "Unity.Analytics.Tracker", new AssemblyContainer(null, AssemblyType.Unity) },
            { "Sirenix.Utilities", new AssemblyContainer(null, AssemblyType.Sirenix) },
            { "DOTween", new AssemblyContainer(null, AssemblyType.Game) },
            { "Rewired_Windows", new AssemblyContainer(null, AssemblyType.Game) },
            { "Unity.Analytics.StandardEvents", new AssemblyContainer(null, AssemblyType.Unity) },
            { "mcs", new AssemblyContainer(null, AssemblyType.System) },
            { "Rewired_Core", new AssemblyContainer(null, AssemblyType.Game) },
            { "Newtonsoft.Json", new AssemblyContainer(null, AssemblyType.Game) },
            { "DOTweenPro", new AssemblyContainer(null, AssemblyType.Game) },
            { "DemiLib", new AssemblyContainer(null, AssemblyType.Game) },
            { "netstandard", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Configuration", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Xml", new AssemblyContainer(null, AssemblyType.System) },
            { "Anonymously Hosted DynamicMethods Assembly", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Net.Http", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Xml.Linq", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Numerics", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Runtime.Serialization", new AssemblyContainer(null, AssemblyType.System) },
            { "Sirenix.Serialization.RuntimeEmitted", new AssemblyContainer(null, AssemblyType.Sirenix) },
            { "System.ServiceModel.Internals", new AssemblyContainer(null, AssemblyType.System) },
            { "System.Data", new AssemblyContainer(null, AssemblyType.System) }
            */
        };
        public static bool UpdateAssemblyInfo(string AssemblyName, Assembly assemblyInfo)
        {
            if (LoadedAssemblies.TryGetValue(AssemblyName, out AssemblyContainer container))
            {
                container.Assembly = assemblyInfo;
                return true;
            }
            // Entrypoint.Log("New Container for: " + AssemblyName);
            return LoadedAssemblies.TryAdd(AssemblyName, new AssemblyContainer(assemblyInfo));
        }
        public static bool OnAssemblyLoad(string AssemblyName, OnLoadedArg Callback, bool add = true)
        {
            return AssemblyLoad(AssemblyName, Callback, add);
        }
        public static bool OnAssemblyLoad(string AssemblyName, OnLoaded Callback, bool add = true)
        {
            return AssemblyLoad(AssemblyName, Callback, add);
        }
        private static IEnumerable<AssemblyContainer> GetLoadedAssemblies()
        {
            foreach (var asm in LoadedAssemblies)
                if (asm.Value.IsLoaded)
                    yield return asm.Value;
        }
        private static bool AssemblyLoad(string AssemblyName, Delegate Callback, bool add)
        {
            if (LoadedAssemblies.TryGetValue(AssemblyName, out AssemblyContainer container))
            {
                if (container.AssemblyLoaded.ContainsValue(Callback, out Guid id))
                {
                    if (!add)
                    {
                        return container.AssemblyLoaded.TryRemove(id, out Delegate _);
                    }
                    return true;
                }
                else if (add)
                {
                    if (container.IsLoaded && Callback.Method.GetParameters().Length == 1)
                        return Callback.DynamicInvoke(container.Assembly) != null;
                    else if (container.IsLoaded && Callback.Method.GetParameters().Length == 0)
                        return Callback.DynamicInvoke() != null;
                    Entrypoint.Log("Did not invoke for: " + AssemblyName);
                    return container.AssemblyLoaded.TryAdd(Guid.NewGuid(), Callback);
                }
            }
            else
            {
                Entrypoint.Log("New Container for: " + AssemblyName);
                container = new AssemblyContainer(null, AssemblyType.System);
                return container.AssemblyLoaded.TryAdd(Guid.NewGuid(), Callback) && LoadedAssemblies.TryAdd(AssemblyName, container);
            }
            return false;
        }
    }
}
