using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x0200009C RID: 156
public class LateralExtenderAgent : Agent
{
	// Token: 0x06000788 RID: 1928 RVA: 0x0002ACCF File Offset: 0x00028ECF
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000789 RID: 1929 RVA: 0x0002ACF5 File Offset: 0x00028EF5
	public override void OnDeviceReset()
	{

	}

	// Token: 0x0600078A RID: 1930 RVA: 0x0002AD12 File Offset: 0x00028F12
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x0600078B RID: 1931 RVA: 0x0002AD1B File Offset: 0x00028F1B
	protected override void OnDriverSet()
	{

	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0002AD30 File Offset: 0x00028F30
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0600078D RID: 1933 RVA: 0x0002ADA4 File Offset: 0x00028FA4
	[AgentPropertyHandler(1)]
	public void HandleTargetPosition(AgentProperty property)
	{

	}

	// Token: 0x040006E9 RID: 1769
	private AgentProperty _targetPositionProperty;

	// Token: 0x040006EA RID: 1770
	private AgentProperty _currentPositionProperty;

	// Token: 0x040006EB RID: 1771
	private LateralExtenderDriver _driver;

	// Token: 0x040006EC RID: 1772
	private bool _canTrigger;

	// Token: 0x040006ED RID: 1773
	private bool _shouldTrigger;

	// Token: 0x040006EE RID: 1774
	private const float _tolerance = 0.01f;

	// Token: 0x02000369 RID: 873
	public enum Commands
	{
		// Token: 0x04001C02 RID: 7170
		SetPhysics = 1,
		// Token: 0x04001C03 RID: 7171
		UpdateVisuals = 4
	}
}
}