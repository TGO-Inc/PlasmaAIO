using System;
using Behavior;
using UnityEngine;

// Token: 0x020000D2 RID: 210
public class SmallerHingeAgent : Agent
{
	// Token: 0x06000945 RID: 2373 RVA: 0x000324F0 File Offset: 0x000306F0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00032516 File Offset: 0x00030716
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000947 RID: 2375 RVA: 0x0003252C File Offset: 0x0003072C
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00032538 File Offset: 0x00030738
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000325C0 File Offset: 0x000307C0
	[AgentPropertyHandler(1)]
	public void HandleTargetPosition(AgentProperty property)
	{

	}

	// Token: 0x04000893 RID: 2195
	private AgentProperty _targetRotationProperty;

	// Token: 0x04000894 RID: 2196
	private AgentProperty _currentRotationProperty;

	// Token: 0x04000895 RID: 2197
	private bool _canTrigger;

	// Token: 0x04000896 RID: 2198
	private bool _shouldTrigger;

	// Token: 0x04000897 RID: 2199
	private const float _tolerance = 1f;

	// Token: 0x0200038D RID: 909
	public enum Commands
	{
		// Token: 0x04001C6D RID: 7277
		SetPhysics = 1
	}
}
