extern alias GameClass;
using AutoMapper;
using AutoMapper.Internal;
using GameClass;
using Newtonsoft.Json;
using PrefabUtil;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media.Animation;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PlasmaAPI.API.Patches
{
    internal class Resources : MonoBehaviour
    {
        public static volatile Assembly asm;
        public static volatile Type type;
        public static volatile Type type0;
        public static void LoadAll(string path, Type systemTypeInstance, ref Object[] __result)
        {
            //if (ResourceManager.ModdedResources.TryGetValue(path, out ConcurrentBag<Object> arry) || systemTypeInstance == typeof(AgentGestalt))
            if (path.Equals(ComponentType.Component.String()))
            {
                var newAry = __result.ToList();
                var prefab_clone = new UnityPackageReader()
                    .LoadFile("E:\\Unity Projects\\default.unitypackage");
                var prefab = prefab_clone.LoadPrefabs().FirstOrDefault();
                
                var gobj = new GameObject();
                foreach(var component in prefab.Components)
                {
                    Type type = null;
                    AppDomain.CurrentDomain.GetAssemblies().ForAll(a => {
                        type = a.GetType(component.Type);
                        if (type != null)
                            return;
                    });
                    File.AppendAllText(component.Type + ".txt", component.ToString());
                    Component n_component;
                    if (!component.Type.Equals("MonoBehavior"))
                    {
                        if (!component.Type.Equals("Transform"))
                            n_component = gobj.AddComponent(type);
                        else
                            n_component = gobj.transform;


                        var config = new MapperConfiguration(cfg => cfg.CreateMap<AgentGestalt, AgentGestalt>());
                        var mpper = config.CreateMapper();
                        var n = mpper.Map(component.Root, n_component);
                        File.AppendAllText("out.txt", JsonConvert.SerializeObject(n, Formatting.Indented) + "\n\n");
                    }   
                    else
                    {
                        // script
                        n_component = gobj.transform;
                    }
                    n_component.name = component.Name;
                    n_component.tag = component.Tag;
                }
                /*
                //ResourceManager.CloneObjects.AddOrUpdate(path, newAry[0], (k, v) => v = newAry[0]);
                AgentGestalt cast = (AgentGestalt)__result[0];
                AgentGestalt clone = (AgentGestalt)ScriptableObject.CreateInstance(typeof(AgentGestalt));

                var config = new MapperConfiguration(cfg => cfg.CreateMap<AgentGestalt, AgentGestalt>());
                var mpper = config.CreateMapper();
                mpper.Map(cast, clone);

                clone.name = "Test Component";
                clone.id = (AgentGestaltEnum)Math.Abs(clone.name.GetHashCode()) + 786;
                clone.agent = type;
                var list = clone.componentPrefab.GetComponents<Component>();
                var comp = clone.componentPrefab.GetComponent<AccelerometerDriver>();
                var vfx = clone.componentPrefab.GetComponent<VFXComponent>();
                Destroy(comp);
                clone.description = "Blank";
                clone.keywords = "test,debug";
                clone.displayName = clone.name;
                clone.componentIds = new System.Collections.Generic.Dictionary<int, string>()
                {
                    { 0, "Bush" }
                };
                clone.componentPrefab.name = clone.name;
                clone.componentPreview = Sprite.Create(new Texture2D(1,1), new Rect(), Vector2.one);
                clone.componentIcon = Sprite.Create(new Texture2D(1, 1), new Rect(), Vector2.one);
                clone.properties = new System.Collections.Generic.Dictionary<int, AgentGestalt.Property>();
                clone.ports = new System.Collections.Generic.Dictionary<int, AgentGestalt.Port>();
                //clone.componentPrefab = new GameObject();
                //ObjImporter.ImportModel("Airplane.obj", asm, clone);
                //File.WriteAllText("clone.log", clone.ToJson());
                newAry.Reverse();
                newAry.Add(clone);
                newAry.Reverse();*/
                //newAry.AddRange(arry.Where(i => i != null));
                __result = newAry.ToArray();
            }
        }
    }
    public static class Extensions
    {
        public static T Clone<T>(this T obj)
        {
            var inst = obj.GetType().GetMethod("MemberwiseClone", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            return (T)inst?.Invoke(obj, null);
        }
        public static string ToJson<T>(this T obj)
        {
            var settings = new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            return JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
        }
    }
}
