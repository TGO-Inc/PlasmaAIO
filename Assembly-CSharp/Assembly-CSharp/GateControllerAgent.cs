using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x02000103 RID: 259
public class GateControllerAgent : Agent
{
	// Token: 0x06000A64 RID: 2660 RVA: 0x00036758 File Offset: 0x00034958
	public override void OnSketchCompiling(Sketch sketch)
	{

	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x000367D0 File Offset: 0x000349D0
	[SketchNodePortOperation(1)]
	public void Apply(SketchNode sketchNode)
	{

	}

	// Token: 0x0400096C RID: 2412
	private List<Agent> _gates;
}
