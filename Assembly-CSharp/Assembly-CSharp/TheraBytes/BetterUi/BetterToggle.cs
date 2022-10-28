using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001D5 RID: 469
	[AddComponentMenu("Better UI/Controls/Better Toggle", 30)]
	public class BetterToggle : Toggle, IBetterTransitionUiElement
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00059A10 File Offset: 0x00057C10
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x00059A18 File Offset: 0x00057C18
		public List<Transitions> BetterToggleTransitions
		{
			get
			{
				return this.betterToggleTransitions;
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00059A20 File Offset: 0x00057C20
		protected override void OnEnable()
		{

		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00059A54 File Offset: 0x00057C54
		protected override void OnDisable()
		{

		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00059A74 File Offset: 0x00057C74
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00059B20 File Offset: 0x00057D20
		private void ValueChanged(bool on)
		{

		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00059B2C File Offset: 0x00057D2C
		public void ValueChanged(bool on, bool immediate)
		{

		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00059B8C File Offset: 0x00057D8C
		public override void OnPointerClick(PointerEventData eventData)
		{

		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00059BBB File Offset: 0x00057DBB
		public override void OnPointerEnter(PointerEventData eventData)
		{

		}

		// Token: 0x04000E96 RID: 3734
		public bool heavySound;

		// Token: 0x04000E97 RID: 3735
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();

		// Token: 0x04000E98 RID: 3736
		[SerializeField]
		private List<Transitions> betterToggleTransitions = new List<Transitions>();

		// Token: 0x020003DC RID: 988
		[Serializable]
		public class ToggleGraphics
		{
			// Token: 0x04001D9E RID: 7582
			public Toggle.ToggleTransition ToggleTransition = Toggle.ToggleTransition.Fade;

			// Token: 0x04001D9F RID: 7583
			public Graphic Graphic;

			// Token: 0x04001DA0 RID: 7584
			public float FadeDuration = 0.1f;
		}
	}
}
