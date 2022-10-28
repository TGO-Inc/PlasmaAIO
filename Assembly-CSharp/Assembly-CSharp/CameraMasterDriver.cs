using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000063 RID: 99
public class CameraMasterDriver : ComponentDriver
{
	// Token: 0x060005D1 RID: 1489 RVA: 0x00021E7C File Offset: 0x0002007C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00021EAC File Offset: 0x000200AC
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0400050E RID: 1294
	public Transform mount;

	// Token: 0x0400050F RID: 1295
	private RigidbodyCharacter _character;

	// Token: 0x04000510 RID: 1296
	private Camera _camera;

	// Token: 0x04000511 RID: 1297
	private AgentProperty _fovProperty;

	// Token: 0x04000512 RID: 1298
	private float _savedFOV;
}
}