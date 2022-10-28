using System;
using UnityEngine;

// Token: 0x0200014B RID: 331
public class DynamicGridProjector : MonoBehaviour
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00044A88 File Offset: 0x00042C88
	public float circleRadius
	{
		get
		{
			return base.transform.lossyScale.x * 0.5f;
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00044AA0 File Offset: 0x00042CA0
	public SubComponentHandler owner
	{
		get
		{
			return this._owner;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00044AA8 File Offset: 0x00042CA8
	// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00044AB0 File Offset: 0x00042CB0
	public float distance { get; set; }

	// Token: 0x06000D79 RID: 3449 RVA: 0x00044ABC File Offset: 0x00042CBC
	private void Awake()
	{

	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00044C10 File Offset: 0x00042E10
	public void DrawGrid()
	{

	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00045174 File Offset: 0x00043374
	public void CalculateAndStoreGridPosition(Vector3 hitPosition, Vector3 hitNormal)
	{

	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x000454D8 File Offset: 0x000436D8
	public bool FindPointOnMeshBasedOnLastHitPosition(out Vector3 position, out Quaternion rotation)
	{
        position = default;
        rotation = default;

        return default;
    }

	// Token: 0x06000D7D RID: 3453 RVA: 0x0004554C File Offset: 0x0004374C
	private Quaternion GetRotationForGridPoint()
	{

        return default;
    }

	// Token: 0x06000D7E RID: 3454 RVA: 0x000456A0 File Offset: 0x000438A0
	private static Quaternion RotationHelper(Vector3 meshNormal, Vector3 referenceVector, Vector3 a, Vector3 b, Transform targetTransform)
	{

        return default;
    }

	// Token: 0x06000D7F RID: 3455 RVA: 0x0004574C File Offset: 0x0004394C
	public void UpdateScale(Vector3 scale)
	{

	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00045806 File Offset: 0x00043A06
	private int ToNextNearest(int x)
	{

        return default;
    }

	// Token: 0x06000D81 RID: 3457 RVA: 0x0004583C File Offset: 0x00043A3C
	private int ToNearest(int x)
	{

        return default;
    }

	// Token: 0x04000AED RID: 2797
	public static float cellSize = 0.0625f;

	// Token: 0x04000AEE RID: 2798
	public DynamicGridProjector.Shape shape;

	// Token: 0x04000AEF RID: 2799
	public float cylinderSectionStepSize;

	// Token: 0x04000AF0 RID: 2800
	public float cylinderUnitDiameter;

	// Token: 0x04000AF1 RID: 2801
	public bool rotateOnScale;

	// Token: 0x04000AF2 RID: 2802
	private SubComponentHandler _owner;

	// Token: 0x04000AF3 RID: 2803
	private Material _gridMaterial;

	// Token: 0x04000AF4 RID: 2804
	private Material _cylinderGridMaterial;

	// Token: 0x04000AF5 RID: 2805
	private float _innerRadius;

	// Token: 0x04000AF6 RID: 2806
	private float _outerBorder;

	// Token: 0x04000AF7 RID: 2807
	private Vector3 _rectScale;

	// Token: 0x04000AF8 RID: 2808
	private Vector3 _lastHitPosition;

	// Token: 0x04000AF9 RID: 2809
	private Vector3 _lastHitNormal;

	// Token: 0x04000AFA RID: 2810
	private Vector3 _gridPosition;

	// Token: 0x020003AF RID: 943
	public enum Shape
	{
		// Token: 0x04001CFD RID: 7421
		Rectangle,
		// Token: 0x04001CFE RID: 7422
		Circle,
		// Token: 0x04001CFF RID: 7423
		Cylinder
	}
}
