using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000002 RID: 2
public static class Screener
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private static void Init()
	{

	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020A0 File Offset: 0x000002A0
	public static void ShowValue(Func<string> action, int id = 0)
	{

	}

	// Token: 0x04000001 RID: 1
	private static Transform _container;

	// Token: 0x04000002 RID: 2
	private static GameObject _itemPrefab;

	// Token: 0x04000003 RID: 3
	private static Dictionary<int, ScreenerItem> _ids;
}
}