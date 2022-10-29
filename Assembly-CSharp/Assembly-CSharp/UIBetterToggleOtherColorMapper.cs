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
// Token: 0x02000013 RID: 19
public class UIBetterToggleOtherColorMapper : UIColorMapper
{
	// Token: 0x06000069 RID: 105 RVA: 0x000040BC File Offset: 0x000022BC
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x0400007F RID: 127
	[ColorEntity]
	public int normalColor;

	// Token: 0x04000080 RID: 128
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x04000081 RID: 129
	[ColorEntity]
	public int pressedColor;

	// Token: 0x04000082 RID: 130
	[ColorEntity]
	public int disabledColor;

	// Token: 0x04000083 RID: 131
	[ColorEntity]
	public int contentNormalColor;

	// Token: 0x04000084 RID: 132
	[ColorEntity]
	public int contentHighlightedColor;

	// Token: 0x04000085 RID: 133
	[ColorEntity]
	public int contentPressedColor;

	// Token: 0x04000086 RID: 134
	[ColorEntity]
	public int contentDisabledColor;

	// Token: 0x04000087 RID: 135
	[ColorEntity]
	public int borderNormalColor;

	// Token: 0x04000088 RID: 136
	[ColorEntity]
	public int borderHighlightedColor;

	// Token: 0x04000089 RID: 137
	[ColorEntity]
	public int borderPressedColor;

	// Token: 0x0400008A RID: 138
	[ColorEntity]
	public int borderDisabledColor;

	// Token: 0x0400008B RID: 139
	[ColorEntity]
	public int symbolOnColor;

	// Token: 0x0400008C RID: 140
	[ColorEntity]
	public int symbolOffColor;

	// Token: 0x0400008D RID: 141
	[ColorEntity]
	public int labelOnColor;

	// Token: 0x0400008E RID: 142
	[ColorEntity]
	public int labelOffColor;
}
}