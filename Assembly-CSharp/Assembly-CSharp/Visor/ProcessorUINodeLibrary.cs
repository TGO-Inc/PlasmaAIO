using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x02000271 RID: 625
	public class ProcessorUINodeLibrary : SerializedMonoBehaviour, IEscapeHandler
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x00076B4C File Offset: 0x00074D4C
		private void Awake()
		{

		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00076D54 File Offset: 0x00074F54
		public void Setup(ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00076DCD File Offset: 0x00074FCD
		public void CleanUp()
		{

		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00076DE5 File Offset: 0x00074FE5
		public void Close()
		{

		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00076DF3 File Offset: 0x00074FF3
		public void OnEscapePressed()
		{

		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00076E29 File Offset: 0x00075029
		public void SpawnNode(AgentId agentId)
		{

		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00076E38 File Offset: 0x00075038
		public void ExpandCategory(AgentCategoryEnum category)
		{

		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00076F0C File Offset: 0x0007510C
		public void CollapseCategory(AgentCategoryEnum category)
		{

		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00076F68 File Offset: 0x00075168
		public void ExpandFavorites()
		{

		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00076FBC File Offset: 0x000751BC
		public void CollapseFavorites()
		{

		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00077010 File Offset: 0x00075210
		private void HandleChange(string text)
		{

		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00077018 File Offset: 0x00075218
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00077050 File Offset: 0x00075250
		private void Populate()
		{

		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00077374 File Offset: 0x00075574
		private void PopulateFavorites()
		{

		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00077488 File Offset: 0x00075688
		private bool ShouldShowNode(AgentGestaltEnum id)
		{

            return default;
        }

		// Token: 0x060017CD RID: 6093 RVA: 0x000774C4 File Offset: 0x000756C4
		public void OnHighlightItem(AgentGestaltEnum nodeId)
		{

		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00077525 File Offset: 0x00075725
		public void ToggleFavorite(AgentGestaltEnum nodeId)
		{

		}

		// Token: 0x0400134E RID: 4942
		public GameObject nodeItemPrefab;

		// Token: 0x0400134F RID: 4943
		public GameObject categoryItemPrefab;

		// Token: 0x04001350 RID: 4944
		public TMP_InputField searchField;

		// Token: 0x04001351 RID: 4945
		public RectTransform content;

		// Token: 0x04001352 RID: 4946
		public GameObject message;

		// Token: 0x04001353 RID: 4947
		public TextMeshProUGUI description;

		// Token: 0x04001354 RID: 4948
		public GameObject advancedHint;

		// Token: 0x04001355 RID: 4949
		public ScrollRectNoDragging scrollView;

		// Token: 0x04001356 RID: 4950
		public TextMeshProUGUI hint;

		// Token: 0x04001357 RID: 4951
		private ProcessorUI _processorUI;

		// Token: 0x04001358 RID: 4952
		private EscapeManager _escapeManager;

		// Token: 0x04001359 RID: 4953
		private Dictionary<AgentId, GameObject> _nodeItems;

		// Token: 0x0400135A RID: 4954
		private Dictionary<AgentCategoryEnum, GameObject> _categoryItems;

		// Token: 0x0400135B RID: 4955
		private Dictionary<AgentCategoryEnum, List<GameObject>> _categorizedItems;

		// Token: 0x0400135C RID: 4956
		private List<GameObject> _favoriteItems;

		// Token: 0x0400135D RID: 4957
		private ProcessorUICategoryItem _favoriteCategory;

		// Token: 0x0400135E RID: 4958
		private ProcessorUINodeItem _singleItem;
	}
}
