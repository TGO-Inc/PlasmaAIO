extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using HarmonyLib;
using Plasma.Application.Game;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Plasma.API.Patches
{
    internal class ProcessorUICategoryItem
    {
        static int applied = 0;
        public static void Setup()
        {
            if (GameClass.Holder.instance.agentCategories != null && applied < CategoryManager.AgentCategories.Count())
            {
                foreach (string categoryName in CategoryManager.AgentCategories.Keys)
                {
                    if (!GameClass.Holder.instance.agentCategories.ContainsKey(CategoryManager.AgentCategories[categoryName]))
                    {
                        applied++;
                        GameClass.Holder.instance.agentCategories.Add(CategoryManager.AgentCategories[categoryName], categoryName);
                    }
                }
            }
        }
    }
    internal class ComponentItem
    {
        public static void Setup(AgentGestaltEnum theComponentGestaltId, GameClass.Visor.ComponentItem __instance)
        {
            GameClass.Holder.componentGestalts.TryGetValue(theComponentGestaltId, out AgentGestalt agentGestalt);
            __instance.componentName.text = agentGestalt.displayName.ToUpperInvariant();
            __instance.preview.sprite = agentGestalt.componentPreview;
            __instance.description.text = agentGestalt.description;
            __instance.massValue.text = agentGestalt.componentMass.ToString("F2", CultureInfo.InvariantCulture) + " Kg";
        }
    }
}
