using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200009E RID: 158
public class LCDAgent : Agent, IDataSelectionProvider
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0002B567 File Offset: 0x00029767
	// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0002B56F File Offset: 0x0002976F
	public RenderTexture renderTexture { get; private set; }

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002B578 File Offset: 0x00029778
	// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0002B580 File Offset: 0x00029780
	public int renderTextureIndex { get; private set; }

	// Token: 0x060007A8 RID: 1960 RVA: 0x0002B589 File Offset: 0x00029789
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x060007A9 RID: 1961 RVA: 0x0002B598 File Offset: 0x00029798
	public override void AllocResources()
	{

	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0002B632 File Offset: 0x00029832
	public override void DeallocResources()
	{

	}

	// Token: 0x060007AB RID: 1963 RVA: 0x0002B644 File Offset: 0x00029844
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0002B708 File Offset: 0x00029908
	public override void OnWorldTickUpdate()
	{

	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0002B798 File Offset: 0x00029998
	public override void OnDeviceReset()
	{

	}

	// Token: 0x060007AE RID: 1966 RVA: 0x0002B7A8 File Offset: 0x000299A8
	[AgentPropertyHandler(1)]
	public void HandleContent(AgentProperty property)
	{

	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0002B828 File Offset: 0x00029A28
	[AgentPropertyHandler(2)]
	public void HandleMode(AgentProperty property)
	{

	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x0002B880 File Offset: 0x00029A80
	[AgentPropertyHandler(3)]
	public void HandleCursorPosition(AgentProperty property)
	{

	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0002B8DC File Offset: 0x00029ADC
	public override FloatRange GetLimitsForProperty(int propertyId)
	{

        return default;
    }

	// Token: 0x04000706 RID: 1798
	public const int lcdLength = 13;

	// Token: 0x04000707 RID: 1799
	private AgentProperty _stateProperty;

	// Token: 0x04000708 RID: 1800
	private AgentProperty _contentProperty;

	// Token: 0x04000709 RID: 1801
	private AgentProperty _formattedTextProperty;

	// Token: 0x0400070A RID: 1802
	private AgentProperty _bufferProperty;

	// Token: 0x0400070B RID: 1803
	private AgentProperty _modeProperty;

	// Token: 0x0400070C RID: 1804
	private AgentProperty _decimalDigitsProperty;

	// Token: 0x0400070D RID: 1805
	private AgentProperty _scrollPositionProperty;

	// Token: 0x0400070E RID: 1806
	private AgentProperty _scrollIntervalProperty;

	// Token: 0x0400070F RID: 1807
	private AgentProperty _cursorPositionProperty;

	// Token: 0x04000710 RID: 1808
	private AgentProperty _cursorProperty;

	// Token: 0x04000711 RID: 1809
	private int _elapsedTicks;

	// Token: 0x04000712 RID: 1810
	private const int _textureWidth = 50;

	// Token: 0x0200036B RID: 875
	public enum Commands
	{
		// Token: 0x04001C08 RID: 7176
		UpdateVisuals = 1,
		// Token: 0x04001C09 RID: 7177
		SetState
	}
}
}