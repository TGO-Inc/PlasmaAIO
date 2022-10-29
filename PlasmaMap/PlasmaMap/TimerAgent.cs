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
// Token: 0x02000133 RID: 307
public class TimerAgent : Agent
{
	// Token: 0x06000B7B RID: 2939 RVA: 0x0003BBC0 File Offset: 0x00039DC0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x0003BC4A File Offset: 0x00039E4A
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x0003BC78 File Offset: 0x00039E78
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0003BD7E File Offset: 0x00039F7E
	[SketchNodePortOperation(1)]
	public void Start(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A2B RID: 2603
	private AgentProperty _elapsedTicksProperty;

	// Token: 0x04000A2C RID: 2604
	private AgentProperty _runningProperty;

	// Token: 0x04000A2D RID: 2605
	private AgentProperty _doneProperty;

	// Token: 0x04000A2E RID: 2606
	private AgentProperty _durationProperty;

	// Token: 0x04000A2F RID: 2607
	private AgentProperty _loopProperty;

	// Token: 0x04000A30 RID: 2608
	private AgentProperty _progressProperty;

	// Token: 0x04000A31 RID: 2609
	private Data _elapsedTime;
}
}