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
// Token: 0x020001B4 RID: 436
public enum PlasmaRayStatus
{
	// Token: 0x04000DEE RID: 3566
	off,
	// Token: 0x04000DEF RID: 3567
	activating,
	// Token: 0x04000DF0 RID: 3568
	active,
	// Token: 0x04000DF1 RID: 3569
	deactivating
}
}