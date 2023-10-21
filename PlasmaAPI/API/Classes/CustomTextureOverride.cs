extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using System;
using UnityEngine;
using Assimp;

namespace Plasma.API
{
    public struct CustomTextureOverride
    {
        public string MaterialName;
        public TextureSlot Diffuse;
        public TextureSlot Normal;
        public TextureSlot Specular;
        public Color BaseColor; 
    }
}
