using System;
using System.Collections.Generic;
using System.Linq;
using TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000010 RID: 16
public class UIBetterSelectableColorMapper : UIColorMapper
{
	// Token: 0x06000063 RID: 99 RVA: 0x00003960 File Offset: 0x00001B60
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x0400005C RID: 92
	[ColorEntity]
	public int normalColor;

	// Token: 0x0400005D RID: 93
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x0400005E RID: 94
	[ColorEntity]
	public int pressedColor;

	// Token: 0x0400005F RID: 95
	[ColorEntity]
	public int disabledColor;

	// Token: 0x04000060 RID: 96
	[ColorEntity]
	public int contentNormalColor;

	// Token: 0x04000061 RID: 97
	[ColorEntity]
	public int contentHighlightedColor;

	// Token: 0x04000062 RID: 98
	[ColorEntity]
	public int contentPressedColor;

	// Token: 0x04000063 RID: 99
	[ColorEntity]
	public int contentDisabledColor;
}
