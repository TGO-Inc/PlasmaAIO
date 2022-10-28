using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200005F RID: 95
public class ButtonSimpleDriver : ComponentDriver
{
	// Token: 0x060005AF RID: 1455 RVA: 0x000218ED File Offset: 0x0001FAED
	public override void Awake()
	{

	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00021910 File Offset: 0x0001FB10
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00021924 File Offset: 0x0001FB24
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0002192C File Offset: 0x0001FB2C
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00021934 File Offset: 0x0001FB34
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x060005B4 RID: 1460 RVA: 0x00021937 File Offset: 0x0001FB37
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0002196D File Offset: 0x0001FB6D
	public override void OnInteractionUp()
	{

	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x000219A3 File Offset: 0x0001FBA3
	public override void OnPlasmaInteraction()
	{

	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x000219BF File Offset: 0x0001FBBF
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x000219D4 File Offset: 0x0001FBD4
	private IEnumerator SimulatePress()
	{

        return default;
    }

	// Token: 0x060005B9 RID: 1465 RVA: 0x000219E4 File Offset: 0x0001FBE4
	private void SetLEDStripColor()
	{

	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00021A3C File Offset: 0x0001FC3C
	private void UpdateVisuals()
	{

	}

	// Token: 0x040004F6 RID: 1270
	public StudioEventEmitter FMODEmitterOn;

	// Token: 0x040004F7 RID: 1271
	public StudioEventEmitter FMODEmitterOff;

	// Token: 0x040004F8 RID: 1272
	public Animator animator;

	// Token: 0x040004F9 RID: 1273
	public MeshRenderer meshRenderer;

	// Token: 0x040004FA RID: 1274
	private AgentProperty _isPressedProperty;

	// Token: 0x040004FB RID: 1275
	private bool _isPressed;

	// Token: 0x040004FC RID: 1276
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040004FD RID: 1277
	private Coroutine _coroutine;

	// Token: 0x040004FE RID: 1278
	private int _colorId;

	// Token: 0x040004FF RID: 1279
	private const string _FMODParamSize = "Size";
}
}