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
// Token: 0x02000135 RID: 309
public class TutorialVideoPlayer : Agent, IDataSelectionProvider
{
	// Token: 0x06000B85 RID: 2949 RVA: 0x0003BE84 File Offset: 0x0003A084
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0003BE98 File Offset: 0x0003A098
	[SketchNodePortOperation(1)]
	public void Open(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x0003BEB4 File Offset: 0x0003A0B4
	[SketchNodePortOperation(2)]
	public void Close(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A33 RID: 2611
	private AgentProperty _videoClipProperty;
}
}