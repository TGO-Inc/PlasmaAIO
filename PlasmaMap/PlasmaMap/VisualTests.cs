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
// Token: 0x020001B9 RID: 441
[ExecuteInEditMode]
public class VisualTests : MonoBehaviour
{
	// Token: 0x06001022 RID: 4130 RVA: 0x00055743 File Offset: 0x00053943
	private void Start()
	{
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00055748 File Offset: 0x00053948
	private void Update()
	{

	}

	// Token: 0x04000E1C RID: 3612
	[Header("[REFERENCES]")]
	public GameObject[] objects;

	// Token: 0x04000E1D RID: 3613
	public VisualBehaviour[] behaviours;

	// Token: 0x04000E1E RID: 3614
	[Header("[COMMANDS]")]
	public bool GETREFS;
}
}