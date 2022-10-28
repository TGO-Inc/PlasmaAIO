using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000115 RID: 277
public class NumberDecoratorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000ADD RID: 2781 RVA: 0x00039191 File Offset: 0x00037391
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x000391B8 File Offset: 0x000373B8
	[SketchNodePortOperation(1)]
	public void Decorate(SketchNode sketchNode)
	{

	}

	// Token: 0x040009B6 RID: 2486
	private AgentProperty _numberProperty;

	// Token: 0x040009B7 RID: 2487
	private AgentProperty _decorationProperty;
}
}