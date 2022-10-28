using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000295 RID: 661
	public class ImageRow : MonoBehaviour
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00083B81 File Offset: 0x00081D81
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x00083B89 File Offset: 0x00081D89
		public UserAssetsController.AssetDescription assetDescription { get; private set; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00083B92 File Offset: 0x00081D92
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x00083B9A File Offset: 0x00081D9A
		public int position { get; private set; }

		// Token: 0x06001A0E RID: 6670 RVA: 0x00083BA3 File Offset: 0x00081DA3
		public void Setup(UserAssetsController.AssetDescription theAssetDescription, int thePosition, ImageBrowser browser)
		{

		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00083BD4 File Offset: 0x00081DD4
		public void Select()
		{

		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00083BE7 File Offset: 0x00081DE7
		public void Deselect()
		{

		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00083BFA File Offset: 0x00081DFA
		public void OnClicked()
		{

		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00083C08 File Offset: 0x00081E08
		public void LoadTexutre()
		{

		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00083C57 File Offset: 0x00081E57
		public void UnloadTexture()
		{

		}

		// Token: 0x04001521 RID: 5409
		public RawImage thumbnail;

		// Token: 0x04001522 RID: 5410
		public TextMeshProUGUI info;

		// Token: 0x04001523 RID: 5411
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x04001524 RID: 5412
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x04001525 RID: 5413
		[FormerlySerializedAs("isNone")]
		public bool isEmpty;

		// Token: 0x04001526 RID: 5414
		public bool isRuntime;

		// Token: 0x04001527 RID: 5415
		private ImageBrowser _browser;
	}
}
