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
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000143 RID: 323
public class WorldCreatorAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000BCA RID: 3018 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0003D7DC File Offset: 0x0003B9DC
	public static Dictionary<int, string> GetDynamicOptions()
	{

        return default;
    }

	// Token: 0x06000BCC RID: 3020 RVA: 0x0003D858 File Offset: 0x0003BA58
	public static string GetDynamicOption(int id)
	{

        return default;
    }

	// Token: 0x06000BCD RID: 3021 RVA: 0x0003D874 File Offset: 0x0003BA74
	[SketchNodePortOperation(1)]
	public void Create(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A75 RID: 2677
	private AgentProperty _biomeProperty;
}
}