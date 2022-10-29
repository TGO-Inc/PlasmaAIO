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
// Token: 0x0200012A RID: 298
public class SynchronizerAgent : Agent
{
	// Token: 0x06000B37 RID: 2871 RVA: 0x0003AA9C File Offset: 0x00038C9C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x0003AAF4 File Offset: 0x00038CF4
	[SketchNodePortOperation(1)]
	public void Synchronize(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A0D RID: 2573
	private AgentProperty _v1Property;

	// Token: 0x04000A0E RID: 2574
	private AgentProperty _v2Property;

	// Token: 0x04000A0F RID: 2575
	private AgentProperty _v3Property;

	// Token: 0x04000A10 RID: 2576
	private AgentProperty _v4Property;
}
}