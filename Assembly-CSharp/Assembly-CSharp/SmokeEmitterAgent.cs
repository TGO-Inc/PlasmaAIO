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
// Token: 0x020000D4 RID: 212
public class SmokeEmitterAgent : Agent, IDataSelectionProvider
{
	// Token: 0x0200038E RID: 910
	public enum Commands
	{
		// Token: 0x04001C6F RID: 7279
		UpdateVisuals = 1,
		// Token: 0x04001C70 RID: 7280
		SetState
	}
}
}