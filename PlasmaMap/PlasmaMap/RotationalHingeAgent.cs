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
// Token: 0x020000C5 RID: 197
public class RotationalHingeAgent : Agent
{
	// Token: 0x060008DE RID: 2270 RVA: 0x00030E0F File Offset: 0x0002F00F
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00030E23 File Offset: 0x0002F023
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000830 RID: 2096
	private AgentProperty _currentVelocityProperty;

	// Token: 0x02000385 RID: 901
	public enum Commands
	{
		// Token: 0x04001C56 RID: 7254
		SetPhysics = 1
	}
}
}