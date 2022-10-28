using System;
using Behavior;

// Token: 0x02000066 RID: 102
public class CollisionDetectorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x060005E6 RID: 1510 RVA: 0x0002258C File Offset: 0x0002078C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x000225E1 File Offset: 0x000207E1
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00022600 File Offset: 0x00020800
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000523 RID: 1315
	private AgentProperty _collisionBeginProperty;

	// Token: 0x04000524 RID: 1316
	private AgentProperty _collisionEndProperty;

	// Token: 0x04000525 RID: 1317
	private AgentProperty _hitForceProperty;

	// Token: 0x04000526 RID: 1318
	private AgentProperty _hitEntityProperty;
}
