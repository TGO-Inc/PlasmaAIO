using System;
using System.Collections.Generic;
using UnityEngine;

namespace Visor
{
	// Token: 0x020002A7 RID: 679
	public class Quickbar : VisorElement
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0008736F File Offset: 0x0008556F
		public bool isEnabled
		{
			get
			{
				return this._currentState == VisorElement.States.Enabled;
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0008737C File Offset: 0x0008557C
		protected override void CustomSetup()
		{

		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000873FC File Offset: 0x000855FC
		public void UpdateAssignment(int slotIndex, bool animate = true)
		{

		}

		// Token: 0x040015C2 RID: 5570
		public Transform slotsContainer;

		// Token: 0x040015C3 RID: 5571
		private Dictionary<int, QuickbarSlot> _slots;
	}
}
