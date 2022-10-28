using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000FE RID: 254
public class FlipFlopAgent : Agent
{
	// Token: 0x06000A50 RID: 2640 RVA: 0x0003637D File Offset: 0x0003457D
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00036391 File Offset: 0x00034591
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x000363A4 File Offset: 0x000345A4
	[SketchNodePortOperation(1)]
	public void Flip(SketchNode sketchNode)
	{

	}

	// Token: 0x04000963 RID: 2403
	private AgentProperty _currentOutputProperty;
}
}