using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000127 RID: 295
public class SequencerAgent : Agent
{
	// Token: 0x06000B26 RID: 2854 RVA: 0x0003A490 File Offset: 0x00038690
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0003A51F File Offset: 0x0003871F
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x0003A53D File Offset: 0x0003873D
	[AgentPropertyHandler(1)]
	public void HandleForwardPayload(AgentProperty property)
	{

	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0003A558 File Offset: 0x00038758
	[SketchNodePortOperation(1)]
	public void ActAndStep(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x0003A647 File Offset: 0x00038847
	[SketchNodePortOperation(2)]
	public void Reset(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0003A650 File Offset: 0x00038850
	private bool OutputInternal(SketchNode sketchNode, int index)
	{

        return default;
    }

	// Token: 0x040009FB RID: 2555
	private AgentProperty _nextPortProperty;

	// Token: 0x040009FC RID: 2556
	private AgentProperty _doneProperty;

	// Token: 0x040009FD RID: 2557
	private AgentProperty _payloadProperty;

	// Token: 0x040009FE RID: 2558
	private AgentProperty _forwardPayloadProperty;

	// Token: 0x040009FF RID: 2559
	private AgentProperty _loopProperty;

	// Token: 0x04000A00 RID: 2560
	private AgentProperty _firstStepThenOutputProperty;

	// Token: 0x04000A01 RID: 2561
	private AgentProperty _backwardProperty;
}
}