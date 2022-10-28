using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000071 RID: 113
public class DistanceSensorDriver : ComponentDriver
{
	// Token: 0x06000631 RID: 1585 RVA: 0x00023B80 File Offset: 0x00021D80
	public override void Awake()
	{

	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00023C88 File Offset: 0x00021E88
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00023D01 File Offset: 0x00021F01
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00023D1A File Offset: 0x00021F1A
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00023D24 File Offset: 0x00021F24
	private bool Raycast(int layerMask, out float distance, float maxDistance)
	{
        distance = default;

        return default;
    }

	// Token: 0x06000636 RID: 1590 RVA: 0x00023DDD File Offset: 0x00021FDD
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00023DF8 File Offset: 0x00021FF8
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00023E70 File Offset: 0x00022070
	private void SetLaserDistance(float distance)
	{

	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00023EE8 File Offset: 0x000220E8
	private void UpdateVisuals()
	{

	}

	// Token: 0x0400057C RID: 1404
	public Transform apeTransform;

	// Token: 0x0400057D RID: 1405
	public LineRenderer lineRenderer;

	// Token: 0x0400057E RID: 1406
	public MeshRenderer meshRenderer;

	// Token: 0x0400057F RID: 1407
	private AgentProperty _detectedProperty;

	// Token: 0x04000580 RID: 1408
	private AgentProperty _distanceProperty;

	// Token: 0x04000581 RID: 1409
	private AgentProperty _maxDistanceProperty;

	// Token: 0x04000582 RID: 1410
	private AgentProperty _detectablesProperty;

	// Token: 0x04000583 RID: 1411
	private AgentProperty _laserProperty;

	// Token: 0x04000584 RID: 1412
	private AgentProperty _laserColorProperty;

	// Token: 0x04000585 RID: 1413
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000586 RID: 1414
	private Dictionary<int, int> _detectablesLayers;

	// Token: 0x04000587 RID: 1415
	private RaycastHit[] _hitResults;

	// Token: 0x04000588 RID: 1416
	private int _lineColorId;

	// Token: 0x04000589 RID: 1417
	private int _meshColorId;

	// Token: 0x0400058A RID: 1418
	private int _mainTexId;
}
