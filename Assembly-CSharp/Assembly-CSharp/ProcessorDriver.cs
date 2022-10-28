using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000BE RID: 190
public class ProcessorDriver : ComponentDriver
{
	// Token: 0x060008B8 RID: 2232 RVA: 0x000300E4 File Offset: 0x0002E2E4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x0003011C File Offset: 0x0002E31C
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00030130 File Offset: 0x0002E330
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00030139 File Offset: 0x0002E339
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00030146 File Offset: 0x0002E346
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x060008BD RID: 2237 RVA: 0x0003016D File Offset: 0x0002E36D
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00030176 File Offset: 0x0002E376
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060008BF RID: 2239 RVA: 0x000301AC File Offset: 0x0002E3AC
	private void UpdateVisuals(bool instant = false)
	{

	}

	// Token: 0x0400080C RID: 2060
	public Animator animator;

	// Token: 0x0400080D RID: 2061
	public Transform button;

	// Token: 0x0400080E RID: 2062
	public StudioEventEmitter FMODEmitter;

	// Token: 0x0400080F RID: 2063
	private bool _buttonPressed;

	// Token: 0x04000810 RID: 2064
	private AgentProperty _stateProperty;

	// Token: 0x04000811 RID: 2065
	private AgentProperty _internalStateProperty;

	// Token: 0x04000812 RID: 2066
	private ProcessorAgent _processorAgent;
}
}