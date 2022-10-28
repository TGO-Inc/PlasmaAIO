using System;
using Behavior;

// Token: 0x020000B7 RID: 183
public class PlasmaTogglerAgent : Agent, IDataSelectionProvider
{
	// Token: 0x0600086A RID: 2154 RVA: 0x0002F089 File Offset: 0x0002D289
	protected override void OnSetupFinished()
	{
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002F08B File Offset: 0x0002D28B
	[SketchNodePortOperation(1)]
	public void FireToggleState(SketchNode sketchNode)
	{

	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0002F094 File Offset: 0x0002D294
	[SketchNodePortOperation(2)]
	public void FireInteraction(SketchNode sketchNode)
	{

	}

	// Token: 0x02000379 RID: 889
	public enum Commands
	{
		// Token: 0x04001C30 RID: 7216
		FireToggleState = 1,
		// Token: 0x04001C31 RID: 7217
		FireInteraction
	}
}
