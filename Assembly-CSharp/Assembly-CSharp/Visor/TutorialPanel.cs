using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Timeline;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000258 RID: 600
	public class TutorialPanel : MonoBehaviour
	{
		// Token: 0x06001668 RID: 5736 RVA: 0x00070B98 File Offset: 0x0006ED98
		public void Setup()
		{

		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00070C10 File Offset: 0x0006EE10
		public void ShowMessage(TutorialGestaltEnum id, string extraText = null)
		{

		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00070CC1 File Offset: 0x0006EEC1
		private IEnumerator Run()
		{

            return default;
        }

		// Token: 0x04001225 RID: 4645
		public TextMeshProUGUI message;

		// Token: 0x04001226 RID: 4646
		public RectTransform drawer;

		// Token: 0x04001227 RID: 4647
		public float lineHeight;

		// Token: 0x04001228 RID: 4648
		public float stayTimer;

		// Token: 0x04001229 RID: 4649
		public float inBetweenTimer;

		// Token: 0x0400122A RID: 4650
		public int maxImpressions;

		// Token: 0x0400122B RID: 4651
		public DOVisualSequence showSequence;

		// Token: 0x0400122C RID: 4652
		public DOVisualSequence hideSequence;

		// Token: 0x0400122D RID: 4653
		private TutorialGestaltEnum _currentTutorial;

		// Token: 0x0400122E RID: 4654
		private TutorialGestaltEnum _nextTutorial;

		// Token: 0x0400122F RID: 4655
		private string _extraText;

		// Token: 0x04001230 RID: 4656
		private Sequence _showSequence;

		// Token: 0x04001231 RID: 4657
		private Sequence _hideSequence;

		// Token: 0x04001232 RID: 4658
		private Dictionary<TutorialGestaltEnum, float> _lastShown;
	}
}
