using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000074 RID: 116
public class DoorAgent : Agent
{
	// Token: 0x06000651 RID: 1617 RVA: 0x000248C2 File Offset: 0x00022AC2
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000248FA File Offset: 0x00022AFA
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00024910 File Offset: 0x00022B10
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0002491C File Offset: 0x00022B1C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00024980 File Offset: 0x00022B80
	[AgentPropertyHandler(1)]
	public void HandleTargetPosition(AgentProperty property)
	{

	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000249BE File Offset: 0x00022BBE
	[SketchNodePortOperation(1)]
	public void Open(SketchNode sketchNode)
	{

	}

	// Token: 0x0400059B RID: 1435
	private AgentProperty _targetRotationProperty;

	// Token: 0x0400059C RID: 1436
	private AgentProperty _currentRotationProperty;

	// Token: 0x0400059D RID: 1437
	private AgentProperty _invertedProperty;

	// Token: 0x0400059E RID: 1438
	private bool _canTrigger;

	// Token: 0x0400059F RID: 1439
	private bool _shouldTrigger;

	// Token: 0x040005A0 RID: 1440
	private const float _tolerance = 1f;

	// Token: 0x040005A1 RID: 1441
	private const float _openDegrees = 90f;

	// Token: 0x02000357 RID: 855
	public enum Commands
	{
		// Token: 0x04001BC1 RID: 7105
		SetPhysics = 1
	}
}
}