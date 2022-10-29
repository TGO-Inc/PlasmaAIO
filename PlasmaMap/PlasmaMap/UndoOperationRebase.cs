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
// Token: 0x0200015F RID: 351
public class UndoOperationRebase : UndoOperation
{
	// Token: 0x06000DED RID: 3565 RVA: 0x000473CD File Offset: 0x000455CD
	public UndoOperationRebase(ComponentHandler component)
	{

	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x000473FC File Offset: 0x000455FC
	public UndoOperationRebase(ComponentHandler component, Vector3 position, Quaternion rotation)
	{

	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00047448 File Offset: 0x00045648
	public override void Execute()
	{

	}

	// Token: 0x04000B52 RID: 2898
	private SubComponentHandler _oldBaseSubComponent;

	// Token: 0x04000B53 RID: 2899
	private Vector3 _position;

	// Token: 0x04000B54 RID: 2900
	private Quaternion _rotation;

	// Token: 0x04000B55 RID: 2901
	private bool _restoreTransforms;
}
}