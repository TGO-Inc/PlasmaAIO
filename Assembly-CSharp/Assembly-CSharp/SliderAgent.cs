using System;
using Behavior;
using UnityEngine;

// Token: 0x020000D0 RID: 208
public class SliderAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000931 RID: 2353 RVA: 0x00032173 File Offset: 0x00030373
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00032199 File Offset: 0x00030399
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x06000933 RID: 2355 RVA: 0x000321B3 File Offset: 0x000303B3
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x06000934 RID: 2356 RVA: 0x000321CD File Offset: 0x000303CD
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x06000935 RID: 2357 RVA: 0x000321D6 File Offset: 0x000303D6
	public override void PrepareForSketchRetrigger()
	{

	}

	// Token: 0x06000936 RID: 2358 RVA: 0x000321E0 File Offset: 0x000303E0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000880 RID: 2176
	private AgentProperty _positionProperty;

	// Token: 0x04000881 RID: 2177
	private AgentProperty _previousPositionProperty;

	// Token: 0x04000882 RID: 2178
	private bool _shouldConsumeInput;

	// Token: 0x0200038C RID: 908
	public enum Commands
	{
		// Token: 0x04001C6A RID: 7274
		SetLEDStripColor = 1,
		// Token: 0x04001C6B RID: 7275
		UpdateVisuals
	}
}
