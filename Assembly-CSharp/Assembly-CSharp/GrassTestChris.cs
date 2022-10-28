using System;
using UnityEngine;

// Token: 0x020001A2 RID: 418
public class GrassTestChris : MonoBehaviour
{
	// Token: 0x06000FBF RID: 4031 RVA: 0x00052E81 File Offset: 0x00051081
	private void Start()
	{
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00052E84 File Offset: 0x00051084
	private void Update()
	{

	}

	// Token: 0x04000D38 RID: 3384
	[Header("[GRASS FORCE]")]
	public bool forceEnabled;

	// Token: 0x04000D39 RID: 3385
	public float radius;

	// Token: 0x04000D3A RID: 3386
	public float strength;

	// Token: 0x04000D3B RID: 3387
	public GrassFlowRenderer.GrassForce grassForce;

	// Token: 0x04000D3C RID: 3388
	[Header("[RIPPLE]")]
	public bool rippleEnabled;

	// Token: 0x04000D3D RID: 3389
	public float rStrength;

	// Token: 0x04000D3E RID: 3390
	public float rDecayRate;

	// Token: 0x04000D3F RID: 3391
	public float rSpeed;

	// Token: 0x04000D40 RID: 3392
	public float rStartRadius;

	// Token: 0x04000D41 RID: 3393
	public float rSharpness;
}
