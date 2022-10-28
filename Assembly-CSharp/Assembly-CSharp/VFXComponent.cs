using System;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x02000196 RID: 406
public class VFXComponent : SerializedMonoBehaviour
{
	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0004CDBB File Offset: 0x0004AFBB
	// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0004CDC3 File Offset: 0x0004AFC3
	public ComponentHandler componentHandler { get; private set; }

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0004CDCC File Offset: 0x0004AFCC
	public IEnumerable<MeshRenderer> meshRenderers
	{
		get
		{
			return this._relevantMeshRenderers;
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
	public Bounds bounds
	{
		get
		{
			return this._bounds;
		}
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x0004CDDC File Offset: 0x0004AFDC
	private void Awake()
	{

	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
	public void SetSpherePosition(Vector3 worldPosition)
	{

	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0004CF6E File Offset: 0x0004B16E
	public void SetWireframeColorColliding(bool colliding)
	{

	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0004CF7D File Offset: 0x0004B17D
	public void SetWireframeColorGrabbing(bool grabbing)
	{

	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0004CF8C File Offset: 0x0004B18C
	private void SetWireframeColor()
	{

	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x0004D038 File Offset: 0x0004B238
	public void SetTransitionParameters(Vector3 worldPosition, float radius, bool updateSpecialMaterials)
	{

	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x0004D138 File Offset: 0x0004B338
	public void UpdateTransition(Vector3 worldPosition, float radius)
	{

	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x0004D1D8 File Offset: 0x0004B3D8
	public void CompleteTransition()
	{

	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x0004D244 File Offset: 0x0004B444
	public void SetTransparent(bool value)
	{

	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x0004D39C File Offset: 0x0004B59C
	public void RunFeedbackFX()
	{

	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x0004D47C File Offset: 0x0004B67C
	private void FeedbackTween(float val)
	{

	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x0004D4F5 File Offset: 0x0004B6F5
	private void OnDrawGizmosSelected()
	{

	}

	// Token: 0x04000CB9 RID: 3257
	public Dictionary<MeshRenderer, VFXComponent.SpecialMaterial> specialMaterials;

	// Token: 0x04000CBA RID: 3258
	private List<MeshRenderer> _relevantMeshRenderers;

	// Token: 0x04000CBB RID: 3259
	private List<MaterialPropertyBlock> _relevantPropertyBlocks;

	// Token: 0x04000CBC RID: 3260
	private Bounds _bounds;

	// Token: 0x04000CBD RID: 3261
	private bool _isTransparent;

	// Token: 0x04000CBE RID: 3262
	private bool _isColliding;

	// Token: 0x04000CBF RID: 3263
	private bool _isGrabbing;

	// Token: 0x04000CC0 RID: 3264
	private Vector4 packPlane;

	// Token: 0x020003CA RID: 970
	// (Invoke) Token: 0x060020F9 RID: 8441
	public delegate void Callback();

	// Token: 0x020003CB RID: 971
	public class SpecialMaterial
	{
		// Token: 0x04001D6D RID: 7533
		public Material wireframeSolid;

		// Token: 0x04001D6E RID: 7534
		public Material transparent;
	}
}
