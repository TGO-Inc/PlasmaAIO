using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020001B5 RID: 437
[Serializable]
public class TubeRayRenderer
{
	// Token: 0x06001014 RID: 4116 RVA: 0x0005537C File Offset: 0x0005357C
	public void SetShaderParameters(float currentAlpha)
	{

	}

	// Token: 0x04000DF2 RID: 3570
	public bool enabled;

	// Token: 0x04000DF3 RID: 3571
	public TubeRenderer tubeRenderer;

	// Token: 0x04000DF4 RID: 3572
	[Space(10f)]
	public float widthMultiplier;

	// Token: 0x04000DF5 RID: 3573
	public float sinMUL;

	// Token: 0x04000DF6 RID: 3574
	public float sinFreq;

	// Token: 0x04000DF7 RID: 3575
	public float sinSpeed;

	// Token: 0x04000DF8 RID: 3576
	public float sinOffset;

	// Token: 0x04000DF9 RID: 3577
	public float alphaBrightness;

	// Token: 0x04000DFA RID: 3578
	public float alphaContrast = 1f;

	// Token: 0x04000DFB RID: 3579
	public Texture2D noise1Texture;

	// Token: 0x04000DFC RID: 3580
	[ColorUsage(true, true)]
	public Color noise1Color = Color.black;

	// Token: 0x04000DFD RID: 3581
	public float noise1Brightness;

	// Token: 0x04000DFE RID: 3582
	public float noise1Contrast = 1f;

	// Token: 0x04000DFF RID: 3583
	public Vector2 noise1Tiling = new Vector2(1f, 1f);

	// Token: 0x04000E00 RID: 3584
	public Vector2 noise1Speed = new Vector2(0f, 0f);

	// Token: 0x04000E01 RID: 3585
	public Texture2D noise2Texture;

	// Token: 0x04000E02 RID: 3586
	[ColorUsage(true, true)]
	public Color noise2Color = Color.black;

	// Token: 0x04000E03 RID: 3587
	public float noise2Brightness;

	// Token: 0x04000E04 RID: 3588
	public float noise2Contrast = 1f;

	// Token: 0x04000E05 RID: 3589
	public Vector2 noise2Tiling = new Vector2(1f, 1f);

	// Token: 0x04000E06 RID: 3590
	public Vector2 noise2Speed = new Vector2(0f, 0f);

	// Token: 0x04000E07 RID: 3591
	public Texture2D displacementTexture;

	// Token: 0x04000E08 RID: 3592
	public float displacementMul;

	// Token: 0x04000E09 RID: 3593
	public Vector2 displacementFrequency = new Vector2(1f, 1f);

	// Token: 0x04000E0A RID: 3594
	public Vector2 displacementSpeed = new Vector2(0f, 0f);

	// Token: 0x04000E0B RID: 3595
	[HideInInspector]
	public float[] radiuses;

	// Token: 0x04000E0C RID: 3596
	[HideInInspector]
	public Vector3[] tubePoints;

	// Token: 0x04000E0D RID: 3597
	[HideInInspector]
	public Material material;
}
}