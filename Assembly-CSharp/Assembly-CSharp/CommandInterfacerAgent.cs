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
// Token: 0x020000F5 RID: 245
public class CommandInterfacerAgent : Agent
{
	// Token: 0x06000A1D RID: 2589 RVA: 0x000354DF File Offset: 0x000336DF
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00035508 File Offset: 0x00033708
	public override void OnAgentInterfaceChanged(AgentId theAgentId)
	{

	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x000355CF File Offset: 0x000337CF
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x000355DF File Offset: 0x000337DF
	public override void StartSketchNodeRepeatOperation()
	{

	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00035613 File Offset: 0x00033813
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00035650 File Offset: 0x00033850
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x0400093E RID: 2366
	private AgentProperty _commandPropertyConfigured;

	// Token: 0x0400093F RID: 2367
	private AgentProperty _commandPropertyRuntime;

	// Token: 0x04000940 RID: 2368
	private int _counter;

	// Token: 0x04000941 RID: 2369
	private bool _shouldRun;
}
}