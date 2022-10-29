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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000081 RID: 129
public class FrameDriver : ComponentDriver
{
	// Token: 0x060006A3 RID: 1699 RVA: 0x0002637C File Offset: 0x0002457C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x000263DC File Offset: 0x000245DC
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x000263E4 File Offset: 0x000245E4
	private void RenderContent()
	{

	}

	// Token: 0x04000601 RID: 1537
	public MeshRenderer imageMeshRenderer;

	// Token: 0x04000602 RID: 1538
	private FrameAgent _frameAgent;

	// Token: 0x04000603 RID: 1539
	private AgentProperty _contentProperty;
}
}