using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200000B RID: 11
public class SpriteColorMapper : UIColorMapper
{
	// Token: 0x06000059 RID: 89 RVA: 0x0000343B File Offset: 0x0000163B
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x04000046 RID: 70
	[ColorEntity]
	public int normalColor;
}
}