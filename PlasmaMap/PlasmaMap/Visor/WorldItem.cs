using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002B6 RID: 694
	public class WorldItem : SerializedMonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0008B9EA File Offset: 0x00089BEA
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0008B9F2 File Offset: 0x00089BF2
		public SerializedWorldMetaData serializedMetaData { get; private set; }

		// Token: 0x06001C20 RID: 7200 RVA: 0x0008B9FC File Offset: 0x00089BFC
		public void Setup(SerializedWorldMetaData metaData, WorldBrowser browser)
		{

		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0008BD67 File Offset: 0x00089F67
		private IEnumerator GetPreviewTexture()
		{

            return default;
        }

		// Token: 0x06001C22 RID: 7202 RVA: 0x0008BD78 File Offset: 0x00089F78
		private void HandleItemDownloaded(bool success, WorkshopController.WorkshopItemDownloadedResult result)
		{

		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0008BDE4 File Offset: 0x00089FE4
		private void HandleOnUserInformationRetrieved(ulong steamId, string userName)
		{

		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0008BE38 File Offset: 0x0008A038
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0008BE85 File Offset: 0x0008A085
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0008BE99 File Offset: 0x0008A099
		public void OnPointerClick(PointerEventData data)
		{

		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0008BECE File Offset: 0x0008A0CE
		private void Unhighlight()
		{

		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0008BEFC File Offset: 0x0008A0FC
		private void OnDestroy()
		{

		}

		// Token: 0x040016DE RID: 5854
		public bool createNewWorld;

		// Token: 0x040016DF RID: 5855
		public TextMeshProUGUI title;

		// Token: 0x040016E0 RID: 5856
		public TextMeshProUGUI info;

		// Token: 0x040016E1 RID: 5857
		public TextMeshProUGUI message;

		// Token: 0x040016E2 RID: 5858
		public RawImage image;

		// Token: 0x040016E3 RID: 5859
		public UIImageColorMapper borderNormalMapper;

		// Token: 0x040016E4 RID: 5860
		public UIImageColorMapper borderHighlightedMapper;

		// Token: 0x040016E5 RID: 5861
		public UIImageColorMapper iconNormalMapper;

		// Token: 0x040016E6 RID: 5862
		public UIImageColorMapper iconHighlightedMapper;

		// Token: 0x040016E7 RID: 5863
		public Image stateIcon;

		// Token: 0x040016E8 RID: 5864
		public GameObject loadingCircle;

		// Token: 0x040016E9 RID: 5865
		public GameObject stageIcon;

		// Token: 0x040016EA RID: 5866
		public GameObject updatedIcon;

		// Token: 0x040016EB RID: 5867
		public Dictionary<SerializedWorldMetaData.States, Sprite> stateSprites;

		// Token: 0x040016EC RID: 5868
		private WorldBrowser _browser;

		// Token: 0x040016ED RID: 5869
		private bool _valid;

		// Token: 0x040016EE RID: 5870
		private bool _needToUnsubscribeFromInfoEvent;

		// Token: 0x040016EF RID: 5871
		private bool _needToUnsubscribeFromDownloadEvent;
	}
}
