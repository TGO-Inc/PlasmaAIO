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
using DG.Tweening;
using PlasmaAPI.GameClass.EasyFSM;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000034 RID: 52
public class Controllers : MonoBehaviour
{
	// Token: 0x06000122 RID: 290 RVA: 0x00008414 File Offset: 0x00006614
	private void Awake()
	{

	}

	// Token: 0x06000123 RID: 291 RVA: 0x000084D7 File Offset: 0x000066D7
	private void Start()
	{

	}

	// Token: 0x06000124 RID: 292 RVA: 0x000084E4 File Offset: 0x000066E4
	private static T Init<T>() where T : Controller
	{

        return default;
    }

	// Token: 0x0400014F RID: 335
	public static WorldController worldController;

	// Token: 0x04000150 RID: 336
	public static AssetController assetController;

	// Token: 0x04000151 RID: 337
	public static WifiController wifiController;

	// Token: 0x04000152 RID: 338
	public static GPSController gpsController;

	// Token: 0x04000153 RID: 339
	public static VisorUIController visorUIController;

	// Token: 0x04000154 RID: 340
	public static DebugToolsController debugToolsController;

	// Token: 0x04000155 RID: 341
	public static RenderQueueController renderQueueController;

	// Token: 0x04000156 RID: 342
	public static EasyFSMController easyFSMController;

	// Token: 0x04000157 RID: 343
	public static AudioController audioController;

	// Token: 0x04000158 RID: 344
	public static List<Controller> controllers;
}
}