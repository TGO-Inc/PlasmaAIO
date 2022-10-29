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
// Token: 0x020000A0 RID: 160
public class LedAgent : Agent
{
	// Token: 0x060007BB RID: 1979 RVA: 0x0002BCF4 File Offset: 0x00029EF4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060007BC RID: 1980 RVA: 0x0002BD08 File Offset: 0x00029F08
	[SketchNodePortOperation(1)]
	public void Toggle(SketchNode sketchNode)
	{

	}

	// Token: 0x04000727 RID: 1831
	private AgentProperty _stateProperty;

	// Token: 0x0200036D RID: 877
	public enum Commands
	{
		// Token: 0x04001C0E RID: 7182
		UpdateVisuals = 1
	}
}
}