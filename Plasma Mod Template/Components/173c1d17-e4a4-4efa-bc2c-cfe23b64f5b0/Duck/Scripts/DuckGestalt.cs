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
using PlasmaAPI.Mods.MY_FIRST_MOD.Duck;
using Assimp;
using Newtonsoft.Json;

namespace PlasmaAPI.Mods.MY_FIRST_MOD.Gestalts
{
    internal class DuckGestalt : AbstractGestalt
    {
        private readonly Guid _guid;
        private readonly Vector3 _scaleOffset;
        private readonly IEnumerable<ResourceStream> _mesh;
        private readonly Dictionary<string, ResourceStream> _tex;
        private readonly Type driver;
        private readonly CustomTextureOverride? _customTextureData;
        public DuckGestalt()
        {
            this._scaleOffset = Vector3.one / 10;
            this._guid = Guid.Parse("173c1d17-e4a4-4efa-bc2c-cfe23b64f5b0");
            this._mesh = FileManager.GetFilesInPath("Mesh", this.Guid, this).ToEnum();
            this._tex = FileManager.GetFilesInPath("Textures", this.Guid, this).ToDict();
            this._customTextureData = new CustomTextureOverride()
            {
                Diffuse = new TextureSlot()
                {
                    FilePath = "obj_decor_babyduck_dif.tga",
                    TextureType = TextureType.Diffuse
                },
                Normal = new TextureSlot()
                {
                    FilePath = "obj_decor_babyduck_nor.tga",
                    TextureType = TextureType.Normals
                },
                Specular = new TextureSlot()
                {
                    FilePath = "obj_decor_babyduck_asg.tga",
                    TextureType = TextureType.Specular
                },
                BaseColor = new Color(1f, 200 / 255f, 0, 1),
                MaterialName = "blinn1"
            };

            this.advanced = false;
            this.affectedByProjectileExplosion = true;
            this.agent = typeof(DuckAgent);
            this.canBeModule = true;
            this.componentAllowNonUniformScale = false;
            this.componentAllowsDocking = false;
            this.componentAllowsMounting = false;
            this.componentCanHaveFocus = false;
            this.componentCategory = ComponentCategories.Decorative;
            this.componentConsumesInput = false;
            this.componentDisableScaling = false;
            this.componentFocusLocksCamera = false;
            this.componentHidden = false;
            this.componentHidesHintsUnderRaycast = false;

            var carPreview = FileManager.GetFilesInPath("Previews", this.Guid, this);
            Texture2D uTexture = new Texture2D(2, 2);
            uTexture.LoadImage(MeshImporter.FindTexture("preview.png", carPreview));
            uTexture.Scale(512, 512, true);

            this.componentIcon = Sprite.Create(uTexture, Rect.MinMaxRect(0, 0, uTexture.width, uTexture.height), new Vector2(uTexture.width / 2, uTexture.height / 2));
            this.componentIds = new Dictionary<int, string>() { { 0, "Bush" } };
            this.componentInteractionLocksCamera = false;
            this.componentInteractive = false;
            this.componentMass = 0.5f;
            this.componentPlasmaConsumption = 1f;
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
            this.defaultMassCategory = MassCategories.Light;
            this.defaultsToKinematic = false;
            this.description = "Its an Duck bro";
            this.developersOnly = false;
            this.deviceComponentModifier = null;
            this.displayName = "Duck";
            this.driver = typeof(DuckDriver);
            this.experimental = true;
            this.handlesModuleProperties = false;
            this.hideNode = true;
            this.id = CategoryManager.CreateGestaltEnum(this.displayName);
            this.keywords = "duck,swim,animal,pond,fly";
            this.modifierAffectsAllBodies = false;
            this.name = "Duck";
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
            this.type = Types.Component;
        }

        public override Guid Guid => _guid;

        public override IEnumerable<ResourceStream> MeshResources => _mesh;

        public override Dictionary<string, ResourceStream> TextureResources => _tex;

        public override Type Driver => driver;

        public override Vector3 ScaleOffset => _scaleOffset;

        public override CustomTextureOverride? CustomTextureData => _customTextureData;
    }
}
