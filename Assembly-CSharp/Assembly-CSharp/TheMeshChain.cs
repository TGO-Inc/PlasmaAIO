using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000194 RID: 404
public class TheMeshChain
{
	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0004C3DE File Offset: 0x0004A5DE
	// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0004C3E6 File Offset: 0x0004A5E6
	public bool worldSpaceData
	{
		get
		{
			return this.m_WorldSpaceData;
		}
		set
		{
			this.m_WorldSpaceData = value;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0004C3EF File Offset: 0x0004A5EF
	// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x0004C3F7 File Offset: 0x0004A5F7
	public int reservedElements { get; private set; }

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0004C400 File Offset: 0x0004A600
	// (set) Token: 0x06000EDA RID: 3802 RVA: 0x0004C408 File Offset: 0x0004A608
	public bool centerAtRoot { get; set; }

	// Token: 0x06000EDB RID: 3803 RVA: 0x0004C411 File Offset: 0x0004A611
	public TheMeshChain()
	{

	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x0004C428 File Offset: 0x0004A628
	public void GenerateMesh(GameObject owner, bool dynamic, int totalElements, bool segments, bool setMesh = true)
	{

	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x0004C6C0 File Offset: 0x0004A8C0
	public void RefreshMesh()
	{

	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x0004C78B File Offset: 0x0004A98B
	public void SetMeshDataDirty(TheMeshChain.MeshRefreshFlag dataThatNeedsUpdate)
	{

	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x0004C79C File Offset: 0x0004A99C
	public void SetElementPosition(int elementIndex, ref Vector3 position)
	{

	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0004C84C File Offset: 0x0004AA4C
	public void SetElementPipe(int elementIndex, ref Vector3 startPoint, ref Vector3 endPoint)
	{

	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x0004C8FC File Offset: 0x0004AAFC
	public void SetElementSize(int elementIndex, float sizeModification)
	{

	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0004C988 File Offset: 0x0004AB88
	public void SetElementSize(int elementIndex, float startSize, float endSize)
	{

	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0004CA14 File Offset: 0x0004AC14
	public void SetElementColor(int elementIndex, ref Color color)
	{

	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x0004CA8C File Offset: 0x0004AC8C
	public void SetElementColor32(int elementIndex, ref Color32 color)
	{

	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x0004CAEC File Offset: 0x0004ACEC
	public void SetElementColor(int elementIndex, ref Color startColor, ref Color endColor)
	{

	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0004CB64 File Offset: 0x0004AD64
	public void SetElementColor32(int elementIndex, ref Color32 startColor, ref Color32 endColor)
	{

	}

	// Token: 0x04000CA3 RID: 3235
	private Vector3[] m_Verts;

	// Token: 0x04000CA4 RID: 3236
	private Color32[] m_Colors;

	// Token: 0x04000CA5 RID: 3237
	private List<Vector4> m_ShapeData;

	// Token: 0x04000CA6 RID: 3238
	private List<Vector3> m_NeighborPoints;

	// Token: 0x04000CA7 RID: 3239
	private TheMeshChain.MeshRefreshFlag m_DataThatNeedsUpdate = TheMeshChain.MeshRefreshFlag.All;

	// Token: 0x04000CA8 RID: 3240
	private Mesh m_Mesh;

	// Token: 0x04000CA9 RID: 3241
	private Transform m_OwnerTransform;

	// Token: 0x04000CAA RID: 3242
	private bool m_WorldSpaceData;

	// Token: 0x020003C9 RID: 969
	[Flags]
	public enum MeshRefreshFlag
	{
		// Token: 0x04001D68 RID: 7528
		None = 0,
		// Token: 0x04001D69 RID: 7529
		Positions = 1,
		// Token: 0x04001D6A RID: 7530
		Colors = 2,
		// Token: 0x04001D6B RID: 7531
		Sizes = 4,
		// Token: 0x04001D6C RID: 7532
		All = 7
	}
}
}