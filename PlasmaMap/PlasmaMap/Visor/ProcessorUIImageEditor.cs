using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Data = PlasmaAPI.GameClass.Behavior.Data;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000268 RID: 616
	public class ProcessorUIImageEditor : DataEditor
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x000743FC File Offset: 0x000725FC
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000744F4 File Offset: 0x000726F4
		public override void CleanUp()
		{

		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000745C4 File Offset: 0x000727C4
		public void HandleChange(string text)
		{

		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00074624 File Offset: 0x00072824
		public void HandleSubmit(string text)
		{

		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00074680 File Offset: 0x00072880
		private void SetImage(ProcessorUIImageRow imageRow)
		{

		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000747B8 File Offset: 0x000729B8
		private void Populate()
		{

		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00074898 File Offset: 0x00072A98
		public void OnImageRowClicked(ProcessorUIImageRow imageRow)
		{

		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000748E8 File Offset: 0x00072AE8
		private void SelectImageRowByMD5(string md5)
		{

		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0007497C File Offset: 0x00072B7C
		private void SelectEmptyImageRow()
		{

		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000749A1 File Offset: 0x00072BA1
		private void SelectRuntimeImageRow()
		{

		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000749C8 File Offset: 0x00072BC8
		private void SnapTo(ProcessorUIImageRow target)
		{

		}

		// Token: 0x04001300 RID: 4864
		public TMP_InputField searchField;

		// Token: 0x04001301 RID: 4865
		public ScrollRectNoDragging scrollRect;

		// Token: 0x04001302 RID: 4866
		public RectTransform content;

		// Token: 0x04001303 RID: 4867
		public GameObject imageRowPrefab;

		// Token: 0x04001304 RID: 4868
		public GameObject imageRowRuntimePrefab;

		// Token: 0x04001305 RID: 4869
		public GameObject imageRowEmptyPrefab;

		// Token: 0x04001306 RID: 4870
		private Data _oldConfiguredData;

		// Token: 0x04001307 RID: 4871
		private Data _oldRuntimeData;

		// Token: 0x04001308 RID: 4872
		private int _selectedImageIndex;

		// Token: 0x04001309 RID: 4873
		private ProcessorUIImageRow _runtimeRow;

		// Token: 0x0400130A RID: 4874
		private ProcessorUIImageRow _emptyRow;

		// Token: 0x0400130B RID: 4875
		private ProcessorUIImageRow _selectedImageRow;
	}
}
