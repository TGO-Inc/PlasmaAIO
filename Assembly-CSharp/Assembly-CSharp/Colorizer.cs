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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000145 RID: 325
public class Colorizer : MonoBehaviour
{
	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0003D8F2 File Offset: 0x0003BAF2
	// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0003D8FA File Offset: 0x0003BAFA
	public int colorId { get; private set; }

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0003D903 File Offset: 0x0003BB03
	// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0003D90B File Offset: 0x0003BB0B
	public int altColorId { get; private set; }

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0003D914 File Offset: 0x0003BB14
	private void Awake()
	{

	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0003D924 File Offset: 0x0003BB24
	public void SetColorFromPalette(int theColorId, bool secondary)
	{

	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
	public void SetStructureColor()
	{

	}

	// Token: 0x04000A77 RID: 2679
	public List<MeshRenderer> renderers;

	// Token: 0x04000A78 RID: 2680
	private MaterialPropertyBlock _propertyBlock;
}
}