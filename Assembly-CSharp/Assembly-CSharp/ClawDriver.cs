using System;
using FMODUnity;
using UnityEngine;

// Token: 0x02000065 RID: 101
public class ClawDriver : ComponentDriver
{
	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00021F89 File Offset: 0x00020189
	private ArticulationBody fingerA
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00021F9C File Offset: 0x0002019C
	private ArticulationBody fingerB
	{
		get
		{
			return this._component.GetSubComponent(2).articulationBody;
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00021FB0 File Offset: 0x000201B0
	public override void Awake()
	{

	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00021FFD File Offset: 0x000201FD
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0002200A File Offset: 0x0002020A
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00022018 File Offset: 0x00020218
	private float ConvertFrom01(float position)
	{

        return default;
    }

	// Token: 0x060005DB RID: 1499 RVA: 0x00022040 File Offset: 0x00020240
	private float ConvertTo01(float position)
	{

        return default;
    }

	// Token: 0x060005DC RID: 1500 RVA: 0x0002205C File Offset: 0x0002025C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060005DD RID: 1501 RVA: 0x000220B4 File Offset: 0x000202B4
	private void SetPhysics()
	{

	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00022275 File Offset: 0x00020475
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00022284 File Offset: 0x00020484
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x000222C1 File Offset: 0x000204C1
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x000222D0 File Offset: 0x000204D0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0002241C File Offset: 0x0002061C
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0002253C File Offset: 0x0002073C
	public override float GetLimit(bool unscale = false)
	{

        return default;
    }

	// Token: 0x060005E4 RID: 1508 RVA: 0x0002255D File Offset: 0x0002075D
	private void OnDestroy()
	{

	}

	// Token: 0x04000513 RID: 1299
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000514 RID: 1300
	public float maxMotorSpeed;

	// Token: 0x04000515 RID: 1301
	public float maxMotorForce;

	// Token: 0x04000516 RID: 1302
	public PIDController pidControllerA;

	// Token: 0x04000517 RID: 1303
	public PIDController pidControllerB;

	// Token: 0x04000518 RID: 1304
	public float simulatedMotorDelta;

	// Token: 0x04000519 RID: 1305
	public float simulatedMaxMotorSpeed;

	// Token: 0x0400051A RID: 1306
	private AgentProperty _targetPositionProperty;

	// Token: 0x0400051B RID: 1307
	private AgentProperty _forceProperty;

	// Token: 0x0400051C RID: 1308
	private AgentProperty _maxSpeedProperty;

	// Token: 0x0400051D RID: 1309
	private AgentProperty _currentPositionProperty;

	// Token: 0x0400051E RID: 1310
	private ArticulationDrive _articulationDriveA;

	// Token: 0x0400051F RID: 1311
	private ArticulationDrive _articulationDriveB;

	// Token: 0x04000520 RID: 1312
	private const float _extension = 0.265f;

	// Token: 0x04000521 RID: 1313
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x04000522 RID: 1314
	private const string _FMODParamSize = "Size";
}
