using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200017A RID: 378
public class SensorTriggerListener : MonoBehaviour
{
	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00049D9B File Offset: 0x00047F9B
	public ComponentHandler component
	{
		get
		{
			return this._componentDriver.component;
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00049DA8 File Offset: 0x00047FA8
	private void Awake()
	{

	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00049DB6 File Offset: 0x00047FB6
	public void OnTriggerEnter(Collider theCollider)
	{

	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00049DD2 File Offset: 0x00047FD2
	public void OnTriggerStay(Collider theCollider)
	{

	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00049DEE File Offset: 0x00047FEE
	public void OnTriggerExit(Collider theCollider)
	{

	}

	// Token: 0x04000BE1 RID: 3041
	private ComponentDriver _componentDriver;
}
}