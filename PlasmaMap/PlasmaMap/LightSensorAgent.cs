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
// Token: 0x020000A4 RID: 164
public class LightSensorAgent : Agent
{
	// Token: 0x060007D6 RID: 2006 RVA: 0x0002C030 File Offset: 0x0002A230
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0002C044 File Offset: 0x0002A244
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000737 RID: 1847
	private AgentProperty _intensityProperty;
}
}