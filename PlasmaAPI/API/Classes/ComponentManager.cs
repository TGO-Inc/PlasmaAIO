extern alias GameClass;
using GameClass;
using PlasmaAPI.Application.Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.API
{
    public class ComponentManager
    {
        public static void AddNewComponent(Type @class, string DisplayName, Assembly asm)
        {
            Patches.Resources.asm = asm;
            //ResourceManager.AddToResources(ComponentType.Component.String(), null);
            /*
            if (ResourceManager.CloneObjects.TryGetValue(ComponentType.Component.String(), out UnityEngine.Object obj))
            {
                AgentGestalt gestalt = (AgentGestalt)ScriptableObject.CreateInstance(obj.GetType());
                File.WriteAllText("Clone.txt", gestalt.ToString());
            }*/
            /*
            AgentGestalt gestalt = (AgentGestalt)ScriptableObject.CreateInstance(typeof(AgentGestalt));
            gestalt.componentCategory = AgentGestalt.ComponentCategories.Structure;
            gestalt.properties = new Dictionary<int, AgentGestalt.Property>();
            gestalt.ports = new Dictionary<int, AgentGestalt.Port>();
            gestalt.type = AgentGestalt.Types.Component;
            gestalt.agent = null;
            gestalt.componentPreview = Sprite.Create(new Texture2D(1, 1), new Rect(0, 0, 1, 1), Vector2.zero);
            gestalt.componentMass = 10;
            gestalt.hideFlags = HideFlags.None;
            gestalt.hideNode = false;
            gestalt.developersOnly = false;
            gestalt.componentHidden = false;
            gestalt.componentIcon = Sprite.Create(new Texture2D(1, 1), new Rect(0, 0, 1, 1), Vector2.zero);
            gestalt.displayName = DisplayName;
            gestalt.componentPrefab = new GameObject(DisplayName)
            {
                layer = 0,
                isStatic = false,
                tag = "Untagged",
                hideFlags = HideFlags.None
            };
            gestalt.componentPrefab.AddComponent<Colorizer>();
            gestalt.componentPrefab.AddComponent<VFXComponent>();
            var obj = gestalt.componentPrefab.AddComponent<ComponentHandler>();
            obj.gameObject.AddComponent<Colorizer>();
            obj.gameObject.AddComponent<VFXComponent>();
            obj.gameObject.AddComponent<SubComponentHandler>();
            gestalt.affectedByProjectileExplosion = false;
            gestalt.advanced = false;
            gestalt.nodeAlwaysRun = true;
            gestalt.componentSupportSecondarySnappingPointChild = true;
            gestalt.defaultsToKinematic = true;
            gestalt.nodeCategory = AgentCategoryEnum.Misc;
            gestalt.componentIds = new Dictionary<int, string>() { { 0, "ARPL_Main" } };
            gestalt.name = DisplayName;
            gestalt.description = "Airplane go brrr";
            gestalt.keywords = "air,plane,plain,airplane,airplain";
            gestalt.id = (AgentGestaltEnum)(gestalt.displayName.GetHashCode() * -1) + 1000;
            CategoryManager.CreateNewGestalt(gestalt);
            ResourceManager.AddToResources("Gestalts/Component Agents", gestalt);
            */
        }
        public static void AddNodeDebug(Type @class, Type @class0)
        {
            Patches.Resources.asm = Assembly.GetAssembly(@class);
            Patches.Resources.type = @class;
            Patches.Resources.type0 = @class0;
            /*
            AgentGestalt gestalt = (AgentGestalt)ScriptableObject.CreateInstance(typeof(AgentGestalt));
            gestalt.properties = new Dictionary<int, AgentGestalt.Property>();
            gestalt.ports = new Dictionary<int, AgentGestalt.Port>();
            gestalt.type = AgentGestalt.Types.Logic;
            gestalt.agent = @class;
            gestalt.displayName = "TEST NODE";
            gestalt.name = "TEST NODE";
            gestalt.hideFlags = HideFlags.None;
            gestalt.hideNode = false;
            gestalt.developersOnly = false;
            gestalt.nodeRepeatable = false;
            gestalt.description = "test node for testing nodes";
            gestalt.nodeCategory = AgentCategoryEnum.Misc;
            gestalt.id = (AgentGestaltEnum)(gestalt.displayName.GetHashCode() * -1) + 1000;
            ResourceManager.AddToResources("Gestalts/Logic Agents", gestalt);
            */
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
