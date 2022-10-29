using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200018D RID: 397
public struct SerializedDyamicProp
{
	// Token: 0x04000C8B RID: 3211
	public int id;

	// Token: 0x04000C8C RID: 3212
	public Vector3 position;

	// Token: 0x04000C8D RID: 3213
	public Quaternion rotation;

	// Token: 0x04000C8E RID: 3214
	public Vector3 linearVelocity;

	// Token: 0x04000C8F RID: 3215
	public Vector3 angularVelocity;
}
}