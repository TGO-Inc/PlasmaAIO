using System;
using UnityEngine;

// Token: 0x0200014C RID: 332
public class FemaleSocketPoint : MonoBehaviour
{
	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00045874 File Offset: 0x00043A74
	public SubComponentHandler owner
	{
		get
		{
			return this._owner;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0004587C File Offset: 0x00043A7C
	// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00045884 File Offset: 0x00043A84
	public SubComponentHandler parent { get; private set; }

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0004588D File Offset: 0x00043A8D
	// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00045895 File Offset: 0x00043A95
	public SubComponentHandler child { get; private set; }

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0004589E File Offset: 0x00043A9E
	public bool isBusy
	{
		get
		{
			return this.parent != null || this.child != null;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000458BC File Offset: 0x00043ABC
	// (set) Token: 0x06000D8B RID: 3467 RVA: 0x000458C4 File Offset: 0x00043AC4
	public bool isCustom
	{
		get
		{
			return this._isCustom;
		}
		set
		{
			this._isCustom = value;
			if (value)
			{
				this.meshGameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
			}
		}
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x000458F0 File Offset: 0x00043AF0
	public void Setup()
	{

	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00045954 File Offset: 0x00043B54
	private void OnEnable()
	{

	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x000459C4 File Offset: 0x00043BC4
	public void SetSubComponentParent(SubComponentHandler p)
	{

	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00045A17 File Offset: 0x00043C17
	public void SetSubComponentChild(SubComponentHandler p)
	{

	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00045A20 File Offset: 0x00043C20
	public void OnScale()
	{

	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00045B08 File Offset: 0x00043D08
	public void MakeFloating()
	{

	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00045B3C File Offset: 0x00043D3C
	public void UpdateColor(bool highlighted)
	{

	}

	// Token: 0x04000AFC RID: 2812
	public GameObject meshGameObject;

	// Token: 0x04000AFD RID: 2813
	public SnappingGeneric.ChildOrientationPreference orientationPreference;

	// Token: 0x04000AFE RID: 2814
	public int index;

	// Token: 0x04000AFF RID: 2815
	public SnappingGeneric matchingSnappingObject;

	// Token: 0x04000B00 RID: 2816
	public bool repositionOnScale;

	// Token: 0x04000B01 RID: 2817
	public float repositionCenter;

	// Token: 0x04000B02 RID: 2818
	public float repositionEdge;

	// Token: 0x04000B03 RID: 2819
	private Vector3 _startingLocalPosition;

	// Token: 0x04000B04 RID: 2820
	private SubComponentHandler _owner;

	// Token: 0x04000B05 RID: 2821
	private bool _isCustom;
}
