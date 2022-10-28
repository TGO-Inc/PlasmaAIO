using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using InGameCodeEditor;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002A5 RID: 677
	public class StringEditor : DataEditor
	{
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00086F92 File Offset: 0x00085192
		public override TMP_InputField mainTextField
		{
			get
			{
				return this._inputField;
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00086F9A File Offset: 0x0008519A
		private void Awake()
		{

		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00086FA8 File Offset: 0x000851A8
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000870F9 File Offset: 0x000852F9
		public override void CleanUp()
		{

		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00087120 File Offset: 0x00085320
		private void HandleChange(string text)
		{

		}

		// Token: 0x040015B7 RID: 5559
		public GameObject highlightedText;

		// Token: 0x040015B8 RID: 5560
		public UIBetterInputFieldColorMapper normalMapper;

		// Token: 0x040015B9 RID: 5561
		public UIBetterInputFieldColorMapper scriptMapper;

		// Token: 0x040015BA RID: 5562
		private TMP_InputField _inputField;

		// Token: 0x040015BB RID: 5563
		private Vector2 _originalSize;
	}
}
