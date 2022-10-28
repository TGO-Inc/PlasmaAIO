using System;
using System.Globalization;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200023C RID: 572
	public class ShareDevicePopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x000697B8 File Offset: 0x000679B8
		public string title
		{
			get
			{
				if (this._serializedMetaData.state != SerializedDeviceMetaData.States.None)
				{
					return "UPDATE DEVICE";
				}
				return "SHARE DEVICE";
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x000697D2 File Offset: 0x000679D2
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1860f, 1520f);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000697E3 File Offset: 0x000679E3
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x000697EB File Offset: 0x000679EB
		public bool canClose { get; private set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000697F4 File Offset: 0x000679F4
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x000697FC File Offset: 0x000679FC
		public object payload { get; private set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00069805 File Offset: 0x00067A05
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0006980D File Offset: 0x00067A0D
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00069816 File Offset: 0x00067A16
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0006981E File Offset: 0x00067A1E
		public object closeEventPayload { get; private set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00069827 File Offset: 0x00067A27
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x0006982F File Offset: 0x00067A2F
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00069838 File Offset: 0x00067A38
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0006983F File Offset: 0x00067A3F
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00069842 File Offset: 0x00067A42
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00069848 File Offset: 0x00067A48
		public void Setup(object setupData)
		{

		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00069991 File Offset: 0x00067B91
		public void OnReveal()
		{

		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0006999A File Offset: 0x00067B9A
		public void OnFinishReveal()
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006999C File Offset: 0x00067B9C
		public void OnConceal()
		{
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006999E File Offset: 0x00067B9E
		public void Close()
		{

		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x000699B4 File Offset: 0x00067BB4
		public void Share()
		{

		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00069A04 File Offset: 0x00067C04
		private void HandleWorkshopUploadDevice(bool success, WorkshopController.WorkshopItemPublishResult result)
		{

		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00069AC0 File Offset: 0x00067CC0
		private void HandleUploadResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00069B34 File Offset: 0x00067D34
		public void ShareUpdate()
		{

		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00069B84 File Offset: 0x00067D84
		private void HandleWorkshopUpdateDevice(bool success, WorkshopController.WorkshopItemPublishResult result)
		{

		}

		// Token: 0x040010CB RID: 4299
		public TextMeshProUGUI deviceName;

		// Token: 0x040010CC RID: 4300
		public TextMeshProUGUI description;

		// Token: 0x040010CD RID: 4301
		public GameObject shareButton;

		// Token: 0x040010CE RID: 4302
		public GameObject updateButton;

		// Token: 0x040010CF RID: 4303
		public TextMeshProUGUI numberOfComponents;

		// Token: 0x040010D0 RID: 4304
		public TextMeshProUGUI totalMass;

		// Token: 0x040010D1 RID: 4305
		public RawImage preview;

		// Token: 0x040010D2 RID: 4306
		public GameObject moduleIcon;

		// Token: 0x040010D3 RID: 4307
		public GameObject moduleDetail;

		// Token: 0x040010D4 RID: 4308
		public GameObject shareMessage;

		// Token: 0x040010D5 RID: 4309
		private Visor _visor;

		// Token: 0x040010D6 RID: 4310
		private SerializedDeviceMetaData _serializedMetaData;
	}
}
