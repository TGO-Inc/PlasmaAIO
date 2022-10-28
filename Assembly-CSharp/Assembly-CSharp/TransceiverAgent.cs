using System;
using Behavior;

// Token: 0x020000E4 RID: 228
public class TransceiverAgent : Agent
{
	// Token: 0x060009BD RID: 2493 RVA: 0x00033F74 File Offset: 0x00032174
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00033FCC File Offset: 0x000321CC
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00034037 File Offset: 0x00032237
	[SketchNodePortOperation(1)]
	public void SendOnChannel1(SketchNode sketchNode)
	{

	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00034040 File Offset: 0x00032240
	[SketchNodePortOperation(2)]
	public void SendOnChannel2(SketchNode sketchNode)
	{

	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00034049 File Offset: 0x00032249
	[SketchNodePortOperation(3)]
	public void SendOnChannel3(SketchNode sketchNode)
	{

	}

	// Token: 0x040008EB RID: 2283
	private AgentProperty _receivedValue1Property;

	// Token: 0x040008EC RID: 2284
	private AgentProperty _receivedValue2Property;

	// Token: 0x040008ED RID: 2285
	private AgentProperty _receivedValue3Property;

	// Token: 0x040008EE RID: 2286
	private AgentProperty _hasReceivedValueProperty;

	// Token: 0x02000396 RID: 918
	public enum Commands
	{
		// Token: 0x04001C92 RID: 7314
		SendOnChannel1 = 1,
		// Token: 0x04001C93 RID: 7315
		SendOnChannel2,
		// Token: 0x04001C94 RID: 7316
		SendOnChannel3
	}
}
