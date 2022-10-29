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
// Token: 0x02000100 RID: 256
public class FunctionCallerAgent : Agent
{
	// Token: 0x06000A56 RID: 2646 RVA: 0x000364E6 File Offset: 0x000346E6
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x0003650C File Offset: 0x0003470C
	public override void OnSketchCompiling(Sketch sketch)
	{

	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x000365B0 File Offset: 0x000347B0
	public override bool NeedsRemoteOutputPort()
	{

        return default;
    }

	// Token: 0x06000A59 RID: 2649 RVA: 0x000365B4 File Offset: 0x000347B4
	public override void HandleRemotePortLogic()
	{

	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00036610 File Offset: 0x00034810
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x0003666C File Offset: 0x0003486C
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x06000A5C RID: 2652 RVA: 0x00036684 File Offset: 0x00034884
	[SketchNodePortOperation(1)]
	public void Call(SketchNode sketchNode)
	{

	}

	// Token: 0x04000964 RID: 2404
	private AgentProperty _functionNameProperty;

	// Token: 0x04000965 RID: 2405
	private AgentProperty _payloadProperty;

	// Token: 0x04000966 RID: 2406
	private FunctionCallerAgent.States _state;

	// Token: 0x04000967 RID: 2407
	private Dictionary<string, SketchNodePort> _functionMarkerPorts;

	// Token: 0x04000968 RID: 2408
	private SketchNodePort _functionMarkerPort;

	// Token: 0x0200039B RID: 923
	private enum States
	{
		// Token: 0x04001CA7 RID: 7335
		None,
		// Token: 0x04001CA8 RID: 7336
		ShouldCallFunction,
		// Token: 0x04001CA9 RID: 7337
		FunctionCalled,
		// Token: 0x04001CAA RID: 7338
		Done
	}
}
}