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
// Token: 0x0200019E RID: 414
[ExecuteInEditMode]
public class CylinderTester : MonoBehaviour
{
	// Token: 0x06000FAC RID: 4012 RVA: 0x0005280D File Offset: 0x00050A0D
	private void Start()
	{
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00052810 File Offset: 0x00050A10
	private void Update()
	{

	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00052897 File Offset: 0x00050A97
	private void OnDrawGizmos()
	{

	}

	// Token: 0x04000D21 RID: 3361
	public bool drawGizmo;

	// Token: 0x04000D22 RID: 3362
	public float innerRadius;

	// Token: 0x04000D23 RID: 3363
	public float outerBorder;

	// Token: 0x04000D24 RID: 3364
	public Material mat;
}
}