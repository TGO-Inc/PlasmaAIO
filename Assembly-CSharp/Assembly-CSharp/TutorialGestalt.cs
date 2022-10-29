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
// Token: 0x02000027 RID: 39
[CreateAssetMenu(menuName = "Plasma/Tutorial Gestalt")]
public class TutorialGestalt : SerializedScriptableObject
{
	// Token: 0x060000C0 RID: 192 RVA: 0x00005EE9 File Offset: 0x000040E9
	private void SetAsInvalid()
	{

	}

	// Token: 0x040000E6 RID: 230
	public string originalText;

	// Token: 0x040000E7 RID: 231
	public string processedText;

	// Token: 0x040000E8 RID: 232
	public bool requireSolidState;

	// Token: 0x040000E9 RID: 233
	public bool alwaysValid;

	// Token: 0x040000EA RID: 234
	public TutorialGestaltEnum id;
}
}