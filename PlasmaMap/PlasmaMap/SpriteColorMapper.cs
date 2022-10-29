using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200000B RID: 11
public class SpriteColorMapper : UIColorMapper
{
	// Token: 0x06000059 RID: 89 RVA: 0x0000343B File Offset: 0x0000163B
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x04000046 RID: 70
	[ColorEntity]
	public int normalColor;
}
}