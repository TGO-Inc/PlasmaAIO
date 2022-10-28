using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000A2 RID: 162
public class Lever1AxisAgent : Agent
{
	// Token: 0x060007C4 RID: 1988 RVA: 0x0002BDE1 File Offset: 0x00029FE1
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0002BE07 File Offset: 0x0002A007
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x0002BE21 File Offset: 0x0002A021
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x0002BE3B File Offset: 0x0002A03B
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0002BE44 File Offset: 0x0002A044
	public override void PrepareForSketchRetrigger()
	{

	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0002BE50 File Offset: 0x0002A050
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0400072B RID: 1835
	private AgentProperty _positionProperty;

	// Token: 0x0400072C RID: 1836
	private AgentProperty _previousPositionProperty;

	// Token: 0x0400072D RID: 1837
	private bool _shouldConsumeInput;

	// Token: 0x0200036E RID: 878
	public enum Commands
	{
		// Token: 0x04001C10 RID: 7184
		SetLEDStripColor = 1,
		// Token: 0x04001C11 RID: 7185
		UpdateVisuals
	}
}
}