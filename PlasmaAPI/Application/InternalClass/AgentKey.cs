extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameClass::TheraBytes.BetterUi.BetterButton;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Plasma.Application.InternalClass
{
    internal class AgentKey : IEquatable<AgentKey>
    {
        public Guid AgentGuid { get; }
        public AgentGestaltEnum AgentId { get; }
        public AgentKey(Guid guid, AgentGestaltEnum @enum)
        {
            AgentGuid = guid;
            AgentId = @enum;
        }

        public bool Equals(AgentKey other)
        {
            return AgentGuid.Equals(other.AgentGuid) || AgentId.Equals(other.AgentId);
        }

        public bool Equals(Guid guid)
        {
            return AgentGuid.Equals(guid);
        }
        public bool Equals(AgentGestaltEnum id)
        {
            return AgentId.Equals(id);
        }
        public override bool Equals(object obj)
        {
            return obj is AgentKey other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + AgentGuid.GetHashCode();
                hash = hash * 23 + AgentId.GetHashCode();
                // hash = hash * 23 + Id3.GetHashCode();
                return hash;
            }
        }
    }
}
