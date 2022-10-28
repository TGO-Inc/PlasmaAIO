using System;
using Behavior;
using MoonSharp.Interpreter;

// Token: 0x0200010D RID: 269
public class LUAProgramAgent : LUACommonAgent
{
	// Token: 0x06000AA2 RID: 2722 RVA: 0x00037DA0 File Offset: 0x00035FA0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00037E8B File Offset: 0x0003608B
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00037EAC File Offset: 0x000360AC
	[AgentPropertyHandler(1)]
	public void HandleSource(AgentProperty property)
	{

	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00037FA8 File Offset: 0x000361A8
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x000380B4 File Offset: 0x000362B4
	[SketchNodePortOperation(1)]
	public void Start(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00038118 File Offset: 0x00036318
	[SketchNodePortOperation(2)]
	public void CallFunction(SketchNode sketchNode)
	{

	}

	// Token: 0x0400099C RID: 2460
	private AgentProperty _runningProperty;

	// Token: 0x0400099D RID: 2461
	private AgentProperty _functionNameProperty;

	// Token: 0x0400099E RID: 2462
	private DynValue _setupEntryPoint;

	// Token: 0x0400099F RID: 2463
	private DynValue _loopEntryPoint;

	// Token: 0x040009A0 RID: 2464
	private DynValue _isDoneEntryPoint;
}
