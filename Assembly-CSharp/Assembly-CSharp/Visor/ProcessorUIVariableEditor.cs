using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000277 RID: 631
	public class ProcessorUIVariableEditor : DataEditor
	{
		// Token: 0x060017FA RID: 6138 RVA: 0x00077C80 File Offset: 0x00075E80
		private void Awake()
		{

		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00077D10 File Offset: 0x00075F10
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00077D76 File Offset: 0x00075F76
		private void HandleChange(string text)
		{

		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00077DB0 File Offset: 0x00075FB0
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00077E28 File Offset: 0x00076028
		private void Populate()
		{

		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00077F20 File Offset: 0x00076120
		public void SelectVariable(ProcessorUIVariableEditorItem variableItem)
		{

		}

		// Token: 0x0400137E RID: 4990
		public TMP_InputField nameField;

		// Token: 0x0400137F RID: 4991
		public GameObject variableItemPrefab;

		// Token: 0x04001380 RID: 4992
		public Transform content;

		// Token: 0x04001381 RID: 4993
		public GameObject message;

		// Token: 0x04001382 RID: 4994
		private ProcessorUIVariableEditorItem _selectedVariableItem;

		// Token: 0x04001383 RID: 4995
		private string _mappedVariable;
	}
}
