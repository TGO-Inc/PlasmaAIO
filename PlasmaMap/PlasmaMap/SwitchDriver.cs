using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000DB RID: 219
public class SwitchDriver : ComponentDriver
{
	// Token: 0x0600098D RID: 2445 RVA: 0x000334CF File Offset: 0x000316CF
	public override void Awake()
	{

	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000334F2 File Offset: 0x000316F2
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00033518 File Offset: 0x00031718
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00033538 File Offset: 0x00031738
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00033558 File Offset: 0x00031758
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000992 RID: 2450 RVA: 0x0003358F File Offset: 0x0003178F
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000993 RID: 2451 RVA: 0x00033592 File Offset: 0x00031792
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x06000994 RID: 2452 RVA: 0x000335B0 File Offset: 0x000317B0
	public override void OnPlasmaInteraction()
	{

	}

	// Token: 0x06000995 RID: 2453 RVA: 0x000335CE File Offset: 0x000317CE
	private void PlaySound()
	{

	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00033602 File Offset: 0x00031802
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00033618 File Offset: 0x00031818
	private void UpdateVisuals(bool instant)
	{

	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0003367B File Offset: 0x0003187B
	private void SetLEDStripColor()
	{

	}

	// Token: 0x040008C4 RID: 2244
	public StudioEventEmitter FMODEmitterOn;

	// Token: 0x040008C5 RID: 2245
	public StudioEventEmitter FMODEmitterOff;

	// Token: 0x040008C6 RID: 2246
	public Animator animator;

	// Token: 0x040008C7 RID: 2247
	public MeshRenderer meshRenderer;

	// Token: 0x040008C8 RID: 2248
	private bool _currentValue;

	// Token: 0x040008C9 RID: 2249
	private AgentProperty _stateProperty;

	// Token: 0x040008CA RID: 2250
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x040008CB RID: 2251
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040008CC RID: 2252
	private int _colorId;

	// Token: 0x040008CD RID: 2253
	private const string _FMODParamSize = "Size";
}
}