using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000109 RID: 265
public class LogicOperatorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A83 RID: 2691 RVA: 0x00036E80 File Offset: 0x00035080
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00036EE8 File Offset: 0x000350E8
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000A85 RID: 2693 RVA: 0x00037098 File Offset: 0x00035298
	private float ConvertToFloat(Data value)
	{

        return default;
    }

	// Token: 0x06000A86 RID: 2694 RVA: 0x000370FC File Offset: 0x000352FC
	[SketchNodePortOperation(1)]
	public void Compare(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x00037184 File Offset: 0x00035384
	private bool Compare(Data first, Data second)
	{

        return default;
    }

	// Token: 0x04000984 RID: 2436
	private AgentProperty _v1Property;

	// Token: 0x04000985 RID: 2437
	private AgentProperty _v2Property;

	// Token: 0x04000986 RID: 2438
	private AgentProperty _v3Property;

	// Token: 0x04000987 RID: 2439
	private AgentProperty _v4Property;

	// Token: 0x04000988 RID: 2440
	private AgentProperty _operatorProperty;
}
}