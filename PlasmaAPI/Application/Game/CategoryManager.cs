extern alias GameClass;
extern alias PLibrary;
using PLibrary;
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
    public static class CategoryManager
    {
        private static readonly int HashFactor = 999;
        public static ConcurrentDictionary<string, AgentCategoryEnum> AgentCategories = new ConcurrentDictionary<string, AgentCategoryEnum>();
        public static ConcurrentDictionary<AgentGestalt, AgentGestaltEnum> AgentGestalts = new ConcurrentDictionary<AgentGestalt, AgentGestaltEnum>();
        public static ConcurrentDictionary<string, AgentGestaltEnum> AgentGestaltEnum = new ConcurrentDictionary<string, AgentGestaltEnum>();
        public static ConcurrentDictionary<string, AgentGestalt.ComponentCategories> ComponentCategories = new ConcurrentDictionary<string, AgentGestalt.ComponentCategories>();
        public static AgentCategoryEnum CreateGenericGategory(Guid unique_id)
        {
            string name = unique_id.ToString().ToUpperInvariant();
            if (AgentCategories.ContainsKey(name))
                return AgentCategories[name];
            int hash = Math.Abs(name.GetHashCode()) + HashFactor;
            AgentCategories.TryAdd(name, (AgentCategoryEnum)hash);
            return (AgentCategoryEnum)hash;
        }
        public static AgentGestaltEnum CreateGestaltEnum(Guid unique_id)
        {
            string name = unique_id.ToString().ToUpperInvariant();
            if (AgentGestaltEnum.ContainsKey(name))
                return AgentGestaltEnum[name];
            int hash = Math.Abs(name.GetHashCode()) + HashFactor;
            AgentGestaltEnum.TryAdd(name, (AgentGestaltEnum)hash);
            return (AgentGestaltEnum)hash;
        }
        public static void CreateNewGestalt(AgentGestalt name)
        {
            if (AgentGestalts.ContainsKey(name)) return;
            AgentGestaltEnum.TryAdd(name.name, name.id);
            AgentGestalts.TryAdd(name, name.id);
        }
        public static AgentGestalt.ComponentCategories CreateComponentGategory(Guid unique_id)
        {
            string name = unique_id.ToString().ToUpperInvariant();
            name = name.ToUpperInvariant();
            if (ComponentCategories.ContainsKey(name))
                return ComponentCategories[name];
            int hash = Math.Abs(name.GetHashCode()) + HashFactor;
            ComponentCategories.TryAdd(name, (AgentGestalt.ComponentCategories)(hash));
            return (AgentGestalt.ComponentCategories)hash;
        }
    }
}
