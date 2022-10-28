using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x020000FC RID: 252
public class EventBroadcasterAgent : Agent
{
	// Token: 0x06000A47 RID: 2631 RVA: 0x0003616D File Offset: 0x0003436D
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00036194 File Offset: 0x00034394
	public override void OnSketchCompiling(Sketch sketch)
	{

	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00036244 File Offset: 0x00034444
	public override bool NeedsRemoteOutputPort()
	{

        return default;
    }

	// Token: 0x06000A4A RID: 2634 RVA: 0x00036248 File Offset: 0x00034448
	public override void HandleRemotePortLogic()
	{

	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x000362BC File Offset: 0x000344BC
	[SketchNodePortOperation(1)]
	public void Broadcast(SketchNode sketchNode)
	{

	}

	// Token: 0x0400095F RID: 2399
	private AgentProperty _eventNameProperty;

	// Token: 0x04000960 RID: 2400
	private AgentProperty _payloadProperty;

	// Token: 0x04000961 RID: 2401
	private Dictionary<string, List<SketchNodePort>> _eventListenerPorts;
}
