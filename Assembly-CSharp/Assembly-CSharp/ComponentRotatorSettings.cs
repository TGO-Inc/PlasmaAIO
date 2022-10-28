using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200002B RID: 43
[CreateAssetMenu(fileName = "RotatorSettings", menuName = "Plasma/Rotator Settings")]
public class ComponentRotatorSettings : ScriptableObject
{
	// Token: 0x04000104 RID: 260
	[Header("Pitch & Yaw Control")]
	public float targetSmoothing = 0.99f;

	// Token: 0x04000105 RID: 261
	public bool reverseRotationDirectionWhenTipFacingAway = true;

	// Token: 0x04000106 RID: 262
	public float angleThresholdToReverseRotationInDeg = 10f;

	// Token: 0x04000107 RID: 263
	[Header("Roll Control")]
	public bool useAutoRollFromPatrick = true;

	// Token: 0x04000108 RID: 264
	public float rollRotationAnglePerSecond = 90f;
}
}