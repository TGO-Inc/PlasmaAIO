using System;
using UnityEngine;

// Token: 0x02000195 RID: 405
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[DisallowMultipleComponent]
public abstract class TheMeshChainRenderer : MonoBehaviour
{
	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0004CBD1 File Offset: 0x0004ADD1
	// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0004CBDE File Offset: 0x0004ADDE
	public virtual Material material
	{
		get
		{
			return this.m_MeshRenderer.material;
		}
		set
		{
			this.m_MeshRenderer.material = value;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0004CBEC File Offset: 0x0004ADEC
	// (set) Token: 0x06000EEA RID: 3818 RVA: 0x0004CBF9 File Offset: 0x0004ADF9
	public virtual Material[] materials
	{
		get
		{
			return this.m_MeshRenderer.materials;
		}
		set
		{
			this.m_MeshRenderer.materials = value;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0004CC07 File Offset: 0x0004AE07
	// (set) Token: 0x06000EEC RID: 3820 RVA: 0x0004CC14 File Offset: 0x0004AE14
	public virtual Material sharedMaterial
	{
		get
		{
			return this.m_MeshRenderer.sharedMaterial;
		}
		set
		{
			this.m_MeshRenderer.sharedMaterial = value;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000EED RID: 3821 RVA: 0x0004CC22 File Offset: 0x0004AE22
	// (set) Token: 0x06000EEE RID: 3822 RVA: 0x0004CC2F File Offset: 0x0004AE2F
	public virtual Material[] SharedMaterials
	{
		get
		{
			return this.m_MeshRenderer.materials;
		}
		set
		{
			this.m_MeshRenderer.sharedMaterials = value;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0004CC3D File Offset: 0x0004AE3D
	// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x0004CC45 File Offset: 0x0004AE45
	public float widthMultiplier
	{
		get
		{
			return this.m_Width;
		}
		set
		{
			this.m_Width = value;
			this.UpdateWidth();
		}
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0004CC54 File Offset: 0x0004AE54
	public void SetTotalWidth(float newWidth)
	{

	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0004CC64 File Offset: 0x0004AE64
	public void SetTotalColor(Color newColor)
	{

	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0004CC8C File Offset: 0x0004AE8C
	public void SetupMeshBackend()
	{

	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0004CD36 File Offset: 0x0004AF36
	protected virtual void Awake()
	{

	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x0004CD45 File Offset: 0x0004AF45
	private void Reset()
	{

	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0004CD54 File Offset: 0x0004AF54
	protected virtual void LateUpdate()
	{

	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x0004CD70 File Offset: 0x0004AF70
	public static implicit operator Renderer(TheMeshChainRenderer meshChainRenderer)
	{

        return default;
    }

	// Token: 0x06000EF8 RID: 3832 RVA: 0x0004CD78 File Offset: 0x0004AF78
	protected virtual void UpdateColors()
	{
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x0004CD7A File Offset: 0x0004AF7A
	protected virtual void UpdateWidth()
	{
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x0004CD7C File Offset: 0x0004AF7C
	public virtual void Initialize(bool generate = true)
	{
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x0004CD7E File Offset: 0x0004AF7E
	protected virtual bool NeedsReinitialize()
	{

        return default;
    }

	// Token: 0x06000EFC RID: 3836 RVA: 0x0004CD81 File Offset: 0x0004AF81
	protected virtual void OnEnable()
	{

	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x0004CD8F File Offset: 0x0004AF8F
	protected virtual void OnDisable()
	{

	}

	// Token: 0x04000CAD RID: 3245
	public bool debug;

	// Token: 0x04000CAE RID: 3246
	public bool worldDataMode;

	// Token: 0x04000CAF RID: 3247
	public bool depthScaleMode;

	// Token: 0x04000CB0 RID: 3248
	public bool caps;

	// Token: 0x04000CB1 RID: 3249
	public bool segments;

	// Token: 0x04000CB2 RID: 3250
	[SerializeField]
	protected Material[] m_Materials;

	// Token: 0x04000CB3 RID: 3251
	public Color startColor;

	// Token: 0x04000CB4 RID: 3252
	[SerializeField]
	protected float m_Width = 1f;

	// Token: 0x04000CB5 RID: 3253
	[SerializeField]
	protected MeshRenderer m_MeshRenderer;

	// Token: 0x04000CB6 RID: 3254
	protected TheMeshChain m_XRMeshData;

	// Token: 0x04000CB7 RID: 3255
	protected bool m_MeshNeedsRefreshing;

	// Token: 0x04000CB8 RID: 3256
	protected float m_StepSize = 1f;
}
