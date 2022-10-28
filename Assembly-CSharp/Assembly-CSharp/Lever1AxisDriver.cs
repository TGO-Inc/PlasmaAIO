using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000A3 RID: 163
public class Lever1AxisDriver : ComponentDriver
{
	// Token: 0x060007CB RID: 1995 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
	public override void Awake()
	{

	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0002BECB File Offset: 0x0002A0CB
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060007CD RID: 1997 RVA: 0x0002BEF1 File Offset: 0x0002A0F1
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060007CE RID: 1998 RVA: 0x0002BF10 File Offset: 0x0002A110
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0002BF30 File Offset: 0x0002A130
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x0002BF66 File Offset: 0x0002A166
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x060007D1 RID: 2001 RVA: 0x0002BF69 File Offset: 0x0002A169
	public override void OnInteractionHold(Camera theCamera, Vector2 movement)
	{

	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0002BFA6 File Offset: 0x0002A1A6
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0002BFBB File Offset: 0x0002A1BB
	private void UpdateVisuals()
	{

	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
	private void SetLEDStripColor()
	{

	}

	// Token: 0x0400072E RID: 1838
	public MeshRenderer meshRenderer;

	// Token: 0x0400072F RID: 1839
	public GameObject rotatingGameObject;

	// Token: 0x04000730 RID: 1840
	public float stickMovementSpeed;

	// Token: 0x04000731 RID: 1841
	private AgentProperty _positionProperty;

	// Token: 0x04000732 RID: 1842
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x04000733 RID: 1843
	private float _currentValue;

	// Token: 0x04000734 RID: 1844
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000735 RID: 1845
	private int _colorId;

	// Token: 0x04000736 RID: 1846
	private const float _maxRotationRange = 25f;
}
}