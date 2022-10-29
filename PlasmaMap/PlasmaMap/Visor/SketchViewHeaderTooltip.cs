using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000281 RID: 641
	public class SketchViewHeaderTooltip : MonoBehaviour
	{
		// Token: 0x060018FD RID: 6397 RVA: 0x0007D6F9 File Offset: 0x0007B8F9
		private void Awake()
		{

		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0007D714 File Offset: 0x0007B914
		public void Setup(string message, bool showAsWarning)
		{

		}

		// Token: 0x04001429 RID: 5161
		public TextMeshProUGUI text;

		// Token: 0x0400142A RID: 5162
		public Image icon;

		// Token: 0x0400142B RID: 5163
		public Sprite infoIcon;

		// Token: 0x0400142C RID: 5164
		public Sprite warningIcon;

		// Token: 0x0400142D RID: 5165
		private RectTransform _rectTransform;

		// Token: 0x0400142E RID: 5166
		private UIColorMapperController _mapperController;
	}
}
