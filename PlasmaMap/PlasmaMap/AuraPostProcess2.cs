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
// Token: 0x020001A7 RID: 423
[ExecuteInEditMode]
public class AuraPostProcess2 : MonoBehaviour
{
	// Token: 0x06000FD7 RID: 4055 RVA: 0x0005323C File Offset: 0x0005143C
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{

	}

	// Token: 0x04000D58 RID: 3416
	[Range(1f, 16f)]
	public int pollo = 1;

	// Token: 0x04000D59 RID: 3417
	public int iterations = 1;

	// Token: 0x04000D5A RID: 3418
	private RenderTexture[] textures = new RenderTexture[16];

	// Token: 0x04000D5B RID: 3419
	[Header("[DEBUG]")]
	public int w;

	// Token: 0x04000D5C RID: 3420
	[Header("[DEBUG]")]
	public int h;

	// Token: 0x04000D5D RID: 3421
	[SerializeField]
	private Material postprocessMaterial;
}
}