using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200017B RID: 379
public class StructureTriggerListener : MonoBehaviour
{
	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00049E12 File Offset: 0x00048012
	// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00049E1A File Offset: 0x0004801A
	public ComponentHandler component { get; private set; }

	// Token: 0x06000E71 RID: 3697 RVA: 0x00049E23 File Offset: 0x00048023
	private void Awake()
	{

	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00049E36 File Offset: 0x00048036
	public void OnTriggerEnter(Collider c)
	{

	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00049E4E File Offset: 0x0004804E
	public void OnTriggerExit(Collider c)
	{

	}
}
}