extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using HarmonyLib;
using Plasma.Application.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using System.Xml.Linq;
using Plasma.API.Classes;

namespace Plasma.API.Patches
{
    internal class Device
    {
        public static bool AddComponent(GameClass.Device __instance, GameClass.ComponentHandler component, int theGuid, string theDisplayName, AgentGestaltEnum agentGestaltId)
        {
            if (CategoryManager.AgentGestaltEnum.Values.Contains(agentGestaltId))
            {
                Agent agent = __instance.AddAgent(new AgentId
                {
                    type = AgentGestalt.Types.Component,
                    guid = theGuid,
                    displayName = theDisplayName,
                    agentGestaltId = agentGestaltId
                }, component.resourceIDs, null);
                agent.component = component;
                component.agent = agent;
                ComponentDriver componentDriver = null;
                if (component.gestalt.componentCategory != AgentGestalt.ComponentCategories.Basic)
                {
                    componentDriver = component.GetComponent<ComponentDriver>();
                    if (componentDriver != null)
                    {
                        var meth = __instance.GetType().GetRuntimeMethods().Where(m => m.Name.Equals("SetDriver") && m.IsPrivate).FirstOrDefault();
                        meth.Invoke(__instance, new object[] { component.agentId, componentDriver });
                    }
                }
                agent.CopyConfiguredToRuntimeProperties();
                componentDriver?.OnWireframeEnter();

                return false;
            }
            return true;
        }

        public static void LoadComponent(GameClass.Device __instance, object[] __args)
        {
            /*
            SerializedComponent serializedComponent = (SerializedComponent)__args[0];
            Agent agent = __instance.GetAgent(serializedComponent.agentId);
            if (Guid.TryParse(agent.gestalt.componentPrefab.name.Replace("(Clone)", "").Trim(), out Guid trace))
            {
                var test2 = ComponentManager.ModdedComponents.Where(c => c.Key.AgentGuid.Equals(trace)).FirstOrDefault();
                Debug.LogWarning(test2.Value.displayName);
                agent.gestalt.componentPrefab = ComponentManager.InstantiatePrefab(ComponentManager.StaticReference, test2.Value);
                agent.gestalt.componentPrefab.SetActive(false);
                GameObject.DontDestroyOnLoad(agent.gestalt.componentPrefab);
            }
            */
        }
    }
}
