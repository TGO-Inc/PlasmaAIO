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
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200002D RID: 45
public class ScaleOverlay : SerializedMonoBehaviour
{
	// Token: 0x060000E0 RID: 224 RVA: 0x00006E0C File Offset: 0x0000500C
	private void Awake()
	{

	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00006E30 File Offset: 0x00005030
	public void Setup(ComponentHandler target, bool uniform)
	{

	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00006F98 File Offset: 0x00005198
	private void SetAxisColor(AgentGestalt.NUSAxis axis, Color color)
	{

	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00006FE4 File Offset: 0x000051E4
	private void Update()
	{

	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000701F File Offset: 0x0000521F
	public void CleanUp()
	{

	}

	// Token: 0x0400010F RID: 271
	public Dictionary<AgentGestalt.NUSAxis, MeshRenderer> axisRenderers;

	// Token: 0x04000110 RID: 272
	public float distance;

	// Token: 0x04000111 RID: 273
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000112 RID: 274
	private Transform _camera;

	// Token: 0x04000113 RID: 275
	private bool _active;
}
}