using System;
using Behavior;

// Token: 0x02000070 RID: 112
public class DistanceSensorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x0600062D RID: 1581 RVA: 0x00023ACF File Offset: 0x00021CCF
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00023B07 File Offset: 0x00021D07
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00023B24 File Offset: 0x00021D24
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000579 RID: 1401
	private AgentProperty _detectedProperty;

	// Token: 0x0400057A RID: 1402
	private AgentProperty _wasDetectedProperty;

	// Token: 0x0400057B RID: 1403
	private AgentProperty _distanceProperty;

	// Token: 0x02000355 RID: 853
	public enum Commands
	{
		// Token: 0x04001BBD RID: 7101
		UpdateVisuals = 1
	}
}
