using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x02000122 RID: 290
public class RangeTesterAgent : Agent
{
	// Token: 0x06000B12 RID: 2834 RVA: 0x0003A1E4 File Offset: 0x000383E4
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000B13 RID: 2835 RVA: 0x0003A240 File Offset: 0x00038440
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0003A278 File Offset: 0x00038478
	[SketchNodePortOperation(1)]
	public void Test(SketchNode sketchNode)
	{

	}

	// Token: 0x040009F0 RID: 2544
	private AgentProperty _valueProperty;

	// Token: 0x040009F1 RID: 2545
	private AgentProperty _lowerLimitProperty;

	// Token: 0x040009F2 RID: 2546
	private AgentProperty _upperLimitProperty;
}
