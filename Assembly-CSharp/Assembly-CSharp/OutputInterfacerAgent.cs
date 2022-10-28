using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x02000118 RID: 280
public class OutputInterfacerAgent : Agent
{
	// Token: 0x06000AE8 RID: 2792 RVA: 0x00039523 File Offset: 0x00037723
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x0003955C File Offset: 0x0003775C
	public override void OnAgentInterfaceChanged(AgentId theAgentId)
	{

	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00039623 File Offset: 0x00037823
	[SketchNodePortOperation(1)]
	public void Send(SketchNode sketchNode)
	{

	}

	// Token: 0x040009C3 RID: 2499
	private AgentProperty _outputPropertyConfigured;

	// Token: 0x040009C4 RID: 2500
	private AgentProperty _outputPropertyRuntime;

	// Token: 0x040009C5 RID: 2501
	private AgentProperty _payloadProperty;
}
