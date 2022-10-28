using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200004D RID: 77
[Serializable]
public class MaterialTransitionerTransparentParameters
{
	// Token: 0x04000363 RID: 867
	public Texture2D scanlinesTex;

	// Token: 0x04000364 RID: 868
	public Texture2D randomTex;

	// Token: 0x04000365 RID: 869
	[ColorUsage(false, true)]
	public Color rim1Color;

	// Token: 0x04000366 RID: 870
	public float rim1Exponent;

	// Token: 0x04000367 RID: 871
	public float rim1MUL;

	// Token: 0x04000368 RID: 872
	[ColorUsage(false, true)]
	public Color rim2Color;

	// Token: 0x04000369 RID: 873
	public float rim2Exponent;

	// Token: 0x0400036A RID: 874
	public float rim2MUL;

	// Token: 0x0400036B RID: 875
	public Vector4 scanlinesParams1;

	// Token: 0x0400036C RID: 876
	public Vector4 scanlinesParams2;

	// Token: 0x0400036D RID: 877
	public Vector4 rndParams;

	// Token: 0x0400036E RID: 878
	public float alphaRimExponent;

	// Token: 0x0400036F RID: 879
	public float alphaRimMUL;

	// Token: 0x04000370 RID: 880
	public float alphaADD;

	// Token: 0x04000371 RID: 881
	public float emissionGlobalMUL;
}
}