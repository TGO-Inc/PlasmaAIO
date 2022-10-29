using PlasmaAPI.GameClass.Behavior;
﻿using System;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000269 RID: 617
	public class ProcessorUIImageRow : MonoBehaviour
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00074A42 File Offset: 0x00072C42
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x00074A4A File Offset: 0x00072C4A
		public UserAssetsController.AssetDescription assetDescription { get; private set; }

		// Token: 0x06001765 RID: 5989 RVA: 0x00074A54 File Offset: 0x00072C54
		public void Setup(UserAssetsController.AssetDescription theAssetDescription, ProcessorUIImageEditor editor)
		{

		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00074AB5 File Offset: 0x00072CB5
		public void Select()
		{

		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00074AC8 File Offset: 0x00072CC8
		public void Deselect()
		{

		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00074ADB File Offset: 0x00072CDB
		public void OnClicked()
		{

		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00074AE9 File Offset: 0x00072CE9
		public void Click()
		{

		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00074AFC File Offset: 0x00072CFC
		private void Update()
		{

		}

		// Token: 0x0400130C RID: 4876
		public RawImage thumbnail;

		// Token: 0x0400130D RID: 4877
		public TextMeshProUGUI info;

		// Token: 0x0400130E RID: 4878
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x0400130F RID: 4879
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x04001310 RID: 4880
		public bool isEmpty;

		// Token: 0x04001311 RID: 4881
		public bool isRuntime;

		// Token: 0x04001312 RID: 4882
		private Rect _viewportRect;

		// Token: 0x04001313 RID: 4883
		private RectTransform _rectTransform;

		// Token: 0x04001314 RID: 4884
		private bool _visible;

		// Token: 0x04001315 RID: 4885
		private ProcessorUIImageEditor _editor;
	}
}
