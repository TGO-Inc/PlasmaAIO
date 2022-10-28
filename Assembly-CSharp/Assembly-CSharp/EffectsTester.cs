using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020001AC RID: 428
public class EffectsTester : MonoBehaviour
{
	// Token: 0x06000FE9 RID: 4073 RVA: 0x00053B07 File Offset: 0x00051D07
	private void Start()
	{
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00053B09 File Offset: 0x00051D09
	private void Update()
	{
	}

	// Token: 0x04000D89 RID: 3465
	[Header("[PARAMETERS]")]
	public Color outlineColor;

	// Token: 0x04000D8A RID: 3466
	[Header("[COMMANDS]")]
	public bool SolidToWireframe;

	// Token: 0x04000D8B RID: 3467
	public bool WireframeToSolid;

	// Token: 0x04000D8C RID: 3468
	public bool WireframeToGrabbedWireframe;

	// Token: 0x04000D8D RID: 3469
	public bool GrabbedWireframeToWireframe;

	// Token: 0x04000D8E RID: 3470
	public bool WireframeToHighlightedComponent;

	// Token: 0x04000D8F RID: 3471
	public bool HighlightedComponentToWireframe;

	// Token: 0x04000D90 RID: 3472
	public bool TransparentToWireframe;

	// Token: 0x04000D91 RID: 3473
	public bool SetTransparent;

	// Token: 0x04000D92 RID: 3474
	[Header("[REFERENCES]")]
	public Transform POD;

	// Token: 0x04000D93 RID: 3475
	public List<MeshRenderer> outlineObjects;

	// Token: 0x04000D94 RID: 3476
	public List<MeshRenderer> auraObjects;

	// Token: 0x04000D95 RID: 3477
	public List<string> auraPresets;

	// Token: 0x04000D96 RID: 3478
	public float outlineTime;

	// Token: 0x04000D97 RID: 3479
	public float auraTime;

	// Token: 0x04000D98 RID: 3480
	[Header("[DEBUG]")]
	public float outlineElapsed;

	// Token: 0x04000D99 RID: 3481
	public int currentOutlineObj;

	// Token: 0x04000D9A RID: 3482
	public float auraElapsed;

	// Token: 0x04000D9B RID: 3483
	public int currentAuraObj;

	// Token: 0x04000D9C RID: 3484
	public int currentAuraPreset;
}
}