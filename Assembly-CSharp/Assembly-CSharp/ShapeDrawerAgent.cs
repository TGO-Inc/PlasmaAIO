using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000128 RID: 296
public class ShapeDrawerAgent : Agent
{
	// Token: 0x06000B2D RID: 2861 RVA: 0x0003A6A4 File Offset: 0x000388A4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x0003A730 File Offset: 0x00038930
	[SketchNodePortOperation(1)]
	public void DrawLine(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x0003A7AC File Offset: 0x000389AC
	[SketchNodePortOperation(2)]
	public void DrawRect(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x0003A828 File Offset: 0x00038A28
	[SketchNodePortOperation(3)]
	public void DrawCircle(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x0003A898 File Offset: 0x00038A98
	[SketchNodePortOperation(4)]
	public void FillRect(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0003A914 File Offset: 0x00038B14
	[SketchNodePortOperation(5)]
	public void FillCircle(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A02 RID: 2562
	private AgentProperty _x1Property;

	// Token: 0x04000A03 RID: 2563
	private AgentProperty _y1Property;

	// Token: 0x04000A04 RID: 2564
	private AgentProperty _x2Property;

	// Token: 0x04000A05 RID: 2565
	private AgentProperty _y2Property;

	// Token: 0x04000A06 RID: 2566
	private AgentProperty _radiusProperty;

	// Token: 0x04000A07 RID: 2567
	private AgentProperty _colorProperty;

	// Token: 0x04000A08 RID: 2568
	private AgentProperty _destinationProperty;
}
}