using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Behavior;
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x02000140 RID: 320
public class VectorMathAgent : Agent
{
	// Token: 0x06000BB5 RID: 2997 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x0003D0EC File Offset: 0x0003B2EC
	[SketchNodePortOperation(1)]
	public void Add(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x0003D1A8 File Offset: 0x0003B3A8
	[SketchNodePortOperation(2)]
	public void Subtract(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x0003D264 File Offset: 0x0003B464
	[SketchNodePortOperation(3)]
	public void Multiply(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x0003D300 File Offset: 0x0003B500
	[SketchNodePortOperation(4)]
	public void Divide(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x0003D39C File Offset: 0x0003B59C
	private List<float> GetComponents(string vector, SketchNode sketchNode)
	{

        return default;
    }

	// Token: 0x04000A6F RID: 2671
	private AgentProperty _v1Property;

	// Token: 0x04000A70 RID: 2672
	private AgentProperty _v2Property;

	// Token: 0x04000A71 RID: 2673
	private AgentProperty _scalarProperty;
}
}