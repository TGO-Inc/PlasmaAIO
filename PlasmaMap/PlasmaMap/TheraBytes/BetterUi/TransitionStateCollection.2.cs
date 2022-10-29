using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001DF RID: 479
	[Serializable]
	public abstract class TransitionStateCollection
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060010F2 RID: 4338
		public abstract Object Target { get; }

		// Token: 0x060010F3 RID: 4339
		public abstract void Apply(string stateName, bool instant);

		// Token: 0x020003F1 RID: 1009
		[Serializable]
		public abstract class TransitionStateBase
		{
			// Token: 0x06002187 RID: 8583 RVA: 0x000A3CA6 File Offset: 0x000A1EA6
			public TransitionStateBase(string name)
			{

			}

			// Token: 0x04001DDD RID: 7645
			public string Name;
		}
	}
}
