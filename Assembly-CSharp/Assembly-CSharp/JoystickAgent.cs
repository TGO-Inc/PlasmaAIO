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

namespace PlasmaAPI.GameClass {
// Token: 0x02000090 RID: 144
public class JoystickAgent : Agent
{
	// Token: 0x06000718 RID: 1816 RVA: 0x00028BF0 File Offset: 0x00026DF0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00028C61 File Offset: 0x00026E61
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00028C85 File Offset: 0x00026E85
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00028C90 File Offset: 0x00026E90
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000670 RID: 1648
	private AgentProperty _horizontalProperty;

	// Token: 0x04000671 RID: 1649
	private AgentProperty _verticalProperty;

	// Token: 0x04000672 RID: 1650
	private AgentProperty _isGrabbedProperty;

	// Token: 0x04000673 RID: 1651
	private AgentProperty _returnToCenterProperty;

	// Token: 0x04000674 RID: 1652
	private bool _wasGrabbed;

	// Token: 0x04000675 RID: 1653
	private bool _shouldConsumeInput;

	// Token: 0x04000676 RID: 1654
	private Data _zeroPercent;

	// Token: 0x04000677 RID: 1655
	private bool _wasReturningToCenter;

	// Token: 0x02000361 RID: 865
	public enum Commands
	{
		// Token: 0x04001BD9 RID: 7129
		SetLEDStripColor = 1,
		// Token: 0x04001BDA RID: 7130
		SetReturnToCenter
	}
}
}