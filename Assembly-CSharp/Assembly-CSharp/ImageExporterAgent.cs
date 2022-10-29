using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000106 RID: 262
public class ImageExporterAgent : Agent
{
	// Token: 0x06000A73 RID: 2675 RVA: 0x00036BD7 File Offset: 0x00034DD7
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00036BFD File Offset: 0x00034DFD
	[SketchNodePortOperation(1)]
	public void Export(SketchNode sketchNode)
	{

	}

	// Token: 0x0400097B RID: 2427
	private AgentProperty _nameProperty;

	// Token: 0x0400097C RID: 2428
	private AgentProperty _imageProperty;
}
}