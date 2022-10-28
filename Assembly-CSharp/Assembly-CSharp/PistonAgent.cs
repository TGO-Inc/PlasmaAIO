using System;
using Behavior;

// Token: 0x020000B3 RID: 179
public class PistonAgent : Agent
{
	// Token: 0x0600084A RID: 2122 RVA: 0x0002E978 File Offset: 0x0002CB78
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600084B RID: 2123 RVA: 0x0002E99E File Offset: 0x0002CB9E
	public override void OnDeviceReset()
	{

	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0002E9B4 File Offset: 0x0002CBB4
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0002E9BD File Offset: 0x0002CBBD
	protected override void OnDriverSet()
	{

	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0002EA44 File Offset: 0x0002CC44
	[AgentPropertyHandler(1)]
	public void HandleTargetPosition(AgentProperty property)
	{

	}

	// Token: 0x040007A7 RID: 1959
	private AgentProperty _targetPositionProperty;

	// Token: 0x040007A8 RID: 1960
	private AgentProperty _currentPositionProperty;

	// Token: 0x040007A9 RID: 1961
	private PistonDriver _driver;

	// Token: 0x040007AA RID: 1962
	private bool _canTrigger;

	// Token: 0x040007AB RID: 1963
	private bool _shouldTrigger;

	// Token: 0x040007AC RID: 1964
	private const float _tolerance = 0.01f;

	// Token: 0x02000376 RID: 886
	public enum Commands
	{
		// Token: 0x04001C28 RID: 7208
		SetPhysics = 1
	}
}
