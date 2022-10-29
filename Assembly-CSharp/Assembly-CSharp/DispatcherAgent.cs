using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000FA RID: 250
public class DispatcherAgent : Agent
{
	// Token: 0x06000A3B RID: 2619 RVA: 0x00035FCF File Offset: 0x000341CF
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00035FF5 File Offset: 0x000341F5
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00035FFE File Offset: 0x000341FE
	[AgentPropertyHandler(1)]
	public void HandleForwardPayload(AgentProperty property)
	{

	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00036014 File Offset: 0x00034214
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00036066 File Offset: 0x00034266
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x06000A40 RID: 2624 RVA: 0x00036071 File Offset: 0x00034271
	[SketchNodePortOperation(1)]
	public void Dispatch(SketchNode sketchNode)
	{

	}

	// Token: 0x0400095A RID: 2394
	private int _counter;

	// Token: 0x0400095B RID: 2395
	private AgentProperty _payloadProperty;

	// Token: 0x0400095C RID: 2396
	private AgentProperty _forwardPayloadProperty;
}
}