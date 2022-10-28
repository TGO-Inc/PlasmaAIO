using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000F4 RID: 244
public class ColorTweenerAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A18 RID: 2584 RVA: 0x000351FC File Offset: 0x000333FC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x000352D4 File Offset: 0x000334D4
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x00035300 File Offset: 0x00033500
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x000354AB File Offset: 0x000336AB
	[SketchNodePortOperation(1)]
	public void Start(SketchNode sketchNode)
	{

	}

	// Token: 0x04000934 RID: 2356
	private Data _colorData;

	// Token: 0x04000935 RID: 2357
	private Data _progressData;

	// Token: 0x04000936 RID: 2358
	private AgentProperty _elapsedTicksProperty;

	// Token: 0x04000937 RID: 2359
	private AgentProperty _runningProperty;

	// Token: 0x04000938 RID: 2360
	private AgentProperty _backwardProperty;

	// Token: 0x04000939 RID: 2361
	private AgentProperty _durationProperty;

	// Token: 0x0400093A RID: 2362
	private AgentProperty _fromProperty;

	// Token: 0x0400093B RID: 2363
	private AgentProperty _toProperty;

	// Token: 0x0400093C RID: 2364
	private AgentProperty _loopTypeProperty;

	// Token: 0x0400093D RID: 2365
	private AgentProperty _easeProperty;

	// Token: 0x0200039A RID: 922
	private enum LoopType
	{
		// Token: 0x04001CA3 RID: 7331
		Once,
		// Token: 0x04001CA4 RID: 7332
		Repeat,
		// Token: 0x04001CA5 RID: 7333
		Yoyo
	}
}
}