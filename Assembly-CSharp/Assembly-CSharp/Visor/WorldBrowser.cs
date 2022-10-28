using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CielaSpike;
using Rewired;
using Sirenix.Serialization;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x020002B5 RID: 693
	public class WorldBrowser : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x0008A48D File Offset: 0x0008868D
		public string title
		{
			get
			{
				return "WORLD BROWSER";
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0008A494 File Offset: 0x00088694
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2846f, 1600f);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0008A4A5 File Offset: 0x000886A5
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0008A4AD File Offset: 0x000886AD
		public bool canClose { get; private set; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x0008A4B6 File Offset: 0x000886B6
		public object payload
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0008A4B9 File Offset: 0x000886B9
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0008A4C1 File Offset: 0x000886C1
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0008A4CA File Offset: 0x000886CA
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0008A4D2 File Offset: 0x000886D2
		public object closeEventPayload { get; private set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0008A4DB File Offset: 0x000886DB
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0008A4E3 File Offset: 0x000886E3
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0008A4EC File Offset: 0x000886EC
		public string exitKey
		{
			get
			{
				return "WM_Toggle";
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x0008A4F3 File Offset: 0x000886F3
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0008A4F6 File Offset: 0x000886F6
		public bool useDefaultInputSystem
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0008A4F9 File Offset: 0x000886F9
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0008A501 File Offset: 0x00088701
		public WorldItem highlightedItem { get; set; }

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0008A50A File Offset: 0x0008870A
		private void Awake()
		{

		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0008A51C File Offset: 0x0008871C
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0008A5D8 File Offset: 0x000887D8
		public void OnReveal()
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0008A5DC File Offset: 0x000887DC
		public void OnFinishReveal()
		{

		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0008A636 File Offset: 0x00088836
		public void OnConceal()
		{

		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0008A63F File Offset: 0x0008883F
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0008A64E File Offset: 0x0008884E
		private IEnumerator MoveCaretToEnd()
		{

            return default;
        }

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0008A660 File Offset: 0x00088860
		private void HandleChange(string text)
		{

		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0008A6B4 File Offset: 0x000888B4
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0008A733 File Offset: 0x00088933
		public void OnSearchButtonClicked()
		{

		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0008A73B File Offset: 0x0008893B
		public void OnOnlyStagedChanged(bool value)
		{

		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0008A743 File Offset: 0x00088943
		public void OnOnlySharedChanged(bool value)
		{

		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0008A74C File Offset: 0x0008894C
		public void OnTabClicked(int tabId)
		{

		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0008A8EC File Offset: 0x00088AEC
		private void UpdatePageLabel()
		{

		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0008A929 File Offset: 0x00088B29
		public void GoToNextPage()
		{

		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0008A945 File Offset: 0x00088B45
		public void GoToPrevPage()
		{

		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0008A961 File Offset: 0x00088B61
		public void SortByDate(bool on)
		{

		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0008A986 File Offset: 0x00088B86
		public void SortByAlphabetOrSubscriptions(bool on)
		{

		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0008A9AC File Offset: 0x00088BAC
		public void OnNewWorldClicked()
		{

		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0008AA4E File Offset: 0x00088C4E
		private void HandleWarningNewResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0008AA70 File Offset: 0x00088C70
		private void PopulateCurrentTab()
		{

		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0008AB36 File Offset: 0x00088D36
		public void OpenFindWorldPopup()
		{

		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0008AB6C File Offset: 0x00088D6C
		private void HandleFindWorldClose(object thePayload)
		{

		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0008AC34 File Offset: 0x00088E34
		public void OnItemClicked(WorldItem item)
		{

		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0008AE24 File Offset: 0x00089024
		private void HandleSubscribedWorldClose(object thePayload)
		{

		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0008B028 File Offset: 0x00089228
		private void HandleDiscoverWorldClose(object thePayload)
		{

		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0008B220 File Offset: 0x00089420
		private void HandleLocalWorldClose(object thePayload)
		{

		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0008B3B5 File Offset: 0x000895B5
		private void HandleUnpublishResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0008B3D3 File Offset: 0x000895D3
		private void HandlePublishOrUpdateWorldClose(object thePayload)
		{

		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0008B3E3 File Offset: 0x000895E3
		private void Query()
		{

		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0008B418 File Offset: 0x00089618
		private void Populate()
		{

		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0008B650 File Offset: 0x00089850
		private void PopulateLocal()
		{

		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0008B683 File Offset: 0x00089883
		private void PopulateDiscovered()
		{

		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0008B6B6 File Offset: 0x000898B6
		private void PopulateSubscribed()
		{

		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0008B6E9 File Offset: 0x000898E9
		private IEnumerator GetAllLocalItems()
		{

            return default;
        }

		// Token: 0x06001C13 RID: 7187 RVA: 0x0008B6F8 File Offset: 0x000898F8
		private void AllDiscoveredItemsHandler(bool success, WorkshopController.WorkshopQueryResult result)
		{

		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0008B7A0 File Offset: 0x000899A0
		private void AllSubscribedItemsHandler(bool success, WorkshopController.WorkshopQueryResult result)
		{

		}

		// Token: 0x040016AA RID: 5802
		public BetterToggle[] tabs;

		// Token: 0x040016AB RID: 5803
		public GameObject message;

		// Token: 0x040016AC RID: 5804
		public GameObject noInternetMessage;

		// Token: 0x040016AD RID: 5805
		public LoadingCircle loadingCircle;

		// Token: 0x040016AE RID: 5806
		public Transform content;

		// Token: 0x040016AF RID: 5807
		public TMP_InputField searchField;

		// Token: 0x040016B0 RID: 5808
		public GameObject searchButton;

		// Token: 0x040016B1 RID: 5809
		public GameObject searchTip;

		// Token: 0x040016B2 RID: 5810
		public BetterToggle discoverTab;

		// Token: 0x040016B3 RID: 5811
		public BetterToggle subscribedTab;

		// Token: 0x040016B4 RID: 5812
		public BetterToggle localTab;

		// Token: 0x040016B5 RID: 5813
		public BetterToggle onlyStagedToggle;

		// Token: 0x040016B6 RID: 5814
		public BetterToggle onlySharedToggle;

		// Token: 0x040016B7 RID: 5815
		public BetterToggle byDateToggle;

		// Token: 0x040016B8 RID: 5816
		public BetterToggle byAlphabetOrSubscriptionsToggle;

		// Token: 0x040016B9 RID: 5817
		public BetterButton nextPageButton;

		// Token: 0x040016BA RID: 5818
		public BetterButton prevPageButton;

		// Token: 0x040016BB RID: 5819
		public TextMeshProUGUI pageLabel;

		// Token: 0x040016BC RID: 5820
		public GameObject worldItemPrefab;

		// Token: 0x040016BD RID: 5821
		public GameObject newWorldItemPrefab;

		// Token: 0x040016BE RID: 5822
		public GameObject worldPopupPrefab;

		// Token: 0x040016BF RID: 5823
		public GameObject shareWorldPopupPrefab;

		// Token: 0x040016C0 RID: 5824
		public GameObject findWorldPopupPrefab;

		// Token: 0x040016C1 RID: 5825
		public GameObject localTip;

		// Token: 0x040016C2 RID: 5826
		public GameObject findWorldButton;

		// Token: 0x040016C3 RID: 5827
		private Visor _visor;

		// Token: 0x040016C4 RID: 5828
		private WorldItem _clickedItem;

		// Token: 0x040016C5 RID: 5829
		private WorldBrowser.Tabs _currentTab;

		// Token: 0x040016C6 RID: 5830
		private WorkshopController _workshopController;

		// Token: 0x040016C7 RID: 5831
		private bool _isRevealed;

		// Token: 0x040016C8 RID: 5832
		private int _currentPage;

		// Token: 0x040016C9 RID: 5833
		private int _totalPages;

		// Token: 0x040016CA RID: 5834
		private int _totalItems;

		// Token: 0x040016CB RID: 5835
		private int _lastPageItems;

		// Token: 0x040016CC RID: 5836
		private WorldBrowser.ItemsQuerier _itemsQuerier;

		// Token: 0x040016CD RID: 5837
		private WorldBrowser.ItemsGetter _itemsGetter;

		// Token: 0x040016CE RID: 5838
		private List<SerializedWorldMetaData> _temporaryItems;

		// Token: 0x040016CF RID: 5839
		private List<SerializedWorldMetaData> _localItems;

		// Token: 0x040016D0 RID: 5840
		private SerializedWorldMetaData _metaDataFromFind;

		// Token: 0x040016D1 RID: 5841
		private Dictionary<ulong, SerializedWorldMetaData> _publishedLocalItems;

		// Token: 0x040016D2 RID: 5842
		private Player _input;

		// Token: 0x040016D3 RID: 5843
		private IEnumerator _inputCoroutine;

		// Token: 0x040016D4 RID: 5844
		private bool _internalTrigger;

		// Token: 0x040016D5 RID: 5845
		private bool _lastPopulateWasLocalSearch;

		// Token: 0x040016D6 RID: 5846
		private Regex _regex;

		// Token: 0x040016D7 RID: 5847
		private bool _isPopulating;

		// Token: 0x040016D8 RID: 5848
		private const int _itemsPerPage = 50;

		// Token: 0x020004A9 RID: 1193
		public struct SetupData
		{
			// Token: 0x0400206A RID: 8298
			public SerializedWorldMetaData metaData;

			// Token: 0x0400206B RID: 8299
			public WorldBrowser.Tabs origin;
		}

		// Token: 0x020004AA RID: 1194
		public enum Tabs
		{
			// Token: 0x0400206D RID: 8301
			Invalid = -1,
			// Token: 0x0400206E RID: 8302
			Discover,
			// Token: 0x0400206F RID: 8303
			Subscribed,
			// Token: 0x04002070 RID: 8304
			Local
		}

		// Token: 0x020004AB RID: 1195
		// (Invoke) Token: 0x0600240E RID: 9230
		private delegate void ItemsQuerier();

		// Token: 0x020004AC RID: 1196
		// (Invoke) Token: 0x06002412 RID: 9234
		private delegate List<SerializedWorldMetaData> ItemsGetter();
	}
}
