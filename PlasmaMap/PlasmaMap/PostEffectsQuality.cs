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
// Token: 0x02000044 RID: 68
public enum PostEffectsQuality
{
	// Token: 0x0400024C RID: 588
	Off,
	// Token: 0x0400024D RID: 589
	Low,
	// Token: 0x0400024E RID: 590
	Normal,
	// Token: 0x0400024F RID: 591
	High,
	// Token: 0x04000250 RID: 592
	Ultra
}
}