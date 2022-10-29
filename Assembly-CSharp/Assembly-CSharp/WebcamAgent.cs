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
// Token: 0x020000E6 RID: 230
public class WebcamAgent : Agent, IDataSelectionProvider
{
	// Token: 0x060009CC RID: 2508 RVA: 0x0003434A File Offset: 0x0003254A
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0003435E File Offset: 0x0003255E
	protected override void OnBeforeCopyConfiguredToRuntimeProperties()
	{

	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00034367 File Offset: 0x00032567
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00034374 File Offset: 0x00032574
	private void ValidateWebcam(bool applyToRuntime)
	{

	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x000343F9 File Offset: 0x000325F9
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x060009D1 RID: 2513 RVA: 0x00034410 File Offset: 0x00032610
	public override void AllocResources()
	{

	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00034514 File Offset: 0x00032714
	public override void DeallocResources()
	{

	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00034560 File Offset: 0x00032760
	public static Dictionary<int, string> GetDynamicOptions()
	{

        return default;
    }

	// Token: 0x060009D4 RID: 2516 RVA: 0x000345B8 File Offset: 0x000327B8
	public static string GetDynamicOption(int id)
	{

        return default;
    }

	// Token: 0x060009D5 RID: 2517 RVA: 0x000345E3 File Offset: 0x000327E3
	public override void ValidateSelectionForProperty(int id)
	{

	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x000345F0 File Offset: 0x000327F0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x0003462B File Offset: 0x0003282B
	[SketchNodePortOperation(1)]
	public void TakePicture(SketchNode sketchNode)
	{

	}

	// Token: 0x040008FE RID: 2302
	public Data.Image feedData;

	// Token: 0x040008FF RID: 2303
	public Data.Image pictureData;

	// Token: 0x04000900 RID: 2304
	public Data.Image webcamData;

	// Token: 0x04000901 RID: 2305
	private AgentProperty _stateProperty;

	// Token: 0x02000398 RID: 920
	public enum Commands
	{
		// Token: 0x04001C9B RID: 7323
		SetState = 1,
		// Token: 0x04001C9C RID: 7324
		RenderFeed,
		// Token: 0x04001C9D RID: 7325
		TakePicture,
		// Token: 0x04001C9E RID: 7326
		SetWebcam
	}
}
}