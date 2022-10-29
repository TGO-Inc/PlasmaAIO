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
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x020001BC RID: 444
public class TextureBlitter2 : MonoBehaviour
{
	// Token: 0x0600102B RID: 4139 RVA: 0x00055B1C File Offset: 0x00053D1C
	private void Start()
	{

	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00055B9D File Offset: 0x00053D9D
	private void Update()
	{

	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00055BB0 File Offset: 0x00053DB0
	[ContextMenu("Bake scale options to current mesh (temporary)")]
	public void Blit(int x)
	{

	}

	// Token: 0x04000E33 RID: 3635
	[Header("[REFERENCES]")]
	public Texture2D sourceTexture;

	// Token: 0x04000E34 RID: 3636
	public Texture2D destTexture;

	// Token: 0x04000E35 RID: 3637
	public Material material;

	// Token: 0x04000E36 RID: 3638
	public Camera cameraman;

	// Token: 0x04000E37 RID: 3639
	public RawImage rawDest;

	// Token: 0x04000E38 RID: 3640
	public RawImage rawSource;

	// Token: 0x04000E39 RID: 3641
	public RawImage rawTemp;

	// Token: 0x04000E3A RID: 3642
	[Header("[PARAMETERS]")]
	public Vector4 pixSourceXYWH;

	// Token: 0x04000E3B RID: 3643
	public Vector4 pixDestXYWH;

	// Token: 0x04000E3C RID: 3644
	[Header("[DEBUG]")]
	public bool GO;

	// Token: 0x04000E3D RID: 3645
	public Vector4 sourceXYWH;

	// Token: 0x04000E3E RID: 3646
	public Vector4 destXYWH;

	// Token: 0x04000E3F RID: 3647
	public Texture2D outputTex;

	// Token: 0x04000E40 RID: 3648
	public RenderTexture camRT;

	// Token: 0x04000E41 RID: 3649
	public RenderTexture temporaryRT;
}
}