using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001DB RID: 475
	[Serializable]
	public class ObjectActivenessTransitions : TransitionStateCollection<bool>
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0005A16E File Offset: 0x0005836E
		public override Object Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0005A176 File Offset: 0x00058376
		public ObjectActivenessTransitions(params string[] stateNames) : base(stateNames)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0005A18A File Offset: 0x0005838A
		protected override void ApplyState(TransitionStateCollection<bool>.TransitionState state, bool instant)
		{

		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0005A1B4 File Offset: 0x000583B4
		protected override void AddStateObject(string stateName)
		{

		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0005A1D5 File Offset: 0x000583D5
		protected override IEnumerable<TransitionStateCollection<bool>.TransitionState> GetTransitionStates()
		{

            return default;
        }

		// Token: 0x04000EAA RID: 3754
		[SerializeField]
		private GameObject target;

		// Token: 0x04000EAB RID: 3755
		[SerializeField]
		private List<ObjectActivenessTransitions.ActiveTransitionState> states = new List<ObjectActivenessTransitions.ActiveTransitionState>();

		// Token: 0x020003E9 RID: 1001
		[Serializable]
		public class ActiveTransitionState : TransitionStateCollection<bool>.TransitionState
		{
			// Token: 0x06002167 RID: 8551 RVA: 0x000A37F3 File Offset: 0x000A19F3
			public ActiveTransitionState(string name, bool stateObject) : base(name, stateObject)
			{
			}
		}
	}
}
