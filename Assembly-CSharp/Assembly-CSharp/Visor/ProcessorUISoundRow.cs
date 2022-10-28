using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Visor
{
	// Token: 0x02000275 RID: 629
	public class ProcessorUISoundRow : MonoBehaviour
	{
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00077A74 File Offset: 0x00075C74
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x00077A7C File Offset: 0x00075C7C
		public string soundEvent { get; private set; }

		// Token: 0x060017ED RID: 6125 RVA: 0x00077A88 File Offset: 0x00075C88
		public void Setup(string theSoundEvent, ProcessorUISoundEditor editor)
		{

		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00077B0A File Offset: 0x00075D0A
		public void CleanUp()
		{

		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00077B25 File Offset: 0x00075D25
		public void Select()
		{

		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00077B38 File Offset: 0x00075D38
		public void Deselect()
		{

		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00077B4B File Offset: 0x00075D4B
		public void OnClicked()
		{

		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00077B59 File Offset: 0x00075D59
		private void HandlePlayStopEvent(bool play)
		{

		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00077B7C File Offset: 0x00075D7C
		private void Update()
		{

		}

		// Token: 0x0400136E RID: 4974
		public PlaySoundButton playButton;

		// Token: 0x0400136F RID: 4975
		public TextMeshProUGUI info;

		// Token: 0x04001370 RID: 4976
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x04001371 RID: 4977
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x04001372 RID: 4978
		public bool isEmpty;

		// Token: 0x04001373 RID: 4979
		private Rect _viewportRect;

		// Token: 0x04001374 RID: 4980
		private RectTransform _rectTransform;

		// Token: 0x04001375 RID: 4981
		private bool _visible;

		// Token: 0x04001376 RID: 4982
		private ProcessorUISoundEditor _editor;
	}
}
