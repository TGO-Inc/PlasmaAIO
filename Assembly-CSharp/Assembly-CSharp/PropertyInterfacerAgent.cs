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

namespace PlasmaAPI.GameClass {
// Token: 0x0200011E RID: 286
public class PropertyInterfacerAgent : Agent
{
	// Token: 0x06000AFF RID: 2815 RVA: 0x00039C74 File Offset: 0x00037E74
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00039C9C File Offset: 0x00037E9C
	public override void OnAgentInterfaceChanged(AgentId theAgentId)
	{

	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00039D5F File Offset: 0x00037F5F
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00039D70 File Offset: 0x00037F70
	[AgentPropertyHandler(1)]
	public void HandlePropertyProperty(AgentProperty property)
	{

	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00039DB0 File Offset: 0x00037FB0
	public override void StartSketchNodeRepeatOperation()
	{

	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00039DDC File Offset: 0x00037FDC
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00039E40 File Offset: 0x00038040
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x040009E0 RID: 2528
	private AgentProperty _propertyPropertyConfigured;

	// Token: 0x040009E1 RID: 2529
	private AgentProperty _propertyPropertyRuntime;

	// Token: 0x040009E2 RID: 2530
	private int _propertyId;

	// Token: 0x040009E3 RID: 2531
	private int _dataIndex;

	// Token: 0x040009E4 RID: 2532
	private bool _shouldRun;
}
}