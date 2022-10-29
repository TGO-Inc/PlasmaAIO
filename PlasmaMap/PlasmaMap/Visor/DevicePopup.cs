using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000239 RID: 569
	public class DevicePopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00068555 File Offset: 0x00066755
		public string title
		{
			get
			{
				return "\"" + this._serializedMetaData.name.ToUpperInvariant() + "\"";
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00068576 File Offset: 0x00066776
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2140f, 1340f);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00068587 File Offset: 0x00066787
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0006858F File Offset: 0x0006678F
		public bool canClose { get; private set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00068598 File Offset: 0x00066798
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x000685A0 File Offset: 0x000667A0
		public object payload { get; private set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x000685A9 File Offset: 0x000667A9
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x000685B1 File Offset: 0x000667B1
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x000685BA File Offset: 0x000667BA
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x000685C2 File Offset: 0x000667C2
		public object closeEventPayload { get; private set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000685CB File Offset: 0x000667CB
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x000685D3 File Offset: 0x000667D3
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x000685DC File Offset: 0x000667DC
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x000685E3 File Offset: 0x000667E3
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x000685E6 File Offset: 0x000667E6
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000685EC File Offset: 0x000667EC
		public void Setup(object setupData)
		{

		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00068E4D File Offset: 0x0006704D
		private IEnumerator GetPreviewTexture()
		{

            return default;
        }

		// Token: 0x0600146E RID: 5230 RVA: 0x00068E5C File Offset: 0x0006705C
		private void HandleOnUserInformationRetrieved(ulong steamId, string userName)
		{

		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00068E98 File Offset: 0x00067098
		public void OnReveal()
		{

		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00068F24 File Offset: 0x00067124
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00068F26 File Offset: 0x00067126
		public void OnConceal()
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00068F28 File Offset: 0x00067128
		private void HandleItemDownloaded(bool success, WorkshopController.WorkshopItemDownloadedResult result)
		{

		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00068F91 File Offset: 0x00067191
		public void Close()
		{

		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00068FB0 File Offset: 0x000671B0
		public void Build()
		{

		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00068FC4 File Offset: 0x000671C4
		public void Share()
		{

		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00068FD8 File Offset: 0x000671D8
		public void Unpublish()
		{

		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0006901E File Offset: 0x0006721E
		private void HandleUnpublishResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0006903D File Offset: 0x0006723D
		public void PublishUpdate()
		{

		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00069054 File Offset: 0x00067254
		public void Delete()
		{

		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0006909A File Offset: 0x0006729A
		private void HandleDeleteResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000690BC File Offset: 0x000672BC
		public void Subscribe()
		{

		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0006913C File Offset: 0x0006733C
		public void Unsubscribe()
		{

		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00069193 File Offset: 0x00067393
		private void HandleUnsubscribeResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000691AE File Offset: 0x000673AE
		private void OnDestroy()
		{

		}

		// Token: 0x0400108D RID: 4237
		public TextMeshProUGUI createdOn;

		// Token: 0x0400108E RID: 4238
		public TextMeshProUGUI lastSave;

		// Token: 0x0400108F RID: 4239
		public TextMeshProUGUI author;

		// Token: 0x04001090 RID: 4240
		public TextMeshProUGUI status;

		// Token: 0x04001091 RID: 4241
		public TextMeshProUGUI publishedOn;

		// Token: 0x04001092 RID: 4242
		public TextMeshProUGUI lastUpdate;

		// Token: 0x04001093 RID: 4243
		public TextMeshProUGUI description;

		// Token: 0x04001094 RID: 4244
		public TextMeshProUGUI numberOfComponents;

		// Token: 0x04001095 RID: 4245
		public TextMeshProUGUI totalMass;

		// Token: 0x04001096 RID: 4246
		public RawImage preview;

		// Token: 0x04001097 RID: 4247
		public GameObject localData;

		// Token: 0x04001098 RID: 4248
		public RectTransform publishData;

		// Token: 0x04001099 RID: 4249
		public GameObject moduleIcon;

		// Token: 0x0400109A RID: 4250
		public GameObject moduleDetail;

		// Token: 0x0400109B RID: 4251
		public GameObject subscribeButton;

		// Token: 0x0400109C RID: 4252
		public GameObject unsubscribeButton;

		// Token: 0x0400109D RID: 4253
		public GameObject shareButton;

		// Token: 0x0400109E RID: 4254
		public GameObject updateButton;

		// Token: 0x0400109F RID: 4255
		public GameObject unpublishButton;

		// Token: 0x040010A0 RID: 4256
		public GameObject deleteButton;

		// Token: 0x040010A1 RID: 4257
		public GameObject buildButton;

		// Token: 0x040010A2 RID: 4258
		public GameObject downloadingMessage;

		// Token: 0x040010A3 RID: 4259
		public GameObject downloadErrorMessage;

		// Token: 0x040010A4 RID: 4260
		private Visor _visor;

		// Token: 0x040010A5 RID: 4261
		private SerializedDeviceMetaData _serializedMetaData;

		// Token: 0x040010A6 RID: 4262
		private bool _needToUnsubscribeFromInfoEvent;

		// Token: 0x040010A7 RID: 4263
		private bool _needToUnsubscribeFromDownloadEvent;

		// Token: 0x040010A8 RID: 4264
		private bool _userSubscribed;

		// Token: 0x040010A9 RID: 4265
		private DeviceBrowser.Tabs _origin;

		// Token: 0x02000453 RID: 1107
		public enum CloseActions
		{
			// Token: 0x04001F0A RID: 7946
			Close,
			// Token: 0x04001F0B RID: 7947
			Build,
			// Token: 0x04001F0C RID: 7948
			Share,
			// Token: 0x04001F0D RID: 7949
			Delete,
			// Token: 0x04001F0E RID: 7950
			Unpublish,
			// Token: 0x04001F0F RID: 7951
			Update,
			// Token: 0x04001F10 RID: 7952
			Subscribe,
			// Token: 0x04001F11 RID: 7953
			Unsubscribe
		}
	}
}
