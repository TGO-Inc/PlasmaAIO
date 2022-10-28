using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000124 RID: 292
public class RepeaterAgent : Agent
{
	// Token: 0x06000B19 RID: 2841 RVA: 0x0003A31B File Offset: 0x0003851B
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0003A32F File Offset: 0x0003852F
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0003A340 File Offset: 0x00038540
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0003A395 File Offset: 0x00038595
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x06000B1D RID: 2845 RVA: 0x0003A39D File Offset: 0x0003859D
	[SketchNodePortOperation(1)]
	public void Start(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0003A3BA File Offset: 0x000385BA
	[SketchNodePortOperation(2)]
	public void Stop(SketchNode sketchNode)
	{

	}

	// Token: 0x040009F4 RID: 2548
	private int _counter;

	// Token: 0x040009F5 RID: 2549
	private bool _shouldRun;

	// Token: 0x040009F6 RID: 2550
	private AgentProperty _repetitionsProperty;
}
}