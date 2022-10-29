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
using System.Globalization;
using Behavior;
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x0200013F RID: 319
public class VectorDecomposerAgent : Agent
{
	// Token: 0x06000BB0 RID: 2992 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x0003CF1C File Offset: 0x0003B11C
	[SketchNodePortOperation(1)]
	public void Decompose(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x0003CF84 File Offset: 0x0003B184
	[SketchNodePortOperation(2)]
	public void Mask(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0003D01C File Offset: 0x0003B21C
	private List<float> GetComponents(SketchNode sketchNode)
	{

        return default;
    }

	// Token: 0x04000A6B RID: 2667
	private AgentProperty _vectorProperty;

	// Token: 0x04000A6C RID: 2668
	private AgentProperty _maskXProperty;

	// Token: 0x04000A6D RID: 2669
	private AgentProperty _maskYProperty;

	// Token: 0x04000A6E RID: 2670
	private AgentProperty _maskZProperty;
}
}