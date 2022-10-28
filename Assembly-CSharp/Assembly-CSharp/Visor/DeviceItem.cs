using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000238 RID: 568
	public class DeviceItem : SerializedMonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00068092 File Offset: 0x00066292
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0006809A File Offset: 0x0006629A
		public SerializedDeviceMetaData serializedMetaData { get; private set; }

		// Token: 0x06001453 RID: 5203 RVA: 0x000680A4 File Offset: 0x000662A4
		public void Setup(SerializedDeviceMetaData metaData, DeviceBrowser browser)
		{

		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000683D0 File Offset: 0x000665D0
		private IEnumerator GetPreviewTexture()
		{

            return default;
        }

		// Token: 0x06001455 RID: 5205 RVA: 0x000683E0 File Offset: 0x000665E0
		private void HandleItemDownloaded(bool success, WorkshopController.WorkshopItemDownloadedResult result)
		{

		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006844C File Offset: 0x0006664C
		private void HandleOnUserInformationRetrieved(ulong steamId, string userName)
		{

		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0006849F File Offset: 0x0006669F
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000684C8 File Offset: 0x000666C8
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000684DC File Offset: 0x000666DC
		public void OnPointerClick(PointerEventData data)
		{

		}

		// Token: 0x0600145A RID: 5210 RVA: 0x000684FC File Offset: 0x000666FC
		private void Unhighlight()
		{

		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0006850F File Offset: 0x0006670F
		private void OnDestroy()
		{

		}

		// Token: 0x0400107E RID: 4222
		public TextMeshProUGUI title;

		// Token: 0x0400107F RID: 4223
		public TextMeshProUGUI info;

		// Token: 0x04001080 RID: 4224
		public TextMeshProUGUI message;

		// Token: 0x04001081 RID: 4225
		public RawImage image;

		// Token: 0x04001082 RID: 4226
		public UIImageColorMapper borderNormalMapper;

		// Token: 0x04001083 RID: 4227
		public UIImageColorMapper borderHighlightedMapper;

		// Token: 0x04001084 RID: 4228
		public Image stateIcon;

		// Token: 0x04001085 RID: 4229
		public GameObject moduleIcon;

		// Token: 0x04001086 RID: 4230
		public GameObject loadingCircle;

		// Token: 0x04001087 RID: 4231
		public Dictionary<SerializedDeviceMetaData.States, Sprite> stateSprites;

		// Token: 0x04001088 RID: 4232
		private DeviceBrowser _browser;

		// Token: 0x04001089 RID: 4233
		private bool _valid;

		// Token: 0x0400108A RID: 4234
		private bool _needToUnsubscribeFromInfoEvent;

		// Token: 0x0400108B RID: 4235
		private bool _needToUnsubscribeFromDownloadEvent;
	}
}
