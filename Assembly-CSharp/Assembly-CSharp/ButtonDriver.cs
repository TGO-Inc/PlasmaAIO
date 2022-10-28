using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

// Token: 0x0200005D RID: 93
public class ButtonDriver : ComponentDriver
{
	// Token: 0x0600059C RID: 1436 RVA: 0x000216C1 File Offset: 0x0001F8C1
	public override void Awake()
	{

	}

	// Token: 0x0600059D RID: 1437 RVA: 0x000216E4 File Offset: 0x0001F8E4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0002170A File Offset: 0x0001F90A
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00021712 File Offset: 0x0001F912
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0002171A File Offset: 0x0001F91A
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00021726 File Offset: 0x0001F926
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x060005A2 RID: 1442 RVA: 0x00021729 File Offset: 0x0001F929
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0002175F File Offset: 0x0001F95F
	public override void OnInteractionUp()
	{

	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00021795 File Offset: 0x0001F995
	public override void OnPlasmaInteraction()
	{

	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x000217B1 File Offset: 0x0001F9B1
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x000217C6 File Offset: 0x0001F9C6
	private IEnumerator SimulatePress()
	{

        return default;
    }

	// Token: 0x060005A7 RID: 1447 RVA: 0x000217D5 File Offset: 0x0001F9D5
	private void SetLEDStripColor()
	{

	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00021818 File Offset: 0x0001FA18
	private void UpdateVisuals()
	{

	}

	// Token: 0x040004E8 RID: 1256
	public StudioEventEmitter FMODEmitterOn;

	// Token: 0x040004E9 RID: 1257
	public StudioEventEmitter FMODEmitterOff;

	// Token: 0x040004EA RID: 1258
	public Animator animator;

	// Token: 0x040004EB RID: 1259
	public MeshRenderer meshRenderer;

	// Token: 0x040004EC RID: 1260
	private AgentProperty _isPressedProperty;

	// Token: 0x040004ED RID: 1261
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x040004EE RID: 1262
	private bool _isPressed;

	// Token: 0x040004EF RID: 1263
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040004F0 RID: 1264
	private Coroutine _coroutine;

	// Token: 0x040004F1 RID: 1265
	private int _colorId;

	// Token: 0x040004F2 RID: 1266
	private const string _FMODParamSize = "Size";
}
