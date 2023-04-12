using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

namespace PlasmaAPI.API.Classes
{
    internal class ShaderMaterial : Material
    {
        public new Color color
        {
            get
            {
                int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainColor);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    return GetColor(firstPropertyNameIdByAttribute);
                }

                return GetColor("_BaseColor");
            }
            set
            {
                int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainColor);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    SetColor(firstPropertyNameIdByAttribute, value);
                }
                else
                {
                    SetColor("_BaseColor", value);
                }
            }
        }
        private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
        {
            MethodInfo methodInfo = typeof(Material).GetMethod("GetFirstPropertyNameIdByAttribute", BindingFlags.NonPublic | BindingFlags.Instance);

            if (methodInfo != null)
            {
                return (int)methodInfo.Invoke(this, new object[] { attributeFlag });
            }
            else
            {
                Debug.LogError("GetFirstPropertyNameIdByAttribute method not found.");
                return -1;
            }
        }

        public new Texture mainTexture
        {
            get
            {
                int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    return GetTexture(firstPropertyNameIdByAttribute);
                }

                return GetTexture("_DetailAlbTex");
            }
            set
            {
                int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    SetTexture(firstPropertyNameIdByAttribute, value);
                }
                else
                {
                    SetTexture("_DetailAlbTex", value);
                }
            }
        }

        public new Vector2 mainTextureOffset
        {
            get
            {
                int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    return GetTextureOffset(firstPropertyNameIdByAttribute);
                }

                return GetTextureOffset("_DetailAlbTex");
            }
            set
            {
                int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    SetTextureOffset(firstPropertyNameIdByAttribute, value);
                }
                else
                {
                    SetTextureOffset("_DetailAlbTex", value);
                }
            }
        }

        public new Vector2 mainTextureScale
        {
            get
            {
                int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    return GetTextureScale(firstPropertyNameIdByAttribute);
                }

                return GetTextureScale("_DetailAlbTex");
            }
            set
            {
                int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
                if (firstPropertyNameIdByAttribute >= 0)
                {
                    SetTextureScale(firstPropertyNameIdByAttribute, value);
                }
                else
                {
                    SetTextureScale("_DetailAlbTex", value);
                }
            }
        }
        public ShaderMaterial(Shader shader) : base(shader)
        {
        }
    }
}
