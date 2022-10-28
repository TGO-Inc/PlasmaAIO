using System;
using System.Collections.Generic;
using System.Linq;
using TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200000E RID: 14
public class UIBetterButtonColorMapper : UIColorMapper
{
	// Token: 0x0600005F RID: 95 RVA: 0x000034C8 File Offset: 0x000016C8
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x0400004A RID: 74
	[ColorEntity]
	public int normalColor;

	// Token: 0x0400004B RID: 75
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x0400004C RID: 76
	[ColorEntity]
	public int pressedColor;

	// Token: 0x0400004D RID: 77
	[ColorEntity]
	public int disabledColor;

	// Token: 0x0400004E RID: 78
	[ColorEntity]
	public int contentNormalColor;

	// Token: 0x0400004F RID: 79
	[ColorEntity]
	public int contentHighlightedColor;

	// Token: 0x04000050 RID: 80
	[ColorEntity]
	public int contentPressedColor;

	// Token: 0x04000051 RID: 81
	[ColorEntity]
	public int contentDisabledColor;
}
