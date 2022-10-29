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
// Token: 0x0200013B RID: 315
public class VariableReaderAgent : Agent
{
	// Token: 0x06000BA0 RID: 2976 RVA: 0x0003CA59 File Offset: 0x0003AC59
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x0003CA70 File Offset: 0x0003AC70
	[SketchNodePortOperation(1)]
	public void Read(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A63 RID: 2659
	private AgentProperty _variableProperty;
}
}