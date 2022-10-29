using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x02000021 RID: 33
public class ImageDebuggerCell : MonoBehaviour
{
	// Token: 0x040000BE RID: 190
	public RawImage texture;

	// Token: 0x040000BF RID: 191
	public TextMeshProUGUI type;

	// Token: 0x040000C0 RID: 192
	public TextMeshProUGUI memory;

	// Token: 0x040000C1 RID: 193
	public TextMeshProUGUI info;
}
}