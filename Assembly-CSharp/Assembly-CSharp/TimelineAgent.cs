using System;
using Behavior;

// Token: 0x02000132 RID: 306
public class TimelineAgent : Agent
{
	// Token: 0x06000B76 RID: 2934 RVA: 0x0003B9DC File Offset: 0x00039BDC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x0003BA43 File Offset: 0x00039C43
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x0003BA80 File Offset: 0x00039C80
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x0003BB7D File Offset: 0x00039D7D
	[SketchNodePortOperation(1)]
	public void Start(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A26 RID: 2598
	private AgentProperty _nextIntervalProperty;

	// Token: 0x04000A27 RID: 2599
	private AgentProperty _doneProperty;

	// Token: 0x04000A28 RID: 2600
	private AgentProperty _loopProperty;

	// Token: 0x04000A29 RID: 2601
	private AgentProperty _elapsedTicksProperty;

	// Token: 0x04000A2A RID: 2602
	private AgentProperty _runningProperty;
}
