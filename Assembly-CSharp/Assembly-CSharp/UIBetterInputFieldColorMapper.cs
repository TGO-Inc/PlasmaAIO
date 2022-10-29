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
using System.Linq;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200000F RID: 15
public class UIBetterInputFieldColorMapper : UIColorMapper
{
	// Token: 0x06000061 RID: 97 RVA: 0x00003640 File Offset: 0x00001840
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x04000052 RID: 82
	[ColorEntity]
	public int normalColor;

	// Token: 0x04000053 RID: 83
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x04000054 RID: 84
	[ColorEntity]
	public int pressedColor;

	// Token: 0x04000055 RID: 85
	[ColorEntity]
	public int disabledColor;

	// Token: 0x04000056 RID: 86
	[ColorEntity]
	public int borderNormalColor;

	// Token: 0x04000057 RID: 87
	[ColorEntity]
	public int borderHighlightedColor;

	// Token: 0x04000058 RID: 88
	[ColorEntity]
	public int borderPressedColor;

	// Token: 0x04000059 RID: 89
	[ColorEntity]
	public int borderDisabledColor;

	// Token: 0x0400005A RID: 90
	[ColorEntity]
	public int textColor;

	// Token: 0x0400005B RID: 91
	[ColorEntity]
	public int selectionColor;
}
}