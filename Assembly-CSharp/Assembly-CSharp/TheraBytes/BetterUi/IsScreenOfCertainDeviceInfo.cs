using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class IsScreenOfCertainDeviceInfo : IScreenTypeCheck, IIsActive
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0005D889 File Offset: 0x0005BA89
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x0005D891 File Offset: 0x0005BA91
		public IsScreenOfCertainDeviceInfo.DeviceInfo ExpectedDeviceInfo
		{
			get
			{
				return this.expectedDeviceInfo;
			}
			set
			{
				this.expectedDeviceInfo = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0005D89A File Offset: 0x0005BA9A
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x0005D8A2 File Offset: 0x0005BAA2
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

		// Token: 0x06001226 RID: 4646 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		public bool IsScreenType()
		{

            return default;
        }

		// Token: 0x04000F56 RID: 3926
		[SerializeField]
		private IsScreenOfCertainDeviceInfo.DeviceInfo expectedDeviceInfo;

		// Token: 0x04000F57 RID: 3927
		[SerializeField]
		private bool isActive;

		// Token: 0x0200041C RID: 1052
		public enum DeviceInfo
		{
			// Token: 0x04001E5C RID: 7772
			Other,
			// Token: 0x04001E5D RID: 7773
			Handheld,
			// Token: 0x04001E5E RID: 7774
			Console,
			// Token: 0x04001E5F RID: 7775
			Desktop,
			// Token: 0x04001E60 RID: 7776
			TouchScreen,
			// Token: 0x04001E61 RID: 7777
			VirtualReality
		}
	}
}
