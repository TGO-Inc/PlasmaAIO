using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using DG.Tweening.Timeline;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000235 RID: 565
	public class ComponentItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00066500 File Offset: 0x00064700
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x00066508 File Offset: 0x00064708
		public ComponentLibrary componentLibrary { get; set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00066511 File Offset: 0x00064711
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x00066519 File Offset: 0x00064719
		public AgentGestaltEnum componentGestaltId { get; private set; }

		// Token: 0x060013F3 RID: 5107 RVA: 0x00066524 File Offset: 0x00064724
		public void Setup(AgentGestaltEnum theComponentGestaltId)
		{

		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0006662C File Offset: 0x0006482C
		public void UpdateQuickbarSlot()
		{

		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0006667F File Offset: 0x0006487F
		private void OnDisable()
		{

		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00066688 File Offset: 0x00064888
		public void Reveal()
		{

		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0006669C File Offset: 0x0006489C
		private void Update()
		{

		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00066804 File Offset: 0x00064A04
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0006689F File Offset: 0x00064A9F
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000668A8 File Offset: 0x00064AA8
		public void OnPointerDown(PointerEventData data)
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000668AA File Offset: 0x00064AAA
		public void OnPointerUp(PointerEventData data)
		{

		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000668D8 File Offset: 0x00064AD8
		private void Unhighlight(bool animate = true)
		{

		}

		// Token: 0x0400102C RID: 4140
		public TextMeshProUGUI componentName;

		// Token: 0x0400102D RID: 4141
		public TextMeshProUGUI quickbarSlotNumber;

		// Token: 0x0400102E RID: 4142
		public TextMeshProUGUI description;

		// Token: 0x0400102F RID: 4143
		public TextMeshProUGUI massValue;

		// Token: 0x04001030 RID: 4144
		public GameObject helpButton;

		// Token: 0x04001031 RID: 4145
		public Image preview;

		// Token: 0x04001032 RID: 4146
		public DOVisualSequence highlightSequence;

		// Token: 0x04001033 RID: 4147
		public DOVisualSequence unhighlightSequence;

		// Token: 0x04001034 RID: 4148
		public DOVisualSequence assignmentSequence;

		// Token: 0x04001035 RID: 4149
		public DOVisualSequence revealSequence;

		// Token: 0x04001036 RID: 4150
		private Player _input;

		// Token: 0x04001037 RID: 4151
		private DOVisualSequence _currentSequence;

		// Token: 0x04001038 RID: 4152
		private UIColorMapperController _mapperController;

		// Token: 0x04001039 RID: 4153
		private bool _isHighlighted;
	}
}
