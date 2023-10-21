extern alias GameClass;

using GameClass::Behavior;
using Plasma.Application.InternalClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.API.Classes
{
    public class DynamicGestalt : AbstractGestalt
    {
        private Guid _guid;
        private Vector3 _scaleOffset;
        private IEnumerable<(string Name, ResourceStream Data)> _mesh;
        private Dictionary<string, ResourceStream> _tex;
        private Type driver;
        private CustomTextureOverride? _customTextureData;
        public override Guid Guid => _guid;
        public override IEnumerable<(string Name, ResourceStream Data)> MeshResources => _mesh;
        public override Dictionary<string, ResourceStream> TextureResources => _tex;
        public override Type Driver => driver;
        public override Vector3 ScaleOffset => _scaleOffset;
        public override CustomTextureOverride? CustomTextureData => _customTextureData;

        public void SetGUID(Guid var)
        {
            this._guid = var;
        }
        public void SetScaleOffset(Vector3 var)
        {
            this._scaleOffset = var;
        }
        public void SetMesh(IEnumerable<(string Name, ResourceStream Data)> var)
        {
            this._mesh = var;
        }
        public void SetDriver(Type var)
        {
            this.driver = var;
        }
        public void SetTextures(Dictionary<string, ResourceStream> var)
        {
            this._tex = var;
        }
        public void SetCustomTextures(CustomTextureOverride var)
        {
            this._customTextureData = var;
        }
    }
    public class DynamicDriver : GameClass.ComponentDriver
    {

        private Transform _transform;

        public override void Awake()
        {
            
        }

        protected override void OnAgentSet()
        {

        }

        public override void OnReset()
        {

        }

        public override void OnMount()
        {

        }

        public override void OnUnmount()
        {

        }

        public override void UpdateConcreteProperties()
        {

        }
        public override void OnScaleChanged()
        {
            base.OnScaleChanged();
        }
    }
}
