using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001D2 RID: 466
	[AddComponentMenu("Better UI/Controls/Better Selectable", 30)]
	public class BetterSelectable : Selectable, IBetterTransitionUiElement
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00059721 File Offset: 0x00057921
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0005972C File Offset: 0x0005792C
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x04000E90 RID: 3728
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();
	}
}
