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
// Token: 0x02000031 RID: 49
public class VFXCameraComposer : MonoBehaviour
{
	// Token: 0x06000117 RID: 279 RVA: 0x00008288 File Offset: 0x00006488
	public void Init()
	{

	}

	// Token: 0x06000118 RID: 280 RVA: 0x000082AC File Offset: 0x000064AC
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{

	}

	// Token: 0x0400014A RID: 330
	private bool _initialized;

	// Token: 0x0400014B RID: 331
	private Camera _camera;
}
}