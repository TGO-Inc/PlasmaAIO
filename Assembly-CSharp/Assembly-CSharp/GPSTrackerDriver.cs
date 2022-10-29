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
// Token: 0x0200008B RID: 139
public class GPSTrackerDriver : ComponentDriver
{
	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060006FA RID: 1786 RVA: 0x00028128 File Offset: 0x00026328
	public Vector3 selfVelocity
	{
		get
		{
			if (!this._component.device.isMounted)
			{
				return this._articulationBody.velocity;
			}
			return Controllers.worldController.playerVelocity;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060006FB RID: 1787 RVA: 0x00028152 File Offset: 0x00026352
	public Vector3 worldPosition
	{
		get
		{
			return this._transform.position;
		}
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00028160 File Offset: 0x00026360
	public override void Awake()
	{

	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000281B0 File Offset: 0x000263B0
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000281C3 File Offset: 0x000263C3
	public override void OnMount()
	{

	}

	// Token: 0x060006FF RID: 1791 RVA: 0x000281DC File Offset: 0x000263DC
	public override void OnUnmount()
	{

	}

	// Token: 0x06000700 RID: 1792 RVA: 0x000281F5 File Offset: 0x000263F5
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x04000642 RID: 1602
	public float LEDOnDuration;

	// Token: 0x04000643 RID: 1603
	public float LEDOffDuration;

	// Token: 0x04000644 RID: 1604
	public MeshRenderer meshRenderer;

	// Token: 0x04000645 RID: 1605
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000646 RID: 1606
	private int _colorId;

	// Token: 0x04000647 RID: 1607
	private bool _blink;

	// Token: 0x04000648 RID: 1608
	private ArticulationBody _articulationBody;

	// Token: 0x04000649 RID: 1609
	private Transform _transform;
}
}