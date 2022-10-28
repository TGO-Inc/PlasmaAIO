using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000126 RID: 294
public class SelectorAgent : Agent
{
	// Token: 0x06000B23 RID: 2851 RVA: 0x0003A437 File Offset: 0x00038637
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0003A44C File Offset: 0x0003864C
	[SketchNodePortOperation(1)]
	public void Yield(SketchNode sketchNode)
	{

	}

	// Token: 0x040009F9 RID: 2553
	private AgentProperty _indexProperty;

	// Token: 0x040009FA RID: 2554
	private const int _firstPayload = 3;
}
}