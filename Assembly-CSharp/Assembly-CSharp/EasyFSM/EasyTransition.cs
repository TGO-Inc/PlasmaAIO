using System;
using System.Collections.Generic;

namespace EasyFSM
{
	// Token: 0x0200022A RID: 554
	public class EasyTransition
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00063F77 File Offset: 0x00062177
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00063F7F File Offset: 0x0006217F
		public EasyTransition.Types type { get; set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00063F88 File Offset: 0x00062188
		public EasyState targetState { get; }

		// Token: 0x06001377 RID: 4983 RVA: 0x00063F90 File Offset: 0x00062190
		public EasyTransition(EasyState targetState)
		{

		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00063FAA File Offset: 0x000621AA
		public void AddCondition(EasyTransition.Condition condition)
		{

		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00063FB8 File Offset: 0x000621B8
		public bool Check()
		{

            return default;
        }

		// Token: 0x04000FE9 RID: 4073
		private List<EasyTransition.Condition> _conditions;

		// Token: 0x02000440 RID: 1088
		// (Invoke) Token: 0x0600227C RID: 8828
		public delegate bool Condition();

		// Token: 0x02000441 RID: 1089
		public enum Types
		{
			// Token: 0x04001ED4 RID: 7892
			AllMustPass,
			// Token: 0x04001ED5 RID: 7893
			AnySuffices
		}
	}
}
