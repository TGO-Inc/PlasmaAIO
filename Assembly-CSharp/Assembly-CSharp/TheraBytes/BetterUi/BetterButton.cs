using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001CA RID: 458
	[AddComponentMenu("Better UI/Controls/Better Button", 30)]
	public class BetterButton : Button, IBetterTransitionUiElement
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00057EA7 File Offset: 0x000560A7
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00057EB0 File Offset: 0x000560B0
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00057F24 File Offset: 0x00056124
		public override void OnPointerClick(PointerEventData eventData)
		{

		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00057F53 File Offset: 0x00056153
		public override void OnPointerEnter(PointerEventData eventData)
		{

		}

		// Token: 0x04000E6E RID: 3694
		public bool heavySound;

		// Token: 0x04000E6F RID: 3695
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();
	}
}
