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
using UnityEngine.Rendering;

namespace PlasmaAPI.GameClass {
// Token: 0x02000198 RID: 408
[ExecuteInEditMode]
public class CommandBufferBlurRefraction : MonoBehaviour
{
	// Token: 0x06000F48 RID: 3912 RVA: 0x0004E23D File Offset: 0x0004C43D
	public void OnEnable()
	{

	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x0004E245 File Offset: 0x0004C445
	public void OnDisable()
	{

	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0004E250 File Offset: 0x0004C450
	public void OnWillRenderObject()
	{

	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
	private void Cleanup()
	{

	}

	// Token: 0x04000CCD RID: 3277
	public float Amount = 2f;

	// Token: 0x04000CCE RID: 3278
	public Shader BlurShader;

	// Token: 0x04000CCF RID: 3279
	private readonly Dictionary<Camera, CommandBuffer> _cameras = new Dictionary<Camera, CommandBuffer>();

	// Token: 0x04000CD0 RID: 3280
	private Material _material;
}
}