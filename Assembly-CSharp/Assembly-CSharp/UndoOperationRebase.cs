using System;
using UnityEngine;

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
