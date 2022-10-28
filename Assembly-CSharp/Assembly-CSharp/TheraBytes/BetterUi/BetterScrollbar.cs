using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001D0 RID: 464
	[AddComponentMenu("Better UI/Controls/Better Scrollbar", 30)]
	public class BetterScrollbar : Scrollbar, IBetterTransitionUiElement
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x000595AE File Offset: 0x000577AE
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000595B8 File Offset: 0x000577B8
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x04000E8D RID: 3725
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();
	}
}
