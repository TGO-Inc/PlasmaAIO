using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000075 RID: 117
public class DoorDriver : ComponentDriver
{
	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x000249F4 File Offset: 0x00022BF4
	private ArticulationBody hinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00024A07 File Offset: 0x00022C07
	public override void Awake()
	{

	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00024A1C File Offset: 0x00022C1C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00024A74 File Offset: 0x00022C74
	private void SetPhysics()
	{

	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00024B58 File Offset: 0x00022D58
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00024B95 File Offset: 0x00022D95
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00024BA2 File Offset: 0x00022DA2
	public override void OnReset()
	{

	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00024BBA File Offset: 0x00022DBA
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00024BC4 File Offset: 0x00022DC4
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00024D80 File Offset: 0x00022F80
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x06000662 RID: 1634 RVA: 0x00024D96 File Offset: 0x00022F96
	public override float GetLimit(bool unscaled = false)
	{

        return default;
    }

	// Token: 0x040005A2 RID: 1442
	public StudioEventEmitter FMODEmitterServo;

	// Token: 0x040005A3 RID: 1443
	public float maxMotorSpeed;

	// Token: 0x040005A4 RID: 1444
	public float maxMotorTorque;

	// Token: 0x040005A5 RID: 1445
	public PIDController positionPidController;

	// Token: 0x040005A6 RID: 1446
	public FloatRange attenuationRange;

	// Token: 0x040005A7 RID: 1447
	public float attenuationMinDistance;

	// Token: 0x040005A8 RID: 1448
	private AgentProperty _targetRotationProperty;

	// Token: 0x040005A9 RID: 1449
	private AgentProperty _torqueProperty;

	// Token: 0x040005AA RID: 1450
	private AgentProperty _maxSpeedProperty;

	// Token: 0x040005AB RID: 1451
	private AgentProperty _currentRotationProperty;

	// Token: 0x040005AC RID: 1452
	private ArticulationDrive _articulationDrive;

	// Token: 0x040005AD RID: 1453
	private float _oldTargetDistance;

	// Token: 0x040005AE RID: 1454
	private const string _FMODParamSize = "Size";

	// Token: 0x040005AF RID: 1455
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x040005B0 RID: 1456
	private const string _FMODParamPower = "Power";

	// Token: 0x040005B1 RID: 1457
	private const string _FMODParamResistance = "Resistance";
}
}