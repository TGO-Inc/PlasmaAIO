using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using MoonSharp.Interpreter;

namespace PlasmaAPI.GameClass {
// Token: 0x0200010C RID: 268
public class LUAFunctionAgent : LUACommonAgent
{
	// Token: 0x06000A9D RID: 2717 RVA: 0x00037BF4 File Offset: 0x00035DF4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00037CB9 File Offset: 0x00035EB9
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00037CCC File Offset: 0x00035ECC
	[AgentPropertyHandler(1)]
	public void HandleSource(AgentProperty property)
	{

	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00037D44 File Offset: 0x00035F44
	[SketchNodePortOperation(1)]
	public void Call(SketchNode sketchNode)
	{

	}

	// Token: 0x0400099B RID: 2459
	private DynValue _entryPoint;
}
}