using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200026D RID: 621
	public class ProcessorUILabelSettings : MonoBehaviour, IEscapeHandler
	{
		// Token: 0x0600179C RID: 6044 RVA: 0x000760A8 File Offset: 0x000742A8
		public void Setup(SketchViewLabel label)
		{

		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000761B0 File Offset: 0x000743B0
		public void CleanUp()
		{

		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00076203 File Offset: 0x00074403
		public void OnEscapePressed()
		{

		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0007621C File Offset: 0x0007441C
		public void Apply()
		{

		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x000762B0 File Offset: 0x000744B0
		private void HandleCommentChange(string text)
		{

		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00076368 File Offset: 0x00074568
		private void HandleTitleChange(string text)
		{

		}

		// Token: 0x04001339 RID: 4921
		public TMP_InputField titleField;

		// Token: 0x0400133A RID: 4922
		public TMP_InputField commentField;

		// Token: 0x0400133B RID: 4923
		public TMP_InputField demoImageAssetField;

		// Token: 0x0400133C RID: 4924
		public Button applyButton;

		// Token: 0x0400133D RID: 4925
		private SketchViewLabel _label;

		// Token: 0x0400133E RID: 4926
		private EscapeManager _escapeManager;
	}
}
