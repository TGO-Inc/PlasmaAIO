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
// Token: 0x02000142 RID: 322
public class WindowOpenerAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000BC5 RID: 3013 RVA: 0x0003D6F7 File Offset: 0x0003B8F7
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0003D70C File Offset: 0x0003B90C
	public static Dictionary<int, string> GetDynamicOptions()
	{

        return default;
    }

	// Token: 0x06000BC7 RID: 3015 RVA: 0x0003D788 File Offset: 0x0003B988
	public static string GetDynamicOption(int id)
	{

        return default;
    }

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0003D7A4 File Offset: 0x0003B9A4
	[SketchNodePortOperation(1)]
	public void Open(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A74 RID: 2676
	private AgentProperty _windowProperty;
}
}