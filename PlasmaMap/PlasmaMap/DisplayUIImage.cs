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
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x020000EE RID: 238
public class DisplayUIImage : DisplayUIElement
{
	// Token: 0x06000A07 RID: 2567 RVA: 0x00034ECB File Offset: 0x000330CB
	public DisplayUIImage()
	{

	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00034EFA File Offset: 0x000330FA
	public override bool IsWithinRect(Vector2Int position)
	{

        return default;
    }

	// Token: 0x06000A09 RID: 2569 RVA: 0x00034EFD File Offset: 0x000330FD
	public override void CreateUI(Transform container)
	{

	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00034F26 File Offset: 0x00033126
	public override GameObject GetPrefab()
	{

        return default;
    }

	// Token: 0x0400092B RID: 2347
	public int index;
}
}