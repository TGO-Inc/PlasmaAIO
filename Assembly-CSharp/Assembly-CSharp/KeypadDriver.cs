using System;
using System.Collections.Generic;
using DG.Tweening;
using FMODUnity;
using UnityEngine;

// Token: 0x02000095 RID: 149
public class KeypadDriver : ComponentDriver
{
	// Token: 0x0600074C RID: 1868 RVA: 0x00029F30 File Offset: 0x00028130
	public override void Awake()
	{

	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00029F53 File Offset: 0x00028153
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00029F79 File Offset: 0x00028179
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00029F81 File Offset: 0x00028181
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00029F91 File Offset: 0x00028191
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00029FA0 File Offset: 0x000281A0
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000752 RID: 1874 RVA: 0x00029FE0 File Offset: 0x000281E0
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x06000753 RID: 1875 RVA: 0x0002A0BD File Offset: 0x000282BD
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0002A0DA File Offset: 0x000282DA
	private void AnimateButtonPress(Transform target)
	{

	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0002A11C File Offset: 0x0002831C
	private void SetLEDStripColor()
	{

	}

	// Token: 0x040006B0 RID: 1712
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040006B1 RID: 1713
	public List<MeshRenderer> meshRenderers;

	// Token: 0x040006B2 RID: 1714
	public Dictionary<KeypadAgent.Keys, Transform> keysMeshes;

	// Token: 0x040006B3 RID: 1715
	public Dictionary<Transform, KeypadAgent.Keys> keysColliders;

	// Token: 0x040006B4 RID: 1716
	public float restingKeyHeight;

	// Token: 0x040006B5 RID: 1717
	public float pressedKeyHeight;

	// Token: 0x040006B6 RID: 1718
	private AgentProperty _pressedKeyProperty;

	// Token: 0x040006B7 RID: 1719
	private AgentProperty _LEDKeyColorProperty;

	// Token: 0x040006B8 RID: 1720
	private KeypadAgent.Keys _pressedKey;

	// Token: 0x040006B9 RID: 1721
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040006BA RID: 1722
	private int _colorId;

	// Token: 0x040006BB RID: 1723
	private const string _FMODParamKeypad = "Keypad";

	// Token: 0x040006BC RID: 1724
	private const string _FMODParamSize = "Size";
}
