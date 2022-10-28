using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200002C RID: 44
public class RotationOverlay : MonoBehaviour
{
	// Token: 0x060000DA RID: 218 RVA: 0x00006C06 File Offset: 0x00004E06
	private void Awake()
	{

	}

	// Token: 0x060000DB RID: 219 RVA: 0x00006C28 File Offset: 0x00004E28
	public void Setup(ComponentHandler target, int axisId, int secondAxisId = -1)
	{

	}

	// Token: 0x060000DC RID: 220 RVA: 0x00006D30 File Offset: 0x00004F30
	private void Update()
	{

	}

	// Token: 0x060000DD RID: 221 RVA: 0x00006DB6 File Offset: 0x00004FB6
	private void SetAxisColor(int axisId, Color color)
	{

	}

	// Token: 0x060000DE RID: 222 RVA: 0x00006DEF File Offset: 0x00004FEF
	public void CleanUp()
	{

	}

	// Token: 0x04000109 RID: 265
	public MeshRenderer[] axis;

	// Token: 0x0400010A RID: 266
	public float distance;

	// Token: 0x0400010B RID: 267
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400010C RID: 268
	private Transform _camera;

	// Token: 0x0400010D RID: 269
	private ComponentHandler _target;

	// Token: 0x0400010E RID: 270
	private bool _active;
}
}