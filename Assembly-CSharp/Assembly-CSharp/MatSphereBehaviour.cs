using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using DG.Tweening;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020001B1 RID: 433
public class MatSphereBehaviour : MonoBehaviour
{
	// Token: 0x06001007 RID: 4103 RVA: 0x00054BF9 File Offset: 0x00052DF9
	private void Start()
	{

	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00054C20 File Offset: 0x00052E20
	private void Update()
	{

	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00054D5C File Offset: 0x00052F5C
	private void OnDrawGizmos()
	{

	}

	// Token: 0x04000DC9 RID: 3529
	public bool CMD_PACK;

	// Token: 0x04000DCA RID: 3530
	public bool CMD_BIGBOUNDS;

	// Token: 0x04000DCB RID: 3531
	public bool drawGizmos;

	// Token: 0x04000DCC RID: 3532
	public MeshRenderer mr;

	// Token: 0x04000DCD RID: 3533
	public MeshFilter mf;

	// Token: 0x04000DCE RID: 3534
	public Material mat;

	// Token: 0x04000DCF RID: 3535
	[Range(0f, 1f)]
	public float pack;

	// Token: 0x04000DD0 RID: 3536
	public Bounds mrBounds;

	// Token: 0x04000DD1 RID: 3537
	public Bounds mfBounds;

	// Token: 0x04000DD2 RID: 3538
	public Bounds bigBounds;
}
}