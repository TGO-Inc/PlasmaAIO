using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200009B RID: 155
public class LampDriver : ComponentDriver
{
	// Token: 0x0600077C RID: 1916 RVA: 0x0002AA78 File Offset: 0x00028C78
	public override void Awake()
	{

	}

	// Token: 0x0600077D RID: 1917 RVA: 0x0002AACC File Offset: 0x00028CCC
	private void HandleQualitySettingsChanged()
	{

	}

	// Token: 0x0600077E RID: 1918 RVA: 0x0002AAE4 File Offset: 0x00028CE4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600077F RID: 1919 RVA: 0x0002AB39 File Offset: 0x00028D39
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000780 RID: 1920 RVA: 0x0002AB51 File Offset: 0x00028D51
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000781 RID: 1921 RVA: 0x0002AB69 File Offset: 0x00028D69
	private void CommonUpdate()
	{

	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0002AB90 File Offset: 0x00028D90
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000783 RID: 1923 RVA: 0x0002ABD0 File Offset: 0x00028DD0
	public override void OnScaleChanged()
	{

	}

	// Token: 0x06000784 RID: 1924 RVA: 0x0002ABD8 File Offset: 0x00028DD8
	private void SetColorAndIntensity()
	{

	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0002AC9C File Offset: 0x00028E9C
	private void SetRange()
	{

	}

	// Token: 0x06000786 RID: 1926 RVA: 0x0002ACB4 File Offset: 0x00028EB4
	private void OnDestroy()
	{

	}

	// Token: 0x040006E1 RID: 1761
	public MeshRenderer meshRenderer;

	// Token: 0x040006E2 RID: 1762
	public Light pointLight;

	// Token: 0x040006E3 RID: 1763
	private AgentProperty _stateProperty;

	// Token: 0x040006E4 RID: 1764
	private AgentProperty _intensityProperty;

	// Token: 0x040006E5 RID: 1765
	private AgentProperty _colorProperty;

	// Token: 0x040006E6 RID: 1766
	private AgentProperty _rangeProperty;

	// Token: 0x040006E7 RID: 1767
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040006E8 RID: 1768
	private int _colorId;
}
}