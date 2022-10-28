using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000009 RID: 9
public interface ISmoothScrollListProvider
{
	// Token: 0x06000050 RID: 80
	void Populate(RectTransform content);

	// Token: 0x06000051 RID: 81
	void ModifyPosition(RectTransform item);

	// Token: 0x06000052 RID: 82
	float GetItemHeight();

	// Token: 0x06000053 RID: 83
	int GetInitialTopItemIndex();

	// Token: 0x06000054 RID: 84
	void OnEnterViewport(RectTransform item);

	// Token: 0x06000055 RID: 85
	void OnExitViewport(RectTransform item);
}
}