extern alias GameClass;
extern alias PLibrary;
using GameClass;

namespace PlasmaDevToolkit.Patches
{
    internal class WorldController
    { 
        public static bool Init(GameClass.WorldController __instance)
        {
            __instance.disableGuruMeditation = true;
            __instance.skipLoadingScreen = true;
            return true;
        }
        public static void CreateNewDevice(AgentGestalt rootComponentGestalt)
        {
            /*
            if (rootComponentGestalt.componentPrefab.name == ComponentManager.StaticModId)
            {
                rootComponentGestalt.componentPrefab = ComponentManager.InstantiatePrefab(ComponentManager.StaticReference, rootComponentGestalt);
            }*/
            /*
            int guid = ____uniqueDeviceID += 1;
            string newDisplayNameForDevice = "Device";
            int num = ____devices.Count + 1;
            while (!__instance.IsDisplayNameAvailable(newDisplayNameForDevice + " " + num.ToString("D2")))
            {
                num++;
            }

            newDisplayNameForDevice += " " + num.ToString("D2");
            Device device = __instance.InstantiateDevice(guid, newDisplayNameForDevice);
            Articulation articulation = device.CreateNewArticulation();
            GameObject gameObject = UnityEngine.Object.Instantiate(rootComponentGestalt.componentPrefab, device.componentDriversContainer.transform);

            if (!rootComponentGestalt.componentPrefab.activeInHierarchy)
            {
                gameObject = tmp.CallAwakeOnComponents(gameObject);
            }

            GameClass.ComponentHandler component = gameObject.GetComponent<GameClass.ComponentHandler>();

            articulation.rootComponent = component;
            foreach (GameClass.SubComponentHandler subComponentHandler in component.allSubComponents)
            {
                if (subComponentHandler.parentSubComponent != null)
                {
                    subComponentHandler.articulationBody.transform.SetParent(subComponentHandler.parentSubComponent.articulationBody.transform);
                }
                else
                {
                    subComponentHandler.articulationBody.transform.SetParent(articulation.transform);
                }
                subComponentHandler.transform.SetParent(gameObject.transform);
            }
            component.gestalt = rootComponentGestalt;
            device.rootComponent = component;
            component.device = device;
            component.articulation = articulation;
            foreach (SubComponentHandler subComponentHandler2 in component.allSubComponents)
            {
                if (subComponentHandler2.parentSubComponent != null)
                {
                    subComponentHandler2.rigidbody.transform.SetParent(subComponentHandler2.parentSubComponent.rigidbody.transform);
                }
                else
                {
                    subComponentHandler2.rigidbody.transform.SetParent(device.rigidbodiesContainer.transform);
                }
            }
            if (rootComponentGestalt.needsResources)
            {
                component.resourceIDs = Controllers.assetController.ReserveResourceIdsForGestalt(rootComponentGestalt);
            }
            device.AddComponent(component, device.GetAvailableGuid(), device.GetDisplayNameFor(rootComponentGestalt), rootComponentGestalt.id);
            component.gameObject.name = component.agentId.displayName + "[" + component.agentId.guid.ToString() + "]";
            device.BuildComponentsLists();
            device.MakeWireframe(false);
            device.kinematicBase = rootComponentGestalt.defaultsToKinematic;
            device.shouldShowTreeLines = false;
            device.stageState = Device.State.Solid;
            device.stageReset = false;
            // return device;
            __result = device;
            return false;
            */
        }
        /*
        public static void SpawnComponent(GameClass.WorldController __instance,
            GameClass.ComponentHandler __component,
            GameClass.GraphicsControllers __vfxController,
            Cursor __cursor,
            GameClass.AgentGestalt __agentGestalt,
            GameClass.Device __device,
            GameClass.AgentGestalt.ComponentCategories __componentCategory,
            GameClass.AgentGestalt.ComponentCategories ____componentCategory,
            Vector3 __scale,
            GameClass.VFXDevice __vfxDevice,
            float __a,
            float ____moveComponentDistance,
            Quaternion ____componentToCameraYRootOffset,
            GameClass.DynamicGridProjector __dynamicGridProjector,
            GameClass.SnappingGeneric ____candidateSnappingObject,
            Quaternion __identity,
            Vector3 __zero,
            Quaternion ____candidatePositionReferenceFrame,
            Quaternion ____candidateRotationReferenceFrame,
            Vector3 ____candidateRaycastTransform,
            GameClass.UndoOperationSpawn __undoOperation,
            AgentGestaltEnum componentGestaltId)
        {
            
        }
        */

        /*
        public static bool ShouldOpenExceptionPopup(ref bool __result)
        {
            __result = false;
            return false;
        }*/
    }
    
}
