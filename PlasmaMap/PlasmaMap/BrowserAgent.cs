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
using Steamworks;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000F0 RID: 240
public class BrowserAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A0E RID: 2574 RVA: 0x00035013 File Offset: 0x00033213
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0003503C File Offset: 0x0003323C
	[SketchNodePortOperation(1)]
	public void OpenURL(SketchNode sketchNode)
	{

	}

	// Token: 0x0400092F RID: 2351
	private AgentProperty _urlProperty;

	// Token: 0x04000930 RID: 2352
	private AgentProperty _modeProperty;
}
}