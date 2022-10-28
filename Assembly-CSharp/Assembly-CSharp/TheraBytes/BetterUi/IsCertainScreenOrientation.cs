using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public class IsCertainScreenOrientation : IScreenTypeCheck, IIsActive
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0005D80D File Offset: 0x0005BA0D
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0005D815 File Offset: 0x0005BA15
		public IsCertainScreenOrientation.Orientation ExpectedOrientation
		{
			get
			{
				return this.expectedOrientation;
			}
			set
			{
				this.expectedOrientation = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0005D81E File Offset: 0x0005BA1E
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x0005D826 File Offset: 0x0005BA26
		public bool IsActive
		{
			get
			{
				return this.isActive;
			}
			set
			{
				this.isActive = value;
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0005D82F File Offset: 0x0005BA2F
		public IsCertainScreenOrientation(IsCertainScreenOrientation.Orientation expectedOrientation)
		{

		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0005D840 File Offset: 0x0005BA40
		public bool IsScreenType()
		{

            return default;
        }

		// Token: 0x04000F54 RID: 3924
		[SerializeField]
		private IsCertainScreenOrientation.Orientation expectedOrientation;

		// Token: 0x04000F55 RID: 3925
		[SerializeField]
		private bool isActive;

		// Token: 0x0200041B RID: 1051
		public enum Orientation
		{
			// Token: 0x04001E59 RID: 7769
			Portrait,
			// Token: 0x04001E5A RID: 7770
			Landscape
		}
	}
}
