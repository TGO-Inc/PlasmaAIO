using System;
using FMODUnity;
using UnityEngine;

// Token: 0x020000B2 RID: 178
public class ParticleEmitterCommonDriver : ComponentDriver
{
	// Token: 0x0600083C RID: 2108 RVA: 0x0002E4E9 File Offset: 0x0002C6E9
	public override void Awake()
	{

	}

	// Token: 0x0600083D RID: 2109 RVA: 0x0002E514 File Offset: 0x0002C714
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x0600083E RID: 2110 RVA: 0x0002E538 File Offset: 0x0002C738
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x0600083F RID: 2111 RVA: 0x0002E55C File Offset: 0x0002C75C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0002E620 File Offset: 0x0002C820
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000841 RID: 2113 RVA: 0x0002E64D File Offset: 0x0002C84D
	public override void OnResetFinished()
	{

	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0002E65C File Offset: 0x0002C85C
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0002E722 File Offset: 0x0002C922
	public override void OnPropertyEditorOpen()
	{

	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0002E73C File Offset: 0x0002C93C
	public override void OnPropertyEditorClose()
	{

	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0002E74C File Offset: 0x0002C94C
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0002E80B File Offset: 0x0002CA0B
	public override void OnScaleChanged()
	{

	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0002E814 File Offset: 0x0002CA14
	private void UpdateVisuals()
	{

	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0002E94C File Offset: 0x0002CB4C
	private void OnDestroy()
	{

	}

	// Token: 0x04000794 RID: 1940
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000795 RID: 1941
	public ParticleSystem smokeSystem;

	// Token: 0x04000796 RID: 1942
	private AgentProperty _stateProperty;

	// Token: 0x04000797 RID: 1943
	private AgentProperty _speedProperty;

	// Token: 0x04000798 RID: 1944
	private AgentProperty _lifetimeProperty;

	// Token: 0x04000799 RID: 1945
	private AgentProperty _sizeProperty;

	// Token: 0x0400079A RID: 1946
	private AgentProperty _spreadProperty;

	// Token: 0x0400079B RID: 1947
	private AgentProperty _colorProperty;

	// Token: 0x0400079C RID: 1948
	private AgentProperty _transparencyProperty;

	// Token: 0x0400079D RID: 1949
	private FloatRange _scaleRange;

	// Token: 0x0400079E RID: 1950
	protected int _statePropertyId;

	// Token: 0x0400079F RID: 1951
	protected int _speedPropertyId;

	// Token: 0x040007A0 RID: 1952
	protected int _lifetimePropertyId;

	// Token: 0x040007A1 RID: 1953
	protected int _sizePropertyId;

	// Token: 0x040007A2 RID: 1954
	protected int _spreadPropertyId;

	// Token: 0x040007A3 RID: 1955
	protected int _colorPropertyId;

	// Token: 0x040007A4 RID: 1956
	protected int _transparencyPropertyId;

	// Token: 0x040007A5 RID: 1957
	protected int _setStateCommandId;

	// Token: 0x040007A6 RID: 1958
	protected int _updateVisualsCommandId;
}
