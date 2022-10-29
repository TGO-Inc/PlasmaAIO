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
// Token: 0x0200002E RID: 46
public class LocalCharacterInterpolation : SimpleInterpolation
{
	// Token: 0x060000E6 RID: 230 RVA: 0x0000703C File Offset: 0x0000523C
	public override void Interpolate(float delta)
	{

	}

	// Token: 0x04000114 RID: 276
	public Transform cameraContainer;
}
}