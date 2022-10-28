using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000159 RID: 345
public class UndoOperationAttach : UndoOperation
{
	// Token: 0x06000DE1 RID: 3553 RVA: 0x00046D74 File Offset: 0x00044F74
	public UndoOperationAttach(ComponentHandler component, Vector3 position, Quaternion rotation)
	{

	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00046DEC File Offset: 0x00044FEC
	public override void Execute()
	{

	}

	// Token: 0x04000B42 RID: 2882
	private int _oldGuid;

	// Token: 0x04000B43 RID: 2883
	private string _oldDisplayName;

	// Token: 0x04000B44 RID: 2884
	private Dictionary<WorldController.GlobalPermissions, WorldController.GlobalPermissionStates> _oldPermissions;

	// Token: 0x04000B45 RID: 2885
	private bool _oldKinematicBase;

	// Token: 0x04000B46 RID: 2886
	private Vector3 _basePosition;

	// Token: 0x04000B47 RID: 2887
	private Quaternion _baseRotation;
}
}