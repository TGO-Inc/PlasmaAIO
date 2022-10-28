using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000059 RID: 89
public class AccelerometerDriver : ComponentDriver
{
	// Token: 0x0600058E RID: 1422 RVA: 0x0002145C File Offset: 0x0001F65C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600058F RID: 1423 RVA: 0x000214C8 File Offset: 0x0001F6C8
	public override void OnReset()
	{

	}

	// Token: 0x06000590 RID: 1424 RVA: 0x000214D6 File Offset: 0x0001F6D6
	public override void OnMount()
	{

	}

	// Token: 0x06000591 RID: 1425 RVA: 0x000214EF File Offset: 0x0001F6EF
	public override void OnUnmount()
	{

	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00021508 File Offset: 0x0001F708
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x040004DD RID: 1245
	private AgentProperty _propertyX;

	// Token: 0x040004DE RID: 1246
	private AgentProperty _propertyY;

	// Token: 0x040004DF RID: 1247
	private AgentProperty _propertyZ;

	// Token: 0x040004E0 RID: 1248
	private AgentProperty _propertyWorldspace;

	// Token: 0x040004E1 RID: 1249
	private Vector3? _previousPosition;

	// Token: 0x040004E2 RID: 1250
	private Vector3? _previousVelocity;

	// Token: 0x040004E3 RID: 1251
	private Transform _transform;
}
}