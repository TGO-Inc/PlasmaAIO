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

namespace PlasmaAPI.GameClass {
// Token: 0x0200000C RID: 12
public class TabItem : MonoBehaviour
{
	// Token: 0x0600005B RID: 91 RVA: 0x00003466 File Offset: 0x00001666
	public void Toggled(bool value)
	{

	}

	// Token: 0x04000047 RID: 71
	public UIBetterToggleColorMapper normalMapper;

	// Token: 0x04000048 RID: 72
	public UIBetterToggleColorMapper selectedMapper;
}
}