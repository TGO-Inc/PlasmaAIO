using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x0200011F RID: 287
public class PropertyReaderAgent : Agent
{
	// Token: 0x06000B07 RID: 2823 RVA: 0x00039E50 File Offset: 0x00038050
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000B08 RID: 2824 RVA: 0x00039ED4 File Offset: 0x000380D4
	[SketchNodePortOperation(1)]
	public void Read(SketchNode sketchNode)
	{

	}
}
