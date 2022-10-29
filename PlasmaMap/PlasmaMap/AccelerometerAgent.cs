using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;

namespace PlasmaAPI.GameClass {
// Token: 0x02000058 RID: 88
public class AccelerometerAgent : Agent
{
	// Token: 0x0600058A RID: 1418 RVA: 0x00021395 File Offset: 0x0001F595
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600058B RID: 1419 RVA: 0x000213BE File Offset: 0x0001F5BE
	public override void OnDeviceReset()
	{

	}

	// Token: 0x0600058C RID: 1420 RVA: 0x000213F0 File Offset: 0x0001F5F0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x040004DA RID: 1242
	private AgentProperty _propertyX;

	// Token: 0x040004DB RID: 1243
	private AgentProperty _propertyY;

	// Token: 0x040004DC RID: 1244
	private AgentProperty _propertyZ;
}
}