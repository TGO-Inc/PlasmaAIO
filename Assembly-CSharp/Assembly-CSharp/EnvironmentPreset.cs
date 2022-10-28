using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace PlasmaAPI.GameClass {
// Token: 0x0200016B RID: 363
[CreateAssetMenu(menuName = "Plasma/Environment Preset")]
[Serializable]
public class EnvironmentPreset : SerializedScriptableObject
{
	// Token: 0x04000B87 RID: 2951
	public float hour;

	// Token: 0x04000B88 RID: 2952
	public Color sunColor;

	// Token: 0x04000B89 RID: 2953
	[ColorUsage(true, true)]
	public Color sunEmissiveColor;

	// Token: 0x04000B8A RID: 2954
	public float sunIntensity;

	// Token: 0x04000B8B RID: 2955
	public float sunRingAngleX;

	// Token: 0x04000B8C RID: 2956
	public float sunRingAngleY;

	// Token: 0x04000B8D RID: 2957
	public float sunRingAngleZ;

	// Token: 0x04000B8E RID: 2958
	[Range(0f, 1f)]
	public float sunShadowsStrenght;

	// Token: 0x04000B8F RID: 2959
	public Color moonColor;

	// Token: 0x04000B90 RID: 2960
	[ColorUsage(true, true)]
	public Color moonEmissiveColor;

	// Token: 0x04000B91 RID: 2961
	public float moonIntensity;

	// Token: 0x04000B92 RID: 2962
	[Range(0f, 1f)]
	public float moonShadowsStrenght;

	// Token: 0x04000B93 RID: 2963
	public Color skyColor;

	// Token: 0x04000B94 RID: 2964
	public Color equatorColor;

	// Token: 0x04000B95 RID: 2965
	public Color groundColor;

	// Token: 0x04000B96 RID: 2966
	public Material skyboxMat;

	// Token: 0x04000B97 RID: 2967
	public float cloudsEmissionIntensity = 1f;

	// Token: 0x04000B98 RID: 2968
	public Color cloudsTopColor = Color.white;

	// Token: 0x04000B99 RID: 2969
	public Color cloudsBottomColor = new Color32(0, 138, 188, byte.MaxValue);

	// Token: 0x04000B9A RID: 2970
	public float cloudsTopBottomContrast = 1.2f;

	// Token: 0x04000B9B RID: 2971
	public float cloudsTopBottomTuning = -0.4f;

	// Token: 0x04000B9C RID: 2972
	public Color fogColor;

	// Token: 0x04000B9D RID: 2973
	public float fogStart;

	// Token: 0x04000B9E RID: 2974
	public float fogEnd;

	// Token: 0x04000B9F RID: 2975
	public PostProcessProfile ppProfile;
}
}