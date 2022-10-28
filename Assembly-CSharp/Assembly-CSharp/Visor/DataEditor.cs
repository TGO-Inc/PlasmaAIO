using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using Rewired;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000291 RID: 657
	public class DataEditor : SerializedMonoBehaviour, IEscapeHandler
	{
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00083296 File Offset: 0x00081496
		public bool isDirty
		{
			get
			{
				return this._isDirty;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0008329E File Offset: 0x0008149E
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x000832A6 File Offset: 0x000814A6
		public Data cachedConfiguredData { get; private set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000832AF File Offset: 0x000814AF
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x000832B7 File Offset: 0x000814B7
		public Data cachedRuntimeData { get; private set; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000832C0 File Offset: 0x000814C0
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x000832C8 File Offset: 0x000814C8
		public string cachedVariable { get; private set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000832D1 File Offset: 0x000814D1
		public virtual TMP_InputField mainTextField
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000832D4 File Offset: 0x000814D4
		public virtual void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x060019ED RID: 6637 RVA: 0x000833AA File Offset: 0x000815AA
		public virtual void CleanUp()
		{

		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000833CD File Offset: 0x000815CD
		public void OnEscapePressed()
		{

		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000833DF File Offset: 0x000815DF
		protected void SetDirty(bool value)
		{

		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00083419 File Offset: 0x00081619
		protected void Apply()
		{

		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0008342C File Offset: 0x0008162C
		public void SetData(Data configuredData, Data runtimeData = null)
		{

		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0008347E File Offset: 0x0008167E
		public void SetVariable(string variableName)
		{

		}

		// Token: 0x040014FB RID: 5371
		public bool needsScrollBar;

		// Token: 0x040014FC RID: 5372
		public Vector2 processorUISize;

		// Token: 0x040014FD RID: 5373
		public UIColorMapperController confirmMapper;

		// Token: 0x040014FE RID: 5374
		public Button applyButton;

		// Token: 0x040014FF RID: 5375
		public Button closeButton;

		// Token: 0x04001500 RID: 5376
		public bool showApplyMessage;

		// Token: 0x04001501 RID: 5377
		protected Agent _agent;

		// Token: 0x04001502 RID: 5378
		protected int _propertyId;

		// Token: 0x04001503 RID: 5379
		protected AgentProperty _configuredProperty;

		// Token: 0x04001504 RID: 5380
		protected AgentProperty _runtimeProperty;

		// Token: 0x04001505 RID: 5381
		protected ProcessorUI _processorUI;

		// Token: 0x04001506 RID: 5382
		protected Player _input;

		// Token: 0x04001507 RID: 5383
		private EscapeManager _escapeManager;

		// Token: 0x04001508 RID: 5384
		private bool _isDirty;

		// Token: 0x04001509 RID: 5385
		private bool _canClose;
	}
}
