extern alias GameClass;
using GameClass;
using HarmonyLib;
using PlasmaAPI.Application.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaAPI.API.Patches
{
    [HarmonyPatch(typeof(GameClass.Device))]
    internal class Device
    {
        [HarmonyPrefix]
        [HarmonyPatch("AddComponent")]
        public static bool AddComponent(GameClass.Device __instance, ComponentHandler component, int theGuid, string theDisplayName, AgentGestaltEnum agentGestaltId)
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
                if (componentDriver != null)
                {
                    componentDriver.OnWireframeEnter();
                }

                return false;
            }
            return true;
        }
    }
}
