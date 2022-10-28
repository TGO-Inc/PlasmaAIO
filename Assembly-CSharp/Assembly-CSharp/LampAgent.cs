using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x0200009A RID: 154
public class LampAgent : Agent
{
	// Token: 0x06000779 RID: 1913 RVA: 0x0002AA3D File Offset: 0x00028C3D
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600077A RID: 1914 RVA: 0x0002AA51 File Offset: 0x00028C51
	[SketchNodePortOperation(1)]
	public void Toggle(SketchNode sketchNode)
	{

	}

	// Token: 0x040006E0 RID: 1760
	private AgentProperty _stateProperty;

	// Token: 0x02000368 RID: 872
	public enum Commands
	{
		// Token: 0x04001BFD RID: 7165
		SetState = 1,
		// Token: 0x04001BFE RID: 7166
		SetColor,
		// Token: 0x04001BFF RID: 7167
		SetRange = 4,
		// Token: 0x04001C00 RID: 7168
		SetIntensity
	}
}
}