using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200016A RID: 362
public class DynamicPropsManager : MonoBehaviour
{
	// Token: 0x06000E18 RID: 3608 RVA: 0x00047B10 File Offset: 0x00045D10
	private void AssignIds()
	{

	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00047C6C File Offset: 0x00045E6C
	private void Awake()
	{

	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00047CB4 File Offset: 0x00045EB4
	public void StoreInterpolationState()
	{

	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00047D0C File Offset: 0x00045F0C
	public void InterpolateAndBoundsCheck(float d, Vector3 worldCenter, float worldRadiusSquared)
	{

	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00047DFC File Offset: 0x00045FFC
	public SerializedPropsManager Serialize()
	{

        return default;
    }

	// Token: 0x06000E1D RID: 3613 RVA: 0x00047ECC File Offset: 0x000460CC
	public void Load(SerializedPropsManager serializedPropsManager)
	{

	}

	// Token: 0x04000B86 RID: 2950
	private Dictionary<int, DynamicProp> _registeredProps;
}
}