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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000114 RID: 276
public class NumberComparatorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000ADB RID: 2779 RVA: 0x000390BC File Offset: 0x000372BC
	[SketchNodePortOperation(1)]
	public void Compare(SketchNode sketchNode)
	{

	}

	// Token: 0x020003A1 RID: 929
	private enum Operators
	{
		// Token: 0x04001CB3 RID: 7347
		Equal,
		// Token: 0x04001CB4 RID: 7348
		NotEqual,
		// Token: 0x04001CB5 RID: 7349
		Less,
		// Token: 0x04001CB6 RID: 7350
		LessOrEqual,
		// Token: 0x04001CB7 RID: 7351
		Greater,
		// Token: 0x04001CB8 RID: 7352
		GreaterOrEqual
	}
}
}