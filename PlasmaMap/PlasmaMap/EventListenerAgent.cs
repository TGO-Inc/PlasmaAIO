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
// Token: 0x020000FD RID: 253
public class EventListenerAgent : Agent
{
	// Token: 0x06000A4D RID: 2637 RVA: 0x00036348 File Offset: 0x00034548
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0003635C File Offset: 0x0003455C
	[SketchNodePortOperation(1)]
	public void Run(SketchNode sketchNode)
	{

	}

	// Token: 0x04000962 RID: 2402
	private AgentProperty _payloadProperty;
}
}