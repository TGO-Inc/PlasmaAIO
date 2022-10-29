using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;

namespace PlasmaAPI.GameClass {
// Token: 0x02000057 RID: 87
[AttributeUsage(AttributeTargets.Method)]
public class AgentPropertyHandlerAttribute : Attribute
{
	// Token: 0x06000589 RID: 1417 RVA: 0x00021386 File Offset: 0x0001F586
	public AgentPropertyHandlerAttribute(int id)
	{

	}

	// Token: 0x040004D9 RID: 1241
	public readonly int id;
}
}