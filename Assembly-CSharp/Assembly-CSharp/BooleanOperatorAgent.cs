using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000EF RID: 239
public class BooleanOperatorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A0B RID: 2571 RVA: 0x00034F33 File Offset: 0x00033133
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00034F6C File Offset: 0x0003316C
	[SketchNodePortOperation(1)]
	public void Perform(SketchNode sketchNode)
	{

	}

	// Token: 0x0400092C RID: 2348
	private AgentProperty _v1Property;

	// Token: 0x0400092D RID: 2349
	private AgentProperty _v2Property;

	// Token: 0x0400092E RID: 2350
	private AgentProperty _operatorProperty;
}
}