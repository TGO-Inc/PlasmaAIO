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
// Token: 0x02000024 RID: 36
[CreateAssetMenu(menuName = "Plasma/Hint Gestalt")]
public class HintGestalt : SerializedScriptableObject
{
	// Token: 0x060000AE RID: 174 RVA: 0x000058E0 File Offset: 0x00003AE0
	private void SetAsInvalid()
	{

	}

	// Token: 0x040000C2 RID: 194
	public RewiredEnum rewiredActionId;

	// Token: 0x040000C3 RID: 195
	public RewiredEnum rewiredActionModifierId = RewiredEnum.NoModifier;

	// Token: 0x040000C4 RID: 196
	public string text;

	// Token: 0x040000C5 RID: 197
	public bool showClock;

	// Token: 0x040000C6 RID: 198
	public bool useSecondaryMap;

	// Token: 0x040000C7 RID: 199
	public bool altVisuals;

	// Token: 0x040000C8 RID: 200
	public HintGestaltEnum id;
}
}