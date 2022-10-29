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
using PlasmaAPI.GameClass.Visor;

namespace PlasmaAPI.GameClass {
// Token: 0x02000028 RID: 40
public class ScrollWheelCatcher : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	// Token: 0x060000C2 RID: 194 RVA: 0x00005EFA File Offset: 0x000040FA
	private void Awake()
	{

	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00005F0D File Offset: 0x0000410D
	public void OnScroll(PointerEventData eventData)
	{

	}

	// Token: 0x040000EB RID: 235
	private PropertyList _propertyList;
}
}