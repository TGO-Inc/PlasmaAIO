using System;
using Behavior;

// Token: 0x0200013D RID: 317
public class VariableWriterAgent : Agent
{
	// Token: 0x06000BAA RID: 2986 RVA: 0x0003CD80 File Offset: 0x0003AF80
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
	[SketchNodePortOperation(1)]
	public void Write(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A66 RID: 2662
	private AgentProperty _variableProperty;

	// Token: 0x04000A67 RID: 2663
	private AgentProperty _valueProperty;
}
