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
// Token: 0x0200014D RID: 333
public class FollowTargetOnUpdate : MonoBehaviour
{
	// Token: 0x06000D94 RID: 3476 RVA: 0x00045B94 File Offset: 0x00043D94
	private void Update()
	{

	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00045BE0 File Offset: 0x00043DE0
	public void SetTarget(Transform t, bool worldPositionStays = true)
	{

	}

	// Token: 0x04000B08 RID: 2824
	private Transform _target;

	// Token: 0x04000B09 RID: 2825
	private Vector3 _offset;
}
}