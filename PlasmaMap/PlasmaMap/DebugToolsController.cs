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
// Token: 0x02000038 RID: 56
public class DebugToolsController : Controller
{
	// Token: 0x06000174 RID: 372 RVA: 0x000097B6 File Offset: 0x000079B6
	public override void Init()
	{

	}

	// Token: 0x0400017C RID: 380
	public KeyCode imageDebuggerKey;

	// Token: 0x0400017D RID: 381
	private GameObject _imageDebuggerCanvas;
}
}