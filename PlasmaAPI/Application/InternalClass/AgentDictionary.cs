extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using Plasma.API.Classes;
using System;
using System.Collections.Concurrent;

namespace Plasma.Application.InternalClass
{
    internal class AgentDictionary : ConcurrentDictionary<AgentKey, AbstractGestalt>
    {

        public bool TryGetValue(Guid guid, out AbstractGestalt value)
        {
            AgentKey key = new AgentKey(guid, default);
            return TryGetValue(key, out value);
        }

        public bool TryGetValue(AgentGestaltEnum id, out AbstractGestalt value)
        {
            AgentKey key = new AgentKey(Guid.Empty, id);
            return TryGetValue(key, out value);
        }

        public bool TryAdd(AbstractGestalt value)
        {
            AgentKey key = new AgentKey(value.Guid, value.id);
            return base.TryAdd(key, value);
        }

        public bool TryAdd(AgentGestaltEnum id, AbstractGestalt value)
        {
            AgentKey key = new AgentKey(default, id);
            return base.TryAdd(key, value);
        }

        public bool TryAdd(Guid guid, AbstractGestalt value)
        {
            AgentKey key = new AgentKey(guid, default);
            return base.TryAdd(key, value);
        }
    }
}
