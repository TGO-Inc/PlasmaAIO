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
// Token: 0x0200001F RID: 31
public class UITextColorMapper : UIColorMapper
{
	// Token: 0x06000092 RID: 146 RVA: 0x00004E98 File Offset: 0x00003098
	protected override void RefreshColors(Holder holder, int applyState = 0)
	{

	}

	// Token: 0x040000B8 RID: 184
	[ColorEntity]
	public int normalColor;
}
}