extern alias GameClass;
using GameClass;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaAPI.Application.Game
{
    internal static class CategoryManager
    {
        private static int currentNodeId = 3;
        private static int currentGestaltId = 302;
        private static int currentComponentId = 3;
        public static ConcurrentDictionary<string, AgentCategoryEnum> AgentCategories = new ConcurrentDictionary<string, AgentCategoryEnum>();
        public static ConcurrentDictionary<AgentGestalt, AgentGestaltEnum> AgentGestalts = new ConcurrentDictionary<AgentGestalt, AgentGestaltEnum>();
        public static ConcurrentDictionary<string, AgentGestaltEnum> AgentGestaltEnum = new ConcurrentDictionary<string, AgentGestaltEnum>();
        public static ConcurrentDictionary<string, AgentGestalt.ComponentCategories> ComponentCategories = new ConcurrentDictionary<string, AgentGestalt.ComponentCategories>();
        public static AgentCategoryEnum CreateNewGenericGategory(string name)
        {
            name = name.ToUpperInvariant();
            if (AgentCategories.ContainsKey(name))
                return AgentCategories[name];
            AgentCategories.TryAdd(name, (AgentCategoryEnum)(++currentNodeId));
            return (AgentCategoryEnum)currentNodeId;
        }
        public static void CreateNewGestalt(AgentGestalt name)
        {
            if (AgentGestalts.ContainsKey(name)) return;
            AgentGestaltEnum.TryAdd(name.name, name.id);
            AgentGestalts.TryAdd(name, name.id);
        }
        public static AgentGestalt.ComponentCategories CreateNewComponentGategory(string name)
        {
            name = name.ToUpperInvariant();
            if (ComponentCategories.ContainsKey(name))
                return ComponentCategories[name];
            ComponentCategories.TryAdd(name, (AgentGestalt.ComponentCategories)(++currentComponentId));
            return (AgentGestalt.ComponentCategories)currentComponentId;
        }
    }
}
