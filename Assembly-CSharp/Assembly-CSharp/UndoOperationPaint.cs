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
// Token: 0x02000158 RID: 344
public class UndoOperationPaint : UndoOperation
{
	// Token: 0x06000DDF RID: 3551 RVA: 0x00046D11 File Offset: 0x00044F11
	public UndoOperationPaint(ComponentHandler component, bool alternate)
	{

	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00046D45 File Offset: 0x00044F45
	public override void Execute()
	{

	}

	// Token: 0x04000B40 RID: 2880
	private int _color;

	// Token: 0x04000B41 RID: 2881
	private bool _alternate;
}
}