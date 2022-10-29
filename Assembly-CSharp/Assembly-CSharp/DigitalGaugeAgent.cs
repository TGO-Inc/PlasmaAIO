using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200006A RID: 106
public class DigitalGaugeAgent : Agent
{
	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00022AB4 File Offset: 0x00020CB4
	// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00022ABC File Offset: 0x00020CBC
	public RenderTexture renderTexture { get; private set; }

	// Token: 0x060005F8 RID: 1528 RVA: 0x00022AC5 File Offset: 0x00020CC5
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x060005F9 RID: 1529 RVA: 0x00022AD4 File Offset: 0x00020CD4
	public override void AllocResources()
	{

	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00022B56 File Offset: 0x00020D56
	public override void DeallocResources()
	{

	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00022B68 File Offset: 0x00020D68
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00022B8E File Offset: 0x00020D8E
	public override FloatRange GetLimitsForProperty(int propertyId)
	{

        return default;
    }

	// Token: 0x04000533 RID: 1331
	public int renderTextureIndex;

	// Token: 0x04000535 RID: 1333
	private AgentProperty _lowerLimitProperty;

	// Token: 0x04000536 RID: 1334
	private AgentProperty _upperLimitProperty;

	// Token: 0x02000352 RID: 850
	public enum Commands
	{
		// Token: 0x04001BAB RID: 7083
		SetState = 1,
		// Token: 0x04001BAC RID: 7084
		SetBackgroundColor,
		// Token: 0x04001BAD RID: 7085
		SetForegroundColor,
		// Token: 0x04001BAE RID: 7086
		UpdateVisuals
	}
}
}