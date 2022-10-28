using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000017 RID: 23
public class UIColorMapperController : MonoBehaviour
{
	// Token: 0x06000076 RID: 118 RVA: 0x00004630 File Offset: 0x00002830
	private void Awake()
	{

	}

	// Token: 0x06000077 RID: 119 RVA: 0x00004640 File Offset: 0x00002840
	public void GatherMappers()
	{

	}

	// Token: 0x06000078 RID: 120 RVA: 0x000046E4 File Offset: 0x000028E4
	public void ApplyMapper(string label, bool force = false)
	{

	}

	// Token: 0x04000096 RID: 150
	public bool includeInactive;

	// Token: 0x04000097 RID: 151
	private Dictionary<string, List<UIColorMapper>> _colorMappers;
}
}