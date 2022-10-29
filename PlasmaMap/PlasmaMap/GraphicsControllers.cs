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
// Token: 0x0200016D RID: 365
public class GraphicsControllers : MonoBehaviour
{
	// Token: 0x06000E23 RID: 3619 RVA: 0x000480B2 File Offset: 0x000462B2
	private void Awake()
	{

	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x000480D4 File Offset: 0x000462D4
	private static T Init<T>() where T : Controller
	{

        return default;
    }

	// Token: 0x04000BA8 RID: 2984
	public static EnvironmentController environmentController;

	// Token: 0x04000BA9 RID: 2985
	public static VFXController vfxController;

	// Token: 0x04000BAA RID: 2986
	public static QualitySettingsController qualitySettingsController;
}
}