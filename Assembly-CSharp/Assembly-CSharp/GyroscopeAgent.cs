using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x0200008C RID: 140
public class GyroscopeAgent : Agent
{
	// Token: 0x06000702 RID: 1794 RVA: 0x00028234 File Offset: 0x00026434
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00028290 File Offset: 0x00026490
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0400064A RID: 1610
	private AgentProperty _pitchProperty;

	// Token: 0x0400064B RID: 1611
	private AgentProperty _yawProperty;

	// Token: 0x0400064C RID: 1612
	private AgentProperty _rollProperty;

	// Token: 0x0400064D RID: 1613
	private AgentProperty _pitchSpeedProperty;

	// Token: 0x0400064E RID: 1614
	private AgentProperty _yawSpeedProperty;

	// Token: 0x0400064F RID: 1615
	private AgentProperty _rollSpeedProperty;
}
}