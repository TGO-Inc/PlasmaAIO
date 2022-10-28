using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001D3 RID: 467
	[AddComponentMenu("Better UI/Controls/Better Slider", 30)]
	public class BetterSlider : Slider, IBetterTransitionUiElement
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x000597B3 File Offset: 0x000579B3
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000597BC File Offset: 0x000579BC
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x04000E91 RID: 3729
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();
	}
}
