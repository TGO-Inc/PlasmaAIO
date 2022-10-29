using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Rewired;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000245 RID: 581
	public class HudHint : MonoBehaviour
	{
		// Token: 0x0600154D RID: 5453 RVA: 0x0006CED8 File Offset: 0x0006B0D8
		public void Setup(HintGestaltEnum hintId)
		{

		}

		// Token: 0x04001163 RID: 4451
		public TextMeshProUGUI key;

		// Token: 0x04001164 RID: 4452
		public TextMeshProUGUI text;

		// Token: 0x04001165 RID: 4453
		public Transform inputIcon;

		// Token: 0x04001166 RID: 4454
		public Transform modifierIcon;

		// Token: 0x04001167 RID: 4455
		public GameObject modifierZone;

		// Token: 0x04001168 RID: 4456
		public GameObject holdZone;

		// Token: 0x04001169 RID: 4457
		public float padding;

		// Token: 0x0400116A RID: 4458
		public float extraPadding;
	}
}
