using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000104 RID: 260
public class GrabDetectorAgent : Agent
{
	// Token: 0x06000A67 RID: 2663 RVA: 0x0003685C File Offset: 0x00034A5C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00036894 File Offset: 0x00034A94
	private void HandleOnOnDeviceGrabbed(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x000368CF File Offset: 0x00034ACF
	private void HandleOnOnDeviceReleased(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x000368D8 File Offset: 0x00034AD8
	protected override void OnCleanUpFinished()
	{

	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x000368FC File Offset: 0x00034AFC
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0003690C File Offset: 0x00034B0C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0400096D RID: 2413
	private AgentProperty _deviceProperty;

	// Token: 0x0400096E RID: 2414
	private bool _isGrabbed;

	// Token: 0x0400096F RID: 2415
	private bool _wasGrabbed;
}
}