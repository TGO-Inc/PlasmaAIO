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
// Token: 0x02000119 RID: 281
public class ParserAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000AEC RID: 2796 RVA: 0x0003965E File Offset: 0x0003785E
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00039684 File Offset: 0x00037884
	[SketchNodePortOperation(1)]
	public void Parse(SketchNode sketchNode)
	{

	}

	// Token: 0x040009C6 RID: 2502
	private AgentProperty _textProperty;

	// Token: 0x040009C7 RID: 2503
	private AgentProperty _decorationProperty;
}
}