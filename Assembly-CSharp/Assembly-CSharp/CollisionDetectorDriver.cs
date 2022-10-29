using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000067 RID: 103
public class CollisionDetectorDriver : ComponentDriver
{
	// Token: 0x060005EA RID: 1514 RVA: 0x0002266C File Offset: 0x0002086C
	public override void Awake()
	{

	}

	// Token: 0x060005EB RID: 1515 RVA: 0x000227F8 File Offset: 0x000209F8
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0002285F File Offset: 0x00020A5F
	public override void OnReset()
	{

	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00022870 File Offset: 0x00020A70
	public override void OnSensorCollisionEnter(Collision collision, DeviceComponentModifier modifier)
	{

	}

	// Token: 0x060005EE RID: 1518 RVA: 0x000228D4 File Offset: 0x00020AD4
	public override void OnSensorCollisionStay(Collision collision, DeviceComponentModifier modifier)
	{

	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0002292C File Offset: 0x00020B2C
	private bool CheckIfCollisionValid(Collision collision, out Device device, out int detectableLayer)
	{
        device = default;
        detectableLayer = default;

        return default;
    }

	// Token: 0x060005F0 RID: 1520 RVA: 0x000229D4 File Offset: 0x00020BD4
	private string GetEntity(int layer, Device device)
	{

        return default;
    }

	// Token: 0x060005F1 RID: 1521 RVA: 0x00022A0C File Offset: 0x00020C0C
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x04000527 RID: 1319
	private AgentProperty _collisionBeginProperty;

	// Token: 0x04000528 RID: 1320
	private AgentProperty _collisionEndProperty;

	// Token: 0x04000529 RID: 1321
	private AgentProperty _hitForceProperty;

	// Token: 0x0400052A RID: 1322
	private AgentProperty _detectablesProperty;

	// Token: 0x0400052B RID: 1323
	private AgentProperty _hitEntityProperty;

	// Token: 0x0400052C RID: 1324
	private Dictionary<int, int> _detectablesLayers;

	// Token: 0x0400052D RID: 1325
	private Dictionary<int, string> _entityLayers;

	// Token: 0x0400052E RID: 1326
	private float _hitForce;

	// Token: 0x0400052F RID: 1327
	private string _hitEntityName;

	// Token: 0x04000530 RID: 1328
	private bool _isColliding;

	// Token: 0x04000531 RID: 1329
	private bool _wasColliding;

	// Token: 0x04000532 RID: 1330
	private int _projectilesLayer;
}
}