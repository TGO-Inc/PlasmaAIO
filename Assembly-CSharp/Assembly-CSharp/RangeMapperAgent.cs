using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000121 RID: 289
public class RangeMapperAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000B0F RID: 2831 RVA: 0x0003A094 File Offset: 0x00038294
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0003A128 File Offset: 0x00038328
	[SketchNodePortOperation(1)]
	public void Map(SketchNode sketchNode)
	{

	}

	// Token: 0x040009E8 RID: 2536
	private AgentProperty _valueProperty;

	// Token: 0x040009E9 RID: 2537
	private AgentProperty _min1Property;

	// Token: 0x040009EA RID: 2538
	private AgentProperty _max1Property;

	// Token: 0x040009EB RID: 2539
	private AgentProperty _min2Property;

	// Token: 0x040009EC RID: 2540
	private AgentProperty _max2Property;

	// Token: 0x040009ED RID: 2541
	private AgentProperty _easeProperty;

	// Token: 0x040009EE RID: 2542
	private FloatRange _firstRange;

	// Token: 0x040009EF RID: 2543
	private FloatRange _secondRange;
}
}