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
// Token: 0x020001AB RID: 427
public class ChrisSimpleMover : MonoBehaviour
{
	// Token: 0x06000FE6 RID: 4070 RVA: 0x000539CA File Offset: 0x00051BCA
	private void Start()
	{

	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x000539F0 File Offset: 0x00051BF0
	private void Update()
	{

	}

	// Token: 0x04000D83 RID: 3459
	public Vector3 positionSpeed;

	// Token: 0x04000D84 RID: 3460
	public Vector3 positionAmplitude;

	// Token: 0x04000D85 RID: 3461
	public Vector3 rotationSpeed;

	// Token: 0x04000D86 RID: 3462
	public Vector3 rotationAmplitude;

	// Token: 0x04000D87 RID: 3463
	private Vector3 startPosition;

	// Token: 0x04000D88 RID: 3464
	private Quaternion startRotation;
}
}