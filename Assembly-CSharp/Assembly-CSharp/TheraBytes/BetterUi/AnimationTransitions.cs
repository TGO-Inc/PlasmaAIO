using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001D7 RID: 471
	[Serializable]
	public class AnimationTransitions : TransitionStateCollection<string>
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00059CAD File Offset: 0x00057EAD
		public override UnityEngine.Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00059CB5 File Offset: 0x00057EB5
		public AnimationTransitions(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00059CCC File Offset: 0x00057ECC
		protected override void ApplyState(TransitionStateCollection<string>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00059D78 File Offset: 0x00057F78
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00059D99 File Offset: 0x00057F99
		protected override IEnumerable<TransitionStateCollection<string>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x04000E9C RID: 3740
		[SerializeField]
		private Animator target;

		// Token: 0x04000E9D RID: 3741
		[SerializeField]
		private List<AnimationTransitions.AnimationTransitionState> states = new List<AnimationTransitions.AnimationTransitionState>();

		// Token: 0x020003E0 RID: 992
		[Serializable]
		public class AnimationTransitionState : TransitionStateCollection<string>.TransitionState
		{
			// Token: 0x06002139 RID: 8505 RVA: 0x000A30EB File Offset: 0x000A12EB
			public AnimationTransitionState(string name, string stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
