using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000108 RID: 264
public class LoggerAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A80 RID: 2688 RVA: 0x00036DF4 File Offset: 0x00034FF4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00036E1C File Offset: 0x0003501C
	[SketchNodePortOperation(1)]
	public void Log(SketchNode sketchNode)
	{

	}

	// Token: 0x04000982 RID: 2434
	private AgentProperty _messageProperty;

	// Token: 0x04000983 RID: 2435
	private AgentProperty _levelProperty;
}
}