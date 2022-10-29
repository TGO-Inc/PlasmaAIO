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
// Token: 0x02000101 RID: 257
public class FunctionEntryAgent : Agent
{
	// Token: 0x06000A5E RID: 2654 RVA: 0x000366CC File Offset: 0x000348CC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x000366E0 File Offset: 0x000348E0
	[SketchNodePortOperation(1)]
	public void Run(SketchNode sketchNode)
	{

	}

	// Token: 0x04000969 RID: 2409
	private AgentProperty _payloadProperty;
}
}