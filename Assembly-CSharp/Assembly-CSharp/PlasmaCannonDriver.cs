using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000B6 RID: 182
public class PlasmaCannonDriver : ComponentDriver
{
	// Token: 0x06000862 RID: 2146 RVA: 0x0002EEA9 File Offset: 0x0002D0A9
	public override void Awake()
	{

	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0002EECC File Offset: 0x0002D0CC
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0002EF04 File Offset: 0x0002D104
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000865 RID: 2149 RVA: 0x0002EF0C File Offset: 0x0002D10C
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0002EF49 File Offset: 0x0002D149
	private void ResetInnerColor()
	{

	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0002EF84 File Offset: 0x0002D184
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002F067 File Offset: 0x0002D267
	private IEnumerator Effect()
	{

        return default;
    }

	// Token: 0x040007BA RID: 1978
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040007BB RID: 1979
	public GameObject projectilePrefab;

	// Token: 0x040007BC RID: 1980
	public Transform spawnPoint;

	// Token: 0x040007BD RID: 1981
	public MeshRenderer meshRenderer;

	// Token: 0x040007BE RID: 1982
	public Color innerColor;

	// Token: 0x040007BF RID: 1983
	public float colorDuration;

	// Token: 0x040007C0 RID: 1984
	public Collider[] colliders;

	// Token: 0x040007C1 RID: 1985
	private AgentProperty _speedProperty;

	// Token: 0x040007C2 RID: 1986
	private AgentProperty _powerProperty;

	// Token: 0x040007C3 RID: 1987
	private AgentProperty _gravityProperty;

	// Token: 0x040007C4 RID: 1988
	private Coroutine _coroutine;

	// Token: 0x040007C5 RID: 1989
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040007C6 RID: 1990
	private int _colorId;

	// Token: 0x040007C7 RID: 1991
	private float _lastTime;

	// Token: 0x040007C8 RID: 1992
	private float _maxPowerOnRigidBodies = 20f;

	// Token: 0x040007C9 RID: 1993
	private const float _cooldown = 0.25f;
}
}