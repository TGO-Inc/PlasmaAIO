using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.Packs.MeshUtil
{
    internal class MeshMaterialBinding
    {
        private readonly string meshName;
        private readonly UnityEngine.Mesh mesh;
        private readonly UnityEngine.Material material;

        private MeshMaterialBinding() { }    // Do not allow default constructor

        public MeshMaterialBinding(string meshName, Mesh mesh, Material material)
        {
            this.meshName = meshName;
            this.mesh = mesh;
            this.material = material;
        }

        public Mesh Mesh { get => mesh; }
        public Material Material { get => material; }
        public string MeshName { get => meshName; }
    }
}
