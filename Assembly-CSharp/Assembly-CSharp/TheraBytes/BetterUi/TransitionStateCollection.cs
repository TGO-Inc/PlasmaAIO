using System;
using System.Collections.Generic;
using System.Linq;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001DE RID: 478
	public abstract class TransitionStateCollection<T> : TransitionStateCollection
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x0005A468 File Offset: 0x00058668
		protected TransitionStateCollection(string[] stateNames)
		{

		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0005A496 File Offset: 0x00058696
		public IEnumerable<TransitionStateCollection<T>.TransitionState> GetStates()
		{

            return default;
        }

		// Token: 0x060010EE RID: 4334 RVA: 0x0005A4A8 File Offset: 0x000586A8
		public override void Apply(string stateName, bool instant)
		{

		}

		// Token: 0x060010EF RID: 4335
		protected abstract IEnumerable<TransitionStateCollection<T>.TransitionState> GetTransitionStates();

		// Token: 0x060010F0 RID: 4336
		protected abstract void ApplyState(TransitionStateCollection<T>.TransitionState state, bool instant);

		// Token: 0x060010F1 RID: 4337
		protected abstract void AddStateObject(string stateName);

		// Token: 0x020003EE RID: 1006
		[Serializable]
		public abstract class TransitionState : TransitionStateCollection.TransitionStateBase
		{
			// Token: 0x0600217B RID: 8571 RVA: 0x000A3B03 File Offset: 0x000A1D03
			public TransitionState(string name, T stateObject) : base(name)
			{

			}

			// Token: 0x04001DD6 RID: 7638
			public T StateObject;
		}
	}
}
