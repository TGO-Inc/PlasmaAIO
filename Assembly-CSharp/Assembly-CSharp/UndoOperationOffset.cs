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
// Token: 0x0200015E RID: 350
public class UndoOperationOffset : UndoOperation
{
	// Token: 0x06000DEB RID: 3563 RVA: 0x0004738C File Offset: 0x0004558C
	public UndoOperationOffset(ComponentHandler component, float offset)
	{

	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x000473A9 File Offset: 0x000455A9
	public override void Execute()
	{

	}

	// Token: 0x04000B51 RID: 2897
	private float _offset;
}
}