using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000082 RID: 130
public class FrontalExtenderAgent : Agent
{
	// Token: 0x060006A7 RID: 1703 RVA: 0x0002644D File Offset: 0x0002464D
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00026473 File Offset: 0x00024673
	public override void OnDeviceReset()
	{

	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00026490 File Offset: 0x00024690
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00026499 File Offset: 0x00024699
	protected override void OnDriverSet()
	{

	}

	// Token: 0x060006AB RID: 1707 RVA: 0x000264AC File Offset: 0x000246AC
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00026520 File Offset: 0x00024720
	[AgentPropertyHandler(1)]
	public void HandleTargetPosition(AgentProperty property)
	{

	}

	// Token: 0x04000604 RID: 1540
	public const float tolerance = 0.01f;

	// Token: 0x04000605 RID: 1541
	private AgentProperty _targetPositionProperty;

	// Token: 0x04000606 RID: 1542
	private AgentProperty _currentPositionProperty;

	// Token: 0x04000607 RID: 1543
	private FrontalExtenderDriver _driver;

	// Token: 0x04000608 RID: 1544
	private bool _canTrigger;

	// Token: 0x04000609 RID: 1545
	private bool _shouldTrigger;

	// Token: 0x0200035E RID: 862
	public enum Commands
	{
		// Token: 0x04001BD0 RID: 7120
		SetPhysics = 1,
		// Token: 0x04001BD1 RID: 7121
		UpdateVisuals = 4
	}
}
}