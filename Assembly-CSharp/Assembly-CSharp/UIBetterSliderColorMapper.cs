using System;
using System.Collections.Generic;
using System.Linq;
using TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000011 RID: 17
public class UIBetterSliderColorMapper : UIColorMapper
{
	// Token: 0x06000065 RID: 101 RVA: 0x00003AD8 File Offset: 0x00001CD8
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x04000064 RID: 100
	[ColorEntity]
	public int normalColor;

	// Token: 0x04000065 RID: 101
	[ColorEntity]
	public int highlightedColor;

	// Token: 0x04000066 RID: 102
	[ColorEntity]
	public int pressedColor;

	// Token: 0x04000067 RID: 103
	[ColorEntity]
	public int disabledColor;

	// Token: 0x04000068 RID: 104
	[ColorEntity]
	public int handleNormalColor;

	// Token: 0x04000069 RID: 105
	[ColorEntity]
	public int handleHighlightedColor;

	// Token: 0x0400006A RID: 106
	[ColorEntity]
	public int handlePressedColor;

	// Token: 0x0400006B RID: 107
	[ColorEntity]
	public int handleDisabledColor;
}
