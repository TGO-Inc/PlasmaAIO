using System;
using Behavior;

// Token: 0x0200008E RID: 142
public class ImpactSensorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x0600070D RID: 1805 RVA: 0x00028738 File Offset: 0x00026938
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600070E RID: 1806 RVA: 0x0002878D File Offset: 0x0002698D
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x0600070F RID: 1807 RVA: 0x000287A0 File Offset: 0x000269A0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000660 RID: 1632
	private AgentProperty _collisionBeginProperty;

	// Token: 0x04000661 RID: 1633
	private AgentProperty _hitForceProperty;

	// Token: 0x04000662 RID: 1634
	private AgentProperty _hitComponentProperty;

	// Token: 0x04000663 RID: 1635
	private AgentProperty _hitEntityProperty;
}
