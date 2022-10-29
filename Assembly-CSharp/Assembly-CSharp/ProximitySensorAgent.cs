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
// Token: 0x020000BF RID: 191
public class ProximitySensorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x060008C1 RID: 2241 RVA: 0x0003030C File Offset: 0x0002E50C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00030345 File Offset: 0x0002E545
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x0003036C File Offset: 0x0002E56C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000813 RID: 2067
	private AgentProperty _foundProperty;

	// Token: 0x04000814 RID: 2068
	private AgentProperty _lostProperty;

	// Token: 0x04000815 RID: 2069
	private AgentProperty _detectionsProperty;

	// Token: 0x02000382 RID: 898
	public enum Commands
	{
		// Token: 0x04001C4D RID: 7245
		UpdateVisuals = 1,
		// Token: 0x04001C4E RID: 7246
		SetSphereRadius,
		// Token: 0x04001C4F RID: 7247
		SetShape,
		// Token: 0x04001C50 RID: 7248
		SetBoxSize
	}
}
}