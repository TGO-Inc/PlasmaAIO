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
// Token: 0x02000116 RID: 278
public class NumberNegatorAgent : Agent
{
	// Token: 0x06000AE0 RID: 2784 RVA: 0x00039203 File Offset: 0x00037403
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00039217 File Offset: 0x00037417
	[SketchNodePortOperation(1)]
	public void Negate(SketchNode sketchNode)
	{

	}

	// Token: 0x040009B8 RID: 2488
	private AgentProperty _numberProperty;
}
}