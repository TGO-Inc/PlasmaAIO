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
// Token: 0x020001A0 RID: 416
[ExecuteInEditMode]
public class FoliageLightSetter : MonoBehaviour
{
	// Token: 0x06000FB8 RID: 4024 RVA: 0x00052CCE File Offset: 0x00050ECE
	private void Start()
	{
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00052CD0 File Offset: 0x00050ED0
	private void Update()
	{

	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00052D25 File Offset: 0x00050F25
	private void OnDrawGizmos()
	{

	}

	// Token: 0x04000D2F RID: 3375
	public Light sun;

	// Token: 0x04000D30 RID: 3376
	public Material[] mats;
}
}