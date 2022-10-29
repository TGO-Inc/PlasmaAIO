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
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x020000F9 RID: 249
public class DeviceListenerAgent : Agent
{
	// Token: 0x06000A2F RID: 2607 RVA: 0x00035BD4 File Offset: 0x00033DD4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00035C58 File Offset: 0x00033E58
	private void HandleOnDeviceSpawned(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00035C68 File Offset: 0x00033E68
	private void HandleOnDeviceLoaded(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00035C71 File Offset: 0x00033E71
	private void HandleOnDeviceDeleted(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00035C7A File Offset: 0x00033E7A
	private void HandleOnOnDeviceGrabbed(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00035C8A File Offset: 0x00033E8A
	private void HandleOnOnDeviceReleased(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00035C93 File Offset: 0x00033E93
	private void HandleOnComponentAttached(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00035CA3 File Offset: 0x00033EA3
	private void HandleOnDeviceStateToggled(int guid)
	{

	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00035CC0 File Offset: 0x00033EC0
	protected override void OnCleanUpFinished()
	{

	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00035D44 File Offset: 0x00033F44
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00035F8C File Offset: 0x0003418C
	private static string GetDeviceState(string deviceName)
	{

        return default;
    }

	// Token: 0x04000952 RID: 2386
	private string _relevantComponent;

	// Token: 0x04000953 RID: 2387
	private string _spawnedDevice;

	// Token: 0x04000954 RID: 2388
	private string _deletedDevice;

	// Token: 0x04000955 RID: 2389
	private string _loadedDevice;

	// Token: 0x04000956 RID: 2390
	private string _grabbedDevice;

	// Token: 0x04000957 RID: 2391
	private string _releasedDevice;

	// Token: 0x04000958 RID: 2392
	private string _modifiedDevice;

	// Token: 0x04000959 RID: 2393
	private string _toggledDevice;
}
}