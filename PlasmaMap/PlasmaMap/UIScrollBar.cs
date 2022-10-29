using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using DG.Tweening;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200001B RID: 27
public class UIScrollBar : MonoBehaviour
{
	// Token: 0x06000081 RID: 129 RVA: 0x00004940 File Offset: 0x00002B40
	public void Setup(UISmoothScrollList scrollList)
	{

	}

	// Token: 0x06000082 RID: 130 RVA: 0x000049FC File Offset: 0x00002BFC
	public void UpdatePosition(int topItemIndex)
	{

	}

	// Token: 0x0400009F RID: 159
	public RectTransform bar;

	// Token: 0x040000A0 RID: 160
	public float areaHeight;

	// Token: 0x040000A1 RID: 161
	public float minBarHeight;

	// Token: 0x040000A2 RID: 162
	public float topY;

	// Token: 0x040000A3 RID: 163
	private UISmoothScrollList _scrollList;

	// Token: 0x040000A4 RID: 164
	private float _positionIncrement;
}
}