using System;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Visor
{
	// Token: 0x02000298 RID: 664
	public class InterfaceItem : MonoBehaviour
	{
		// Token: 0x06001A19 RID: 6681 RVA: 0x00083F4F File Offset: 0x0008214F
		public void Setup(InterfaceEditor editor, string text, int id, bool state)
		{

		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00083F73 File Offset: 0x00082173
		private void HandleValue(bool value)
		{

		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00083F88 File Offset: 0x00082188
		public void SetValue(bool value)
		{

		}

		// Token: 0x04001530 RID: 5424
		public BetterToggle toggle;

		// Token: 0x04001531 RID: 5425
		public TextMeshProUGUI label;

		// Token: 0x04001532 RID: 5426
		private InterfaceEditor _editor;

		// Token: 0x04001533 RID: 5427
		private int _id;
	}
}
