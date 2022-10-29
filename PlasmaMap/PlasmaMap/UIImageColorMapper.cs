using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x02000019 RID: 25
public class UIImageColorMapper : UIColorMapper
{
	// Token: 0x0600007D RID: 125 RVA: 0x0000485C File Offset: 0x00002A5C
	protected override void RefreshColors(Holder holder, int stateToApply = 0)
	{

	}

	// Token: 0x04000099 RID: 153
	[ColorEntity]
	public int normalColor;
}
}