using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000A6 RID: 166
public class LinkBallAgent : Agent
{
	// Token: 0x060007DC RID: 2012 RVA: 0x0002C324 File Offset: 0x0002A524
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060007DD RID: 2013 RVA: 0x0002C379 File Offset: 0x0002A579
	public override void OnDeviceReset()
	{

	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0002C39D File Offset: 0x0002A59D
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x060007DF RID: 2015 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x0002C46C File Offset: 0x0002A66C
	[AgentPropertyHandler(1)]
	public void HandleTargetVerticalPosition(AgentProperty property)
	{

	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x0002C4AC File Offset: 0x0002A6AC
	[AgentPropertyHandler(2)]
	public void HandleTargetHorizontallPosition(AgentProperty property)
	{

	}

	// Token: 0x0400073A RID: 1850
	private AgentProperty _targetVerticalPositionProperty;

	// Token: 0x0400073B RID: 1851
	private AgentProperty _currentVerticalPositionProperty;

	// Token: 0x0400073C RID: 1852
	private AgentProperty _targetHorizontalPositionProperty;

	// Token: 0x0400073D RID: 1853
	private AgentProperty _currentHorizontalPositionProperty;

	// Token: 0x0400073E RID: 1854
	private bool _canTriggerVertical;

	// Token: 0x0400073F RID: 1855
	private bool _shouldTriggerVertical;

	// Token: 0x04000740 RID: 1856
	private bool _canTriggerHorizontal;

	// Token: 0x04000741 RID: 1857
	private bool _shouldTriggerHorizontal;

	// Token: 0x04000742 RID: 1858
	private const float _tolerance = 1f;

	// Token: 0x0200036F RID: 879
	public enum Commands
	{
		// Token: 0x04001C13 RID: 7187
		SetPhysics = 1
	}
}
}