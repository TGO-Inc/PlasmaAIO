using System;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Visor
{
	// Token: 0x020002A1 RID: 673
	public class SelectionItem : MonoBehaviour
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x000868FD File Offset: 0x00084AFD
		public void Setup(SelectionEditor editor, string text, int id, bool state)
		{

		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00086921 File Offset: 0x00084B21
		private void HandleValue(bool value)
		{

		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00086934 File Offset: 0x00084B34
		public void SetValue(bool value)
		{

		}

		// Token: 0x04001599 RID: 5529
		public BetterToggle toggle;

		// Token: 0x0400159A RID: 5530
		public TextMeshProUGUI label;

		// Token: 0x0400159B RID: 5531
		private SelectionEditor _editor;

		// Token: 0x0400159C RID: 5532
		private int _id;
	}
}
