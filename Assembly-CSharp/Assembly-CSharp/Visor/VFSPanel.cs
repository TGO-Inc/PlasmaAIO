using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using DG.Tweening;
using DG.Tweening.Timeline;
using FMODUnity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200025A RID: 602
	public class VFSPanel : MonoBehaviour
	{
		// Token: 0x06001679 RID: 5753 RVA: 0x000710BB File Offset: 0x0006F2BB
		public void Setup()
		{

		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000710D0 File Offset: 0x0006F2D0
		public void Show(string theMessage, Visor.VFSMessageTypes type)
		{

		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00071220 File Offset: 0x0006F420
		private void SetupContent(string theMessage, Visor.VFSMessageTypes type)
		{

		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000712A2 File Offset: 0x0006F4A2
		private IEnumerator Wait()
		{

            return default;
        }

		// Token: 0x0600167D RID: 5757 RVA: 0x000712B1 File Offset: 0x0006F4B1
		private void OnDestroy()
		{

		}

		// Token: 0x0400123E RID: 4670
		public float duration;

		// Token: 0x0400123F RID: 4671
		public Image icon;

		// Token: 0x04001240 RID: 4672
		public Sprite infoSprite;

		// Token: 0x04001241 RID: 4673
		public Sprite errorSprite;

		// Token: 0x04001242 RID: 4674
		public TextMeshProUGUI message;

		// Token: 0x04001243 RID: 4675
		public DOVisualSequence openSequence;

		// Token: 0x04001244 RID: 4676
		public DOVisualSequence closeSequence;

		// Token: 0x04001245 RID: 4677
		[EventRef]
		public string openNegativeSound;

		// Token: 0x04001246 RID: 4678
		[EventRef]
		public string closeNegativeSound;

		// Token: 0x04001247 RID: 4679
		[EventRef]
		public string openPositiveSound;

		// Token: 0x04001248 RID: 4680
		[EventRef]
		public string closePositiveSound;

		// Token: 0x04001249 RID: 4681
		private string _queuedMessage;

		// Token: 0x0400124A RID: 4682
		private Visor.VFSMessageTypes _queuedType;

		// Token: 0x0400124B RID: 4683
		private Visor.VFSMessageTypes _lastType;

		// Token: 0x0400124C RID: 4684
		private bool _useQueue;

		// Token: 0x0400124D RID: 4685
		private VFSPanel.States _state;

		// Token: 0x0400124E RID: 4686
		private UIColorMapperController _colorMapper;

		// Token: 0x02000467 RID: 1127
		private enum States
		{
			// Token: 0x04001F67 RID: 8039
			Closed,
			// Token: 0x04001F68 RID: 8040
			Opening,
			// Token: 0x04001F69 RID: 8041
			Showing,
			// Token: 0x04001F6A RID: 8042
			Closing,
			// Token: 0x04001F6B RID: 8043
			Transitioning
		}
	}
}
