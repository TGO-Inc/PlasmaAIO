using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000287 RID: 647
	public class SketchViewPropertyTooltip : MonoBehaviour
	{
		// Token: 0x06001998 RID: 6552 RVA: 0x00081B7E File Offset: 0x0007FD7E
		private void Awake()
		{

		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00081B8C File Offset: 0x0007FD8C
		private void ShowText(string text)
		{

		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00081C1C File Offset: 0x0007FE1C
		public void Setup(AgentProperty property, Device device, Sketch sketch, SketchNode sketchNode)
		{

		}

		// Token: 0x040014B4 RID: 5300
		public Image icon;

		// Token: 0x040014B5 RID: 5301
		public GameObject colorPreview;

		// Token: 0x040014B6 RID: 5302
		public Image colorPreviewColor;

		// Token: 0x040014B7 RID: 5303
		public TextMeshProUGUI colorPreviewValue;

		// Token: 0x040014B8 RID: 5304
		public GameObject textPreview;

		// Token: 0x040014B9 RID: 5305
		public TextMeshProUGUI textPreviewString;

		// Token: 0x040014BA RID: 5306
		public GameObject imagePreview;

		// Token: 0x040014BB RID: 5307
		public RawImage imagePreviewTexture;

		// Token: 0x040014BC RID: 5308
		public TextMeshProUGUI imagePreviewAsset;

		// Token: 0x040014BD RID: 5309
		public GameObject soundPreview;

		// Token: 0x040014BE RID: 5310
		public TextMeshProUGUI soundPreviewAsset;

		// Token: 0x040014BF RID: 5311
		public PlaySoundButton soundPreviewButton;

		// Token: 0x040014C0 RID: 5312
		private RectTransform _rectTransform;
	}
}
