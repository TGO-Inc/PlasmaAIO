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
// Token: 0x020000A8 RID: 168
public class MagnetAgent : Agent
{
	// Token: 0x02000370 RID: 880
	public enum Commands
	{
		// Token: 0x04001C15 RID: 7189
		SetForce = 1,
		// Token: 0x04001C16 RID: 7190
		SetPolarity,
		// Token: 0x04001C17 RID: 7191
		SetRange
	}
}
}