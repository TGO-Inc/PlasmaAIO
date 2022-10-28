using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CielaSpike;
using Rewired;
using Sirenix.Serialization;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000237 RID: 567
	public class DeviceBrowser : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00066F19 File Offset: 0x00065119
		public string title
		{
			get
			{
				return "DEVICE BROWSER";
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00066F20 File Offset: 0x00065120
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2846f, 1600f);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00066F31 File Offset: 0x00065131
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00066F39 File Offset: 0x00065139
		public bool canClose { get; private set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00066F42 File Offset: 0x00065142
		public object payload
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00066F45 File Offset: 0x00065145
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00066F4D File Offset: 0x0006514D
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00066F56 File Offset: 0x00065156
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00066F5E File Offset: 0x0006515E
		public object closeEventPayload { get; private set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00066F67 File Offset: 0x00065167
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00066F6F File Offset: 0x0006516F
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00066F78 File Offset: 0x00065178
		public string exitKey
		{
			get
			{
				return "BM_Toggle";
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00066F7F File Offset: 0x0006517F
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00066F82 File Offset: 0x00065182
		public bool useDefaultInputSystem
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00066F85 File Offset: 0x00065185
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x00066F8D File Offset: 0x0006518D
		public DeviceItem highlightedItem { get; set; }

		// Token: 0x06001425 RID: 5157 RVA: 0x00066F96 File Offset: 0x00065196
		private void Awake()
		{

		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00066FA8 File Offset: 0x000651A8
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00067064 File Offset: 0x00065264
		public void OnReveal()
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00067068 File Offset: 0x00065268
		public void OnFinishReveal()
		{

		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000670C2 File Offset: 0x000652C2
		public void OnConceal()
		{

		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000670CB File Offset: 0x000652CB
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x0600142B RID: 5163 RVA: 0x000670DA File Offset: 0x000652DA
		private IEnumerator MoveCaretToEnd()
		{

            return default;
        }

		// Token: 0x0600142C RID: 5164 RVA: 0x000670EC File Offset: 0x000652EC
		private void HandleChange(string text)
		{

		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00067140 File Offset: 0x00065340
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000671BF File Offset: 0x000653BF
		public void OnSearchButtonClicked()
		{

		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000671C7 File Offset: 0x000653C7
		public void OnOnlyModuleChanged(bool value)
		{

		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000671CF File Offset: 0x000653CF
		public void OnOnlySharedChanged(bool value)
		{

		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000671D8 File Offset: 0x000653D8
		public void OnTabClicked(int tabId)
		{

		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00067378 File Offset: 0x00065578
		private void UpdatePageLabel()
		{

		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000673B5 File Offset: 0x000655B5
		public void GoToNextPage()
		{

		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000673D1 File Offset: 0x000655D1
		public void GoToPrevPage()
		{

		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000673ED File Offset: 0x000655ED
		public void SortByDate(bool on)
		{

		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00067412 File Offset: 0x00065612
		public void SortByAlphabetOrSubscriptions(bool on)
		{

		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00067438 File Offset: 0x00065638
		private void PopulateCurrentTab()
		{

		}

		// Token: 0x06001438 RID: 5176 RVA: 0x000674FE File Offset: 0x000656FE
		public void OpenFindDevicePopup()
		{

		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00067534 File Offset: 0x00065734
		private void HandleFindDeviceClose(object thePayload)
		{

		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000675FC File Offset: 0x000657FC
		public void OnItemClicked(DeviceItem item)
		{

		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000677DC File Offset: 0x000659DC
		private void HandleSubscribedDeviceClose(object thePayload)
		{

		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00067848 File Offset: 0x00065A48
		private void HandleDiscoverDeviceClose(object thePayload)
		{

		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00067918 File Offset: 0x00065B18
		private void HandleLocalDeviceClose(object thePayload)
		{

		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00067AA4 File Offset: 0x00065CA4
		private void HandleUnpublishResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00067AC2 File Offset: 0x00065CC2
		private void HandlePublishOrUpdateDeviceClose(object thePayload)
		{

		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00067AD2 File Offset: 0x00065CD2
		private void Query()
		{

		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00067B08 File Offset: 0x00065D08
		private void Populate()
		{

		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00067CF8 File Offset: 0x00065EF8
		private void PopulateLocal()
		{

		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00067D2B File Offset: 0x00065F2B
		private void PopulateDiscovered()
		{

		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00067D5E File Offset: 0x00065F5E
		private void PopulateSubscribed()
		{

		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00067D91 File Offset: 0x00065F91
		private IEnumerator GetAllLocalItems()
		{

            return default;
        }

		// Token: 0x06001446 RID: 5190 RVA: 0x00067DA0 File Offset: 0x00065FA0
		private void AllDiscoveredItemsHandler(bool success, WorkshopController.WorkshopQueryResult result)
		{

		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00067E48 File Offset: 0x00066048
		private void AllSubscribedItemsHandler(bool success, WorkshopController.WorkshopQueryResult result)
		{

		}

		// Token: 0x0400104B RID: 4171
		public BetterToggle[] tabs;

		// Token: 0x0400104C RID: 4172
		public GameObject message;

		// Token: 0x0400104D RID: 4173
		public GameObject noInternetMessage;

		// Token: 0x0400104E RID: 4174
		public LoadingCircle loadingCircle;

		// Token: 0x0400104F RID: 4175
		public Transform content;

		// Token: 0x04001050 RID: 4176
		public TMP_InputField searchField;

		// Token: 0x04001051 RID: 4177
		public GameObject searchButton;

		// Token: 0x04001052 RID: 4178
		public GameObject searchTip;

		// Token: 0x04001053 RID: 4179
		public BetterToggle discoverTab;

		// Token: 0x04001054 RID: 4180
		public BetterToggle subscribedTab;

		// Token: 0x04001055 RID: 4181
		public BetterToggle localTab;

		// Token: 0x04001056 RID: 4182
		public BetterToggle onlyModulesToggle;

		// Token: 0x04001057 RID: 4183
		public BetterToggle onlySharedToggle;

		// Token: 0x04001058 RID: 4184
		public BetterToggle byDateToggle;

		// Token: 0x04001059 RID: 4185
		public BetterToggle byAlphabetOrSubscriptionsToggle;

		// Token: 0x0400105A RID: 4186
		public BetterButton nextPageButton;

		// Token: 0x0400105B RID: 4187
		public BetterButton prevPageButton;

		// Token: 0x0400105C RID: 4188
		public TextMeshProUGUI pageLabel;

		// Token: 0x0400105D RID: 4189
		public GameObject deviceItemPrefab;

		// Token: 0x0400105E RID: 4190
		public GameObject devicePopupPrefab;

		// Token: 0x0400105F RID: 4191
		public GameObject shareDevicePopupPrefab;

		// Token: 0x04001060 RID: 4192
		public GameObject findDevicePopupPrefab;

		// Token: 0x04001061 RID: 4193
		public GameObject localTip;

		// Token: 0x04001062 RID: 4194
		public GameObject findButton;

		// Token: 0x04001063 RID: 4195
		private Visor _visor;

		// Token: 0x04001064 RID: 4196
		private DeviceItem _clickedItem;

		// Token: 0x04001065 RID: 4197
		private DeviceBrowser.Tabs _currentTab;

		// Token: 0x04001066 RID: 4198
		private WorkshopController _workshopController;

		// Token: 0x04001067 RID: 4199
		private bool _isRevealed;

		// Token: 0x04001068 RID: 4200
		private int _currentPage;

		// Token: 0x04001069 RID: 4201
		private int _totalPages;

		// Token: 0x0400106A RID: 4202
		private int _totalItems;

		// Token: 0x0400106B RID: 4203
		private int _lastPageItems;

		// Token: 0x0400106C RID: 4204
		private DeviceBrowser.ItemsQuerier _itemsQuerier;

		// Token: 0x0400106D RID: 4205
		private DeviceBrowser.ItemsGetter _itemsGetter;

		// Token: 0x0400106E RID: 4206
		private List<SerializedDeviceMetaData> _temporaryItems;

		// Token: 0x0400106F RID: 4207
		private List<SerializedDeviceMetaData> _localItems;

		// Token: 0x04001070 RID: 4208
		private Dictionary<ulong, SerializedDeviceMetaData> _publishedLocalItems;

		// Token: 0x04001071 RID: 4209
		private SerializedDeviceMetaData _metaDataFromFind;

		// Token: 0x04001072 RID: 4210
		private Player _input;

		// Token: 0x04001073 RID: 4211
		private IEnumerator _inputCoroutine;

		// Token: 0x04001074 RID: 4212
		private bool _internalTrigger;

		// Token: 0x04001075 RID: 4213
		private bool _lastPopulateWasLocalSearch;

		// Token: 0x04001076 RID: 4214
		private Regex _regex;

		// Token: 0x04001077 RID: 4215
		private bool _isPopulating;

		// Token: 0x04001078 RID: 4216
		private const int _itemsPerPage = 50;

		// Token: 0x02000449 RID: 1097
		public struct SetupData
		{
			// Token: 0x04001EEF RID: 7919
			public SerializedDeviceMetaData metaData;

			// Token: 0x04001EF0 RID: 7920
			public DeviceBrowser.Tabs origin;
		}

		// Token: 0x0200044A RID: 1098
		public enum Tabs
		{
			// Token: 0x04001EF2 RID: 7922
			Invalid = -1,
			// Token: 0x04001EF3 RID: 7923
			Discover,
			// Token: 0x04001EF4 RID: 7924
			Subscribed,
			// Token: 0x04001EF5 RID: 7925
			Local
		}

		// Token: 0x0200044B RID: 1099
		// (Invoke) Token: 0x06002295 RID: 8853
		private delegate void ItemsQuerier();

		// Token: 0x0200044C RID: 1100
		// (Invoke) Token: 0x06002299 RID: 8857
		private delegate List<SerializedDeviceMetaData> ItemsGetter();
	}
}
