using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000148 RID: 328
public class ComponentMeshHandler : MonoBehaviour
{
	// Token: 0x06000CBE RID: 3262 RVA: 0x00040779 File Offset: 0x0003E979
	private void Awake()
	{

	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x0004079C File Offset: 0x0003E99C
	public void SetMeshColliderObjectEnabled(bool value)
	{

	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x000407F0 File Offset: 0x0003E9F0
	public void SetMeshCollidersLayer(int layer)
	{

	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x00040844 File Offset: 0x0003EA44
	public void StoreState()
	{

	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x0004089C File Offset: 0x0003EA9C
	public void StoreLocalTransform()
	{

	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x00040940 File Offset: 0x0003EB40
	public void Interpolate(float delta)
	{

	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x000409D4 File Offset: 0x0003EBD4
	public void UpdateLocalTransform()
	{

	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00040A46 File Offset: 0x0003EC46
	public void RenderOntoSolidComponent()
	{

	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00040A80 File Offset: 0x0003EC80
	public void OverrideTransforms()
	{

	}

	// Token: 0x04000AA7 RID: 2727
	public SubComponentHandler subComponent;

	// Token: 0x04000AA8 RID: 2728
	public List<GameObject> meshColliderGameObjects;

	// Token: 0x04000AA9 RID: 2729
	protected ComponentMeshHandler.StoredTransform[] _storedTransforms;

	// Token: 0x04000AAA RID: 2730
	private int _index;

	// Token: 0x04000AAB RID: 2731
	public Vector3 _localPosition;

	// Token: 0x04000AAC RID: 2732
	public Quaternion _localRotation;

	// Token: 0x020003A6 RID: 934
	protected struct StoredTransform
	{
		// Token: 0x04001CC9 RID: 7369
		public Vector3 position;

		// Token: 0x04001CCA RID: 7370
		public Quaternion rotation;
	}
}
}