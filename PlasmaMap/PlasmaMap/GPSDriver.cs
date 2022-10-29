using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000087 RID: 135
public class GPSDriver : ComponentDriver
{
	// Token: 0x060006E1 RID: 1761 RVA: 0x00027C9D File Offset: 0x00025E9D
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00027CDA File Offset: 0x00025EDA
	public override void OnMount()
	{

	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00027CF3 File Offset: 0x00025EF3
	public override void OnUnmount()
	{

	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00027D0C File Offset: 0x00025F0C
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x04000637 RID: 1591
	private AgentProperty _positionXProperty;

	// Token: 0x04000638 RID: 1592
	private AgentProperty _positionZProperty;

	// Token: 0x04000639 RID: 1593
	private Transform _transform;
}
}