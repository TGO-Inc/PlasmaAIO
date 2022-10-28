using System;
using System.Collections;
using DG.Tweening;
using DG.Tweening.Timeline;
using FMODUnity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200023F RID: 575
	public class DialogBox : MonoBehaviour
	{
		// Token: 0x060014E7 RID: 5351 RVA: 0x0006A4DE File Offset: 0x000686DE
		private void Awake()
		{

		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0006A4F8 File Offset: 0x000686F8
		public void Setup(string theTitle, string theMessage, string cancelText, string okText, bool critical, bool showLoadingCircle, bool enableMask, float timer)
		{

		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0006A5EE File Offset: 0x000687EE
		private IEnumerator RunTimer()
		{

            return default;
        }

		// Token: 0x060014EA RID: 5354 RVA: 0x0006A600 File Offset: 0x00068800
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x060014EB RID: 5355 RVA: 0x0006A658 File Offset: 0x00068858
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x060014EC RID: 5356 RVA: 0x0006A6A6 File Offset: 0x000688A6
		public void CancelAndClose()
		{

		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0006A6CC File Offset: 0x000688CC
		public void OkAndClose()
		{

		}

		// Token: 0x040010FF RID: 4351
		public TextMeshProUGUI title;

		// Token: 0x04001100 RID: 4352
		public TextMeshProUGUI message;

		// Token: 0x04001101 RID: 4353
		public TextMeshProUGUI cancelButton;

		// Token: 0x04001102 RID: 4354
		public TextMeshProUGUI okButton;

		// Token: 0x04001103 RID: 4355
		public GameObject loadingCircle;

		// Token: 0x04001104 RID: 4356
		public UIBetterButtonColorMapper criticalMapper;

		// Token: 0x04001105 RID: 4357
		public DOVisualSequence openSequence;

		// Token: 0x04001106 RID: 4358
		public DOVisualSequence closeSequence;

		// Token: 0x04001107 RID: 4359
		[EventRef]
		public string openSound;

		// Token: 0x04001108 RID: 4360
		[EventRef]
		public string closeSound;

		// Token: 0x04001109 RID: 4361
		private RectMask2D _mask;

		// Token: 0x0400110A RID: 4362
		private float _timer;

		// Token: 0x0400110B RID: 4363
		private string _title;

		// Token: 0x0400110C RID: 4364
		private Coroutine _coroutine;
	}
}
