extern alias PLibrary;
using PLibrary;
using PlasmaAPI.API;
using System;
using System.Collections.Generic;
using PlasmaAPI.Application.Game;
using UnityEngine;
using PlasmaAPI.API.Classes;
using PlasmaAPI.Application.InternalClass;
using PlasmaAPI.Packs;
using PlasmaAPI.Application.Extensions;
using PlasmaAPI.Mods.MY_FIRST_MOD.Car;

namespace PlasmaAPI.Mods.MY_FIRST_MOD.Gestalts
{
    internal class CarGestalt : AbstractGestalt
    {
        private readonly Guid _guid;
        private readonly Vector3 _scaleOffset;
        private readonly IEnumerable<ResourceStream> _mesh;
        private readonly Dictionary<string, ResourceStream> _tex;
        private readonly Type driver;
        public CarGestalt()
        {
            this._guid = Guid.Parse("ca4de6c3-55a9-4516-95b2-4bc178e923f7");
            this.advanced = false;
            this.affectedByProjectileExplosion = true;
            this.agent = typeof(CarAgent);
            this.canBeModule = true;
            this.componentAllowNonUniformScale = false;
            this.componentAllowsDocking = false;
            this.componentAllowsMounting = false;
            this.componentCanHaveFocus = false;
            this.componentCategory = ComponentCategories.Mechanic;
            this.componentConsumesInput = false;
            this.componentDisableScaling = false;
            this.componentFocusLocksCamera = false;
            this.componentHidden = false;
            this.componentHidesHintsUnderRaycast = false;

            var carPreview = FileManager.GetFilesInPath("Previews", "ca4de6c3-55a9-4516-95b2-4bc178e923f7", this);
            Texture2D uTexture = new Texture2D(2, 2);
            uTexture.LoadImage(MeshImporter.FindTexture("preview.png", carPreview));
            uTexture.Scale(512, 512, true);

            this.componentIcon = Sprite.Create(uTexture, Rect.MinMaxRect(0, 0, uTexture.width, uTexture.height), new Vector2(uTexture.width / 2, uTexture.height / 2));
            this.componentIds = new Dictionary<int, string>() { { 0, "Bush" } };
            this.componentInteractionLocksCamera = false;
            this.componentInteractive = false;
            this.componentMass = 200f;
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
            this.description = "Its an Car bro";
            this.developersOnly = false;
            this.deviceComponentModifier = null;
            this.displayName = "Car";
            this.driver = typeof(CarDriver);
            this.experimental = true;
            this.handlesModuleProperties = false;
            this.hideNode = true;
            /// NEVER change this value, once you've shared the mod
            this.id = CategoryManager.CreateGestaltEnum(this.Guid);
            this.keywords = "car,drive,go,wheel";
            this.modifierAffectsAllBodies = false;
            this.name = "Car";
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
            this.spawnScale = Vector3.one * 10;
            this._scaleOffset = Vector3.one;
            this.type = Types.Component;

            this._mesh = FileManager.GetFilesInPath("Mesh", "ca4de6c3-55a9-4516-95b2-4bc178e923f7", this).ToEnum();
            this._tex = FileManager.GetFilesInPath("Textures", "ca4de6c3-55a9-4516-95b2-4bc178e923f7", this).ToDict();
        }

        public override Guid Guid => _guid;

        public override IEnumerable<ResourceStream> MeshResources => _mesh;

        public override Dictionary<string, ResourceStream> TextureResources => _tex;

        public override Type Driver => driver;

        public override Vector3 ScaleOffset => _scaleOffset;

        public override CustomTextureOverride? CustomTextureData => null;
    }
}
