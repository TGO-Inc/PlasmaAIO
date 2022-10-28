using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Globalization;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002B8 RID: 696
	public class WorldPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0008BFD1 File Offset: 0x0008A1D1
		public string title
		{
			get
			{
				return "\"" + this._serializedMetaData.name.ToUpperInvariant() + "\"";
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0008BFF2 File Offset: 0x0008A1F2
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2360f, 1340f);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0008C003 File Offset: 0x0008A203
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x0008C00B File Offset: 0x0008A20B
		public bool canClose { get; private set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0008C014 File Offset: 0x0008A214
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x0008C01C File Offset: 0x0008A21C
		public object payload { get; private set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0008C025 File Offset: 0x0008A225
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0008C02D File Offset: 0x0008A22D
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0008C036 File Offset: 0x0008A236
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0008C03E File Offset: 0x0008A23E
		public object closeEventPayload { get; private set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0008C047 File Offset: 0x0008A247
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0008C04F File Offset: 0x0008A24F
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0008C058 File Offset: 0x0008A258
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0008C05F File Offset: 0x0008A25F
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0008C062 File Offset: 0x0008A262
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0008C068 File Offset: 0x0008A268
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0008CAD4 File Offset: 0x0008ACD4
		private IEnumerator GetPreviewTexture()
		{

            return default;
        }

		// Token: 0x06001C41 RID: 7233 RVA: 0x0008CAE3 File Offset: 0x0008ACE3
		private void HandleOnUserInformationRetrieved(ulong steamId, string userName)
		{

		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0008CB1C File Offset: 0x0008AD1C
		public void OnReveal()
		{

		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0008CBA8 File Offset: 0x0008ADA8
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0008CBAA File Offset: 0x0008ADAA
		public void OnConceal()
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0008CBAC File Offset: 0x0008ADAC
		private void HandleItemDownloaded(bool success, WorkshopController.WorkshopItemDownloadedResult result)
		{

		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0008CC2D File Offset: 0x0008AE2D
		public void Close()
		{

		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0008CC4C File Offset: 0x0008AE4C
		public void Load()
		{

		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0008CCD0 File Offset: 0x0008AED0
		private void HandleLoadWorldResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0008CD0C File Offset: 0x0008AF0C
		public void Share()
		{

		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0008CD86 File Offset: 0x0008AF86
		private void HandleShareWorldResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0008CDA8 File Offset: 0x0008AFA8
		public void Unpublish()
		{

		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0008CDEE File Offset: 0x0008AFEE
		private void HandleUnpublishResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0008CE10 File Offset: 0x0008B010
		public void ShareUpdate()
		{

		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0008CE8C File Offset: 0x0008B08C
		public void Delete()
		{

		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0008CED2 File Offset: 0x0008B0D2
		private void HandleDeleteResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0008CEF4 File Offset: 0x0008B0F4
		public void Subscribe()
		{

		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0008CF74 File Offset: 0x0008B174
		public void Unsubscribe()
		{

		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0008CFF2 File Offset: 0x0008B1F2
		private void HandleUnsubscribeResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0008D010 File Offset: 0x0008B210
		public void StartNew()
		{

		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0008D074 File Offset: 0x0008B274
		private void HandleStartNewWorldResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0008D0AC File Offset: 0x0008B2AC
		private void SaveProgressAndStartNew()
		{

		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0008D105 File Offset: 0x0008B305
		public void Resume()
		{

		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0008D119 File Offset: 0x0008B319
		private void OnDestroy()
		{

		}

		// Token: 0x040016F5 RID: 5877
		public TextMeshProUGUI createdOn;

		// Token: 0x040016F6 RID: 5878
		public TextMeshProUGUI lastSave;

		// Token: 0x040016F7 RID: 5879
		public TextMeshProUGUI author;

		// Token: 0x040016F8 RID: 5880
		public TextMeshProUGUI status;

		// Token: 0x040016F9 RID: 5881
		public TextMeshProUGUI publishedOn;

		// Token: 0x040016FA RID: 5882
		public TextMeshProUGUI lastUpdate;

		// Token: 0x040016FB RID: 5883
		public TextMeshProUGUI description;

		// Token: 0x040016FC RID: 5884
		public TextMeshProUGUI numberOfDevices;

		// Token: 0x040016FD RID: 5885
		public TextMeshProUGUI biome;

		// Token: 0x040016FE RID: 5886
		public RawImage preview;

		// Token: 0x040016FF RID: 5887
		public GameObject localData;

		// Token: 0x04001700 RID: 5888
		public RectTransform publishData;

		// Token: 0x04001701 RID: 5889
		public GameObject stagedRibbon;

		// Token: 0x04001702 RID: 5890
		public GameObject updatedRibbon;

		// Token: 0x04001703 RID: 5891
		public GameObject stagedBanner;

		// Token: 0x04001704 RID: 5892
		public GameObject updatedBanner;

		// Token: 0x04001705 RID: 5893
		public GameObject subscribeButton;

		// Token: 0x04001706 RID: 5894
		public GameObject unsubscribeButton;

		// Token: 0x04001707 RID: 5895
		public GameObject shareButton;

		// Token: 0x04001708 RID: 5896
		public GameObject updateButton;

		// Token: 0x04001709 RID: 5897
		public GameObject unpublishButton;

		// Token: 0x0400170A RID: 5898
		public GameObject deleteButton;

		// Token: 0x0400170B RID: 5899
		public GameObject loadButton;

		// Token: 0x0400170C RID: 5900
		public GameObject startButton;

		// Token: 0x0400170D RID: 5901
		public GameObject restartButton;

		// Token: 0x0400170E RID: 5902
		public GameObject resumeButton;

		// Token: 0x0400170F RID: 5903
		public GameObject downloadingMessage;

		// Token: 0x04001710 RID: 5904
		public GameObject downloadErrorMessage;

		// Token: 0x04001711 RID: 5905
		private Visor _visor;

		// Token: 0x04001712 RID: 5906
		private SerializedWorldMetaData _serializedMetaData;

		// Token: 0x04001713 RID: 5907
		private bool _needToUnsubscribeFromInfoEvent;

		// Token: 0x04001714 RID: 5908
		private bool _needToUnsubscribeFromDownloadEvent;

		// Token: 0x04001715 RID: 5909
		private bool _userSubscribed;

		// Token: 0x04001716 RID: 5910
		private WorldBrowser.Tabs _origin;

		// Token: 0x020004B3 RID: 1203
		public enum CloseActions
		{
			// Token: 0x04002085 RID: 8325
			Close,
			// Token: 0x04002086 RID: 8326
			Load,
			// Token: 0x04002087 RID: 8327
			StartNew,
			// Token: 0x04002088 RID: 8328
			Resume,
			// Token: 0x04002089 RID: 8329
			Share,
			// Token: 0x0400208A RID: 8330
			Delete,
			// Token: 0x0400208B RID: 8331
			Unpublish,
			// Token: 0x0400208C RID: 8332
			Update,
			// Token: 0x0400208D RID: 8333
			Subscribe,
			// Token: 0x0400208E RID: 8334
			Unsubscribe
		}
	}
}
