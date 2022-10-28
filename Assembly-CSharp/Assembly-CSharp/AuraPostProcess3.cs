using System;
using UnityEngine;

// Token: 0x020001A8 RID: 424
public class AuraPostProcess3 : MonoBehaviour
{
	// Token: 0x06000FD9 RID: 4057 RVA: 0x000532C6 File Offset: 0x000514C6
	private void Start()
	{

	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x000532E0 File Offset: 0x000514E0
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{

	}

	// Token: 0x04000D5E RID: 3422
	private const int BoxDownPrefilterPass = 0;

	// Token: 0x04000D5F RID: 3423
	private const int BoxDownPass = 1;

	// Token: 0x04000D60 RID: 3424
	private const int BoxUpPass = 2;

	// Token: 0x04000D61 RID: 3425
	private const int ApplyBloomPass = 3;

	// Token: 0x04000D62 RID: 3426
	private const int DebugBloomPass = 4;

	// Token: 0x04000D63 RID: 3427
	[Header("[REFERENCES]")]
	public Material bloom;

	// Token: 0x04000D64 RID: 3428
	public Material auraMat;

	// Token: 0x04000D65 RID: 3429
	[Header("[BLOOM PARAMETERS]")]
	[Range(1f, 16f)]
	public float auraBlurRadiusIterations;

	// Token: 0x04000D66 RID: 3430
	[Range(0f, 10f)]
	public float intensity = 1f;

	// Token: 0x04000D67 RID: 3431
	[Range(1f, 16f)]
	public int iterations = 4;

	// Token: 0x04000D68 RID: 3432
	[Range(0f, 10f)]
	public float threshold = 1f;

	// Token: 0x04000D69 RID: 3433
	[Range(0f, 1f)]
	public float softThreshold = 0.5f;

	// Token: 0x04000D6A RID: 3434
	[Header("[DEBUG]")]
	public RenderTexture[] textures = new RenderTexture[16];

	// Token: 0x04000D6B RID: 3435
	private Camera cam;
}
