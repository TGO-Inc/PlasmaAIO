using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200001C RID: 28
public class UIScrollBarColorMapper : UIColorMapper
{
	// Token: 0x06000084 RID: 132 RVA: 0x00004A50 File Offset: 0x00002C50
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x040000A5 RID: 165
	[ColorEntity]
	public int normalColor;

	// Token: 0x040000A6 RID: 166
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x040000A7 RID: 167
	[ColorEntity]
	public int pressedColor;

	// Token: 0x040000A8 RID: 168
	[ColorEntity]
	public int selectedColor;

	// Token: 0x040000A9 RID: 169
	[ColorEntity]
	public int disabledColor;
}
}