using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001CB RID: 459
	[AddComponentMenu("Better UI/Controls/Better Dropdown", 30)]
	public class BetterDropdown : Dropdown, IBetterTransitionUiElement
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00057F8D File Offset: 0x0005618D
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00057F98 File Offset: 0x00056198
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x04000E70 RID: 3696
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();
	}
}
