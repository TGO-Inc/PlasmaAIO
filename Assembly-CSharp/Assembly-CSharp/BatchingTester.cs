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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200019D RID: 413
public class BatchingTester : MonoBehaviour
{
	// Token: 0x06000FA9 RID: 4009 RVA: 0x0005264C File Offset: 0x0005084C
	private void Start()
	{

	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00052730 File Offset: 0x00050930
	private void Update()
	{

	}

	// Token: 0x04000D1C RID: 3356
	public GameObject[] prefabs;

	// Token: 0x04000D1D RID: 3357
	public List<Renderer> rends;

	// Token: 0x04000D1E RID: 3358
	private MaterialPropertyBlock block;

	// Token: 0x04000D1F RID: 3359
	private int nameID;

	// Token: 0x04000D20 RID: 3360
	private List<MaterialPropertyBlock> blocks;
}
}