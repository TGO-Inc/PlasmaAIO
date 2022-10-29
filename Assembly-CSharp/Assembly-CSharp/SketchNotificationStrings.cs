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
using Behavior;
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000152 RID: 338
[CreateAssetMenu(menuName = "Plasma/Sketch Notification Strings")]
public class SketchNotificationStrings : SerializedScriptableObject
{
	// Token: 0x04000B0F RID: 2831
	public Dictionary<SketchNotifications.Types, string> messages;
}
}