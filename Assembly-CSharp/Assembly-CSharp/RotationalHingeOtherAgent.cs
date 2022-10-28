using System;
using Behavior;

// Token: 0x020000C7 RID: 199
public class RotationalHingeOtherAgent : Agent
{
	// Token: 0x060008F0 RID: 2288 RVA: 0x00031272 File Offset: 0x0002F472
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00031286 File Offset: 0x0002F486
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000842 RID: 2114
	private AgentProperty _currentVelocityProperty;

	// Token: 0x02000387 RID: 903
	public enum Commands
	{
		// Token: 0x04001C5A RID: 7258
		SetPhysics = 1
	}
}
