using System;
using Behavior;
using UnityEngine;

// Token: 0x0200010E RID: 270
public class MapperAgent : Agent
{
	// Token: 0x06000AA9 RID: 2729 RVA: 0x00038192 File Offset: 0x00036392
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x000381CB File Offset: 0x000363CB
	[AgentPropertyHandler(1)]
	public void HandleForwardPayload(AgentProperty property)
	{

	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x000381E0 File Offset: 0x000363E0
	[SketchNodePortOperation(1)]
	public void Map(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00038270 File Offset: 0x00036470
	private float ConvertToFloat(Data value)
	{

        return default;
    }

	// Token: 0x06000AAD RID: 2733 RVA: 0x000382D4 File Offset: 0x000364D4
	private bool Compare(Data v1, Data v2)
	{

        return default;
    }

	// Token: 0x040009A1 RID: 2465
	private AgentProperty _valueProperty;

	// Token: 0x040009A2 RID: 2466
	private AgentProperty _payloadProperty;

	// Token: 0x040009A3 RID: 2467
	private AgentProperty _forwardPayloadProperty;

	// Token: 0x040009A4 RID: 2468
	private const int _firstCase = 3;

	// Token: 0x040009A5 RID: 2469
	private const int _firstOutput = 1;
}
