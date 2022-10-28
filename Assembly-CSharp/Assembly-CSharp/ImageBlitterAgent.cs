using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000105 RID: 261
public class ImageBlitterAgent : Agent
{
	// Token: 0x06000A6E RID: 2670 RVA: 0x0003696C File Offset: 0x00034B6C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00036A44 File Offset: 0x00034C44
	[SketchNodePortOperation(1)]
	public void Blit(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00036AFC File Offset: 0x00034CFC
	[SketchNodePortOperation(2)]
	public void Clear(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00036B64 File Offset: 0x00034D64
	[SketchNodePortOperation(3)]
	public void ClearWithColor(SketchNode sketchNode)
	{

	}

	// Token: 0x04000970 RID: 2416
	private AgentProperty _sourceProperty;

	// Token: 0x04000971 RID: 2417
	private AgentProperty _sourceXProperty;

	// Token: 0x04000972 RID: 2418
	private AgentProperty _sourceYProperty;

	// Token: 0x04000973 RID: 2419
	private AgentProperty _sourceWidthProperty;

	// Token: 0x04000974 RID: 2420
	private AgentProperty _sourceHeightProperty;

	// Token: 0x04000975 RID: 2421
	private AgentProperty _destinationXProperty;

	// Token: 0x04000976 RID: 2422
	private AgentProperty _destinationYProperty;

	// Token: 0x04000977 RID: 2423
	private AgentProperty _destinationWidthProperty;

	// Token: 0x04000978 RID: 2424
	private AgentProperty _destinationHeightProperty;

	// Token: 0x04000979 RID: 2425
	private AgentProperty _destinationColorProperty;

	// Token: 0x0400097A RID: 2426
	private AgentProperty _destinationProperty;
}
}