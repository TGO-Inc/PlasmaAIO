using System;
using Behavior;

// Token: 0x020000F7 RID: 247
public class CounterAgent : Agent
{
	// Token: 0x06000A28 RID: 2600 RVA: 0x00035876 File Offset: 0x00033A76
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x0003589C File Offset: 0x00033A9C
	[SketchNodePortOperation(1)]
	public void Step(SketchNode sketchNode)
	{

	}

	// Token: 0x04000942 RID: 2370
	private AgentProperty _valueProperty;

	// Token: 0x04000943 RID: 2371
	private AgentProperty _incrementProperty;
}
