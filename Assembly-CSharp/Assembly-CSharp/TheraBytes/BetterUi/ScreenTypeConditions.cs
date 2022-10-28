using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x02000213 RID: 531
	[Serializable]
	public class ScreenTypeConditions
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0005DADE File Offset: 0x0005BCDE
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0005DAE6 File Offset: 0x0005BCE6
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x0005DAEF File Offset: 0x0005BCEF
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x0005DAF7 File Offset: 0x0005BCF7
		public bool IsActive { get; private set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0005DB00 File Offset: 0x0005BD00
		public List<string> Fallbacks
		{
			get
			{
				return this.fallbacks;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0005DB08 File Offset: 0x0005BD08
		public Vector2 OptimizedResolution
		{
			get
			{
				if (this.optimizedScreenInfo == null)
				{
					return ResolutionMonitor.OptimizedResolutionFallback;
				}
				return this.optimizedScreenInfo.Resolution;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0005DB23 File Offset: 0x0005BD23
		public int OptimizedWidth
		{
			get
			{
				return (int)this.OptimizedResolution.x;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0005DB31 File Offset: 0x0005BD31
		public int OptimizedHeight
		{
			get
			{
				return (int)this.OptimizedResolution.y;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x0005DB3F File Offset: 0x0005BD3F
		public float OptimizedDpi
		{
			get
			{
				if (this.optimizedScreenInfo == null)
				{
					return ResolutionMonitor.OptimizedDpiFallback;
				}
				return this.optimizedScreenInfo.Dpi;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0005DB5A File Offset: 0x0005BD5A
		public IsCertainScreenOrientation CheckOrientation
		{
			get
			{
				return this.checkOrientation;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0005DB62 File Offset: 0x0005BD62
		public IsScreenOfCertainSize CheckScreenSize
		{
			get
			{
				return this.checkScreenSize;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0005DB6A File Offset: 0x0005BD6A
		public IsCertainAspectRatio CheckAspectRatio
		{
			get
			{
				return this.checkAspectRatio;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x0005DB72 File Offset: 0x0005BD72
		public IsScreenOfCertainDeviceInfo CheckDeviceType
		{
			get
			{
				return this.checkDeviceType;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x0005DB7A File Offset: 0x0005BD7A
		public ScreenInfo OptimizedScreenInfo
		{
			get
			{
				return this.optimizedScreenInfo;
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0005DB84 File Offset: 0x0005BD84
		public ScreenTypeConditions(string displayName, bool optimizedScreenInfo = false, bool orientation = false, bool bigger = false, bool smaller = false, bool touch = false, bool vr = false, bool deviceType = false)
		{

		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0005DC20 File Offset: 0x0005BE20
		public bool IsScreenType()
		{

            return default;
        }

		// Token: 0x04000F5F RID: 3935
		[SerializeField]
		private string name = "Screen";

		// Token: 0x04000F60 RID: 3936
		[SerializeField]
		private IsCertainScreenOrientation checkOrientation;

		// Token: 0x04000F61 RID: 3937
		[SerializeField]
		private IsScreenOfCertainSize checkScreenSize;

		// Token: 0x04000F62 RID: 3938
		[SerializeField]
		private IsCertainAspectRatio checkAspectRatio;

		// Token: 0x04000F63 RID: 3939
		[SerializeField]
		private IsScreenOfCertainDeviceInfo checkDeviceType;

		// Token: 0x04000F64 RID: 3940
		[SerializeField]
		private ScreenInfo optimizedScreenInfo;

		// Token: 0x04000F65 RID: 3941
		[SerializeField]
		private List<string> fallbacks = new List<string>();
	}
}
