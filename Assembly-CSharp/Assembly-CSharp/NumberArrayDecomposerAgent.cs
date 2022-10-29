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
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x02000113 RID: 275
public class NumberArrayDecomposerAgent : Agent
{
	// Token: 0x06000AD8 RID: 2776 RVA: 0x00038FFC File Offset: 0x000371FC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00039010 File Offset: 0x00037210
	[SketchNodePortOperation(1)]
	public void Decompose(SketchNode sketchNode)
	{

	}

	// Token: 0x040009B5 RID: 2485
	private AgentProperty _arrayProperty;
}
}