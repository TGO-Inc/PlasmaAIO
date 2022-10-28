using System;
using UnityEngine;

// Token: 0x020000D9 RID: 217
public class SpotlightDriver : ComponentDriver
{
	// Token: 0x0600097A RID: 2426 RVA: 0x0003317C File Offset: 0x0003137C
	public override void Awake()
	{

	}

	// Token: 0x0600097B RID: 2427 RVA: 0x000331D0 File Offset: 0x000313D0
	private void HandleQualitySettingsChanged()
	{

	}

	// Token: 0x0600097C RID: 2428 RVA: 0x000331E8 File Offset: 0x000313E8
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0003324F File Offset: 0x0003144F
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00033267 File Offset: 0x00031467
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600097F RID: 2431 RVA: 0x0003327F File Offset: 0x0003147F
	private void CommonUpdate()
	{

	}

	// Token: 0x06000980 RID: 2432 RVA: 0x000332AC File Offset: 0x000314AC
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000981 RID: 2433 RVA: 0x000332F3 File Offset: 0x000314F3
	public override void OnScaleChanged()
	{

	}

	// Token: 0x06000982 RID: 2434 RVA: 0x000332FC File Offset: 0x000314FC
	private void SetColorAndIntensity()
	{

	}

	// Token: 0x06000983 RID: 2435 RVA: 0x000333C0 File Offset: 0x000315C0
	private void SetAngle()
	{

	}

	// Token: 0x06000984 RID: 2436 RVA: 0x000333D8 File Offset: 0x000315D8
	private void SetRange()
	{

	}

	// Token: 0x06000985 RID: 2437 RVA: 0x000333F0 File Offset: 0x000315F0
	private void OnDestroy()
	{

	}

	// Token: 0x040008B8 RID: 2232
	public MeshRenderer meshRenderer;

	// Token: 0x040008B9 RID: 2233
	public Light spotlight;

	// Token: 0x040008BA RID: 2234
	private AgentProperty _stateProperty;

	// Token: 0x040008BB RID: 2235
	private AgentProperty _intensityProperty;

	// Token: 0x040008BC RID: 2236
	private AgentProperty _colorProperty;

	// Token: 0x040008BD RID: 2237
	private AgentProperty _angleProperty;

	// Token: 0x040008BE RID: 2238
	private AgentProperty _rangeProperty;

	// Token: 0x040008BF RID: 2239
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040008C0 RID: 2240
	private int _colorId;
}
