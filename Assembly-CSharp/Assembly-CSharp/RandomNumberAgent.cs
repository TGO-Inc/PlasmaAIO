using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000120 RID: 288
public class RandomNumberAgent : Agent
{
	// Token: 0x06000B0A RID: 2826 RVA: 0x00039F46 File Offset: 0x00038146
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00039F80 File Offset: 0x00038180
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000B0C RID: 2828 RVA: 0x00039FDC File Offset: 0x000381DC
	[AgentPropertyHandler(1)]
	public void HandleIntegersOnly(AgentProperty property)
	{

	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0003A010 File Offset: 0x00038210
	[SketchNodePortOperation(1)]
	public void Generate(SketchNode sketchNode)
	{

	}

	// Token: 0x040009E5 RID: 2533
	private AgentProperty _minProperty;

	// Token: 0x040009E6 RID: 2534
	private AgentProperty _maxProperty;

	// Token: 0x040009E7 RID: 2535
	private AgentProperty _integersOnlyProperty;
}
}