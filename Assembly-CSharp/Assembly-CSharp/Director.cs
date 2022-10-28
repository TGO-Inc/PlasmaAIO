using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000163 RID: 355
[CanSpill(true)]
public class Director : Controller
{
	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x000476EF File Offset: 0x000458EF
	// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x000476F7 File Offset: 0x000458F7
	public bool playing { get; set; }

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00047700 File Offset: 0x00045900
	[Spill]
	public float currentTime
	{
		get
		{
			return this._currentTime;
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00047708 File Offset: 0x00045908
	public int currentDay
	{
		get
		{
			return this._currentDay;
		}
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00047710 File Offset: 0x00045910
	public override void Init()
	{

	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00047738 File Offset: 0x00045938
	private void Update()
	{

	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x0004779C File Offset: 0x0004599C
	public void AdvanceTime(float hours = 1f)
	{

	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x000477AC File Offset: 0x000459AC
	public void AdvanceTimeTo(float newTime)
	{

	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x000477CE File Offset: 0x000459CE
	public void SetTime(float time)
	{

	}

	// Token: 0x04000B58 RID: 2904
	public float startTime;

	// Token: 0x04000B59 RID: 2905
	public float clockSpeedModifier = 1f;

	// Token: 0x04000B5A RID: 2906
	public float secondsPerInGameHour = 5f;

	// Token: 0x04000B5B RID: 2907
	public FloatRange sunriseTimeFrame;

	// Token: 0x04000B5C RID: 2908
	public FloatRange sunsetTimeFrame;

	// Token: 0x04000B5D RID: 2909
	private int _currentDay;

	// Token: 0x04000B5E RID: 2910
	private float _currentTime;

	// Token: 0x04000B5F RID: 2911
	private float _gameHoursPerSecond;
}
}