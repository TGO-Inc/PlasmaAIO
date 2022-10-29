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
// Token: 0x0200012E RID: 302
public class TextDrawerAgent : Agent
{
	// Token: 0x06000B5A RID: 2906 RVA: 0x0003B2E8 File Offset: 0x000394E8
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x0003B350 File Offset: 0x00039550
	[SketchNodePortOperation(1)]
	public void DrawText(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A1A RID: 2586
	private AgentProperty _xProperty;

	// Token: 0x04000A1B RID: 2587
	private AgentProperty _yProperty;

	// Token: 0x04000A1C RID: 2588
	private AgentProperty _textProperty;

	// Token: 0x04000A1D RID: 2589
	private AgentProperty _colorProperty;

	// Token: 0x04000A1E RID: 2590
	private AgentProperty _destinationProperty;
}
}