using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x02000270 RID: 624
	public class ProcessorUINodeItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00076A36 File Offset: 0x00074C36
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00076A3E File Offset: 0x00074C3E
		public AgentId agentId { get; private set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00076A47 File Offset: 0x00074C47
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00076A4F File Offset: 0x00074C4F
		public AgentCategoryEnum category { get; private set; }

		// Token: 0x060017B7 RID: 6071 RVA: 0x00076A58 File Offset: 0x00074C58
		public void Setup(AgentId theAgentId, AgentCategoryEnum theCategory, ProcessorUINodeLibrary theProcessorUINodeLibrary)
		{

		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00076AB3 File Offset: 0x00074CB3
		public void OnClick()
		{

		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00076AC6 File Offset: 0x00074CC6
		public void OnPointerEnter(PointerEventData eventData)
		{

		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00076ADE File Offset: 0x00074CDE
		public void OnPointerClick(PointerEventData eventData)
		{

		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00076B05 File Offset: 0x00074D05
		public void SetAsShortcut(bool value)
		{

		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00076B22 File Offset: 0x00074D22
		private void RefreshFavoriteIcon()
		{

		}

		// Token: 0x04001348 RID: 4936
		public TextMeshProUGUI label;

		// Token: 0x04001349 RID: 4937
		public GameObject favoriteIcon;

		// Token: 0x0400134A RID: 4938
		private ProcessorUINodeLibrary _processorUINodeLibrary;

		// Token: 0x0400134B RID: 4939
		private UIColorMapperController _mapperController;
	}
}
