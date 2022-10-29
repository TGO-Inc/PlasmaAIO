using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using PlasmaAPI.GameClass.Common.Math;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200015A RID: 346
public class UndoOperationDetach : UndoOperation
{
	// Token: 0x06000DE3 RID: 3555 RVA: 0x00047054 File Offset: 0x00045254
	public UndoOperationDetach(ComponentHandler component)
	{

	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x000470B4 File Offset: 0x000452B4
	public override void Execute()
	{

	}

	// Token: 0x04000B48 RID: 2888
	private SubComponentHandler _oldParent;

	// Token: 0x04000B49 RID: 2889
	private SubComponentHandler _oldChild;

	// Token: 0x04000B4A RID: 2890
	private Vector3 _pitchYawRoll;

	// Token: 0x04000B4B RID: 2891
	private QTransform _parentTransform;

	// Token: 0x04000B4C RID: 2892
	private QTransform _childTransform;
}
}