using System;
using System.Collections.Generic;
using System.Linq;
using TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000012 RID: 18
public class UIBetterToggleColorMapper : UIColorMapper
{
	// Token: 0x06000067 RID: 103 RVA: 0x00003C44 File Offset: 0x00001E44
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x0400006C RID: 108
	[ColorEntity]
	public int normalColor;

	// Token: 0x0400006D RID: 109
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x0400006E RID: 110
	[ColorEntity]
	public int pressedColor;

	// Token: 0x0400006F RID: 111
	[ColorEntity]
	public int disabledColor;

	// Token: 0x04000070 RID: 112
	[ColorEntity]
	public int contentNormalColor;

	// Token: 0x04000071 RID: 113
	[ColorEntity]
	public int contentHighlightedColor;

	// Token: 0x04000072 RID: 114
	[ColorEntity]
	public int contentPressedColor;

	// Token: 0x04000073 RID: 115
	[ColorEntity]
	public int contentDisabledColor;

	// Token: 0x04000074 RID: 116
	[ColorEntity]
	public int borderNormalColor;

	// Token: 0x04000075 RID: 117
	[ColorEntity]
	public int borderHighlightedColor;

	// Token: 0x04000076 RID: 118
	[ColorEntity]
	public int borderPressedColor;

	// Token: 0x04000077 RID: 119
	[ColorEntity]
	public int borderDisabledColor;

	// Token: 0x04000078 RID: 120
	[ColorEntity]
	public int labelNormalColor;

	// Token: 0x04000079 RID: 121
	[ColorEntity]
	public int labelHighlightedColor;

	// Token: 0x0400007A RID: 122
	[ColorEntity]
	public int labelPressedColor;

	// Token: 0x0400007B RID: 123
	[ColorEntity]
	public int labelDisabledColor;

	// Token: 0x0400007C RID: 124
	[ColorEntity]
	public int unselectedColor;

	// Token: 0x0400007D RID: 125
	[ColorEntity]
	public int selectedColor;

	// Token: 0x0400007E RID: 126
	public bool extraBorder;
}
