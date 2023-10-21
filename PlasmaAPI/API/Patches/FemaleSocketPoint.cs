extern alias GameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

namespace Plasma.API.Patches
{
    internal class FemaleSocketPoint
    {
        public static void Awake(GameClass.FemaleSocketPoint __instance)
        {
            if (__instance.meshGameObject == null)
            {
                __instance.meshGameObject = new GameObject()
                {
                    name = "Mesh",
                    tag = "IgnoreMeshRenderer"
                };
                __instance.meshGameObject.AddComponent<MeshRenderer>();
                __instance.meshGameObject.transform.SetParent(__instance.transform);
            }
            
        }
        public static bool Setup(GameClass.FemaleSocketPoint __instance,
            ref MaterialPropertyBlock ____propertyBlock, ref int ____colorId,
            ref Renderer ____renderer, ref GameClass.SubComponentHandler ____owner, ref Vector3 ____startingLocalPosition)
        {
            ____propertyBlock ??= new MaterialPropertyBlock();

            if (__instance.meshGameObject == null)
            {
                __instance.meshGameObject = new GameObject()
                {
                    name = "Mesh",
                    tag = "IgnoreMeshRenderer"
                };
                ____renderer = __instance.meshGameObject.AddComponent<MeshRenderer>();
                __instance.meshGameObject.transform.SetParent(__instance.transform);
            }
            else
            {
                ____renderer = __instance.meshGameObject.GetComponent<MeshRenderer>();
            }

            ____colorId = Shader.PropertyToID("_Color");

            ____owner = __instance.GetComponentInParent<GameClass.SubComponentHandler>(includeInactive: true) ?? throw new Exception("Required SubComponentHandler");

            if (____owner.component == null)
            {
                ____owner.component = ____owner.GetComponentInParent<GameClass.ComponentHandler>(includeInactive: true);
            }

            var scale = ____owner.component.scale;
            scale = new Vector3( 1f / scale.x, 1f / scale.y, 1f / scale.z);

            ____startingLocalPosition = Vector3.Scale(__instance.transform.localPosition, scale);

            ____renderer.GetPropertyBlock(____propertyBlock);
            ____propertyBlock.SetColor(____colorId, Color.gray);
            ____renderer.SetPropertyBlock(____propertyBlock);
            
            return false;
        }
        
    }
}
