using System;
using DG.Tweening.Timeline;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000262 RID: 610
	public class ProcessorLibraryItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00071855 File Offset: 0x0006FA55
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x0007185D File Offset: 0x0006FA5D
		public AgentId agentId { get; private set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x00071866 File Offset: 0x0006FA66
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0007186E File Offset: 0x0006FA6E
		public bool isModule { get; private set; }

		// Token: 0x060016B1 RID: 5809 RVA: 0x00071877 File Offset: 0x0006FA77
		public void SetupAsComponent(AgentId theAgentId, AgentGestalt.ComponentCategories category, Sprite iconSprite, ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000718AB File Offset: 0x0006FAAB
		public void SetupAsModule(AgentId theAgentId, ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000718E7 File Offset: 0x0006FAE7
		public void SetupAsLogic(AgentId theAgentId, ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0007191C File Offset: 0x0006FB1C
		public void SetupAsGhost(ProcessorLibraryItem originalItem)
		{

		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00071980 File Offset: 0x0006FB80
		private void Setup(AgentId theAgentId, ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00071AA0 File Offset: 0x0006FCA0
		public void SetState(ProcessorLibraryItem.States state, bool colorsOnly = false)
		{

		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00071B37 File Offset: 0x0006FD37
		private void ShowMultiIcon(bool state)
		{

		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00071B4C File Offset: 0x0006FD4C
		public void UpdateVisuals(bool multiIcon)
		{

		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00071BEE File Offset: 0x0006FDEE
		public void OnPointerEnter(PointerEventData eventData)
		{

		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00071C0D File Offset: 0x0006FE0D
		public void OnPointerExit(PointerEventData eventData)
		{

		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00071C34 File Offset: 0x0006FE34
		public void OnPointerDown(PointerEventData eventData)
		{

		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00071C63 File Offset: 0x0006FE63
		private void OnDestroy()
		{

		}

		// Token: 0x04001278 RID: 4728
		public UIImageColorMapper backgroundHighlightedMapper;

		// Token: 0x04001279 RID: 4729
		public UIImageColorMapper iconBackgroundNormalMapper;

		// Token: 0x0400127A RID: 4730
		public UIImageColorMapper iconHighlightedMapper;

		// Token: 0x0400127B RID: 4731
		public UIImageColorMapper multiIconHighlightedMapper;

		// Token: 0x0400127C RID: 4732
		public Image icon;

		// Token: 0x0400127D RID: 4733
		public TextMeshProUGUI label;

		// Token: 0x0400127E RID: 4734
		public Sprite logicIcon;

		// Token: 0x0400127F RID: 4735
		public DOVisualSequence shiftRightSequence;

		// Token: 0x04001280 RID: 4736
		public DOVisualSequence shiftLeftSequence;

		// Token: 0x04001281 RID: 4737
		private ProcessorUI _processorUI;

		// Token: 0x04001282 RID: 4738
		private UIColorMapperController _mapperController;

		// Token: 0x04001283 RID: 4739
		private ProcessorLibraryItem.States _state;

		// Token: 0x04001284 RID: 4740
		private Holder.SketchColorTheme _colorTheme;

		// Token: 0x04001285 RID: 4741
		private CanvasGroup _canvasGroup;

		// Token: 0x04001286 RID: 4742
		private bool _isGhost;

		// Token: 0x04001287 RID: 4743
		private bool _beingDragged;

		// Token: 0x0200046C RID: 1132
		public enum States
		{
			// Token: 0x04001F7A RID: 8058
			Normal,
			// Token: 0x04001F7B RID: 8059
			Highlighted
		}
	}
}
