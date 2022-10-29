using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000EC RID: 236
public class DisplayUIText : DisplayUIElement
{
	// Token: 0x060009FC RID: 2556 RVA: 0x00034CE6 File Offset: 0x00032EE6
	public DisplayUIText()
	{

	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00034CF5 File Offset: 0x00032EF5
	public override bool IsWithinRect(Vector2Int position)
	{

        return default;
    }

	// Token: 0x060009FE RID: 2558 RVA: 0x00034CF8 File Offset: 0x00032EF8
	public override void CreateUI(Transform container)
	{

	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00034D96 File Offset: 0x00032F96
	public override GameObject GetPrefab()
	{

        return default;
    }

	// Token: 0x0400091D RID: 2333
	public string text;

	// Token: 0x0400091E RID: 2334
	public int fontSize;

	// Token: 0x0400091F RID: 2335
	public int horizontalAlignment;
}
}