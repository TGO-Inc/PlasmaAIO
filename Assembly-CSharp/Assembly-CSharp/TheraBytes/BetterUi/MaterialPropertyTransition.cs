using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001DA RID: 474
	[Serializable]
	public class MaterialPropertyTransition : TransitionStateCollection<float>
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00059F29 File Offset: 0x00058129
		public override Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00059F31 File Offset: 0x00058131
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x00059F39 File Offset: 0x00058139
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00059F42 File Offset: 0x00058142
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00059F4A File Offset: 0x0005814A
		public int PropertyIndex
		{
			get
			{
				return this.propertyIndex;
			}
			set
			{
				this.propertyIndex = value;
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00059F53 File Offset: 0x00058153
		public MaterialPropertyTransition(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00059F74 File Offset: 0x00058174
		protected override void ApplyState(TransitionStateCollection<float>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00059FCC File Offset: 0x000581CC
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00059FF1 File Offset: 0x000581F1
		protected override IEnumerable<TransitionStateCollection<float>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x060010D8 RID: 4312 RVA: 0x0005A004 File Offset: 0x00058204
		private void CrossFadeProperty(float startValue, float targetValue, float duration)
		{

		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0005A134 File Offset: 0x00058334
		private IEnumerator CoCrossFadeProperty(float startValue, float targetValue, float duration)
		{

            return default;
        }

		// Token: 0x04000EA4 RID: 3748
		private static Dictionary<MaterialPropertyTransition, Coroutine> activeCoroutines = new Dictionary<MaterialPropertyTransition, Coroutine>();

		// Token: 0x04000EA5 RID: 3749
		private static List<MaterialPropertyTransition> keysToRemove = new List<MaterialPropertyTransition>();

		// Token: 0x04000EA6 RID: 3750
		[SerializeField]
		private BetterImage target;

		// Token: 0x04000EA7 RID: 3751
		[SerializeField]
		private float fadeDuration = 0.1f;

		// Token: 0x04000EA8 RID: 3752
		[SerializeField]
		private List<MaterialPropertyTransition.MaterialPropertyTransitionState> states = new List<MaterialPropertyTransition.MaterialPropertyTransitionState>();

		// Token: 0x04000EA9 RID: 3753
		[SerializeField]
		private int propertyIndex;

		// Token: 0x020003E6 RID: 998
		[Serializable]
		public class MaterialPropertyTransitionState : TransitionStateCollection<float>.TransitionState
		{
			// Token: 0x06002157 RID: 8535 RVA: 0x000A3583 File Offset: 0x000A1783
			public MaterialPropertyTransitionState(string name, float stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
