using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000178 RID: 376
public class PlasmaPhysicsConstraintConstantRelativeForce : PlasmaPhysicsConstraint
{
	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00049633 File Offset: 0x00047833
	// (set) Token: 0x06000E57 RID: 3671 RVA: 0x0004963B File Offset: 0x0004783B
	public ArticulationBody targetBody { get; set; }

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00049644 File Offset: 0x00047844
	// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0004964C File Offset: 0x0004784C
	public Transform targetTransform { get; set; }

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00049655 File Offset: 0x00047855
	// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0004965D File Offset: 0x0004785D
	public Vector3 force { get; set; }

	// Token: 0x06000E5C RID: 3676 RVA: 0x00049668 File Offset: 0x00047868
	public override void Tick()
	{

	}
}
}