extern alias GameClass;
extern alias PLibrary;
using Assimp;
using Plasma.API;
using Plasma.Packs;
using System;
using System.Collections.Generic;
using UnityEngine;
using Plasma.Application.Extensions;
using Plasma.Application.Game;
using Plasma.Mods.ScrapMechanicMod;
using Plasma.Application.InternalClass;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Plasma.Mods.ScrapMechanicMod
{
    internal class LoadGestaltFormat
    {
        
        /*
        public static IDictionary<string, object> CreateDynamicGestalt(DataProcessor.PartData part, IconMapProcessor.IconInfo preview)
        {
            /*
            var data = new Dictionary<string, object>
            {
                ["_guid"] = guid,
                ["_scaleOffset"] = Vector3.one,
                ["_mesh"] = meshList.ToEnum(),
                ["_tex"] = TextureStreams.ToDict(),
                ["_customTextureData"] = customTextureData,
                ["advanced"] = false,
                ["affectedByProjectileExplosion"] = true,
                ["agent"] = typeof(GameClass.Agent),
                ["canBeModule"] = true,
                ["componentIcon"] = null,
                ["componentIds"] = new Dictionary<int, string>() { { 0, "Bush" } },
                ["componentPreview"] = null,
                ["componentInteractionLocksCamera"] = false,
                ["componentInteractive"] = false,
                ["componentMass"] = 0.5f,
                ["componentPlasmaConsumption"] = 1f,
                ["componentPlasmaInteraction"] = true,
                ["componentPrefab"] = ComponentManager.GetNewAgentPrefab(guid),
                ["componentReactsToRaycast"] = true,
                ["componentReactsToScaling"] = true,
                ["componentScaleXLimits"] = new PLibrary.FloatRange(0.01f, 1000f),
                ["componentScaleYLimits"] = new PLibrary.FloatRange(0.01f, 1000f),
                ["componentScaleZLimits"] = new PLibrary.FloatRange(0.01f, 1000f),
                ["componentSupportSecondarySnappingPointChild"] = true,
                ["componentSuppressTerrainImpactSFX"] = false,
                ["componentVolumeControl"] = false,
                ["defaultMassCategory"] = GameClass.AgentGestalt.MassCategories.Light,
                ["defaultsToKinematic"] = false,
                ["description"] = "tmp",
                ["developersOnly"] = false,
                ["deviceComponentModifier"] = null,
                ["displayName"] = part.Name ?? part.UUID,
                ["driver"] = typeof(GameClass.ComponentDriver),
                ["experimental"] = true,
                ["handlesModuleProperties"] = false,
                ["hideNode"] = true,
                ["id"] = CategoryManager.CreateGestaltEnum(guid),
                ["keywords"] = "tmp",
                ["modifierAffectsAllBodies"] = false,
                ["name"] = part.UUID,
                ["needsResources"] = false,
                ["nodeAlwaysRun"] = false,
                ["nodeCategory"] = PLibrary.AgentCategoryEnum.Misc,
                ["nodeManualGestaltId"] = PLibrary.NodeManualGestaltEnum.MathExpression,
                ["nodeRepeatable"] = false,
                ["nusDefinitions"] = null,
                ["ports"] = new Dictionary<int, GameClass.AgentGestalt.Port>(),
                ["processesModuleInterfaces"] = false,
                ["properties"] = new Dictionary<int, GameClass.AgentGestalt.Property>(),
                ["simulatedPhysicsWhenMounted"] = false,
                ["spawnScale"] = Vector3.one,
                ["type"] = GameClass.AgentGestalt.Types.Component,
            };
            return data;*
        }*/
    }
}
