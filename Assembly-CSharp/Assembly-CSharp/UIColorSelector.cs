using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000018 RID: 24
public abstract class UIColorSelector : MonoBehaviour
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600007A RID: 122 RVA: 0x0000479C File Offset: 0x0000299C
	public Color colorValue
	{
		get
		{
			return Holder.instance.UIColorPalette[this.color].color;
		}
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000047B8 File Offset: 0x000029B8
	private IList<ValueDropdownItem<int>> ColorList()
	{

        return default;
    }

	// Token: 0x04000098 RID: 152
	[ColorEntity]
	public int color;
}
}