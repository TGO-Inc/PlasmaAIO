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
using System.Globalization;
using Behavior;
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x02000112 RID: 274
public class NumberArrayComposerAgent : Agent
{
	// Token: 0x06000AD5 RID: 2773 RVA: 0x00038EC0 File Offset: 0x000370C0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00038F68 File Offset: 0x00037168
	[SketchNodePortOperation(1)]
	public void Compose(SketchNode sketchNode)
	{

	}

	// Token: 0x040009B4 RID: 2484
	private List<AgentProperty> _elementProperties;
}
}