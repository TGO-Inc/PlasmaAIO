using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000F8 RID: 248
public class DeviceControllerAgent : Agent
{
	// Token: 0x06000A2B RID: 2603 RVA: 0x000358E4 File Offset: 0x00033AE4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00035AA4 File Offset: 0x00033CA4
	[SketchNodePortOperation(1)]
	public void SetPermissions(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00035B90 File Offset: 0x00033D90
	[SketchNodePortOperation(2)]
	public void ToggleState(SketchNode sketchNode)
	{

	}

	// Token: 0x04000944 RID: 2372
	private AgentProperty _deviceProperty;

	// Token: 0x04000945 RID: 2373
	private AgentProperty _stateToggleProperty;

	// Token: 0x04000946 RID: 2374
	private AgentProperty _resetDeviceProperty;

	// Token: 0x04000947 RID: 2375
	private AgentProperty _grabWireframeProperty;

	// Token: 0x04000948 RID: 2376
	private AgentProperty _grabSolidProperty;

	// Token: 0x04000949 RID: 2377
	private AgentProperty _attachDetachProperty;

	// Token: 0x0400094A RID: 2378
	private AgentProperty _manipulationProperty;

	// Token: 0x0400094B RID: 2379
	private AgentProperty _deleteDeviceProperty;

	// Token: 0x0400094C RID: 2380
	private AgentProperty _cloneDeviceProperty;

	// Token: 0x0400094D RID: 2381
	private AgentProperty _editPropertiesProperty;

	// Token: 0x0400094E RID: 2382
	private AgentProperty _accessSketchProperty;

	// Token: 0x0400094F RID: 2383
	private AgentProperty _editSketchProperty;

	// Token: 0x04000950 RID: 2384
	private AgentProperty _paintProperty;

	// Token: 0x04000951 RID: 2385
	private Dictionary<AgentProperty, WorldController.GlobalPermissions> _permissionProperties;
}
}