extern alias GameClass;
using GameClass;
using Plasma.Application.InternalClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.API.Classes
{
    public abstract class AbstractGestalt :  AgentGestalt
    {
        public abstract Guid Guid { get; }
        public abstract Vector3 ScaleOffset { get; }
        public abstract IEnumerable<(string Name, ResourceStream Data)> MeshResources { get; }
        public abstract Dictionary<string, ResourceStream> TextureResources { get; }
        public abstract Type Driver { get; }
        public abstract CustomTextureOverride? CustomTextureData { get; }
    }
}
