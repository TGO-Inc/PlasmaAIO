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
// Token: 0x0200018E RID: 398
public struct SerializedSocket
{
	// Token: 0x04000C90 RID: 3216
	public int ownerSubComponentIndex;

	// Token: 0x04000C91 RID: 3217
	public int index;

	// Token: 0x04000C92 RID: 3218
	public Vector3 localPosition;

	// Token: 0x04000C93 RID: 3219
	public Quaternion localRotation;
}
}