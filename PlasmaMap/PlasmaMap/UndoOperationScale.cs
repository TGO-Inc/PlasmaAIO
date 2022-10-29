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
// Token: 0x02000161 RID: 353
public class UndoOperationScale : UndoOperation
{
	// Token: 0x06000DF2 RID: 3570 RVA: 0x00047642 File Offset: 0x00045842
	public UndoOperationScale(ComponentHandler component, Vector3 scale)
	{

	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00047660 File Offset: 0x00045860
	public override void Execute()
	{

	}

	// Token: 0x04000B56 RID: 2902
	private Vector3 _scale;
}
}