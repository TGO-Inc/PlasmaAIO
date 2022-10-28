using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000179 RID: 377
public class PlasmaProjectile : MonoBehaviour
{
	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000E5E RID: 3678 RVA: 0x000496D0 File Offset: 0x000478D0
	// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000496D8 File Offset: 0x000478D8
	public float powerOnArticulations { get; private set; }

	// Token: 0x06000E60 RID: 3680 RVA: 0x000496E4 File Offset: 0x000478E4
	public void Setup(Collider[] ignoreColliders, Vector3 velocity, float aPowerOnArticulations, float powerOnRigidBodies, bool useGravity)
	{

	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x0004979C File Offset: 0x0004799C
	private void HandleOnPhysicsTick()
	{

	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0004984C File Offset: 0x00047A4C
	private IEnumerator DelayedSuicide()
	{

        return default;
    }

	// Token: 0x06000E63 RID: 3683 RVA: 0x0004985B File Offset: 0x00047A5B
	public void OnCollisionEnter(Collision collision)
	{

	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00049884 File Offset: 0x00047A84
	private void Explode(bool hitTerrain)
	{

	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00049D24 File Offset: 0x00047F24
	private IEnumerator WaitForExplosion()
	{

        return default;
    }

	// Token: 0x06000E66 RID: 3686 RVA: 0x00049D33 File Offset: 0x00047F33
	private void OnDestroy()
	{

	}

	// Token: 0x04000BD3 RID: 3027
	public GameObject explosionEffect;

	// Token: 0x04000BD4 RID: 3028
	public SphereCollider sphereCollider;

	// Token: 0x04000BD5 RID: 3029
	[EventRef]
	public string explosionSound;

	// Token: 0x04000BD6 RID: 3030
	private Rigidbody _rigidbody;

	// Token: 0x04000BD7 RID: 3031
	private float _powerOnRigidBodies;

	// Token: 0x04000BD8 RID: 3032
	private Collider[] _hitColliders;

	// Token: 0x04000BD9 RID: 3033
	private bool _exploded;

	// Token: 0x04000BDA RID: 3034
	private Dictionary<ArticulationBody, Vector3> _articulations;

	// Token: 0x04000BDB RID: 3035
	private int _terrainLayer;

	// Token: 0x04000BDC RID: 3036
	private FloatRange _massRange;

	// Token: 0x04000BDD RID: 3037
	private const float _radius = 3f;

	// Token: 0x04000BDE RID: 3038
	private const int _maxColliders = 64;

	// Token: 0x04000BDF RID: 3039
	private const float _articulationPowerFactor = 80f;
}
}