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
// Token: 0x0200013A RID: 314
public class ValueInjectorAgent : Agent
{
	// Token: 0x06000B9D RID: 2973 RVA: 0x0003CA24 File Offset: 0x0003AC24
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0003CA38 File Offset: 0x0003AC38
	[SketchNodePortOperation(1)]
	public void Inject(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A62 RID: 2658
	private AgentProperty _valueProperty;
}
}