using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Common.Extension;
using PlasmaAPI.GameClass.Common.Math;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000029 RID: 41
public class RotatorProcessData
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005F34 File Offset: 0x00004134
	public Vector3 socketRefDir
	{
		get
		{
			return this.socket.rotation * this.refDirInLocal;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005F4C File Offset: 0x0000414C
	public Vector3 attachmentRefDir
	{
		get
		{
			return this.socket.rotation * this.pivotLocal.rotation * this.refDirInLocal;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x00005F74 File Offset: 0x00004174
	// (set) Token: 0x060000C8 RID: 200 RVA: 0x00005F86 File Offset: 0x00004186
	public Vector3 pitchYawRoll
	{
		get
		{
			return this.pivotLocal.rotation.GetPlasmaAngles();
		}
		set
		{
			this.pivotLocal.rotation = QuaternionUtil.PlasmaAngles(value);
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x00005F9A File Offset: 0x0000419A
	public Vector3 refDirInLocal
	{
		get
		{
			return Vector3.forward;
		}
	}

	// Token: 0x040000EC RID: 236
	public QTransform socket;

	// Token: 0x040000ED RID: 237
	public QTransform pivotLocal;

	// Token: 0x040000EE RID: 238
	public ComponentHandler debug_activeComponent;
}
}