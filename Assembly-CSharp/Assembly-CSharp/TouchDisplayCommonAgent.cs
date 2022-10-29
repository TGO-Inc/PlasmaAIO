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
// Token: 0x020000E0 RID: 224
public class TouchDisplayCommonAgent : DisplayCommonnAgent
{
	// Token: 0x060009AD RID: 2477 RVA: 0x00033B64 File Offset: 0x00031D64
	public override void OnDeviceReset()
	{

	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00033B96 File Offset: 0x00031D96
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00033BA6 File Offset: 0x00031DA6
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00033BB0 File Offset: 0x00031DB0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x040008DD RID: 2269
	protected AgentProperty _pointerXProperty;

	// Token: 0x040008DE RID: 2270
	protected AgentProperty _pointerYProperty;

	// Token: 0x040008DF RID: 2271
	protected AgentProperty _pointerClickedProperty;

	// Token: 0x040008E0 RID: 2272
	protected AgentProperty _pointerActiveProperty;

	// Token: 0x040008E1 RID: 2273
	private bool _shouldConsumeInput;

	// Token: 0x040008E2 RID: 2274
	private bool _pointerWasClicked;

	// Token: 0x040008E3 RID: 2275
	private bool _pointerWasActive;
}
}