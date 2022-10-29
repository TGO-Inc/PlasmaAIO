using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000AA RID: 170
public class MountAgent : Agent
{
	// Token: 0x060007FF RID: 2047 RVA: 0x0002CDC1 File Offset: 0x0002AFC1
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000800 RID: 2048 RVA: 0x0002CDCE File Offset: 0x0002AFCE
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000764 RID: 1892
	public Dictionary<MountPropertyEnum, KeyValuePair<bool, bool>> buttonValues;

	// Token: 0x04000765 RID: 1893
	private bool _shouldConsumeInput;

	// Token: 0x02000371 RID: 881
	public enum Commands
	{
		// Token: 0x04001C19 RID: 7193
		SetPhysics = 1
	}
}
}