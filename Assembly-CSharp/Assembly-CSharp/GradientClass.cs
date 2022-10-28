using System;
using UnityEngine;

// Token: 0x020001B0 RID: 432
[Serializable]
public class GradientClass
{
	// Token: 0x04000DC5 RID: 3525
	[Header("[PARAMETERS]")]
	public string shaderParamName;

	// Token: 0x04000DC6 RID: 3526
	public bool vertical;

	// Token: 0x04000DC7 RID: 3527
	public Gradient gradient;

	// Token: 0x04000DC8 RID: 3528
	[HideInInspector]
	[Header("[DEBUG]")]
	public Texture2D texture;
}
