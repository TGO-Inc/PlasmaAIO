using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000085 RID: 133
public class GamepadInterfaceDriver : ComponentDriver
{
	// Token: 0x060006D0 RID: 1744 RVA: 0x00027128 File Offset: 0x00025328
	public override void Awake()
	{

	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00027178 File Offset: 0x00025378
	public static List<Rewired.Controller> GetAllGamepads()
	{

        return default;
    }

	// Token: 0x060006D2 RID: 1746 RVA: 0x000271D8 File Offset: 0x000253D8
	private void HandleControllerConnected(ControllerStatusChangedEventArgs args)
	{

	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00027207 File Offset: 0x00025407
	private void HandleControllerDisconnected(ControllerStatusChangedEventArgs args)
	{

	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00027238 File Offset: 0x00025438
	private void FetchController()
	{

	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00027284 File Offset: 0x00025484
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x000272E2 File Offset: 0x000254E2
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x000272F4 File Offset: 0x000254F4
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x000274B2 File Offset: 0x000256B2
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x000274C8 File Offset: 0x000256C8
	public override void Preprocess()
	{

	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00027B2C File Offset: 0x00025D2C
	private void SetLEDColor()
	{

	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00027C04 File Offset: 0x00025E04
	private IEnumerator Blink()
	{

        return default;
    }

	// Token: 0x060006DC RID: 1756 RVA: 0x00027C13 File Offset: 0x00025E13
	private void OnDestroy()
	{

	}

	// Token: 0x04000629 RID: 1577
	public MeshRenderer meshRenderer;

	// Token: 0x0400062A RID: 1578
	public float LEDOnDuration;

	// Token: 0x0400062B RID: 1579
	public float LEDOffDuration;

	// Token: 0x0400062C RID: 1580
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400062D RID: 1581
	private GamepadInterfaceAgent _agent;

	// Token: 0x0400062E RID: 1582
	private AgentProperty _gamepadProperty;

	// Token: 0x0400062F RID: 1583
	private AgentProperty _isConnectedProperty;

	// Token: 0x04000630 RID: 1584
	private IGamepadTemplate _gamepad;

	// Token: 0x04000631 RID: 1585
	private bool _wasConnected;

	// Token: 0x04000632 RID: 1586
	private bool _isConnected;

	// Token: 0x04000633 RID: 1587
	private IEnumerator _ledCoroutine;

	// Token: 0x04000634 RID: 1588
	private int _colorId;
}
}