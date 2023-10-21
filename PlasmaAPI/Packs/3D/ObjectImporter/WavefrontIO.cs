using Assimp;
using Plasma.Application.InternalClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plasma.Packs.MeshUtil
{
    internal class WavefrontIO : GenericModelIO
    {
        public readonly ResourceStream mtl;
        public WavefrontIO((string Name, ResourceStream Data) m, ResourceStream mtl) : this(m, mtl, null) { }
        public WavefrontIO((string Name, ResourceStream Data) m, Dictionary<string, ResourceStream> tex) : this(m, null, tex) { }
        public WavefrontIO((string Name, ResourceStream Data) m, (Dictionary<string, ResourceStream> t, ResourceStream f) d) : this(m, d.f, d.t) { }
        public WavefrontIO((string Name, ResourceStream Data) mesh, ResourceStream mtl, Dictionary<string, ResourceStream> tex) : base(mesh, tex)
        {
            this.mtl = mtl;
        }
        public override IOStream OpenFile(string pathToFile, FileIOMode fileMode)
        {
            var (wasFound, stream) = MeshImporter.GetFileStream(pathToFile, this.GetStreams());

            if (wasFound)
                return new StreamAsIO(pathToFile, stream, fileMode);

            this.mtl.Position = 0;
            return new StreamAsIO(pathToFile, this.mtl, fileMode);
        }
    }
}
