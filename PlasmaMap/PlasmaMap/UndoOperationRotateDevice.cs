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
// Token: 0x0200015D RID: 349
public class UndoOperationRotateDevice : UndoOperation
{
	// Token: 0x06000DE9 RID: 3561 RVA: 0x000472C8 File Offset: 0x000454C8
	public UndoOperationRotateDevice(ComponentHandler component, Quaternion rotation)
	{

	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x000472E8 File Offset: 0x000454E8
	public override void Execute()
	{

	}

	// Token: 0x04000B50 RID: 2896
	private Quaternion _rotation;
}
}