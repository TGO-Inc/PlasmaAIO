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
// Token: 0x0200014F RID: 335
public class InteractiveMeshFollow : MonoBehaviour
{
	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00045C8C File Offset: 0x00043E8C
	// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00045C94 File Offset: 0x00043E94
	public Transform followTransform
	{
		get
		{
			return this._followTransform;
		}
		set
		{
			this._followTransform = value;
			this._follow = true;
		}
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00045CA4 File Offset: 0x00043EA4
	private void Update()
	{

	}

	// Token: 0x04000B0B RID: 2827
	private Transform _followTransform;

	// Token: 0x04000B0C RID: 2828
	private bool _follow;
}
}