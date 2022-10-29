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
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x02000023 RID: 35
public class ScrollRectNoDragging : ScrollRect
{
	// Token: 0x060000A8 RID: 168 RVA: 0x000057E8 File Offset: 0x000039E8
	protected override void Start()
	{

	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00005835 File Offset: 0x00003A35
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00005837 File Offset: 0x00003A37
	public override void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00005839 File Offset: 0x00003A39
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000583C File Offset: 0x00003A3C
	public void ResizeToFitContent()
	{

	}
}
}