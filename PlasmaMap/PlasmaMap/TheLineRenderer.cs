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
using UnityEngine.Serialization;

namespace PlasmaAPI.GameClass {
// Token: 0x02000192 RID: 402
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class TheLineRenderer : TheMeshChainRenderer
{
	// Token: 0x06000EB9 RID: 3769 RVA: 0x0004BBF0 File Offset: 0x00049DF0
	private void Update()
	{

	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0004BCA0 File Offset: 0x00049EA0
	// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0004BCA8 File Offset: 0x00049EA8
	public bool useWorldSpace
	{
		get
		{
			return this.m_UseWorldSpace;
		}
		set
		{
			this.m_UseWorldSpace = value;
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0004BCB1 File Offset: 0x00049EB1
	// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0004BCBE File Offset: 0x00049EBE
	public override Material material
	{
		get
		{
			return this.m_MeshRenderer.material;
		}
		set
		{
			this.m_MeshRenderer.material = value;
			this.CopyWorldSpaceDataFromMaterial();
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0004BCD2 File Offset: 0x00049ED2
	// (set) Token: 0x06000EBF RID: 3775 RVA: 0x0004BCDF File Offset: 0x00049EDF
	public override Material[] materials
	{
		get
		{
			return this.m_MeshRenderer.materials;
		}
		set
		{
			this.m_MeshRenderer.materials = value;
			this.CopyWorldSpaceDataFromMaterial();
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0004BCF3 File Offset: 0x00049EF3
	// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0004BD00 File Offset: 0x00049F00
	public override Material sharedMaterial
	{
		get
		{
			return this.m_MeshRenderer.sharedMaterial;
		}
		set
		{
			this.m_MeshRenderer.sharedMaterial = value;
			this.CopyWorldSpaceDataFromMaterial();
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0004BD14 File Offset: 0x00049F14
	// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x0004BD21 File Offset: 0x00049F21
	public override Material[] SharedMaterials
	{
		get
		{
			return this.m_MeshRenderer.materials;
		}
		set
		{
			this.m_MeshRenderer.sharedMaterials = value;
			this.CopyWorldSpaceDataFromMaterial();
		}
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x0004BD38 File Offset: 0x00049F38
	private void CopyWorldSpaceDataFromMaterial()
	{

	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x0004BD8E File Offset: 0x00049F8E
	public Vector3 GetPosition(int index)
	{

        return default;
    }

	// Token: 0x06000EC6 RID: 3782 RVA: 0x0004BD9C File Offset: 0x00049F9C
	public void SetPosition(int index, Vector3 position)
	{

	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x0004BDDB File Offset: 0x00049FDB
	public int GetPositions(Vector3[] positions)
	{

        return default;
    }

	// Token: 0x06000EC8 RID: 3784 RVA: 0x0004BDFC File Offset: 0x00049FFC
	public void SetPositions(Vector3[] newPositions, bool knownSizeChange = false)
	{

	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x0004BEBC File Offset: 0x0004A0BC
	public void AddSegment(Vector3 from, Vector3 to)
	{

	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x0004BF08 File Offset: 0x0004A108
	public void SetVertexCount(int count)
	{

	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x0004BF64 File Offset: 0x0004A164
	public int GetVertexCount()
	{

        return default;
    }

	// Token: 0x06000ECC RID: 3788 RVA: 0x0004BF70 File Offset: 0x0004A170
	public void SetColor(int id, Color col)
	{

	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x0004BFD4 File Offset: 0x0004A1D4
	public void SetColors(Color[] cols)
	{

	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0004C000 File Offset: 0x0004A200
	public void SetWidth(int id, float width)
	{

	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x0004C05C File Offset: 0x0004A25C
	protected override void UpdateWidth()
	{

	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
	public override void Initialize(bool setMesh = true)
	{

	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x0004C2CF File Offset: 0x0004A4CF
	private void SetKeyword(Material m, string keyword, bool state)
	{

	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x0004C2E4 File Offset: 0x0004A4E4
	protected override bool NeedsReinitialize()
	{

        return default;
    }

	// Token: 0x04000CA0 RID: 3232
	[SerializeField]
	[Tooltip("All of the connected points to render as a line.")]
	private Vector3[] m_Positions;

	// Token: 0x04000CA1 RID: 3233
	[SerializeField]
	[FormerlySerializedAs("m_WorldSpaceData")]
	[Tooltip("Draw lines in worldspace (or local space) - driven via shader.")]
	private bool m_UseWorldSpace;
}
}