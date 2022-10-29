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
// Token: 0x0200011A RID: 282
public class PercentageMapperAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000AEF RID: 2799 RVA: 0x000396EC File Offset: 0x000378EC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00039766 File Offset: 0x00037966
	[AgentPropertyHandler(1)]
	public void HandleDecoration(AgentProperty agentProperty)
	{

	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x000397A4 File Offset: 0x000379A4
	[SketchNodePortOperation(1)]
	public void Map(SketchNode sketchNode)
	{

	}

	// Token: 0x040009C8 RID: 2504
	private AgentProperty _fromProperty;

	// Token: 0x040009C9 RID: 2505
	private AgentProperty _toProperty;

	// Token: 0x040009CA RID: 2506
	private AgentProperty _percentageProperty;

	// Token: 0x040009CB RID: 2507
	private AgentProperty _easeProperty;

	// Token: 0x040009CC RID: 2508
	private AgentProperty _useNegativeProperty;

	// Token: 0x040009CD RID: 2509
	private AgentProperty _decorationProperty;
}
}