using System;
using Behavior;
using UnityEngine;

// Token: 0x02000117 RID: 279
public class NumberTweenerAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000AE3 RID: 2787 RVA: 0x00039240 File Offset: 0x00037440
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00039318 File Offset: 0x00037518
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00039344 File Offset: 0x00037544
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x000394EF File Offset: 0x000376EF
	[SketchNodePortOperation(1)]
	public void Start(SketchNode sketchNode)
	{

	}

	// Token: 0x040009B9 RID: 2489
	private Data _numberData;

	// Token: 0x040009BA RID: 2490
	private Data _progressData;

	// Token: 0x040009BB RID: 2491
	private AgentProperty _elapsedTicksProperty;

	// Token: 0x040009BC RID: 2492
	private AgentProperty _runningProperty;

	// Token: 0x040009BD RID: 2493
	private AgentProperty _backwardProperty;

	// Token: 0x040009BE RID: 2494
	private AgentProperty _durationProperty;

	// Token: 0x040009BF RID: 2495
	private AgentProperty _fromProperty;

	// Token: 0x040009C0 RID: 2496
	private AgentProperty _toProperty;

	// Token: 0x040009C1 RID: 2497
	private AgentProperty _loopTypeProperty;

	// Token: 0x040009C2 RID: 2498
	private AgentProperty _easeProperty;

	// Token: 0x020003A2 RID: 930
	private enum LoopType
	{
		// Token: 0x04001CBA RID: 7354
		Once,
		// Token: 0x04001CBB RID: 7355
		Repeat,
		// Token: 0x04001CBC RID: 7356
		Yoyo
	}
}
