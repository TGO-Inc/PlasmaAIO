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
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200001A RID: 26
public class UIInputFieldColorMapper : UIColorMapper
{
	// Token: 0x0600007F RID: 127 RVA: 0x00004888 File Offset: 0x00002A88
	protected override void RefreshColors(Holder holder, int applyState = 0)
	{

	}

	// Token: 0x0400009A RID: 154
	[ColorEntity]
	public int normalColor;

	// Token: 0x0400009B RID: 155
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x0400009C RID: 156
	[ColorEntity]
	public int pressedColor;

	// Token: 0x0400009D RID: 157
	[ColorEntity]
	public int selectionColor;

	// Token: 0x0400009E RID: 158
	[ColorEntity]
	public int disabledColor;
}
}