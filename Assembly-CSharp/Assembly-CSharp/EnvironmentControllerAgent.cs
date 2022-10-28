using System;
using Behavior;

// Token: 0x020000FB RID: 251
public class EnvironmentControllerAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A42 RID: 2626 RVA: 0x00036082 File Offset: 0x00034282
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x000360A8 File Offset: 0x000342A8
	[SketchNodePortOperation(1)]
	public void SetTimeOfDay(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x000360D5 File Offset: 0x000342D5
	[SketchNodePortOperation(2)]
	public void SetTimeSpeed(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x000360F8 File Offset: 0x000342F8
	[SketchNodePortOperation(3)]
	public void GetCurrent(SketchNode sketchNode)
	{

	}

	// Token: 0x0400095D RID: 2397
	private AgentProperty _targetTimeOfDayProperty;

	// Token: 0x0400095E RID: 2398
	private AgentProperty _targetTimeSpeedProperty;
}
