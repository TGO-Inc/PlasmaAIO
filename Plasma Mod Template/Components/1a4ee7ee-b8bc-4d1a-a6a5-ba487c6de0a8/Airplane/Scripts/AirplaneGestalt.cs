extern alias PLibrary;
using PlasmaAPI.API;
using PLibrary;
using System;
using System.Collections.Generic;
using PlasmaAPI.Application.Game;
using UnityEngine;
using PlasmaAPI.API.Classes;
using System.IO;
using System.Linq;
using PlasmaAPI.Application.InternalClass;
using PlasmaAPI.Packs;
using PlasmaAPI.Application.Extensions;
using PlasmaAPI.Mods.MY_FIRST_MOD.Airplane;

namespace PlasmaAPI.Mods.MY_FIRST_MOD.Gestalts
{
    internal class AirplaneGestalt : AbstractGestalt
    {
        private readonly Guid _guid;
        private readonly Vector3 _scaleOffset;
        private readonly IEnumerable<ResourceStream> _mesh;
        private readonly Dictionary<string, ResourceStream> _tex;
        private readonly Type driver;
        public AirplaneGestalt()
        {
            this._guid = Guid.NewGuid();
            this.advanced = false;
            this.affectedByProjectileExplosion = true;
            this.agent = typeof(AirplaneAgent);
            this.canBeModule = true;
            this.componentAllowNonUniformScale = false;
            this.componentAllowsDocking = false;
            this.componentAllowsMounting = false;
            this.componentCanHaveFocus = false;
            this.componentCategory = ComponentCategories.Basic;
            this.componentConsumesInput = false;
            this.componentDisableScaling = false;
            this.componentFocusLocksCamera = false;
            this.componentHidden = false;
            this.componentHidesHintsUnderRaycast = false;

            var planePreview = FileManager.GetFilesInPath("Previews", "1a4ee7ee-b8bc-4d1a-a6a5-ba487c6de0a8", this);
            Texture2D uTexture = new Texture2D(2, 2);
            uTexture.LoadImage(MeshImporter.FindTexture("preview.png", planePreview));
            uTexture.Scale(512, 512, true);

            this.componentIcon = Sprite.Create(uTexture, Rect.MinMaxRect(0, 0, uTexture.width, uTexture.height), new Vector2(uTexture.width / 2, uTexture.height / 2));
            this.componentIds = new Dictionary<int, string>() { { 0, "Bush" } };
            this.componentInteractionLocksCamera = false;
            this.componentInteractive = false;
            this.componentMass = 500f;
            this.componentPlasmaConsumption = 20f;
            this.componentPlasmaInteraction = true;
            this.componentPrefab = ComponentManager.GetNewAgentPrefab(this._guid);
            this.componentPreview = Sprite.Create(uTexture, Rect.MinMaxRect(0, 0, uTexture.width, uTexture.height), new Vector2(uTexture.width / 2, uTexture.height / 2));
            this.componentReactsToRaycast = true;
            this.componentReactsToScaling = true;
            this.componentScaleXLimits = new FloatRange(0.1f, 1000f);
            this.componentScaleYLimits = new FloatRange(0.1f, 1000f);
            this.componentScaleZLimits = new FloatRange(0.1f, 1000f);
            this.componentSupportSecondarySnappingPointChild = true;
            this.componentSuppressTerrainImpactSFX = false;
            this.componentVolumeControl = false;
            this.defaultMassCategory = MassCategories.Heavy;
            this.defaultsToKinematic = false;
            this.description = "Its an airplane bro";
            this.developersOnly = false;
            this.deviceComponentModifier = null;
            this.displayName = "Airplane";
            this.driver = typeof(AirplaneDriver);
            this.experimental = true;
            this.handlesModuleProperties = false;
            this.hideNode = true;
            this.id = CategoryManager.CreateGestaltEnum(this.displayName);
            this.keywords = "air,plane,airplane,fly,sky";
            this.modifierAffectsAllBodies = false;
            this.name = "Airplane";
            this.needsResources = false;
            this.nodeAlwaysRun = false;
            this.nodeCategory = AgentCategoryEnum.Misc;
            this.nodeManualGestaltId = NodeManualGestaltEnum.MathExpression;
            this.nodeRepeatable = false;
            this.nusDefinitions = null;
            this.ports = new Dictionary<int, Port>();
            this.processesModuleInterfaces = false;
            this.properties = new Dictionary<int, Property>();
            this.simulatedPhysicsWhenMounted = false;
            this.spawnScale = Vector3.one;
            this._scaleOffset = Vector3.one;
            this.type = Types.Component;

            this._mesh = FileManager.GetFilesInPath("Mesh", "1a4ee7ee-b8bc-4d1a-a6a5-ba487c6de0a8", this).ToEnum();
            this._tex = FileManager.GetFilesInPath("Textures", "1a4ee7ee-b8bc-4d1a-a6a5-ba487c6de0a8", this).ToDict();
        }

        public override Guid Guid => _guid;

        public override IEnumerable<ResourceStream> MeshResources => _mesh;

        public override Dictionary<string, ResourceStream> TextureResources => _tex;

        public override Type Driver => driver;

        public override Vector3 ScaleOffset => _scaleOffset;

        public override CustomTextureOverride? CustomTextureData => null;
    }
}
