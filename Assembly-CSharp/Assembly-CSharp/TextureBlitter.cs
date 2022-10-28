using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001BB RID: 443
public class TextureBlitter : MonoBehaviour
{
	// Token: 0x06001028 RID: 4136 RVA: 0x000558B0 File Offset: 0x00053AB0
	private void Start()
	{

	}

	// Token: 0x06001029 RID: 4137 RVA: 0x0005594C File Offset: 0x00053B4C
	private void Update()
	{

	}

	// Token: 0x04000E26 RID: 3622
	[Header("[REFERENCES]")]
	public Texture2D sourceTexture;

	// Token: 0x04000E27 RID: 3623
	public Texture2D destTexture;

	// Token: 0x04000E28 RID: 3624
	public Material material;

	// Token: 0x04000E29 RID: 3625
	public RawImage sourceRawImage;

	// Token: 0x04000E2A RID: 3626
	public RawImage destRawImage;

	// Token: 0x04000E2B RID: 3627
	[Header("[PARAMETERS]")]
	public Vector4 sourceXYWH;

	// Token: 0x04000E2C RID: 3628
	public Vector4 destXYWH;

	// Token: 0x04000E2D RID: 3629
	[Header("[DEBUG]")]
	public Texture2D outputTexture;

	// Token: 0x04000E2E RID: 3630
	public Vector4 xywhPixels;

	// Token: 0x04000E2F RID: 3631
	public Texture2D slicedTex;

	// Token: 0x04000E30 RID: 3632
	public Texture2D sourceRegionTexture;

	// Token: 0x04000E31 RID: 3633
	public RenderTexture temporary;

	// Token: 0x04000E32 RID: 3634
	public Vector4 coords;
}
