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
// Token: 0x02000040 RID: 64
[Serializable]
public class PlasmaQualitySetting
{
	// Token: 0x0400022E RID: 558
	public string settingName;

	// Token: 0x0400022F RID: 559
	public int unityQualitySetting;

	// Token: 0x04000230 RID: 560
	public int shaderMaxLOD;

	// Token: 0x04000231 RID: 561
	public TerrainQuality terrainQ;

	// Token: 0x04000232 RID: 562
	public ReflectionProbesQuality refProbesQ;

	// Token: 0x04000233 RID: 563
	public LayerMask refProbesLayerMask;

	// Token: 0x04000234 RID: 564
	public bool grassRendererEnabled = true;

	// Token: 0x04000235 RID: 565
	public int grassMaxRenderDist = 200;

	// Token: 0x04000236 RID: 566
	public int grassGrassPerTri = 1000;

	// Token: 0x04000237 RID: 567
	public Vector2 grassLodParams = new Vector2(50f, 8f);

	// Token: 0x04000238 RID: 568
	public Vector2 grassTerrainLodChunks = new Vector2(25f, 25f);

	// Token: 0x04000239 RID: 569
	public PostEffectsQuality postEffectsQ;

	// Token: 0x0400023A RID: 570
	public HeightFogGlobalQuality heightFogQ;

	// Token: 0x0400023B RID: 571
	public string _;
}
}