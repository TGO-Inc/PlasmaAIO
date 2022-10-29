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
// Token: 0x020001B0 RID: 432
[Serializable]
public class GradientClass
{
	// Token: 0x04000DC5 RID: 3525
	[Header("[PARAMETERS]")]
	public string shaderParamName;

	// Token: 0x04000DC6 RID: 3526
	public bool vertical;

	// Token: 0x04000DC7 RID: 3527
	public Gradient gradient;

	// Token: 0x04000DC8 RID: 3528
	[HideInInspector]
	[Header("[DEBUG]")]
	public Texture2D texture;
}
}