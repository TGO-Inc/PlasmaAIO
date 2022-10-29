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

namespace PlasmaAPI.GameClass {
// Token: 0x020000B5 RID: 181
public class PlasmaCannonAgent : Agent, IDataSelectionProvider
{
	// Token: 0x0600085F RID: 2143 RVA: 0x0002EE96 File Offset: 0x0002D096
	protected override void OnSetupFinished()
	{
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0002EE98 File Offset: 0x0002D098
	[SketchNodePortOperation(1)]
	public void FireToggleState(SketchNode sketchNode)
	{

	}

	// Token: 0x02000377 RID: 887
	public enum Commands
	{
		// Token: 0x04001C2A RID: 7210
		Fire = 1
	}
}
}