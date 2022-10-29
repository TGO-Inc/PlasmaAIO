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
// Token: 0x020000E1 RID: 225
public class TouchDisplayCommonDriver : DisplayCommonDriver
{
	// Token: 0x060009B2 RID: 2482 RVA: 0x00033C98 File Offset: 0x00031E98
	public override bool CanReactToRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x060009B3 RID: 2483 RVA: 0x00033CFC File Offset: 0x00031EFC
	public override void OnRaycastInteraction(Ray ray)
	{

	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00033DC0 File Offset: 0x00031FC0
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00033DD8 File Offset: 0x00031FD8
	public override void OnInteractionUp()
	{

	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00033DF0 File Offset: 0x00031FF0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x040008E4 RID: 2276
	public Transform touchCollider;

	// Token: 0x040008E5 RID: 2277
	protected AgentProperty _pointerXProperty;

	// Token: 0x040008E6 RID: 2278
	protected AgentProperty _pointerYProperty;

	// Token: 0x040008E7 RID: 2279
	protected AgentProperty _pointerClickedProperty;

	// Token: 0x040008E8 RID: 2280
	protected AgentProperty _pointerActiveProperty;

	// Token: 0x040008E9 RID: 2281
	private Vector2 _xy;

	// Token: 0x040008EA RID: 2282
	private bool _active;
}
}