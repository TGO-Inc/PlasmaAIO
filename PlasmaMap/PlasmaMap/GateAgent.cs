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
// Token: 0x02000102 RID: 258
public class GateAgent : Agent
{
	// Token: 0x06000A61 RID: 2657 RVA: 0x00036701 File Offset: 0x00034901
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00036727 File Offset: 0x00034927
	[SketchNodePortOperation(1)]
	public void TryToSend(SketchNode sketchNode)
	{

	}

	// Token: 0x0400096A RID: 2410
	private AgentProperty _allowedProperty;

	// Token: 0x0400096B RID: 2411
	private AgentProperty _payloadProperty;
}
}