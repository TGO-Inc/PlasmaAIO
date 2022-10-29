using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001D8 RID: 472
	[Serializable]
	public class Color32Transitions : TransitionStateCollection<Color32>
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00059DA9 File Offset: 0x00057FA9
		public override Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00059DB1 File Offset: 0x00057FB1
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00059DB9 File Offset: 0x00057FB9
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

		// Token: 0x060010C4 RID: 4292 RVA: 0x00059DC2 File Offset: 0x00057FC2
		public Color32Transitions(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00059DE4 File Offset: 0x00057FE4
		protected override void ApplyState(TransitionStateCollection<Color32>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00059E34 File Offset: 0x00058034
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00059E6D File Offset: 0x0005806D
		protected override IEnumerable<TransitionStateCollection<Color32>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x04000E9E RID: 3742
		[SerializeField]
		private Graphic target;

		// Token: 0x04000E9F RID: 3743
		[SerializeField]
		private float fadeDuration = 0.1f;

		// Token: 0x04000EA0 RID: 3744
		[SerializeField]
		private List<Color32Transitions.Color32TransitionState> states = new List<Color32Transitions.Color32TransitionState>();

		// Token: 0x020003E2 RID: 994
		[Serializable]
		public class Color32TransitionState : TransitionStateCollection<Color32>.TransitionState
		{
			// Token: 0x06002143 RID: 8515 RVA: 0x000A3273 File Offset: 0x000A1473
			public Color32TransitionState(string name, Color32 stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
