using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000129 RID: 297
public class StageControllerAgent : Agent
{
	// Token: 0x06000B34 RID: 2868 RVA: 0x0003A98C File Offset: 0x00038B8C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0003AA04 File Offset: 0x00038C04
	[SketchNodePortOperation(1)]
	public void SetPermissions(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A09 RID: 2569
	private AgentProperty _playerCanSpawnComponentsProperty;

	// Token: 0x04000A0A RID: 2570
	private AgentProperty _playerCanMakeNewDevicesProperty;

	// Token: 0x04000A0B RID: 2571
	private AgentProperty _playerCanFlyProperty;

	// Token: 0x04000A0C RID: 2572
	private Dictionary<AgentProperty, WorldController.WorldPermissions> _permissionProperties;
}
}