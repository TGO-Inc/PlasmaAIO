using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000D8 RID: 216
public class SpotlightAgent : Agent
{
	// Token: 0x06000977 RID: 2423 RVA: 0x00033142 File Offset: 0x00031342
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00033156 File Offset: 0x00031356
	[SketchNodePortOperation(1)]
	public void Toggle(SketchNode sketchNode)
	{

	}

	// Token: 0x040008B7 RID: 2231
	private AgentProperty _stateProperty;

	// Token: 0x02000392 RID: 914
	public enum Commands
	{
		// Token: 0x04001C84 RID: 7300
		SetState = 1,
		// Token: 0x04001C85 RID: 7301
		SetColor,
		// Token: 0x04001C86 RID: 7302
		SetAngle,
		// Token: 0x04001C87 RID: 7303
		SetRange,
		// Token: 0x04001C88 RID: 7304
		SetIntensity
	}
}
}