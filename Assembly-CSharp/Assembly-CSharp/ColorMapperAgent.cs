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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000F3 RID: 243
public class ColorMapperAgent : Agent
{
	// Token: 0x06000A15 RID: 2581 RVA: 0x00035171 File Offset: 0x00033371
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x000351AC File Offset: 0x000333AC
	[SketchNodePortOperation(1)]
	public void Map(SketchNode sketchNode)
	{

	}

	// Token: 0x04000931 RID: 2353
	private AgentProperty _percentageProperty;

	// Token: 0x04000932 RID: 2354
	private AgentProperty _fromProperty;

	// Token: 0x04000933 RID: 2355
	private AgentProperty _toProperty;
}
}