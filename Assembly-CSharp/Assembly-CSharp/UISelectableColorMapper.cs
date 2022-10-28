using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200001D RID: 29
public class UISelectableColorMapper : UIColorMapper
{
	// Token: 0x06000086 RID: 134 RVA: 0x00004B0C File Offset: 0x00002D0C
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x040000AA RID: 170
	[ColorEntity]
	public int normalColor;

	// Token: 0x040000AB RID: 171
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x040000AC RID: 172
	[ColorEntity]
	public int pressedColor;

	// Token: 0x040000AD RID: 173
	[ColorEntity]
	public int disabledColor;
}
}