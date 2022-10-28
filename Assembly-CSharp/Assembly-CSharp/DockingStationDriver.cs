using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using DG.Tweening.Timeline;
using FMODUnity;
using Rewired;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000073 RID: 115
public class DockingStationDriver : ComponentDriver
{
	// Token: 0x06000641 RID: 1601 RVA: 0x0002412C File Offset: 0x0002232C
	public override void Awake()
	{

	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000241FC File Offset: 0x000223FC
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00024210 File Offset: 0x00022410
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00024263 File Offset: 0x00022463
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00024284 File Offset: 0x00022484
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00024298 File Offset: 0x00022498
	public override void Preprocess()
	{

	}

	// Token: 0x06000647 RID: 1607 RVA: 0x000245F8 File Offset: 0x000227F8
	private static void ReplayTween(DOVisualSequence visualSequence)
	{

	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00024610 File Offset: 0x00022810
	public override void OnDock()
	{

	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00024728 File Offset: 0x00022928
	public override void OnUndock()
	{

	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00024780 File Offset: 0x00022980
	public override bool CanDock()
	{

        return default;
    }

	// Token: 0x0600064B RID: 1611 RVA: 0x00024788 File Offset: 0x00022988
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x0600064C RID: 1612 RVA: 0x000247A4 File Offset: 0x000229A4
	public override void OnSensorTriggerEnter(Collider trigger)
	{

	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00024818 File Offset: 0x00022A18
	public override void OnSensorTriggerExit(Collider trigger)
	{

	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00024883 File Offset: 0x00022A83
	public void AlignCollider()
	{

	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000248A0 File Offset: 0x00022AA0
	private void OnDestroy()
	{

	}

	// Token: 0x04000590 RID: 1424
	public StudioEventEmitter FMODEmitterUp;

	// Token: 0x04000591 RID: 1425
	public StudioEventEmitter FMODEmitterDown;

	// Token: 0x04000592 RID: 1426
	public MeshRenderer meshRenderer;

	// Token: 0x04000593 RID: 1427
	public GameObject insideObject;

	// Token: 0x04000594 RID: 1428
	public DOVisualSequence popInAnimation;

	// Token: 0x04000595 RID: 1429
	public DOVisualSequence popOutAnimation;

	// Token: 0x04000596 RID: 1430
	private bool _isPlayerClose;

	// Token: 0x04000597 RID: 1431
	private bool _isDocked;

	// Token: 0x04000598 RID: 1432
	private DockingStationAgent _agent;

	// Token: 0x04000599 RID: 1433
	private Player _input;

	// Token: 0x0400059A RID: 1434
	private Transform _movingPart;
}
}