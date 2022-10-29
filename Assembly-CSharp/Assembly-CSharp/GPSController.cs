using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200003B RID: 59
public class GPSController : Controller
{
	// Token: 0x060001BB RID: 443 RVA: 0x0000AE8D File Offset: 0x0000908D
	public override void Init()
	{

	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000AE9A File Offset: 0x0000909A
	public void Purge()
	{

	}

	// Token: 0x060001BD RID: 445 RVA: 0x0000AEA7 File Offset: 0x000090A7
	public void RegisterTag(int tagId, GPSTagDriver tagDriver)
	{

	}

	// Token: 0x060001BE RID: 446 RVA: 0x0000AEC4 File Offset: 0x000090C4
	public void UnregisterTag(int tagId)
	{

	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000AED4 File Offset: 0x000090D4
	public bool FetchPosition(int tagId, out Vector3 position)
	{
        position = default;

        return default;
    }

	// Token: 0x060001C0 RID: 448 RVA: 0x0000AF0C File Offset: 0x0000910C
	public bool FetchVelocity(int tagId, out Vector3 velocity)
	{
        velocity = default;

        return default;
    }

	// Token: 0x060001C1 RID: 449 RVA: 0x0000AF43 File Offset: 0x00009143
	public void Log(string message)
	{

	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000AF53 File Offset: 0x00009153
	public void LogVerbose(string message)
	{

	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000AF63 File Offset: 0x00009163
	public void LogWarning(string message)
	{

	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000AF73 File Offset: 0x00009173
	public void LogError(string message)
	{

	}

	// Token: 0x040001D1 RID: 465
	private Dictionary<int, GPSTagDriver> _tags;
}
}