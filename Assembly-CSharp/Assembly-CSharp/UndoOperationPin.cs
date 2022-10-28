using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200015B RID: 347
public class UndoOperationPin : UndoOperation
{
	// Token: 0x06000DE5 RID: 3557 RVA: 0x000471AC File Offset: 0x000453AC
	public UndoOperationPin(ComponentHandler component, Vector3 position, Quaternion rotation)
	{

	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x000471D0 File Offset: 0x000453D0
	public override void Execute()
	{

	}

	// Token: 0x04000B4D RID: 2893
	private Vector3 _position;

	// Token: 0x04000B4E RID: 2894
	private Quaternion _rotation;
}
}