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
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x0200011D RID: 285
public class PolygonDrawerAgent : Agent
{
	// Token: 0x06000AFC RID: 2812 RVA: 0x00039B7C File Offset: 0x00037D7C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00039BD4 File Offset: 0x00037DD4
	[SketchNodePortOperation(1)]
	public void Draw(SketchNode sketchNode)
	{

	}

	// Token: 0x040009DC RID: 2524
	private AgentProperty _linesProperty;

	// Token: 0x040009DD RID: 2525
	private AgentProperty _contiguousProperty;

	// Token: 0x040009DE RID: 2526
	private AgentProperty _colorProperty;

	// Token: 0x040009DF RID: 2527
	private AgentProperty _destinationProperty;
}
}