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
// Token: 0x020000BB RID: 187
public class PowerSwitchAgent : Agent
{
	// Token: 0x0600088A RID: 2186 RVA: 0x0002F8A5 File Offset: 0x0002DAA5
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0002F8CB File Offset: 0x0002DACB
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002F8E5 File Offset: 0x0002DAE5
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0002F8EE File Offset: 0x0002DAEE
	public override void PrepareForSketchRetrigger()
	{

	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x040007F3 RID: 2035
	private AgentProperty _stateProperty;

	// Token: 0x040007F4 RID: 2036
	private AgentProperty _previousStateProperty;

	// Token: 0x040007F5 RID: 2037
	private bool _shouldConsumeInput;

	// Token: 0x0200037C RID: 892
	public enum Commands
	{
		// Token: 0x04001C38 RID: 7224
		SetLEDStripColor = 1,
		// Token: 0x04001C39 RID: 7225
		UpdateVisuals
	}
}
}