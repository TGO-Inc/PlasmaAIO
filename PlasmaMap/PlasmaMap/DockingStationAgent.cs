using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000072 RID: 114
public class DockingStationAgent : Agent
{
	// Token: 0x0600063B RID: 1595 RVA: 0x00023F94 File Offset: 0x00022194
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00023FC7 File Offset: 0x000221C7
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00023FDA File Offset: 0x000221DA
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00023FE4 File Offset: 0x000221E4
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00024118 File Offset: 0x00022318
	[SketchNodePortOperation(1)]
	public void Undock(SketchNode sketchNode)
	{

	}

	// Token: 0x0400058B RID: 1419
	public Dictionary<DockingStationPropertyEnum, KeyValuePair<bool, bool>> buttonValues;

	// Token: 0x0400058C RID: 1420
	private bool _wasDocked;

	// Token: 0x0400058D RID: 1421
	private bool _shouldConsumeInput;

	// Token: 0x0400058E RID: 1422
	private AgentProperty _isDockedProperty;

	// Token: 0x0400058F RID: 1423
	private AgentProperty _continuousButtonOutputProperty;

	// Token: 0x02000356 RID: 854
	public enum Commands
	{
		// Token: 0x04001BBF RID: 7103
		Undock = 1
	}
}
}