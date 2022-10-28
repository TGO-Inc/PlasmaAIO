using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200014A RID: 330
public class DeviceComponentModifier : MonoBehaviour
{
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00044A67 File Offset: 0x00042C67
	// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00044A6F File Offset: 0x00042C6F
	public ComponentHandler componentHandler
	{
		get
		{
			return this._componentHandler;
		}
		set
		{
			this._componentHandler = value;
			this.OnComponentSet();
		}
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00044A7E File Offset: 0x00042C7E
	public virtual void OnComponentSet()
	{
	}

	// Token: 0x04000AEC RID: 2796
	private ComponentHandler _componentHandler;
}
}