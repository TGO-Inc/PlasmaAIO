using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000E8 RID: 232
public class WindowCommonDriver : ComponentDriver
{
	// Token: 0x060009E3 RID: 2531 RVA: 0x000349F8 File Offset: 0x00032BF8
	public override void Awake()
	{

	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00034A4E File Offset: 0x00032C4E
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00034A67 File Offset: 0x00032C67
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00034A6F File Offset: 0x00032C6F
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00034A77 File Offset: 0x00032C77
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00034A88 File Offset: 0x00032C88
	private void UpdateVisuals()
	{

	}

	// Token: 0x04000909 RID: 2313
	public MeshRenderer meshRenderer;

	// Token: 0x0400090A RID: 2314
	protected int _glassOpacityPropertyId;

	// Token: 0x0400090B RID: 2315
	protected int _updateVisualsCommandId;

	// Token: 0x0400090C RID: 2316
	private AgentProperty _glassOpacityProperty;

	// Token: 0x0400090D RID: 2317
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400090E RID: 2318
	private int _colorId;

	// Token: 0x0400090F RID: 2319
	private Color _originalColor;
}
}