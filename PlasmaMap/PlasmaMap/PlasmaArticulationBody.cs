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
// Token: 0x02000176 RID: 374
public class PlasmaArticulationBody : MonoBehaviour
{
	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00049610 File Offset: 0x00047810
	// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00049618 File Offset: 0x00047818
	public SubComponentHandler subComponentHandler { get; set; }
}
}