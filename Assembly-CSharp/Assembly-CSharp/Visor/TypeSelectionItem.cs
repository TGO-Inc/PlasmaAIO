using System;
using Behavior;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200028C RID: 652
	public class TypeSelectionItem : MonoBehaviour
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x00082A9F File Offset: 0x00080C9F
		public void Setup(ProcessorUI editor, bool state)
		{

		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00082AAF File Offset: 0x00080CAF
		private void HandleValue(bool value)
		{

		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00082AC8 File Offset: 0x00080CC8
		private void SetValue(bool value)
		{

		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00082B1C File Offset: 0x00080D1C
		private void OnValidate()
		{

		}

		// Token: 0x040014E7 RID: 5351
		public BetterToggle toggle;

		// Token: 0x040014E8 RID: 5352
		public TextMeshProUGUI label;

		// Token: 0x040014E9 RID: 5353
		public Image icon;

		// Token: 0x040014EA RID: 5354
		public Data.Types type;

		// Token: 0x040014EB RID: 5355
		private ProcessorUI _processorUI;
	}
}
