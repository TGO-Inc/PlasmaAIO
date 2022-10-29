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
using Newtonsoft.Json;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200012D RID: 301
public class TextArrayDecomposerAgent : Agent
{
	// Token: 0x06000B57 RID: 2903 RVA: 0x0003B224 File Offset: 0x00039424
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x0003B238 File Offset: 0x00039438
	[SketchNodePortOperation(1)]
	public void Decompose(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A19 RID: 2585
	private AgentProperty _arrayProperty;
}
}