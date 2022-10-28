using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002A4 RID: 676
	public class SoundRow : MonoBehaviour
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x00086E74 File Offset: 0x00085074
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x00086E7C File Offset: 0x0008507C
		public string soundEvent { get; private set; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x00086E85 File Offset: 0x00085085
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x00086E8D File Offset: 0x0008508D
		public int position { get; private set; }

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00086E98 File Offset: 0x00085098
		public void Setup(string theSoundEvent, int thePosition, SoundBrowser browser)
		{

		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00086EFD File Offset: 0x000850FD
		public void CleanUp()
		{

		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00086F18 File Offset: 0x00085118
		public void Select()
		{

		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00086F2B File Offset: 0x0008512B
		public void Deselect()
		{

		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00086F5A File Offset: 0x0008515A
		public void OnClicked()
		{

		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00086F68 File Offset: 0x00085168
		private void HandlePlayStopEvent(bool play)
		{

		}

		// Token: 0x040015AE RID: 5550
		public PlaySoundButton playButton;

		// Token: 0x040015AF RID: 5551
		public TextMeshProUGUI info;

		// Token: 0x040015B0 RID: 5552
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x040015B1 RID: 5553
		public UIBetterButtonColorMapper alternateMapper;

		// Token: 0x040015B2 RID: 5554
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x040015B3 RID: 5555
		[FormerlySerializedAs("isNone")]
		public bool isEmpty;

		// Token: 0x040015B4 RID: 5556
		private SoundBrowser _browser;
	}
}
