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
// Token: 0x0200008D RID: 141
public class GyroscopeDriver : ComponentDriver
{
	// Token: 0x06000705 RID: 1797 RVA: 0x00028350 File Offset: 0x00026550
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000706 RID: 1798 RVA: 0x0002844C File Offset: 0x0002664C
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00028483 File Offset: 0x00026683
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00028490 File Offset: 0x00026690
	public override void OnMount()
	{

	}

	// Token: 0x06000709 RID: 1801 RVA: 0x000284A9 File Offset: 0x000266A9
	public override void OnUnmount()
	{

	}

	// Token: 0x0600070A RID: 1802 RVA: 0x000284C4 File Offset: 0x000266C4
	private void Update()
	{

	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00028548 File Offset: 0x00026748
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x04000650 RID: 1616
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000651 RID: 1617
	public Transform disc;

	// Token: 0x04000652 RID: 1618
	public Transform ring1;

	// Token: 0x04000653 RID: 1619
	public Transform ring2;

	// Token: 0x04000654 RID: 1620
	public float rotationSpeed;

	// Token: 0x04000655 RID: 1621
	private AgentProperty _pitchProperty;

	// Token: 0x04000656 RID: 1622
	private AgentProperty _yawProperty;

	// Token: 0x04000657 RID: 1623
	private AgentProperty _rollProperty;

	// Token: 0x04000658 RID: 1624
	private AgentProperty _pitchSpeedProperty;

	// Token: 0x04000659 RID: 1625
	private AgentProperty _yawSpeedProperty;

	// Token: 0x0400065A RID: 1626
	private AgentProperty _rollSpeedProperty;

	// Token: 0x0400065B RID: 1627
	private AgentProperty _rootComponentProperty;

	// Token: 0x0400065C RID: 1628
	private AgentProperty _negativeAnglesProperty;

	// Token: 0x0400065D RID: 1629
	private Transform _transform;

	// Token: 0x0400065E RID: 1630
	private float _ring1Speed;

	// Token: 0x0400065F RID: 1631
	private float _ring2Speed;
}
}