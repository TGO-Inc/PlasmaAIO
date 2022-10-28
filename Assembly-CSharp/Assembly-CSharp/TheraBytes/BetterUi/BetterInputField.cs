using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001CE RID: 462
	[AddComponentMenu("Better UI/Controls/Better Input Field", 30)]
	public class BetterInputField : InputField, IBetterTransitionUiElement
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x000591FC File Offset: 0x000573FC
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00059204 File Offset: 0x00057404
		public List<Graphic> AdditionalPlaceholders
		{
			get
			{
				return this.additionalPlaceholders;
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0005920C File Offset: 0x0005740C
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00059280 File Offset: 0x00057480
		public override void OnUpdateSelected(BaseEventData eventData)
		{

		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00059298 File Offset: 0x00057498
		private void DisplayPlaceholders(string input)
		{

		}

		// Token: 0x04000E83 RID: 3715
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();

		// Token: 0x04000E84 RID: 3716
		[SerializeField]
		private List<Graphic> additionalPlaceholders = new List<Graphic>();
	}
}
