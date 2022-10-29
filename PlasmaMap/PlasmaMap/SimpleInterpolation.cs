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
// Token: 0x0200018F RID: 399
public class SimpleInterpolation : MonoBehaviour
{
	// Token: 0x06000EAD RID: 3757 RVA: 0x0004B6C3 File Offset: 0x000498C3
	public virtual void Awake()
	{

	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x0004B6D8 File Offset: 0x000498D8
	public void StoreState()
	{

	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x0004B730 File Offset: 0x00049930
	public virtual void Interpolate(float delta)
	{

	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x0004B7B8 File Offset: 0x000499B8
	public virtual void OverrideTransforms()
	{

	}

	// Token: 0x04000C94 RID: 3220
	public Transform owner;

	// Token: 0x04000C95 RID: 3221
	protected SimpleInterpolation.StoredTransform[] _storedTransforms;

	// Token: 0x04000C96 RID: 3222
	protected int _index;

	// Token: 0x020003C7 RID: 967
	protected struct StoredTransform
	{
		// Token: 0x04001D63 RID: 7523
		public Vector3 position;

		// Token: 0x04001D64 RID: 7524
		public Quaternion rotation;
	}
}
}