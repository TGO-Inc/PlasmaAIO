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
// Token: 0x020000C7 RID: 199
public class RotationalHingeOtherAgent : Agent
{
	// Token: 0x060008F0 RID: 2288 RVA: 0x00031272 File Offset: 0x0002F472
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00031286 File Offset: 0x0002F486
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000842 RID: 2114
	private AgentProperty _currentVelocityProperty;

	// Token: 0x02000387 RID: 903
	public enum Commands
	{
		// Token: 0x04001C5A RID: 7258
		SetPhysics = 1
	}
}
}