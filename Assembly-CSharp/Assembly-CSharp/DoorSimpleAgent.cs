using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000076 RID: 118
public class DoorSimpleAgent : Agent
{
	// Token: 0x06000664 RID: 1636 RVA: 0x00024DA5 File Offset: 0x00022FA5
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00024DCB File Offset: 0x00022FCB
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00024DE1 File Offset: 0x00022FE1
	[SketchNodePortOperation(1)]
	public void Open(SketchNode sketchNode)
	{

	}

	// Token: 0x040005B2 RID: 1458
	private AgentProperty _targetRotationProperty;

	// Token: 0x040005B3 RID: 1459
	private AgentProperty _currentRotationProperty;

	// Token: 0x040005B4 RID: 1460
	private const float _openDegrees = 90f;

	// Token: 0x02000358 RID: 856
	public enum Commands
	{
		// Token: 0x04001BC3 RID: 7107
		SetPhysics = 1
	}
}
}