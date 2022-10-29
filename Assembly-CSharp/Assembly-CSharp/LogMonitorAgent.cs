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
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200010A RID: 266
public class LogMonitorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A89 RID: 2697 RVA: 0x00037208 File Offset: 0x00035408
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00037258 File Offset: 0x00035458
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0003726B File Offset: 0x0003546B
	public override void OnNodeMapped(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0003728C File Offset: 0x0003548C
	private void HandleSketchNotification(SketchNotifications.Notification notification)
	{

	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0003733C File Offset: 0x0003553C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000989 RID: 2441
	private AgentProperty _levelProperty;

	// Token: 0x0400098A RID: 2442
	private Dictionary<SketchNotifications.Levels, string> _currentNotifications;

	// Token: 0x0400098B RID: 2443
	private SketchNotificationStrings _sketchNotificationStrings;
}
}