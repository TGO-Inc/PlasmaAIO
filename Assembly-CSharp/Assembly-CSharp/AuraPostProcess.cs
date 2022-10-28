using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020001A6 RID: 422
public class AuraPostProcess : MonoBehaviour
{
	// Token: 0x06000FD4 RID: 4052 RVA: 0x0005316F File Offset: 0x0005136F
	private void Start()
	{

	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x0005318C File Offset: 0x0005138C
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{

	}

	// Token: 0x04000D51 RID: 3409
	[Header("REFERENCES")]
	public Material auraMat;

	// Token: 0x04000D52 RID: 3410
	public Material mixerMat;

	// Token: 0x04000D53 RID: 3411
	public Material spippolaMat;

	// Token: 0x04000D54 RID: 3412
	public int pollo = 1;

	// Token: 0x04000D55 RID: 3413
	[Header("[DEBUG]")]
	public int w;

	// Token: 0x04000D56 RID: 3414
	public int h;

	// Token: 0x04000D57 RID: 3415
	private Camera cam;
}
}