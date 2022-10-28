using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000123 RID: 291
public class RelayAgent : Agent
{
	// Token: 0x06000B16 RID: 2838 RVA: 0x0003A2E6 File Offset: 0x000384E6
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0003A2FA File Offset: 0x000384FA
	[SketchNodePortOperation(1)]
	public void Relay(SketchNode sketchNode)
	{

	}

	// Token: 0x040009F3 RID: 2547
	private AgentProperty _payloadProperty;
}
}