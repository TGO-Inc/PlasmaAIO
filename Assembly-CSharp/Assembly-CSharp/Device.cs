using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Behavior;
using PlasmaAPI.GameClass.Common.Math;
using FMOD.Studio;
using FMODUnity;
using Rewired;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000149 RID: 329
public class Device : MonoBehaviour
{
	// Token: 0x14000018 RID: 24
	// (add) Token: 0x06000CC8 RID: 3272 RVA: 0x00040B08 File Offset: 0x0003ED08
	// (remove) Token: 0x06000CC9 RID: 3273 RVA: 0x00040B3C File Offset: 0x0003ED3C
	public static event Device.DeviceEvent OnDeviceStateToggled;

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00040B6F File Offset: 0x0003ED6F
	// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00040B77 File Offset: 0x0003ED77
	public string metaDataName { get; set; }

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00040B80 File Offset: 0x0003ED80
	// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00040B88 File Offset: 0x0003ED88
	public int saveCounter { get; set; }

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00040B91 File Offset: 0x0003ED91
	public bool isWireframe
	{
		get
		{
			return this._state == Device.State.Wireframe;
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00040B9C File Offset: 0x0003ED9C
	public bool isSolid
	{
		get
		{
			return this._state == Device.State.Solid;
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00040BA7 File Offset: 0x0003EDA7
	// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00040BAF File Offset: 0x0003EDAF
	public MechanicState mechanicState { get; set; }

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00040BB8 File Offset: 0x0003EDB8
	// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00040BC0 File Offset: 0x0003EDC0
	public int guid { get; set; }

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00040BC9 File Offset: 0x0003EDC9
	public Device.State state
	{
		get
		{
			return this._state;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00040BD1 File Offset: 0x0003EDD1
	// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00040BD9 File Offset: 0x0003EDD9
	public string displayName { get; set; }

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00040BE2 File Offset: 0x0003EDE2
	// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00040BEA File Offset: 0x0003EDEA
	public List<ComponentHandler> allComponents { get; private set; }

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00040BF3 File Offset: 0x0003EDF3
	// (set) Token: 0x06000CDA RID: 3290 RVA: 0x00040BFB File Offset: 0x0003EDFB
	public List<ComponentHandler> allComponentsHierarchy { get; private set; }

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00040C04 File Offset: 0x0003EE04
	// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00040C0C File Offset: 0x0003EE0C
	public List<ProcessorAgent> allControllers { get; private set; }

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00040C18 File Offset: 0x0003EE18
	private IEnumerable<ComponentDriver> allDrivers
	{
		get
		{
			List<ComponentDriver> list = new List<ComponentDriver>();
			foreach (Agent agent in this._agents.Values)
			{
				if (agent.driver != null)
				{
					list.Add(agent.driver);
				}
			}
			return list;
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00040C8C File Offset: 0x0003EE8C
	public IEnumerable<AgentId> allAgentIds
	{
		get
		{
			return this._agents.Keys;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00040C99 File Offset: 0x0003EE99
	public IEnumerable<Agent> agents
	{
		get
		{
			return this._agents.Values;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00040CA6 File Offset: 0x0003EEA6
	public Dictionary<AgentId, Agent> agentsDictionary
	{
		get
		{
			return this._agents;
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00040CAE File Offset: 0x0003EEAE
	// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00040CB6 File Offset: 0x0003EEB6
	public int numberOfControllers { get; private set; }

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00040CBF File Offset: 0x0003EEBF
	// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00040CC7 File Offset: 0x0003EEC7
	public ComponentHandler onlyController { get; private set; }

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00040CD0 File Offset: 0x0003EED0
	// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00040CD8 File Offset: 0x0003EED8
	public ComponentHandler rootComponent { get; set; }

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00040CE1 File Offset: 0x0003EEE1
	// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00040CE9 File Offset: 0x0003EEE9
	public VFXDevice vfxDevice { get; private set; }

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00040CF2 File Offset: 0x0003EEF2
	// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00040CFA File Offset: 0x0003EEFA
	public bool needsToEnabledColliders { get; set; }

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00040D03 File Offset: 0x0003EF03
	public Articulation firstArticulation
	{
		get
		{
			return this._articulations[0];
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00040D11 File Offset: 0x0003EF11
	public List<Articulation> articulations
	{
		get
		{
			return this._articulations;
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000CED RID: 3309 RVA: 0x00040D19 File Offset: 0x0003EF19
	// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00040D21 File Offset: 0x0003EF21
	public bool dirtyHierarchy { get; set; }

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00040D2A File Offset: 0x0003EF2A
	// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00040D32 File Offset: 0x0003EF32
	public bool dirtyBounds { get; set; }

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00040D3B File Offset: 0x0003EF3B
	// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00040D43 File Offset: 0x0003EF43
	public Quaternion wireframeRootComponentRotation { get; set; }

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00040D4C File Offset: 0x0003EF4C
	// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00040D54 File Offset: 0x0003EF54
	public float wireframeDistanceFromTerrain { get; set; }

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00040D5D File Offset: 0x0003EF5D
	// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00040D65 File Offset: 0x0003EF65
	public bool kinematicBase { get; set; }

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00040D6E File Offset: 0x0003EF6E
	// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00040D76 File Offset: 0x0003EF76
	public bool shouldShowTreeLines { get; set; }

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00040D80 File Offset: 0x0003EF80
	public Vector3 worldCenter
	{
		get
		{
			int num = 0;
			Vector3 a = Vector3.zero;
			foreach (ComponentHandler componentHandler in this.allComponents)
			{
				a += (this.isWireframe ? componentHandler.wireframePosition : componentHandler.solidPosition);
				num++;
			}
			return a / (float)num;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00040E00 File Offset: 0x0003F000
	// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00040E08 File Offset: 0x0003F008
	public DateTime creationDate { get; set; }

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00040E11 File Offset: 0x0003F011
	// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00040E19 File Offset: 0x0003F019
	public Dictionary<WorldController.GlobalPermissions, WorldController.GlobalPermissionStates> permissions { get; set; }

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00040E24 File Offset: 0x0003F024
	public static Dictionary<WorldController.GlobalPermissions, WorldController.GlobalPermissionStates> defaultPermissions
	{
		get
		{
			return new Dictionary<WorldController.GlobalPermissions, WorldController.GlobalPermissionStates>
			{
				{
					WorldController.GlobalPermissions.Clone,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.AttachDetach,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.ComponentManipulation,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.DeviceDelete,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.GrabSolid,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.GrabWireframe,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.PaintComponent,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.ResetDevice,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.SketchAccess,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.SketchEdit,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.StateToggle,
					WorldController.GlobalPermissionStates.Global
				},
				{
					WorldController.GlobalPermissions.PropertyEditorAccess,
					WorldController.GlobalPermissionStates.Global
				}
			};
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00040EB1 File Offset: 0x0003F0B1
	public bool isMounted
	{
		get
		{
			return this._mounted;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00040EB9 File Offset: 0x0003F0B9
	// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00040EC1 File Offset: 0x0003F0C1
	public bool freshlySplit { get; set; }

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00040ECA File Offset: 0x0003F0CA
	// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00040ED2 File Offset: 0x0003F0D2
	public bool freshlyLoaded { get; set; }

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00040EDB File Offset: 0x0003F0DB
	// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00040EE3 File Offset: 0x0003F0E3
	public Device.State stageState { get; set; }

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00040EEC File Offset: 0x0003F0EC
	// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00040EF4 File Offset: 0x0003F0F4
	public bool stageReset { get; set; }

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00040EFD File Offset: 0x0003F0FD
	// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00040F05 File Offset: 0x0003F105
	public int primaryColorId { get; set; }

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00040F0E File Offset: 0x0003F10E
	// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00040F16 File Offset: 0x0003F116
	public int secondaryColorId { get; set; }

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00040F20 File Offset: 0x0003F120
	public bool canBeModule
	{
		get
		{
			using (List<ProcessorAgent>.Enumerator enumerator = this.allControllers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.moduleInterface.isValid)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00040F80 File Offset: 0x0003F180
	// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00040F88 File Offset: 0x0003F188
	public bool isModule { get; set; }

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00040F91 File Offset: 0x0003F191
	public bool isEditingSockets
	{
		get
		{
			return this._editingSockets;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00040F99 File Offset: 0x0003F199
	// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00040FA1 File Offset: 0x0003F1A1
	public bool isLoading { get; set; }

	// Token: 0x06000D12 RID: 3346 RVA: 0x00040FAC File Offset: 0x0003F1AC
	private void ShowAllAgentsAndProperties()
	{

	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x000410D8 File Offset: 0x0003F2D8
	private void Awake()
	{

	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00041204 File Offset: 0x0003F404
	public Dictionary<WorldController.GlobalPermissions, bool> ValidateSpecialGlobalPermissions()
	{

        return default;
    }

	// Token: 0x06000D15 RID: 3349 RVA: 0x00041350 File Offset: 0x0003F550
	public void BuildComponentsLists()
	{

	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x000414FC File Offset: 0x0003F6FC
	public void TicksPreprocessDriversAndAgents()
	{

	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00041560 File Offset: 0x0003F760
	public void TicksPostprocessAgents()
	{

	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x000415C0 File Offset: 0x0003F7C0
	public void RunWorldTickUpdate(bool firstStep)
	{

	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00041738 File Offset: 0x0003F938
	public void RunInterpolationStateStore()
	{

	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0004179C File Offset: 0x0003F99C
	public void InterpolateMesh(float delta)
	{

	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00041868 File Offset: 0x0003FA68
	public void ExtractDoFState()
	{

	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00041914 File Offset: 0x0003FB14
	public void GetDoFPosition(int bodyIndex, out float a)
	{
        a = default;

	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00041968 File Offset: 0x0003FB68
	public void GetDoFPosition(int bodyIndex, out float a, out float b)
	{
        a = default;
        b = default;

	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x000419C0 File Offset: 0x0003FBC0
	public void GetDoFPosition(int bodyIndex, out float a, out float b, out float c)
	{
        a = default;
        b = default;
        c = default;

	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00041A30 File Offset: 0x0003FC30
	public float GetDoFVelocity(int bodyIndex)
	{

        return default;
    }

	// Token: 0x06000D20 RID: 3360 RVA: 0x00041A88 File Offset: 0x0003FC88
	public void GetDoFVelocity(int bodyIndex, out float a, out float b)
	{
        a = default;
        b = default;

	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00041AC0 File Offset: 0x0003FCC0
	public void GetDoFVelocity(int bodyIndex, out float a, out float b, out float c)
	{
        a = default;
        b = default;
        c = default;

	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00041B0C File Offset: 0x0003FD0C
	public bool CanAddChildComponent(ComponentHandler componentHandler)
	{

        return default;
    }

	// Token: 0x06000D23 RID: 3363 RVA: 0x00041BC8 File Offset: 0x0003FDC8
	public void AttemptToEnablePhysicsColliders(bool exemptEntryCollisions = true)
	{

	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x00041C38 File Offset: 0x0003FE38
	public void PrePhysicsTick()
	{

	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00041C9C File Offset: 0x0003FE9C
	public void PostPhysicsTick()
	{

	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x00041D40 File Offset: 0x0003FF40
	public void UpdateInput(Player input)
	{

	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00041D98 File Offset: 0x0003FF98
	public void Lock()
	{

	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00041DA1 File Offset: 0x0003FFA1
	public void Unlock()
	{

	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x00041DAA File Offset: 0x0003FFAA
	public bool CanHaveStateToggled()
	{

        return default;
    }

	// Token: 0x06000D2A RID: 3370 RVA: 0x00041DD1 File Offset: 0x0003FFD1
	public bool IsInterpenetratingSomething()
	{

        return default;
    }

	// Token: 0x06000D2B RID: 3371 RVA: 0x00041DE8 File Offset: 0x0003FFE8
	public bool CheckComponentsInterpenetrating()
	{

        return default;
    }

	// Token: 0x06000D2C RID: 3372 RVA: 0x00041E44 File Offset: 0x00040044
	public bool IsCollidingWithTerrain()
	{

        return default;
    }

	// Token: 0x06000D2D RID: 3373 RVA: 0x00041EA8 File Offset: 0x000400A8
	public void ToggleState(ComponentHandler origin, bool quietly = false)
	{

	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x000422B4 File Offset: 0x000404B4
	public bool CanBeMounted()
	{

        return default;
    }

	// Token: 0x06000D2F RID: 3375 RVA: 0x00042314 File Offset: 0x00040514
	public void Mount(ComponentHandler component, Transform parent)
	{

	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00042448 File Offset: 0x00040648
	public void UnmountPhaseOne()
	{

	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x00042510 File Offset: 0x00040710
	public void UnmountPhaseTwo()
	{

	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x0004262C File Offset: 0x0004082C
	public void UnmountStayWireframe()
	{

	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x000426FC File Offset: 0x000408FC
	public void TeleportToWireframe(Vector3 position)
	{

	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0004272C File Offset: 0x0004092C
	public void SetKinematicBase(bool value)
	{

	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00042753 File Offset: 0x00040953
	private IEnumerator SetKinematicBaseCheckForCoroutine()
	{

        return default;
    }

	// Token: 0x06000D36 RID: 3382 RVA: 0x00042762 File Offset: 0x00040962
	private void PlayVFXSolid()
	{

	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x00042770 File Offset: 0x00040970
	private void PlayVFXWireframe()
	{

	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x0004277E File Offset: 0x0004097E
	private void UpdateVFXWireframe()
	{

	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x00042793 File Offset: 0x00040993
	private void SetDriver(AgentId agentId, ComponentDriver driver)
	{

	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x000427AF File Offset: 0x000409AF
	public IEnumerator LoadSerializedDeviceComponents(SerializedComponent serializedRootcomponent, bool asyncLoad)
	{

        return default;
    }

	// Token: 0x06000D3B RID: 3387 RVA: 0x000427BA File Offset: 0x000409BA
	public IEnumerator LoadSerializedDeviceComponents(IEnumerable<SerializedComponent> serializedComponents, bool asyncLoad)
	{

        return default;
    }

	// Token: 0x06000D3C RID: 3388 RVA: 0x000427D8 File Offset: 0x000409D8
	private ComponentHandler LoadComponent(SerializedComponent serializedComponent, SubComponentHandler parentSubComponent)
	{

        return default;
    }

	// Token: 0x06000D3D RID: 3389 RVA: 0x00042DC4 File Offset: 0x00040FC4
	private IEnumerator LoadComponentsRecursive(SerializedComponent serializedComponent, SubComponentHandler parentSubComponent, bool asyncLoad)
	{

        return default;
    }

	// Token: 0x06000D3E RID: 3390 RVA: 0x00042DE8 File Offset: 0x00040FE8
	public int GetAvailableGuid()
	{

        return default;
    }

	// Token: 0x06000D3F RID: 3391 RVA: 0x00042E06 File Offset: 0x00041006
	public bool IsGuidAvailable(int theGuid)
	{

        return default;
    }

	// Token: 0x06000D40 RID: 3392 RVA: 0x00042E14 File Offset: 0x00041014
	public void AddComponent(ComponentHandler component, int theGuid, string theDisplayName, AgentGestaltEnum agentGestaltId)
	{

	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x00042EA4 File Offset: 0x000410A4
	public string GetDisplayNameFor(AgentGestalt componentGestalt)
	{

        return default;
    }

	// Token: 0x06000D42 RID: 3394 RVA: 0x00042ED0 File Offset: 0x000410D0
	private static string DisplayName(AgentGestalt componentGestalt, int i)
	{

        return default;
    }

	// Token: 0x06000D43 RID: 3395 RVA: 0x00042EFC File Offset: 0x000410FC
	public string GetDisplayNameForExcluding(AgentGestalt componentGestalt, List<string> exclusionList)
	{

        return default;
    }

	// Token: 0x06000D44 RID: 3396 RVA: 0x00042F38 File Offset: 0x00041138
	public bool IsDisplayNameAvailable(string theDisplayName, ComponentHandler currentComponent = null)
	{

        return default;
    }

	// Token: 0x06000D45 RID: 3397 RVA: 0x00042FBC File Offset: 0x000411BC
	public void MoveAgent(Agent agent)
	{

	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00043060 File Offset: 0x00041260
	public Agent AddAgent(AgentId agentId, Dictionary<AssetController.ResourceTypes, List<int>> resourceIDs, Agent.ModuleInterface theModuleInterface)
	{

        return default;
    }

	// Token: 0x06000D47 RID: 3399 RVA: 0x00043140 File Offset: 0x00041340
	public void RemoveAgent(AgentId agentId, bool performCleanup = true)
	{

	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x0004319C File Offset: 0x0004139C
	public Agent GetAgent(AgentId agentId)
	{

        return default;
    }

	// Token: 0x06000D49 RID: 3401 RVA: 0x000431B9 File Offset: 0x000413B9
	public bool DoesAgentExist(AgentId agentId)
	{

        return default;
    }

	// Token: 0x06000D4A RID: 3402 RVA: 0x000431C8 File Offset: 0x000413C8
	public Agent GetComponentAgentByDisplayName(string componentDisplayName)
	{

        return default;
    }

	// Token: 0x06000D4B RID: 3403 RVA: 0x00043250 File Offset: 0x00041450
	public bool IsUsingUserAsset(UserAssetsController.AssetDescription assetDescription)
	{

        return default;
    }

	// Token: 0x06000D4C RID: 3404 RVA: 0x00043374 File Offset: 0x00041574
	public void QueuePropertyOnModule(AgentId agentId, int propertyId, Data propertyData)
	{

	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x000433D0 File Offset: 0x000415D0
	public Dictionary<int, List<Data>> FetchPropertiesOnModule(AgentId agentId)
	{

        return default;
    }

	// Token: 0x06000D4E RID: 3406 RVA: 0x000433F4 File Offset: 0x000415F4
	public void QueueCommandPortOnModule(AgentId agentId, int commandPortId)
	{

	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0004344C File Offset: 0x0004164C
	public Dictionary<int, int> FetchCommandPortsOnModule(AgentId agentId)
	{

        return default;
    }

	// Token: 0x06000D50 RID: 3408 RVA: 0x00043470 File Offset: 0x00041670
	public void QueueOutputPortOnModule(AgentId agentId, int outputPortId, Data payload)
	{

	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x000434B8 File Offset: 0x000416B8
	public List<KeyValuePair<int, Data>> FetchOutputPortsOnModule(AgentId agentId)
	{

        return default;
    }

	// Token: 0x06000D52 RID: 3410 RVA: 0x000434DC File Offset: 0x000416DC
	private void SwapModuleQueues()
	{

	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00043540 File Offset: 0x00041740
	public ComponentHandler FindComponentByGuid(int theGuid)
	{

        return default;
    }

	// Token: 0x06000D54 RID: 3412 RVA: 0x0004359C File Offset: 0x0004179C
	public MechanicState GetMechanicStateForSnapshot()
	{

        return default;
    }

	// Token: 0x06000D55 RID: 3413 RVA: 0x00043648 File Offset: 0x00041848
	public void MechanicComponentPropertyChanged(ComponentHandler componentHandler, int subComponentIndex, int dof, float amount)
	{

	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00043738 File Offset: 0x00041938
	public void ResetDevice(Vector3 resetPosition, bool updateWireframeVFX, bool forcePositionReset = false)
	{

	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0004399C File Offset: 0x00041B9C
	private void CopyConfiguredToRuntimeProperties()
	{

	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x000439F4 File Offset: 0x00041BF4
	private void OnDestroy()
	{

	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00043A60 File Offset: 0x00041C60
	public void SetComponentsEnabledAfterLoad()
	{

	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00043AB8 File Offset: 0x00041CB8
	public void MakeWireframe()
	{

	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00043BC4 File Offset: 0x00041DC4
	private void MakeSolid()
	{

	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00043DF0 File Offset: 0x00041FF0
	private void SetWireframeCollidersEnabled(bool value)
	{

	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00043E44 File Offset: 0x00042044
	private void SetWireframeCollidersToTrigger(bool value)
	{

	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x00043E98 File Offset: 0x00042098
	public void SetCollidersEnabled(bool value, bool exemptEntryCollisions = true)
	{

	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x00043EEC File Offset: 0x000420EC
	public void SetMeshCollidersEnabled(bool value)
	{

	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00043F40 File Offset: 0x00042140
	private void SetMeshCollidersLayer(int layer)
	{

	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00043F94 File Offset: 0x00042194
	public Articulation CreateNewArticulation()
	{

        return default;
    }

	// Token: 0x06000D62 RID: 3426 RVA: 0x00043FD9 File Offset: 0x000421D9
	private void GenerateMechanicState()
	{

	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00043FE8 File Offset: 0x000421E8
	public void ApplyMechanicState(MechanicState theMechanicState, Articulation targetArticulation = null)
	{

	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00044254 File Offset: 0x00042454
	private Articulation ArticulationForRootComponentWithGuid(int theGuid)
	{

        return default;
    }

	// Token: 0x06000D65 RID: 3429 RVA: 0x000442B8 File Offset: 0x000424B8
	public float GetTotalMass()
	{

        return default;
    }

	// Token: 0x06000D66 RID: 3430 RVA: 0x00044314 File Offset: 0x00042514
	private void SetSelfCollisionEnabled(bool value)
	{

	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x000443FC File Offset: 0x000425FC
	private void RefreshDeviceComponentModifiers()
	{

	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x0004456C File Offset: 0x0004276C
	private void CalculateCenterOfGravity()
	{

	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00044808 File Offset: 0x00042A08
	public void ImpactSFXCollisionEnter(SubComponentHandler subComponentHandler, Collision collision)
	{

	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00044910 File Offset: 0x00042B10
	public void ToggleSocketEditing()
	{

	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00044978 File Offset: 0x00042B78
	private void Log(string message)
	{

	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x000449B0 File Offset: 0x00042BB0
	private void LogVerbose(string message)
	{

	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x000449E8 File Offset: 0x00042BE8
	private void LogWarning(string message)
	{

	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00044A20 File Offset: 0x00042C20
	private void LogError(string message)
	{

	}

	// Token: 0x04000AAE RID: 2734
	public GameObject componentDriversContainer;

	// Token: 0x04000AAF RID: 2735
	public GameObject articulationsContainer;

	// Token: 0x04000AB0 RID: 2736
	public GameObject rigidbodiesContainer;

	// Token: 0x04000AB1 RID: 2737
	[EventRef]
	public string toSolidSound;

	// Token: 0x04000AB2 RID: 2738
	[EventRef]
	public string toWireframeSound;

	// Token: 0x04000AB3 RID: 2739
	[EventRef]
	public string impactComponentDefault;

	// Token: 0x04000AB4 RID: 2740
	[EventRef]
	public string impactTerrain;

	// Token: 0x04000AB5 RID: 2741
	public float impactMinForce;

	// Token: 0x04000AB6 RID: 2742
	public float impactSleepTime;

	// Token: 0x04000AB7 RID: 2743
	public float impactMaxValue;

	// Token: 0x04000AB8 RID: 2744
	public float impactMaxMass;

	// Token: 0x04000AB9 RID: 2745
	private static int maxArticulationChildCount = 64;

	// Token: 0x04000ABA RID: 2746
	private Device.State _state;

	// Token: 0x04000ABB RID: 2747
	private Dictionary<AgentId, Agent> _agents;

	// Token: 0x04000ABC RID: 2748
	private Device.AgentModuleQueues _agentModuleQueues1;

	// Token: 0x04000ABD RID: 2749
	private Device.AgentModuleQueues _agentModuleQueues2;

	// Token: 0x04000ABE RID: 2750
	private Device.AgentModuleQueues _writeableAgentModuleQueues;

	// Token: 0x04000ABF RID: 2751
	private Device.AgentModuleQueues _readableAgentModuleQueues;

	// Token: 0x04000AC0 RID: 2752
	private int _guidIndex;

	// Token: 0x04000AC1 RID: 2753
	private List<Articulation> _articulations;

	// Token: 0x04000AC2 RID: 2754
	private bool _locked;

	// Token: 0x04000AC3 RID: 2755
	private float _lastStateToggleTime;

	// Token: 0x04000AC4 RID: 2756
	private List<float> _dofPositions;

	// Token: 0x04000AC5 RID: 2757
	private List<float> _dofVelocities;

	// Token: 0x04000AC6 RID: 2758
	private List<int> _dofStartIndices;

	// Token: 0x04000AC7 RID: 2759
	private bool _restoreKinematicTransforms;

	// Token: 0x04000AC8 RID: 2760
	private Vector3 _restorePosition;

	// Token: 0x04000AC9 RID: 2761
	private Quaternion _restoreRotation;

	// Token: 0x04000ACA RID: 2762
	private bool _mounted;

	// Token: 0x04000ACB RID: 2763
	private float _lastImpactSFXTime;

	// Token: 0x04000ACC RID: 2764
	private float _cachedMass;

	// Token: 0x04000ACD RID: 2765
	private List<Device.Branch> _branches;

	// Token: 0x04000ACE RID: 2766
	private bool _editingSockets;

	// Token: 0x020003A7 RID: 935
	public enum State
	{
		// Token: 0x04001CCC RID: 7372
		None,
		// Token: 0x04001CCD RID: 7373
		Wireframe,
		// Token: 0x04001CCE RID: 7374
		Solid
	}

	// Token: 0x020003A8 RID: 936
	public class Branch
	{
		// Token: 0x060020B4 RID: 8372 RVA: 0x000A1328 File Offset: 0x0009F528
		public Branch(SubComponentHandler subComponentHandler)
		{

		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x000A13E0 File Offset: 0x0009F5E0
		public void SaveLastTransforms()
		{

		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000A140E File Offset: 0x0009F60E
		public void ForceRefresh()
		{

		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x000A1418 File Offset: 0x0009F618
		public bool HasChanged()
		{

            return default;
        }

		// Token: 0x04001CCF RID: 7375
		public SubComponentHandler rootSubComponent;

		// Token: 0x04001CD0 RID: 7376
		public List<SubComponentHandler> children;

		// Token: 0x04001CD1 RID: 7377
		public List<Collider> colliders;

		// Token: 0x04001CD2 RID: 7378
		private Vector3 _lastPosition;

		// Token: 0x04001CD3 RID: 7379
		private Quaternion _lastRotation;

		// Token: 0x04001CD4 RID: 7380
		private bool _force;
	}

	// Token: 0x020003A9 RID: 937
	[Flags]
	public enum Permissions
	{
		// Token: 0x04001CD6 RID: 7382
		ComponentManipulation = 2,
		// Token: 0x04001CD7 RID: 7383
		StateToggle = 4,
		// Token: 0x04001CD8 RID: 7384
		GrabWireframe = 8,
		// Token: 0x04001CD9 RID: 7385
		PropertyEditorAccess = 16,
		// Token: 0x04001CDA RID: 7386
		SketchAccess = 32,
		// Token: 0x04001CDB RID: 7387
		SketchEdit = 64,
		// Token: 0x04001CDC RID: 7388
		DeviceDelete = 128,
		// Token: 0x04001CDD RID: 7389
		AttachDetach = 256,
		// Token: 0x04001CDE RID: 7390
		GrabSolid = 512,
		// Token: 0x04001CDF RID: 7391
		Clone = 1024,
		// Token: 0x04001CE0 RID: 7392
		ResetDevice = 2048,
		// Token: 0x04001CE1 RID: 7393
		PaintComponent = 4096,
		// Token: 0x04001CE2 RID: 7394
		All = 8190
	}

	// Token: 0x020003AA RID: 938
	private class AgentModuleQueues
	{
		// Token: 0x060020B8 RID: 8376 RVA: 0x000A1471 File Offset: 0x0009F671
		public void Clear()
		{

		}

		// Token: 0x04001CE3 RID: 7395
		public Dictionary<AgentId, Dictionary<int, List<Data>>> properties;

		// Token: 0x04001CE4 RID: 7396
		public Dictionary<AgentId, Dictionary<int, int>> commandPorts;

		// Token: 0x04001CE5 RID: 7397
		public Dictionary<AgentId, List<KeyValuePair<int, Data>>> outputPorts;
	}

	// Token: 0x020003AB RID: 939
	// (Invoke) Token: 0x060020BB RID: 8379
	public delegate void DeviceEvent(int guid);
}
}