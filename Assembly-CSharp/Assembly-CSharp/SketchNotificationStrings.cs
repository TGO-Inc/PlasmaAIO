using System;
using System.Collections.Generic;
using Behavior;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x02000152 RID: 338
[CreateAssetMenu(menuName = "Plasma/Sketch Notification Strings")]
public class SketchNotificationStrings : SerializedScriptableObject
{
	// Token: 0x04000B0F RID: 2831
	public Dictionary<SketchNotifications.Types, string> messages;
}
