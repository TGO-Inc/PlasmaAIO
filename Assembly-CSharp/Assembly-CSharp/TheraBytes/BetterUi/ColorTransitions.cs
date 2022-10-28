using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001D9 RID: 473
	[Serializable]
	public class ColorTransitions : TransitionStateCollection<Color>
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00059E7D File Offset: 0x0005807D
		public override UnityEngine.Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00059E85 File Offset: 0x00058085
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00059E8D File Offset: 0x0005808D
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

		// Token: 0x060010CB RID: 4299 RVA: 0x00059E96 File Offset: 0x00058096
		public ColorTransitions(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00059EB5 File Offset: 0x000580B5
		protected override void ApplyState(TransitionStateCollection<Color>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00059EF4 File Offset: 0x000580F4
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00059F19 File Offset: 0x00058119
		protected override IEnumerable<TransitionStateCollection<Color>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x04000EA1 RID: 3745
		[SerializeField]
		private Graphic target;

		// Token: 0x04000EA2 RID: 3746
		[SerializeField]
		private float fadeDuration = 0.1f;

		// Token: 0x04000EA3 RID: 3747
		[SerializeField]
		private List<ColorTransitions.ColorTransitionState> states = new List<ColorTransitions.ColorTransitionState>();

		// Token: 0x020003E4 RID: 996
		[Serializable]
		public class ColorTransitionState : TransitionStateCollection<Color>.TransitionState
		{
			// Token: 0x0600214D RID: 8525 RVA: 0x000A33FB File Offset: 0x000A15FB
			public ColorTransitionState(string name, Color stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
