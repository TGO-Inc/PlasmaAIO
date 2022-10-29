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
// Token: 0x02000079 RID: 121
public class DroneDriver : ComponentDriver
{
	// Token: 0x06000674 RID: 1652 RVA: 0x00025167 File Offset: 0x00023367
	public override void Awake()
	{

	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00025191 File Offset: 0x00023391
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x06000676 RID: 1654 RVA: 0x0002519E File Offset: 0x0002339E
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x06000677 RID: 1655 RVA: 0x000251AC File Offset: 0x000233AC
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00025254 File Offset: 0x00023454
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00025484 File Offset: 0x00023684
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00025520 File Offset: 0x00023720
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0002560C File Offset: 0x0002380C
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00025A88 File Offset: 0x00023C88
	private float DistanceFromTerrain()
	{

        return default;
    }

	// Token: 0x0600067D RID: 1661 RVA: 0x00025AD9 File Offset: 0x00023CD9
	public override void OnReset()
	{

	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00025AE6 File Offset: 0x00023CE6
	private void OnDestroy()
	{

	}

	// Token: 0x040005C3 RID: 1475
	public PIDController heightPid;

	// Token: 0x040005C4 RID: 1476
	public float pidRatio;

	// Token: 0x040005C5 RID: 1477
	public float angularTorqueForce;

	// Token: 0x040005C6 RID: 1478
	public float angularDampingRatio;

	// Token: 0x040005C7 RID: 1479
	public float horizontalMovementForce;

	// Token: 0x040005C8 RID: 1480
	public float yawChangeSpeed;

	// Token: 0x040005C9 RID: 1481
	public float maxYawTorque;

	// Token: 0x040005CA RID: 1482
	public float heightChangeSpeed;

	// Token: 0x040005CB RID: 1483
	public float maxDistanceFromTerrain;

	// Token: 0x040005CC RID: 1484
	public float linearDamping;

	// Token: 0x040005CD RID: 1485
	public float angularDamping;

	// Token: 0x040005CE RID: 1486
	public float hoveringForceMultiplier;

	// Token: 0x040005CF RID: 1487
	public float pMassRatio;

	// Token: 0x040005D0 RID: 1488
	public float dMassRatio;

	// Token: 0x040005D1 RID: 1489
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040005D2 RID: 1490
	private AgentProperty _stateProperty;

	// Token: 0x040005D3 RID: 1491
	private AgentProperty _lateralProperty;

	// Token: 0x040005D4 RID: 1492
	private AgentProperty _longitudinalProperty;

	// Token: 0x040005D5 RID: 1493
	private AgentProperty _verticalProperty;

	// Token: 0x040005D6 RID: 1494
	private AgentProperty _yawProperty;

	// Token: 0x040005D7 RID: 1495
	private AgentProperty _currentYawProperty;

	// Token: 0x040005D8 RID: 1496
	private AgentProperty _followTerrainProperty;

	// Token: 0x040005D9 RID: 1497
	private AgentProperty _heightProperty;

	// Token: 0x040005DA RID: 1498
	private Quaternion _rotationTarget;

	// Token: 0x040005DB RID: 1499
	private ArticulationBody _bodyTarget;

	// Token: 0x040005DC RID: 1500
	private bool _wasFollowingTerrain;

	// Token: 0x040005DD RID: 1501
	private Vector3 _pointOnTerrain;

	// Token: 0x040005DE RID: 1502
	private float _hoveringForce;

	// Token: 0x040005DF RID: 1503
	private float _savedLinearDamping;

	// Token: 0x040005E0 RID: 1504
	private float _savedAngularDamping;

	// Token: 0x040005E1 RID: 1505
	private float _mass;

	// Token: 0x040005E2 RID: 1506
	private float _yawTorqueMultiplier;

	// Token: 0x040005E3 RID: 1507
	private const string _FMODParamSpeed = "RobotSpeed";

	// Token: 0x040005E4 RID: 1508
	private const string _FMODParamUp = "RobotMoveUp";

	// Token: 0x040005E5 RID: 1509
	private const string _FMODParamDown = "RobotMoveDown";
}
}