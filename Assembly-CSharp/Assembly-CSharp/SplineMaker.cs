using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace PlasmaAPI.GameClass {
// Token: 0x0200019B RID: 411
[ExecuteInEditMode]
public class SplineMaker : MonoBehaviour
{
	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0004EC2F File Offset: 0x0004CE2F
	// (set) Token: 0x06000F5A RID: 3930 RVA: 0x0004EC37 File Offset: 0x0004CE37
	public int pointsPerSegment
	{
		get
		{
			return this._pointsPerSegment;
		}
		set
		{
			this._pointsPerSegment = Mathf.Max(0, value);
			this._isDirty = true;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000F5B RID: 3931 RVA: 0x0004EC4D File Offset: 0x0004CE4D
	// (set) Token: 0x06000F5C RID: 3932 RVA: 0x0004EC55 File Offset: 0x0004CE55
	public bool loop
	{
		get
		{
			return this._loop;
		}
		set
		{
			this._loop = value;
			this._isDirty = true;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0004EC65 File Offset: 0x0004CE65
	// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0004EC6D File Offset: 0x0004CE6D
	public Vector3[] anchorPoints
	{
		get
		{
			return this._anchorPoints;
		}
		set
		{
			this._anchorPoints = value;
			this._isDirty = true;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0004EC7D File Offset: 0x0004CE7D
	public Vector3[] points
	{
		get
		{
			return this._points;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004EC85 File Offset: 0x0004CE85
	public SplineMaker.Vector3ArrayEvent onUpdated
	{
		get
		{
			return this._onUpdated;
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x0004EC8D File Offset: 0x0004CE8D
	private void Awake()
	{

	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x0004ECC3 File Offset: 0x0004CEC3
	private void Update()
	{

	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x0004ECF4 File Offset: 0x0004CEF4
	private void UpdatePoints()
	{

	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x0004EFA2 File Offset: 0x0004D1A2
	private void OnValidate()
	{

	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x0004EFC8 File Offset: 0x0004D1C8
	private void OnDidApplyAnimationProperties()
	{

	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x0004EFD0 File Offset: 0x0004D1D0
	private static Vector3 CatmullRomInterpolation(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{

        return default;
    }

	// Token: 0x04000CDF RID: 3295
	[SerializeField]
	private int _pointsPerSegment = 8;

	// Token: 0x04000CE0 RID: 3296
	[SerializeField]
	private bool _loop;

	// Token: 0x04000CE1 RID: 3297
	[SerializeField]
	private Vector3[] _anchorPoints = new Vector3[0];

	// Token: 0x04000CE2 RID: 3298
	[SerializeField]
	private SplineMaker.Vector3ArrayEvent _onUpdated = new SplineMaker.Vector3ArrayEvent();

	// Token: 0x04000CE3 RID: 3299
	private bool _isDirty = true;

	// Token: 0x04000CE4 RID: 3300
	private Vector3[] _points;

	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class Vector3ArrayEvent : UnityEvent<Vector3[]>
	{
	}
}
}