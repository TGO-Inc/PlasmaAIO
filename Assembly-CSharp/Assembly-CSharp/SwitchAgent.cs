using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000DA RID: 218
public class SwitchAgent : Agent
{
	// Token: 0x06000987 RID: 2439 RVA: 0x0003340B File Offset: 0x0003160B
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00033431 File Offset: 0x00031631
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0003344B File Offset: 0x0003164B
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00033454 File Offset: 0x00031654
	public override void PrepareForSketchRetrigger()
	{

	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00033460 File Offset: 0x00031660
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x040008C1 RID: 2241
	private AgentProperty _stateProperty;

	// Token: 0x040008C2 RID: 2242
	private AgentProperty _previousStateProperty;

	// Token: 0x040008C3 RID: 2243
	private bool _shouldConsumeInput;

	// Token: 0x02000393 RID: 915
	public enum Commands
	{
		// Token: 0x04001C8A RID: 7306
		SetLEDStripColor = 1,
		// Token: 0x04001C8B RID: 7307
		UpdateVisuals
	}
}
}