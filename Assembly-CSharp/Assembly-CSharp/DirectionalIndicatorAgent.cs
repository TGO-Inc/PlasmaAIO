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
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200006C RID: 108
public class DirectionalIndicatorAgent : Agent
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000607 RID: 1543 RVA: 0x00022EF5 File Offset: 0x000210F5
	// (set) Token: 0x06000608 RID: 1544 RVA: 0x00022EFD File Offset: 0x000210FD
	public RenderTexture renderTexture { get; private set; }

	// Token: 0x06000609 RID: 1545 RVA: 0x00022F06 File Offset: 0x00021106
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x0600060A RID: 1546 RVA: 0x00022F18 File Offset: 0x00021118
	public override void AllocResources()
	{

	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00022F9A File Offset: 0x0002119A
	public override void DeallocResources()
	{

	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00022FAC File Offset: 0x000211AC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00022FE4 File Offset: 0x000211E4
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00022FF0 File Offset: 0x000211F0
	[AgentPropertyHandler(1)]
	public void HandleTargetDirection(AgentProperty property)
	{

	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00023030 File Offset: 0x00021230
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000543 RID: 1347
	public int renderTextureIndex;

	// Token: 0x04000545 RID: 1349
	private AgentProperty _currentDirectionProperty;

	// Token: 0x04000546 RID: 1350
	private AgentProperty _targetDirectionProperty;

	// Token: 0x04000547 RID: 1351
	private AgentProperty _differenceProperty;

	// Token: 0x04000548 RID: 1352
	private bool _canTrigger;

	// Token: 0x04000549 RID: 1353
	private bool _shouldTrigger;

	// Token: 0x0400054A RID: 1354
	private const float _tolerance = 1f;

	// Token: 0x02000353 RID: 851
	public enum Commands
	{
		// Token: 0x04001BB0 RID: 7088
		SetState = 5,
		// Token: 0x04001BB1 RID: 7089
		SetBackgroundColor = 1,
		// Token: 0x04001BB2 RID: 7090
		SetCompassColor,
		// Token: 0x04001BB3 RID: 7091
		SetArrowColor,
		// Token: 0x04001BB4 RID: 7092
		UpdateVisuals
	}
}
}