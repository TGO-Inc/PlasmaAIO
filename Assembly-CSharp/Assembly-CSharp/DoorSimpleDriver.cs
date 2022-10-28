using System;
using FMODUnity;
using UnityEngine;

// Token: 0x02000077 RID: 119
public class DoorSimpleDriver : ComponentDriver
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000668 RID: 1640 RVA: 0x00024E04 File Offset: 0x00023004
	private ArticulationBody hinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00024E17 File Offset: 0x00023017
	public override void Awake()
	{

	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00024E2B File Offset: 0x0002302B
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00024E54 File Offset: 0x00023054
	private void SetPhysics()
	{

	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00024F34 File Offset: 0x00023134
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00024F71 File Offset: 0x00023171
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00024F7E File Offset: 0x0002317E
	public override void OnReset()
	{

	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00024F96 File Offset: 0x00023196
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00024FA0 File Offset: 0x000231A0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00025150 File Offset: 0x00023350
	public override float GetLimit(bool unscaled = false)
	{

        return default;
    }

	// Token: 0x040005B5 RID: 1461
	public StudioEventEmitter FMODEmitterServo;

	// Token: 0x040005B6 RID: 1462
	public float maxMotorSpeed;

	// Token: 0x040005B7 RID: 1463
	public float maxMotorTorque;

	// Token: 0x040005B8 RID: 1464
	public PIDController positionPidController;

	// Token: 0x040005B9 RID: 1465
	public FloatRange attenuationRange;

	// Token: 0x040005BA RID: 1466
	public float attenuationMinDistance;

	// Token: 0x040005BB RID: 1467
	private AgentProperty _targetRotationProperty;

	// Token: 0x040005BC RID: 1468
	private AgentProperty _currentRotationProperty;

	// Token: 0x040005BD RID: 1469
	private ArticulationDrive _articulationDrive;

	// Token: 0x040005BE RID: 1470
	private float _oldTargetDistance;

	// Token: 0x040005BF RID: 1471
	private const string _FMODParamSize = "Size";

	// Token: 0x040005C0 RID: 1472
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x040005C1 RID: 1473
	private const string _FMODParamPower = "Power";

	// Token: 0x040005C2 RID: 1474
	private const string _FMODParamResistance = "Resistance";
}
