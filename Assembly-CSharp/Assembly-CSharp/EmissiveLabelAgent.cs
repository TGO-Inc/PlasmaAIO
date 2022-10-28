using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x0200007A RID: 122
public class EmissiveLabelAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000680 RID: 1664 RVA: 0x00025B12 File Offset: 0x00023D12
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00025B26 File Offset: 0x00023D26
	[SketchNodePortOperation(1)]
	public void Toggle(SketchNode sketchNode)
	{

	}

	// Token: 0x040005E6 RID: 1510
	private AgentProperty _stateProperty;

	// Token: 0x0200035A RID: 858
	public enum Commands
	{
		// Token: 0x04001BC7 RID: 7111
		UpdateVisuals = 1
	}
}
}