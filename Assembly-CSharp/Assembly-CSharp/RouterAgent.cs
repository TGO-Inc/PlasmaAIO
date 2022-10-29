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
// Token: 0x02000125 RID: 293
public class RouterAgent : Agent
{
	// Token: 0x06000B20 RID: 2848 RVA: 0x0003A3CB File Offset: 0x000385CB
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0003A3F1 File Offset: 0x000385F1
	[SketchNodePortOperation(1)]
	public void Forward(SketchNode sketchNode)
	{

	}

	// Token: 0x040009F7 RID: 2551
	private AgentProperty _valueProperty;

	// Token: 0x040009F8 RID: 2552
	private AgentProperty _usePrimaryProperty;
}
}