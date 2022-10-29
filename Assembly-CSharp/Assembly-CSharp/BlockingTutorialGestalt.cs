using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000026 RID: 38
[CreateAssetMenu(menuName = "Plasma/Blocking Tutorial Gestalt")]
public class BlockingTutorialGestalt : SerializedScriptableObject
{
	// Token: 0x060000BE RID: 190 RVA: 0x00005ED8 File Offset: 0x000040D8
	private void SetAsInvalid()
	{

	}

	// Token: 0x040000E0 RID: 224
	public string title;

	// Token: 0x040000E1 RID: 225
	public string originalText;

	// Token: 0x040000E2 RID: 226
	public string processedText;

	// Token: 0x040000E3 RID: 227
	public Sprite image;

	// Token: 0x040000E4 RID: 228
	public Vector2 size;

	// Token: 0x040000E5 RID: 229
	public BlockingTutorialGestaltEnum id;
}
}