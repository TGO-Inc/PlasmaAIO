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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200016F RID: 367
public static class TransformExtensions
{
	// Token: 0x06000E27 RID: 3623 RVA: 0x00048138 File Offset: 0x00046338
	public static List<GameObject> FindObjectsWithTag(this Transform parent, string tag)
	{

        return default;
    }

	// Token: 0x06000E28 RID: 3624 RVA: 0x00048198 File Offset: 0x00046398
	public static List<GameObject> FindFirstDegreeObjectsWithLayer(this Transform parent, int layer)
	{

        return default;
    }
}
}