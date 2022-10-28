using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200004C RID: 76
[Serializable]
public class AuraParameterSet
{
	// Token: 0x0400034D RID: 845
	[Header("[AURA]______________________________________________")]
	public string presetName;

	// Token: 0x0400034E RID: 846
	public float auraSize;

	// Token: 0x0400034F RID: 847
	public float wobbleFrequency;

	// Token: 0x04000350 RID: 848
	public float wobbleAmplitude;

	// Token: 0x04000351 RID: 849
	public float wobbleSpeed;

	// Token: 0x04000352 RID: 850
	public float internalAuraSize;

	// Token: 0x04000353 RID: 851
	public float internalWobbleFrequency;

	// Token: 0x04000354 RID: 852
	public float internalWobbleAmplitude;

	// Token: 0x04000355 RID: 853
	public float internalWobbleSpeed;

	// Token: 0x04000356 RID: 854
	[Header("[TEXTURES]")]
	public PlasmaOverlayModeEnum overlayMode;

	// Token: 0x04000357 RID: 855
	[ColorUsage(true, true)]
	public Color color1;

	// Token: 0x04000358 RID: 856
	public Texture2D mainTexture;

	// Token: 0x04000359 RID: 857
	public float UV1SCALE;

	// Token: 0x0400035A RID: 858
	public Vector4 t1_SPX_SPY_CON_BRI;

	// Token: 0x0400035B RID: 859
	[ColorUsage(true, true)]
	public Color color2;

	// Token: 0x0400035C RID: 860
	public Texture2D secondaryTexture;

	// Token: 0x0400035D RID: 861
	public float UV2SCALE;

	// Token: 0x0400035E RID: 862
	public Vector4 t2_SPX_SPY_CON_BRI;

	// Token: 0x0400035F RID: 863
	[Header("[GLOBALS]")]
	public float colorClamp;

	// Token: 0x04000360 RID: 864
	public float alphaCon;

	// Token: 0x04000361 RID: 865
	public float alphaBri;

	// Token: 0x04000362 RID: 866
	public float colorMUL;
}
}