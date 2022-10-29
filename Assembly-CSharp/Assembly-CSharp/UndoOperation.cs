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
// Token: 0x02000157 RID: 343
public class UndoOperation
{
	// Token: 0x06000DDD RID: 3549 RVA: 0x00046D07 File Offset: 0x00044F07
	public virtual void Execute()
	{
	}

	// Token: 0x04000B3D RID: 2877
	public ComponentHandler component;

	// Token: 0x04000B3E RID: 2878
	public UndoOperationType operationType;

	// Token: 0x04000B3F RID: 2879
	public bool linkedToPrevious;
}
}