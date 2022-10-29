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
// Token: 0x02000169 RID: 361
public class DynamicProp : MonoBehaviour
{
	// Token: 0x06000E13 RID: 3603 RVA: 0x00047A40 File Offset: 0x00045C40
	private void Awake()
	{

	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00047A73 File Offset: 0x00045C73
	public void StoreInterpolation()
	{

	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x00047A8E File Offset: 0x00045C8E
	public void Interpolate(float d)
	{

	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00047AAC File Offset: 0x00045CAC
	public void SetEffectEnabled(bool value)
	{

	}

	// Token: 0x04000B82 RID: 2946
	public int id = -1;

	// Token: 0x04000B83 RID: 2947
	private SimpleInterpolation _interpolator;

	// Token: 0x04000B84 RID: 2948
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000B85 RID: 2949
	private MeshRenderer _meshRenderer;
}
}