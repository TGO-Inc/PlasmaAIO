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
// Token: 0x020001AF RID: 431
[ExecuteInEditMode]
public class GradientToTexture : MonoBehaviour
{
	// Token: 0x06001000 RID: 4096 RVA: 0x000549B6 File Offset: 0x00052BB6
	private void Start()
	{
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x000549B8 File Offset: 0x00052BB8
	private void Update()
	{
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x000549BC File Offset: 0x00052BBC
	private void OnValidate()
	{

	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00054A60 File Offset: 0x00052C60
	private void UpdateTexture(GradientClass gradientClass)
	{

	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00054B84 File Offset: 0x00052D84
	private bool UnmatchedAR(GradientClass gradientClass)
	{

        return default;
    }

	// Token: 0x04000DC1 RID: 3521
	public int longSide = 128;

	// Token: 0x04000DC2 RID: 3522
	public int shortSide = 16;

	// Token: 0x04000DC3 RID: 3523
	public GradientClass[] gradients;

	// Token: 0x04000DC4 RID: 3524
	private Material material;
}
}