using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Sirenix.OdinInspector;
using TMPro;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002AA RID: 682
	public class QualityItem : SerializedMonoBehaviour
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00087664 File Offset: 0x00085864
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0008766C File Offset: 0x0008586C
		public int index { get; private set; }

		// Token: 0x06001ACF RID: 6863 RVA: 0x00087675 File Offset: 0x00085875
		public void Setup(string theQuality, int theIndex, SettingsPopup settingsPopup)
		{

		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00087691 File Offset: 0x00085891
		public void OnClicked()
		{

		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0008769F File Offset: 0x0008589F
		public void Select()
		{

		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000876B2 File Offset: 0x000858B2
		public void Deselect()
		{

		}

		// Token: 0x040015D2 RID: 5586
		public TextMeshProUGUI quality;

		// Token: 0x040015D3 RID: 5587
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x040015D4 RID: 5588
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x040015D5 RID: 5589
		private SettingsPopup _settingsPopup;
	}
}
