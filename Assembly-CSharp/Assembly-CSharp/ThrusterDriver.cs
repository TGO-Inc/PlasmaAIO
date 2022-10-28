using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

// Token: 0x020000DF RID: 223
public class ThrusterDriver : ComponentDriver
{
	// Token: 0x060009A0 RID: 2464 RVA: 0x000337F0 File Offset: 0x000319F0
	public override void Awake()
	{

	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00033840 File Offset: 0x00031A40
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0003384D File Offset: 0x00031A4D
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0003385C File Offset: 0x00031A5C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x000338C1 File Offset: 0x00031AC1
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x000338F0 File Offset: 0x00031AF0
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00033963 File Offset: 0x00031B63
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00033984 File Offset: 0x00031B84
	private void SetForce()
	{

	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x000339D4 File Offset: 0x00031BD4
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00033A40 File Offset: 0x00031C40
	private void UpdateVisuals()
	{

	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00033B29 File Offset: 0x00031D29
	private IEnumerator DoEffect()
	{

        return default;
    }

	// Token: 0x060009AB RID: 2475 RVA: 0x00033B38 File Offset: 0x00031D38
	private void OnDestroy()
	{

	}

	// Token: 0x040008CE RID: 2254
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040008CF RID: 2255
	public MeshRenderer meshRenderer;

	// Token: 0x040008D0 RID: 2256
	public Light spotlight;

	// Token: 0x040008D1 RID: 2257
	public float maxForce;

	// Token: 0x040008D2 RID: 2258
	[ColorUsage(true, true)]
	public Color fullColor;

	// Token: 0x040008D3 RID: 2259
	[ColorUsage(true, true)]
	public Color idleColor;

	// Token: 0x040008D4 RID: 2260
	private PlasmaPhysicsConstraintConstantRelativeForce _constraint;

	// Token: 0x040008D5 RID: 2261
	private AgentProperty _stateProperty;

	// Token: 0x040008D6 RID: 2262
	private AgentProperty _forceProperty;

	// Token: 0x040008D7 RID: 2263
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040008D8 RID: 2264
	private int _colorId;

	// Token: 0x040008D9 RID: 2265
	private Coroutine _coroutine;

	// Token: 0x040008DA RID: 2266
	private const float _maxColorOffset = 0.07f;

	// Token: 0x040008DB RID: 2267
	private const string _FMODParamPower = "Power";

	// Token: 0x040008DC RID: 2268
	private const string _FMODParamSize = "Size";
}
