using System;
using UnityEngine;

// Token: 0x0200019A RID: 410
[ExecuteInEditMode]
public class PlasmaTerrainProjector : MonoBehaviour
{
	// Token: 0x06000F53 RID: 3923 RVA: 0x0004E68C File Offset: 0x0004C88C
	private void Start()
	{
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x0004E690 File Offset: 0x0004C890
	private void Update()
	{

	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x0004E78C File Offset: 0x0004C98C
	private void OnDrawGizmos()
	{

	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x0004E7E8 File Offset: 0x0004C9E8
	private void CalcTerrainSize()
	{

	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
	private void ProjectTerrain()
	{

	}

	// Token: 0x04000CD2 RID: 3282
	[Header("[PARAMETERS]_____________________________________________________________________")]
	public LayerMask layerMask;

	// Token: 0x04000CD3 RID: 3283
	public bool showDebugCubes;

	// Token: 0x04000CD4 RID: 3284
	public bool drawDebugRays;

	// Token: 0x04000CD5 RID: 3285
	[Space]
	[Header("[COMMANDS]_______________________________________________________________________")]
	public bool GO;

	// Token: 0x04000CD6 RID: 3286
	public bool RESET;

	// Token: 0x04000CD7 RID: 3287
	[Space]
	[Header("[DEBUG]__________________________________________________________________________")]
	public Terrain terrain;

	// Token: 0x04000CD8 RID: 3288
	private Bounds terrainBounds;

	// Token: 0x04000CD9 RID: 3289
	private GameObject debugCubes;

	// Token: 0x04000CDA RID: 3290
	private float terrainTop;

	// Token: 0x04000CDB RID: 3291
	private float terrainBottom;

	// Token: 0x04000CDC RID: 3292
	private Vector3 terrainSize;

	// Token: 0x04000CDD RID: 3293
	private Vector3 terrainPos;

	// Token: 0x04000CDE RID: 3294
	private Vector3 terrainCenter;
}
