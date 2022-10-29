using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using AK;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200010F RID: 271
public class MathExpressionAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000AAF RID: 2735 RVA: 0x00038338 File Offset: 0x00036538
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x000383B4 File Offset: 0x000365B4
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000AB1 RID: 2737 RVA: 0x000385C0 File Offset: 0x000367C0
	[SketchNodePortOperation(1)]
	public void Evaluate(SketchNode sketchNode)
	{

	}

	// Token: 0x040009A6 RID: 2470
	private ExpressionSolver _expressionSolver;

	// Token: 0x040009A7 RID: 2471
	private Expression _expression;
}
}