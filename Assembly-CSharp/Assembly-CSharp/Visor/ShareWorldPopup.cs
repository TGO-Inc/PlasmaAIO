using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Steamworks;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002B4 RID: 692
	public class ShareWorldPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00089E13 File Offset: 0x00088013
		public string title
		{
			get
			{
				if (this._serializedMetaData.state != SerializedWorldMetaData.States.None)
				{
					return "UPDATE WORLD";
				}
				return "SHARE WORLD";
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00089E2D File Offset: 0x0008802D
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2070f, 1390f);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00089E3E File Offset: 0x0008803E
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x00089E46 File Offset: 0x00088046
		public bool canClose { get; private set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00089E4F File Offset: 0x0008804F
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00089E57 File Offset: 0x00088057
		public object payload { get; private set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00089E60 File Offset: 0x00088060
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x00089E68 File Offset: 0x00088068
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00089E71 File Offset: 0x00088071
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x00089E79 File Offset: 0x00088079
		public object closeEventPayload { get; private set; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00089E82 File Offset: 0x00088082
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x00089E8A File Offset: 0x0008808A
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00089E93 File Offset: 0x00088093
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00089E9A File Offset: 0x0008809A
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00089E9D File Offset: 0x0008809D
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00089EA0 File Offset: 0x000880A0
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0008A05C File Offset: 0x0008825C
		public void OnReveal()
		{

		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0008A104 File Offset: 0x00088304
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0008A106 File Offset: 0x00088306
		public void OnConceal()
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0008A108 File Offset: 0x00088308
		public void Close()
		{

		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0008A11C File Offset: 0x0008831C
		public void Share()
		{

		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0008A1C3 File Offset: 0x000883C3
		private void HandleWorldSavedForShare()
		{

		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0008A1E4 File Offset: 0x000883E4
		private void HandleWorkshopUploadWorld(bool success, WorkshopController.WorkshopItemPublishResult result)
		{

		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0008A2A0 File Offset: 0x000884A0
		private void HandleUploadResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0008A314 File Offset: 0x00088514
		public void ShareUpdate()
		{

		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0008A3BB File Offset: 0x000885BB
		private void HandleWorldSavedForUpdate()
		{

		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0008A3DC File Offset: 0x000885DC
		private void HandleWorkshopUpdateWorld(bool success, WorkshopController.WorkshopItemPublishResult result)
		{

		}

		// Token: 0x04001694 RID: 5780
		public TextMeshProUGUI worldName;

		// Token: 0x04001695 RID: 5781
		public TextMeshProUGUI description;

		// Token: 0x04001696 RID: 5782
		public GameObject shareButton;

		// Token: 0x04001697 RID: 5783
		public GameObject updateButton;

		// Token: 0x04001698 RID: 5784
		public TextMeshProUGUI numberOfDevices;

		// Token: 0x04001699 RID: 5785
		public TextMeshProUGUI biome;

		// Token: 0x0400169A RID: 5786
		public TextMeshProUGUI time;

		// Token: 0x0400169B RID: 5787
		public RawImage preview;

		// Token: 0x0400169C RID: 5788
		public GameObject stageIcon;

		// Token: 0x0400169D RID: 5789
		public GameObject stageDetail;

		// Token: 0x0400169E RID: 5790
		public GameObject shareMessage;

		// Token: 0x0400169F RID: 5791
		public GameObject tags;

		// Token: 0x040016A0 RID: 5792
		public BetterToggle challengeToggle;

		// Token: 0x040016A1 RID: 5793
		public BetterToggle adventureToggle;

		// Token: 0x040016A2 RID: 5794
		public BetterToggle storyToggle;

		// Token: 0x040016A3 RID: 5795
		private Visor _visor;

		// Token: 0x040016A4 RID: 5796
		private SerializedWorldMetaData _serializedMetaData;
	}
}
