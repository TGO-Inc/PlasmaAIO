using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public class AlphaTransitions : TransitionStateCollection<float>
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00059C00 File Offset: 0x00057E00
		public override Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00059C08 File Offset: 0x00057E08
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00059C10 File Offset: 0x00057E10
		public float FadeDurtaion
		{
			get
			{
				return this.fadeDuration;
			}
			set
			{
				this.fadeDuration = value;
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00059C19 File Offset: 0x00057E19
		public AlphaTransitions(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00059C38 File Offset: 0x00057E38
		protected override void ApplyState(TransitionStateCollection<float>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00059C78 File Offset: 0x00057E78
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00059C9D File Offset: 0x00057E9D
		protected override IEnumerable<TransitionStateCollection<float>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x04000E99 RID: 3737
		[SerializeField]
		private Graphic target;

		// Token: 0x04000E9A RID: 3738
		[SerializeField]
		private float fadeDuration = 0.1f;

		// Token: 0x04000E9B RID: 3739
		[SerializeField]
		private List<AlphaTransitions.AlphaTransitionState> states = new List<AlphaTransitions.AlphaTransitionState>();

		// Token: 0x020003DE RID: 990
		[Serializable]
		public class AlphaTransitionState : TransitionStateCollection<float>.TransitionState
		{
			// Token: 0x0600212F RID: 8495 RVA: 0x000A2F61 File Offset: 0x000A1161
			public AlphaTransitionState(string name, float stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
