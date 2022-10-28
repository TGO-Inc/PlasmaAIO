using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000274 RID: 628
	public class ProcessorUISoundEditor : DataEditor
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x00077659 File Offset: 0x00075859
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0007767D File Offset: 0x0007587D
		public override void CleanUp()
		{

		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0007768C File Offset: 0x0007588C
		public void HandleChange(string text)
		{

		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000776D4 File Offset: 0x000758D4
		public void HandleSubmit(string text)
		{

		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00077730 File Offset: 0x00075930
		private void Populate()
		{

		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00077864 File Offset: 0x00075A64
		public void StopLastSoundRow(PlaySoundButton currentSoundButton)
		{

		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00077887 File Offset: 0x00075A87
		public void ClearLastSoundRow()
		{

		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00077890 File Offset: 0x00075A90
		public void OnSoundRowClicked(ProcessorUISoundRow soundRow)
		{

		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x000778E0 File Offset: 0x00075AE0
		private void SelectSoundRowByEvent(string soundEvent)
		{

		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00077970 File Offset: 0x00075B70
		private void SelectEmptySoundRow()
		{

		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00077998 File Offset: 0x00075B98
		private void SetSound(ProcessorUISoundRow soundRow)
		{

		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x000779E0 File Offset: 0x00075BE0
		private void SnapTo(ProcessorUISoundRow target)
		{

		}

		// Token: 0x04001366 RID: 4966
		public TMP_InputField searchField;

		// Token: 0x04001367 RID: 4967
		public ScrollRectNoDragging scrollRect;

		// Token: 0x04001368 RID: 4968
		public RectTransform content;

		// Token: 0x04001369 RID: 4969
		public GameObject soundRowPrefab;

		// Token: 0x0400136A RID: 4970
		public GameObject soundRowEmptyPrefab;

		// Token: 0x0400136B RID: 4971
		private ProcessorUISoundRow _selectedSoundRow;

		// Token: 0x0400136C RID: 4972
		private ProcessorUISoundRow _emptyRow;

		// Token: 0x0400136D RID: 4973
		private PlaySoundButton _lastSoundButton;
	}
}
