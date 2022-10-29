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
// Token: 0x020000A5 RID: 165
public class LightSensorDriver : ComponentDriver
{
	// Token: 0x060007D9 RID: 2009 RVA: 0x0002C065 File Offset: 0x0002A265
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060007DA RID: 2010 RVA: 0x0002C07C File Offset: 0x0002A27C
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x04000738 RID: 1848
	public Transform baseTransform;

	// Token: 0x04000739 RID: 1849
	private AgentProperty _intensityProperty;
}
}