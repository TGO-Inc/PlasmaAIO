using System;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000233 RID: 563
	public class PlaySoundButton : MonoBehaviour
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x000662E4 File Offset: 0x000644E4
		public void Setup(string soundEvent, bool inTooltip = false)
		{

		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00066334 File Offset: 0x00064534
		private void Update()
		{

		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00066371 File Offset: 0x00064571
		public void OnClick()
		{

		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000663A0 File Offset: 0x000645A0
		private void Play()
		{

		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00066404 File Offset: 0x00064604
		public void Stop(bool stopSound)
		{

		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00066468 File Offset: 0x00064668
		public void CleanUp()
		{

		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000664A0 File Offset: 0x000646A0
		private void OnDestroy()
		{

		}

		// Token: 0x04001021 RID: 4129
		public Image icon;

		// Token: 0x04001022 RID: 4130
		public Sprite playIcon;

		// Token: 0x04001023 RID: 4131
		public Sprite stopIcon;

		// Token: 0x04001024 RID: 4132
		public UnityAction<bool> PlayStopEvent;

		// Token: 0x04001025 RID: 4133
		private string _soundEvent;

		// Token: 0x04001026 RID: 4134
		private EventInstance _soundInstance;

		// Token: 0x04001027 RID: 4135
		private bool _isPlaying;
	}
}
