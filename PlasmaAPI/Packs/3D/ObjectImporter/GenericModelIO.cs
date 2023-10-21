using Assimp;
using Plasma.Application.Extensions;
using Plasma.Application.InternalClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.Packs.MeshUtil
{
    internal class GenericModelIO : IOSystem
    {
        private string _name;
        public GenericModelIO((string Name, ResourceStream Data) m, (Dictionary<string, ResourceStream> t, ResourceStream _) t) : this(m, t.t) { }
        public GenericModelIO((string Name, ResourceStream Data) mesh, Dictionary<string, ResourceStream> tex)
        {
            this.TextureList = tex ?? new Dictionary<string, ResourceStream>();
            this.Data.MeshId = Guid.NewGuid();
            this.Data.Mesh = mesh.Data;
            this._name = mesh.Name;
            // this.Type = ModelUtil.Detect(mesh);
        }

        public readonly Dictionary<string, ResourceStream> TextureList;
        private readonly (Guid MeshId, ResourceStream Mesh) Data;
        // private readonly MeshType Type;

        public override IOStream OpenFile(string pathToFile, FileIOMode fileMode)
        {
            var (wasFound, stream) = MeshImporter.GetFileStream(pathToFile, this.GetStreams());

            if (wasFound)
                return new StreamAsIO(pathToFile, stream, fileMode);

            Debug.LogWarning(wasFound);

            return null;
        }
        public string GetMeshName() => Path.GetFileName(this._name); // {this.Type}
        public Dictionary<string, ResourceStream> GetStreams() => TextureList.Expand(this.GetMeshName(), this.Data.Mesh);
        public override void CloseAllFiles() { }
        public override void CloseFile(IOStream stream) { }
    }
}
