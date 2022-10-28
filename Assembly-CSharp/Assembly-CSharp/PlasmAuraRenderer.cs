using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001B6 RID: 438
public class PlasmAuraRenderer : MonoBehaviour
{
	// Token: 0x06001016 RID: 4118 RVA: 0x00055620 File Offset: 0x00053820
	private void Start()
	{
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00055622 File Offset: 0x00053822
	private void Update()
	{

	}

	// Token: 0x04000E0E RID: 3598
	[Header("[PARAMS]")]
	public List<GameObject> plasmedObjects;

	// Token: 0x04000E0F RID: 3599
	public Material maskMat;

	// Token: 0x04000E10 RID: 3600
	public Material fillMat;

	// Token: 0x04000E11 RID: 3601
	[Header("[DEBUG]")]
	public List<MeshFilter> meshFilters;

	// Token: 0x04000E12 RID: 3602
	public List<MeshRenderer> meshRenderers;

	// Token: 0x04000E13 RID: 3603
	public List<Mesh> meshes;

	// Token: 0x04000E14 RID: 3604
	public List<Matrix4x4> matrices;

	// Token: 0x04000E15 RID: 3605
	public Camera myCam;

	// Token: 0x04000E16 RID: 3606
	public CommandBuffer m_GlowBuffer;
}
