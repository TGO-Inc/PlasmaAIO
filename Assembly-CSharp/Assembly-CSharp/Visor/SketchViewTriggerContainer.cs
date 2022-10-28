using System;
using System.Collections.Generic;
using UnityEngine;

namespace Visor
{
	// Token: 0x0200028A RID: 650
	public class SketchViewTriggerContainer : MonoBehaviour
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x00082450 File Offset: 0x00080650
		private void Awake()
		{

		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0008245D File Offset: 0x0008065D
		public void AddTrigger(SketchViewTrigger trigger)
		{

		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0008248C File Offset: 0x0008068C
		public void RemoveTrigger(SketchViewTrigger trigger)
		{

		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000824BC File Offset: 0x000806BC
		public void CleanUp()
		{

		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00082518 File Offset: 0x00080718
		public void Disable()
		{

		}

		// Token: 0x040014D6 RID: 5334
		public int priorityBase;

		// Token: 0x040014D7 RID: 5335
		private HashSet<SketchViewTrigger> _triggers;
	}
}
