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
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000F6 RID: 246
public class ComparatorAgent : Agent
{
	// Token: 0x06000A24 RID: 2596 RVA: 0x00035660 File Offset: 0x00033860
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000A25 RID: 2597 RVA: 0x00035748 File Offset: 0x00033948
	private float ConvertToFloat(Data value)
	{

        return default;
    }

	// Token: 0x06000A26 RID: 2598 RVA: 0x000357AC File Offset: 0x000339AC
	[SketchNodePortOperation(1)]
	public void Compare(SketchNode sketchNode)
	{

	}
}
}