using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000003 RID: 3
public class ScreenerItem : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002104 File Offset: 0x00000304
	// (set) Token: 0x06000004 RID: 4 RVA: 0x0000210C File Offset: 0x0000030C
	public Func<string> action { get; set; }

	// Token: 0x06000005 RID: 5 RVA: 0x00002115 File Offset: 0x00000315
	private void Awake()
	{

	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002123 File Offset: 0x00000323
	private void Update()
	{

	}

	// Token: 0x04000004 RID: 4
	private TextMeshProUGUI _text;
}
}