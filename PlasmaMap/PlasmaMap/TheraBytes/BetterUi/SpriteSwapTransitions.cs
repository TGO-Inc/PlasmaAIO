using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001DC RID: 476
	[Serializable]
	public class SpriteSwapTransitions : TransitionStateCollection<Sprite>
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0005A1E5 File Offset: 0x000583E5
		public override Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0005A1ED File Offset: 0x000583ED
		public SpriteSwapTransitions(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0005A201 File Offset: 0x00058401
		protected override void ApplyState(TransitionStateCollection<Sprite>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0005A224 File Offset: 0x00058424
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0005A245 File Offset: 0x00058445
		protected override IEnumerable<TransitionStateCollection<Sprite>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x04000EAC RID: 3756
		[SerializeField]
		private Image target;

		// Token: 0x04000EAD RID: 3757
		[SerializeField]
		private List<SpriteSwapTransitions.SpriteSwapTransitionState> states = new List<SpriteSwapTransitions.SpriteSwapTransitionState>();

		// Token: 0x020003EB RID: 1003
		[Serializable]
		public class SpriteSwapTransitionState : TransitionStateCollection<Sprite>.TransitionState
		{
			// Token: 0x06002171 RID: 8561 RVA: 0x000A397B File Offset: 0x000A1B7B
			public SpriteSwapTransitionState(string name, Sprite stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
