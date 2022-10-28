using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x0200005E RID: 94
public class ButtonSimpleAgent : Agent
{
	// Token: 0x060005AA RID: 1450 RVA: 0x00021872 File Offset: 0x0001FA72
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00021886 File Offset: 0x0001FA86
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00021899 File Offset: 0x0001FA99
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x060005AD RID: 1453 RVA: 0x000218A4 File Offset: 0x0001FAA4
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x040004F3 RID: 1267
	private bool _wasPressed;

	// Token: 0x040004F4 RID: 1268
	private bool _shouldConsumeInput;

	// Token: 0x040004F5 RID: 1269
	private AgentProperty _pressedProperty;
}
}