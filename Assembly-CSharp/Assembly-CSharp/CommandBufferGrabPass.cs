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
// Token: 0x02000199 RID: 409
[ExecuteInEditMode]
public class CommandBufferGrabPass : MonoBehaviour
{
	// Token: 0x06000F4D RID: 3917 RVA: 0x0004E54A File Offset: 0x0004C74A
	public void OnEnable()
	{

	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x0004E552 File Offset: 0x0004C752
	public void OnDisable()
	{

	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x0004E55C File Offset: 0x0004C75C
	public void OnWillRenderObject()
	{

	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x0004E600 File Offset: 0x0004C800
	private void Cleanup()
	{

	}

	// Token: 0x04000CD1 RID: 3281
	private static readonly Dictionary<Camera, CommandBuffer> cameras = new Dictionary<Camera, CommandBuffer>();
}
}