using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Timeline;
using Rewired;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000236 RID: 566
	public class ComponentLibrary : SerializedMonoBehaviour
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00066981 File Offset: 0x00064B81
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x00066989 File Offset: 0x00064B89
		public bool canAssignQuickbarSlot { get; set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00066992 File Offset: 0x00064B92
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0006699A File Offset: 0x00064B9A
		public bool canSpawn { get; private set; }

		// Token: 0x06001403 RID: 5123 RVA: 0x000669A3 File Offset: 0x00064BA3
		private void Awake()
		{

		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000669C6 File Offset: 0x00064BC6
		private void Start()
		{

		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000669D4 File Offset: 0x00064BD4
		public void Setup()
		{

		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00066A50 File Offset: 0x00064C50
		private void Populate()
		{

		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00066BEC File Offset: 0x00064DEC
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x06001408 RID: 5128 RVA: 0x00066BFB File Offset: 0x00064DFB
		private IEnumerator MoveCaretToEnd()
		{

            return default;
        }

		// Token: 0x06001409 RID: 5129 RVA: 0x00066C0A File Offset: 0x00064E0A
		private void HandleChange(string text)
		{

		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00066C4C File Offset: 0x00064E4C
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00066CFC File Offset: 0x00064EFC
		public void OnCategoryClicked(ComponentCategoryButton button)
		{

		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00066D5C File Offset: 0x00064F5C
		public void PreOpen()
		{

		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00066DF1 File Offset: 0x00064FF1
		public void PostOpen()
		{

		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00066E04 File Offset: 0x00065004
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x0600140F RID: 5135 RVA: 0x00066E30 File Offset: 0x00065030
		public void PreClose()
		{

		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00066EA9 File Offset: 0x000650A9
		public void PostClose()
		{

		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00066EB8 File Offset: 0x000650B8
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x06001412 RID: 5138 RVA: 0x00066EE2 File Offset: 0x000650E2
		public void Close()
		{

		}

		// Token: 0x0400103C RID: 4156
		public TMP_InputField searchField;

		// Token: 0x0400103D RID: 4157
		public GameObject message;

		// Token: 0x0400103E RID: 4158
		public RectTransform content;

		// Token: 0x0400103F RID: 4159
		public ScrollRect scrollRect;

		// Token: 0x04001040 RID: 4160
		public Dictionary<AgentGestalt.ComponentCategories, ComponentCategoryButton> categoryButtons;

		// Token: 0x04001041 RID: 4161
		public DOVisualSequence openSequence;

		// Token: 0x04001042 RID: 4162
		public DOVisualSequence closeSequence;

		// Token: 0x04001043 RID: 4163
		private Player _input;

		// Token: 0x04001044 RID: 4164
		private IEnumerator _inputCoroutine;

		// Token: 0x04001045 RID: 4165
		private ComponentCategoryButton _selectedCategoryButton;

		// Token: 0x04001046 RID: 4166
		private bool _canClose;

		// Token: 0x04001047 RID: 4167
		private Regex _regex;

		// Token: 0x04001048 RID: 4168
		private bool _fastSpawn;
	}
}
