using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;

namespace PlasmaAPI.GameClass {
// Token: 0x020000CC RID: 204
public class SevenSegmentDisplayAgent : Agent
{
	// Token: 0x06000917 RID: 2327 RVA: 0x00031C27 File Offset: 0x0002FE27
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x04000867 RID: 2151
	private AgentProperty _stateProperty;

	// Token: 0x02000389 RID: 905
	public enum Commands
	{
		// Token: 0x04001C60 RID: 7264
		SetState = 1,
		// Token: 0x04001C61 RID: 7265
		SetForegroundColor,
		// Token: 0x04001C62 RID: 7266
		SetBackgroundColor,
		// Token: 0x04001C63 RID: 7267
		UpdateVisuals
	}
}
}