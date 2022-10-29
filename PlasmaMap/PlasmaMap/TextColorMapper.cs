using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;

namespace PlasmaAPI.GameClass {
// Token: 0x0200000D RID: 13
public class TextColorMapper : UIColorMapper
{
	// Token: 0x0600005D RID: 93 RVA: 0x00003496 File Offset: 0x00001696
	protected override void RefreshColors(Holder holder, int applyState = 0)
	{

	}

	// Token: 0x04000049 RID: 73
	[ColorEntity]
	public int normalColor;
}
}