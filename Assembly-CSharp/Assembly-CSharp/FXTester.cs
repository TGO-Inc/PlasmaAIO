using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001A1 RID: 417
public class FXTester : MonoBehaviour
{
	// Token: 0x06000FBC RID: 4028 RVA: 0x00052D69 File Offset: 0x00050F69
	private void Start()
	{
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x00052D6C File Offset: 0x00050F6C
	private void Update()
	{

	}

	// Token: 0x04000D31 RID: 3377
	[Header("[PARAMETERS]")]
	public GameObject gob;

	// Token: 0x04000D32 RID: 3378
	public AnimationCurve animCurve;

	// Token: 0x04000D33 RID: 3379
	public Color color;

	// Token: 0x04000D34 RID: 3380
	[Header("[COMMANDS]")]
	public bool GO;

	// Token: 0x04000D35 RID: 3381
	[Header("[DEBUG]")]
	public List<Material> materials;

	// Token: 0x04000D36 RID: 3382
	public bool running;

	// Token: 0x04000D37 RID: 3383
	public float sampleTime;
}
