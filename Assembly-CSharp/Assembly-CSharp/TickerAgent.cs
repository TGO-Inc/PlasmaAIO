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
// Token: 0x02000131 RID: 305
public class TickerAgent : Agent
{
	// Token: 0x06000B72 RID: 2930 RVA: 0x0003B900 File Offset: 0x00039B00
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0003B938 File Offset: 0x00039B38
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0003B958 File Offset: 0x00039B58
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A23 RID: 2595
	private AgentProperty _firstTickProperty;

	// Token: 0x04000A24 RID: 2596
	private AgentProperty _elapsedTicksProperty;

	// Token: 0x04000A25 RID: 2597
	private AgentProperty _intervalProperty;
}
}