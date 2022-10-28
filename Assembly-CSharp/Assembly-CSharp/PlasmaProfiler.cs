using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

// Token: 0x020001A5 RID: 421
public class PlasmaProfiler : MonoBehaviour
{
	// Token: 0x06000FC6 RID: 4038 RVA: 0x00052F62 File Offset: 0x00051162
	private void Start()
	{
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00052F64 File Offset: 0x00051164
	private void Update()
	{

	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00052FC4 File Offset: 0x000511C4
	public void ToggleCliffs(Toggle m_toggle)
	{

	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00052FF8 File Offset: 0x000511F8
	public void ToggleTrees(Toggle m_toggle)
	{

	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0005302C File Offset: 0x0005122C
	public void ToggleRocks(Toggle m_toggle)
	{

	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x00053060 File Offset: 0x00051260
	public void TogglePlants(Toggle m_toggle)
	{

	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x00053094 File Offset: 0x00051294
	public void ToggleMoveable(Toggle m_toggle)
	{

	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x000530D7 File Offset: 0x000512D7
	public void TogglePPLayer(Toggle m_toggle)
	{

	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x000530EA File Offset: 0x000512EA
	public void ToggleGrass(Toggle m_toggle)
	{

	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x000530FD File Offset: 0x000512FD
	public void ToggleTerrain(Toggle m_toggle)
	{

	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00053110 File Offset: 0x00051310
	public void ToggleVFX(Toggle m_toggle)
	{

	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x0005313B File Offset: 0x0005133B
	public void ToggleShadows(Toggle m_toggle)
	{

	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00053152 File Offset: 0x00051352
	public void TogglePhysics(Toggle m_toggle)
	{

	}

	// Token: 0x04000D44 RID: 3396
	[Header("[PARAMETERS]")]
	public bool advanceTimeInPlay;

	// Token: 0x04000D45 RID: 3397
	public Transform placeCamHere;

	// Token: 0x04000D46 RID: 3398
	[Header("[REFERENCES]")]
	public GameObject replayCam;

	// Token: 0x04000D47 RID: 3399
	public Material componentMatTest;

	// Token: 0x04000D48 RID: 3400
	public RectTransform Content;

	// Token: 0x04000D49 RID: 3401
	[Space]
	public GameObject[] cliffs;

	// Token: 0x04000D4A RID: 3402
	public GameObject[] rocks;

	// Token: 0x04000D4B RID: 3403
	public GameObject[] trees;

	// Token: 0x04000D4C RID: 3404
	public GameObject[] plants;

	// Token: 0x04000D4D RID: 3405
	public GameObject[] moveable;

	// Token: 0x04000D4E RID: 3406
	public Terrain terrain;

	// Token: 0x04000D4F RID: 3407
	public PostProcessLayer ppLayer;

	// Token: 0x04000D50 RID: 3408
	public Camera cam;
}
