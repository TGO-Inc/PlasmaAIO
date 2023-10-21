extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using Plasma.API.Classes;
using Plasma.Application.Game;
using Plasma.Application.InternalClass;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static GameClass::VFXComponent;
using System.CodeDom;
using Plasma.Packs;
using Plasma.API.Patches;
using Doorstop;

namespace Plasma.API
{
    public class ComponentManager
    {
        internal static AgentDictionary ModdedComponents
            = new AgentDictionary();

        internal static GameObject StaticReference = null;
        internal static void UpdateStaticReference(GameObject reference)
        {
            StaticReference = reference;
        }
        internal static GameObject InstantiatePrefab(GameObject reference, AgentGestalt d)
        {
            var tmp = ModdedComponents.Where(c => c.Key.AgentId.Equals(d.id));
            if (tmp.Count() > 0)
            {
                var Gestalt = tmp.FirstOrDefault().Value;

                List<MeshRenderer> renderers = new List<MeshRenderer>();
                var comPref = new GameObject
                {
                    name = d.name,
                    layer = LayerMask.NameToLayer("Default")
                };

                GameObject.DontDestroyOnLoad(comPref);

                var driver = comPref.AddComponent(Gestalt.Driver);

                var sub_comp = new GameObject
                {
                    name = d.name + "_Base",
                };
                var sub_handler = sub_comp.AddComponent<SubComponentHandler>();
                sub_handler.subComponentIndex = 0;
                sub_handler.parentSubComponent = null;
                sub_handler.massRatio = 1;
                sub_comp.transform.SetParent(comPref.transform);

                var articulation_body_comp = new GameObject
                {
                    layer = LayerMask.NameToLayer("Default"),
                    name = "ArticulationBody"
                };
                var articulation_body = articulation_body_comp.AddComponent<ArticulationBody>();
                articulation_body.collisionDetectionMode = CollisionDetectionMode.Discrete;
                articulation_body.linearDamping = 0.05f;
                articulation_body.angularDamping = 0.05f;
                articulation_body.immovable = false;
                articulation_body.mass = 1;
                articulation_body.useGravity = true;
                /// Articulation Body
                {
                    var colliders = new GameObject
                    {
                        tag = "CollidersGroup",
                        name = "Colliders",
                        layer = LayerMask.NameToLayer("Default")
                    };

                    colliders.transform.SetParent(articulation_body.transform);
                }

                articulation_body_comp.transform.SetParent(sub_comp.transform);

                var renderer_comp = new GameObject
                {
                    layer = LayerMask.NameToLayer("Default"),
                    tag = "ComponentRenderGroup",
                    name = "Render"
                };
                renderer_comp.transform.SetParent(sub_comp.transform);
                renderer_comp.transform.localScale = Vector3.one;
                /// Render
                {
                    var main = new GameObject
                    {
                        layer = LayerMask.NameToLayer("Default"),
                        name = d.name + "_Main"
                    };
                    main.transform.SetParent(renderer_comp.transform);

                    GameObject ret = MeshImporter.Load(Gestalt, comPref);

                    ret.transform.SetParent(main.transform);

                    renderers = ret.GetComponentsInChildren<MeshRenderer>(includeInactive: true).ToList();

                    var tree = new GameObject
                    {
                        layer = LayerMask.NameToLayer("Default"),
                        tag = "IgnoreMeshRenderer",
                        name = "Tree Node"
                    };

                    var tree_filter = tree.AddComponent<MeshFilter>();
                    var tree_renderer = tree.AddComponent<MeshRenderer>();

                    var reference_tree_renderer = reference.GetComponentsInChildren<MeshRenderer>().Where(x => x.name == "Tree Node").FirstOrDefault();
                    Application.Extensions.ApiExtensions.MapValues(tree_renderer, reference_tree_renderer);
                    var reference_tree_filter = reference.GetComponentsInChildren<MeshFilter>().Where(x => x.name == "Tree Node").FirstOrDefault();
                    Application.Extensions.ApiExtensions.MapValues(reference_tree_filter, tree_filter);

                    tree.transform.SetParent(renderer_comp.transform);
                    {
                        var icon = new GameObject
                        {
                            tag = "IgnoreMeshRenderer",
                            layer = LayerMask.NameToLayer("Default"),
                            name = "Icon"
                        };
                        var icon_filter = icon.AddComponent<MeshFilter>();
                        var icon_renderer = icon.AddComponent<MeshRenderer>();

                        var reference_icon_renderer = reference.GetComponentsInChildren<MeshRenderer>().Where(x => x.name == "Icon").FirstOrDefault();
                        Application.Extensions.ApiExtensions.MapValues(icon_renderer, reference_icon_renderer);
                        var reference_icon_filter = reference.GetComponentsInChildren<MeshFilter>().Where(x => x.name == "Icon").FirstOrDefault();
                        Application.Extensions.ApiExtensions.MapValues(reference_icon_filter, icon_filter);

                        icon.transform.SetParent(tree.transform);
                    }

                    var socket = new GameObject
                    {
                        name = "Socket"
                    };
                    socket.transform.SetParent(renderer_comp.transform);
                    /// Socket
                    {

                        var color = comPref.AddComponent<Colorizer>();
                        color.renderers = new List<MeshRenderer>();

                        // comPref.SetActive(false);
                        var socket_fsp = socket.AddComponent<GameClass.FemaleSocketPoint>();
                        socket_fsp.transform.SetParent(socket.transform);

                        if (socket_fsp.meshGameObject == null)
                        {
                            socket_fsp.meshGameObject = new GameObject()
                            {
                                name = "Mesh",
                                tag = "IgnoreMeshRenderer"
                            };
                            socket_fsp.meshGameObject.AddComponent<MeshRenderer>();
                            socket_fsp.meshGameObject.transform.SetParent(socket_fsp.transform);
                        }

                        var socket_filter = socket_fsp.meshGameObject.GetComponent<MeshFilter>() ?? socket_fsp.meshGameObject.AddComponent<MeshFilter>();
                        socket_filter.sharedMesh = reference.GetComponentsInChildren<Mesh>().Where(x => x.name == "Socket Mesh B").FirstOrDefault();

                        var socket_renderer = socket_fsp.meshGameObject.GetComponent<MeshRenderer>() ?? socket_fsp.meshGameObject.AddComponent<MeshRenderer>();
                        var reference_socket_renderer = reference.GetComponentsInChildren<MeshRenderer>().Where(x => x.name == "Mesh").FirstOrDefault();

                        /// Map Values
                        Application.Extensions.ApiExtensions.MapValues(reference_socket_renderer, socket_renderer);

                        var socket_collider = socket_fsp.meshGameObject.AddComponent<SphereCollider>();
                        socket_collider.radius = 0.25f;

                        socket_fsp.orientationPreference = SnappingGeneric.ChildOrientationPreference.Any;

                        var vfx = comPref.AddComponent<GameClass.VFXComponent>();
                        vfx.specialMaterials = new Dictionary<MeshRenderer, SpecialMaterial>();

                        foreach (MeshRenderer r in renderers)
                            vfx.specialMaterials.Add(r, new SpecialMaterial() { transparent = new ShaderMaterial(Shader.Find("Plasma/Component Standard v1.3 No Tess")), wireframeSolid = r.material });

                        var handler = comPref.GetComponent<GameClass.ComponentHandler>() ?? comPref.AddComponent<GameClass.ComponentHandler>();
                    }

                    /*
                    var collection = comPref.GetComponentsInChildren<ComponentMeshHandler>().Where(x => x.name.Equals("Wireframe Collider"));
                    if (collection.Count() == 1)
                    {
                        var s = ret.GetComponentsInChildren<MeshFilter>().FirstOrDefault().transform.localScale;
                        collection.First().transform.localScale = s;
                    }
                    */
                }

                return comPref;
            }
            else
            {
                Debug.LogError("Tried to create non existing modded component");
                return null;
            }
        }
        public static GameObject GetNewAgentPrefab(Guid guid)
        {
            var holder = new GameObject() { name = guid.ToString() };
            GameObject.DontDestroyOnLoad(holder);
            holder.SetActive(false);
            return holder;
        }
        public static void NewComponent(Type gestalt)
        {
            if (!Patches.Resources.Components.Contains(gestalt))
            {
                Patches.Resources.Components.Add(gestalt);
            }
        }
        public static void NewDyanamicComponent(object[] data, Func<DynamicGestalt, object[], bool> Callback)
        {
            Patches.Resources.DyanmicComponents.Add((data, Callback));
        }
    }
    public enum ComponentType
    {
        Component,
        Logic
    }
    public static class CompontentString
    {
        public static string String(this ComponentType type)
        {
            switch (type)
            {
                case ComponentType.Component:
                    return "Gestalts/Component Agents";
                case ComponentType.Logic:
                    return "Gestalts/Logic Agents";
                default:
                    return string.Empty;
            }
        }
    }
}
