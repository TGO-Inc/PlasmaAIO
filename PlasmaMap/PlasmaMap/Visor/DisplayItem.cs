using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Sirenix.OdinInspector;
using TMPro;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002A9 RID: 681
	public class DisplayItem : SerializedMonoBehaviour
	{
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x000875EB File Offset: 0x000857EB
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x000875F3 File Offset: 0x000857F3
		public int index { get; private set; }

		// Token: 0x06001AC8 RID: 6856 RVA: 0x000875FC File Offset: 0x000857FC
		public void Setup(int theIndex, SettingsPopup settingsPopup)
		{

		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00087628 File Offset: 0x00085828
		public void OnClicked()
		{

		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00087636 File Offset: 0x00085836
		public void Select()
		{

		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00087649 File Offset: 0x00085849
		public void Deselect()
		{

		}

		// Token: 0x040015CD RID: 5581
		public TextMeshProUGUI display;

		// Token: 0x040015CE RID: 5582
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x040015CF RID: 5583
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x040015D0 RID: 5584
		private SettingsPopup _settingsPopup;
	}
}
