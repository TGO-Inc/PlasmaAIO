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
// Token: 0x0200005C RID: 92
public class ButtonAgent : Agent
{
	// Token: 0x06000597 RID: 1431 RVA: 0x00021619 File Offset: 0x0001F819
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0002163F File Offset: 0x0001F83F
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00021652 File Offset: 0x0001F852
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0002165C File Offset: 0x0001F85C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x040004E4 RID: 1252
	private bool _wasPressed;

	// Token: 0x040004E5 RID: 1253
	private bool _shouldConsumeInput;

	// Token: 0x040004E6 RID: 1254
	private AgentProperty _pressedProperty;

	// Token: 0x040004E7 RID: 1255
	private AgentProperty _continuousOutputProperty;

	// Token: 0x0200034A RID: 842
	public enum Commands
	{
		// Token: 0x04001B8F RID: 7055
		SetLEDStripColor = 1
	}
}
}