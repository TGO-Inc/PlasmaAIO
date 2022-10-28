using System;
using UnityEngine;

// Token: 0x020000CD RID: 205
public class SevenSegmentDisplayDriver : ComponentDriver
{
	// Token: 0x06000919 RID: 2329 RVA: 0x00031C44 File Offset: 0x0002FE44
	public override void Awake()
	{

	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00031C94 File Offset: 0x0002FE94
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00031CEC File Offset: 0x0002FEEC
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00031E0C File Offset: 0x0003000C
	public override void OnTransparencyVFXExit()
	{

	}

	// Token: 0x04000868 RID: 2152
	public MeshRenderer meshRenderer;

	// Token: 0x04000869 RID: 2153
	private AgentProperty _stateProperty;

	// Token: 0x0400086A RID: 2154
	private AgentProperty _backgroundColorProperty;

	// Token: 0x0400086B RID: 2155
	private AgentProperty _foregroundColorProperty;

	// Token: 0x0400086C RID: 2156
	private AgentProperty _digitProperty;

	// Token: 0x0400086D RID: 2157
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400086E RID: 2158
	private int _emissionColorId;

	// Token: 0x0400086F RID: 2159
	private int _colorId;

	// Token: 0x04000870 RID: 2160
	private int _mainTexId;

	// Token: 0x04000871 RID: 2161
	private const float _flips = 10f;

	// Token: 0x04000872 RID: 2162
	private const float _offset = 0.16f;
}
