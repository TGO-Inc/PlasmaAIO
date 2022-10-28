using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200011B RID: 283
public class PhysicsForceAgent : Agent
{
	// Token: 0x06000AF3 RID: 2803 RVA: 0x00039854 File Offset: 0x00037A54
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x000398E0 File Offset: 0x00037AE0
	public override void OnWorldTickUpdate()
	{

	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x000399C9 File Offset: 0x00037BC9
	[SketchNodePortOperation(1)]
	public void Apply(SketchNode sketchNode)
	{

	}

	// Token: 0x040009CE RID: 2510
	private AgentProperty _worldProperty;

	// Token: 0x040009CF RID: 2511
	private AgentProperty _forceXProperty;

	// Token: 0x040009D0 RID: 2512
	private AgentProperty _forceYProperty;

	// Token: 0x040009D1 RID: 2513
	private AgentProperty _forceZProperty;

	// Token: 0x040009D2 RID: 2514
	private AgentProperty _offsetXProperty;

	// Token: 0x040009D3 RID: 2515
	private AgentProperty _offsetYProperty;

	// Token: 0x040009D4 RID: 2516
	private AgentProperty _offsetZProperty;

	// Token: 0x040009D5 RID: 2517
	private bool _apply;
}
}