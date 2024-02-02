extern alias GameClass;
extern alias PLibrary;
using GameClass;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.API.Patches
{

    [HarmonyPatch(typeof(GameClass.ComponentHandler))]
    internal class ComponentHandler
    {
        [HarmonyPatch("Awake")]
        public static bool Awake(GameClass.ComponentHandler __instance)
        {
            // Using reflection for all fields and properties
            var attachmentReferenceFrameProperty = AccessTools.Property(typeof(GameClass.ComponentHandler), "attachmentReferenceFrame");
            Quaternion attachmentReferenceFrame = Quaternion.Euler(0f, 180f, 180f);
            attachmentReferenceFrameProperty.SetValue(__instance, attachmentReferenceFrame);

            __instance.scale = Vector3.one;

            var currentNusLabelIndexField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_currentNusLabelIndex");
            currentNusLabelIndexField.SetValue(__instance, -1);

            var subComponentsField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_subComponents");
            var subComponents = new Dictionary<int, GameClass.SubComponentHandler>();

            var componentDriverField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_componentDriver");
            componentDriverField.SetValue(__instance, __instance.GetComponent<GameClass.ComponentDriver>());

            var physicsConstraintsField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_physicsConstraints");
            physicsConstraintsField.SetValue(__instance, __instance.GetComponentsInChildren<GameClass.PlasmaPhysicsConstraint>(includeInactive: true));

            var colorizerField = AccessTools.Property(typeof(GameClass.ComponentHandler), "colorizer");
            colorizerField.SetValue(__instance, PLibrary.Require.Component<GameClass.Colorizer>(__instance));

            var treeNodeField = AccessTools.Property(typeof(GameClass.ComponentHandler), "treeNode");
            treeNodeField.SetValue(__instance, __instance.GetComponentInChildren<TreeNode>(includeInactive: true));
            
            var vfxComponentField = AccessTools.Property(typeof(GameClass.ComponentHandler), "vfxComponent");
            vfxComponentField.SetValue(__instance, PLibrary.Require.Component<GameClass.VFXComponent>(__instance.gameObject));
            
            var femaleSocketPointsField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_femaleSocketPoints");
            var femaleSocketPoints = new List<GameClass.FemaleSocketPoint>(__instance.gameObject.GetComponentsInChildren<GameClass.FemaleSocketPoint>(includeInactive: true));

            var snappingObjectsField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_snappingObjects");
            snappingObjectsField.SetValue(__instance, new List<GameClass.SnappingGeneric>(__instance.GetComponentsInChildren<GameClass.SnappingGeneric>(includeInactive: true)));

            var componentMeshHandlersField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_componentMeshHandlers");
            componentMeshHandlersField.SetValue(__instance, new List<ComponentMeshHandler>());

            var dynamicGridProjectorsField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_dynamicGridProjectors");
            dynamicGridProjectorsField.SetValue(__instance, __instance.gameObject.GetComponentsInChildren<DynamicGridProjector>(includeInactive: true));

            var structureTriggerListenerField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_structureTriggerListener");
            structureTriggerListenerField.SetValue(__instance, __instance.gameObject.GetComponentsInChildren<StructureTriggerListener>(includeInactive: true));

            var dockingPointField = AccessTools.Property(typeof(GameClass.ComponentHandler), "dockingPoint");
            dockingPointField.SetValue(__instance, PLibrary.Require.ChildWithTagDeep("DockingPoint", __instance, true, false));

            var massCategoryField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_massCategory");
            massCategoryField.SetValue(__instance, GameClass.AgentGestalt.MassCategories.Light);

            var massMultiplierField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_massMultiplier");
            massMultiplierField.SetValue(__instance, 1f);

            var physicMaterialField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_physicMaterial");
            var physicMaterial = new UnityEngine.PhysicMaterial
            {
                bounceCombine = PhysicMaterialCombine.Multiply,
                frictionCombine = PhysicMaterialCombine.Multiply,
                bounciness = GameClass.WorldController.defaultBounciness,
                dynamicFriction = GameClass.WorldController.defaultFriction,
                staticFriction = GameClass.WorldController.defaultFriction
            };
            physicMaterialField.SetValue(__instance, physicMaterial);

            var audioVolumeField = AccessTools.Property(typeof(GameClass.ComponentHandler), "audioVolume");
            audioVolumeField.SetValue(__instance, 1f);

            MethodInfo setCurrentFemaleSocketIndexMethod = AccessTools.Method(typeof(GameClass.ComponentHandler), "SetCurrentFemaleSocketIndex");
            setCurrentFemaleSocketIndexMethod.Invoke(__instance, new object[] { 0 });

            foreach (Collider collider in __instance.gameObject.GetComponentsInChildren<Collider>(includeInactive: true))
            {
                if (collider.gameObject.layer == LayerMask.NameToLayer("Default"))
                {
                    collider.gameObject.layer = LayerMask.NameToLayer("PhysicsComponent");
                }
                collider.sharedMaterial = (UnityEngine.PhysicMaterial)physicMaterialField.GetValue(__instance);
            }

            foreach (GameClass.SubComponentHandler subComponentHandler in __instance.gameObject.GetComponentsInChildren<GameClass.SubComponentHandler>(includeInactive: true))
            {
                subComponents.Add(subComponentHandler.subComponentIndex, subComponentHandler);
                subComponentHandler.Setup();
            }

            foreach (GameClass.FemaleSocketPoint femaleSocketPoint in femaleSocketPoints)
            {
                femaleSocketPoint.Setup();
                femaleSocketPoint.gameObject.SetActive(false);
            }

            femaleSocketPointsField.SetValue(__instance, femaleSocketPoints);
            subComponentsField.SetValue(__instance, subComponents);

            MethodInfo MakeComponentMeshHandlerMethod = AccessTools.Method(typeof(GameClass.ComponentHandler), "MakeComponentMeshHandler");
            MakeComponentMeshHandlerMethod.Invoke(__instance, new object[0]);

            return false;
        }

        public static bool ValidateCurrentFemaleSocket(GameClass.ComponentHandler __instance)
        {
            var femaleSocketPointsField = AccessTools.Field(typeof(GameClass.ComponentHandler), "_femaleSocketPoints");
            if (!(femaleSocketPointsField.GetValue(__instance) is List<GameClass.FemaleSocketPoint> femaleSocketPoints) || femaleSocketPoints.Count <= 0 || femaleSocketPoints.Count <= __instance.GetCurrentFemaleSocketIndex())
            {
                Awake(__instance);
            }
            return true;
        }
    }
}
