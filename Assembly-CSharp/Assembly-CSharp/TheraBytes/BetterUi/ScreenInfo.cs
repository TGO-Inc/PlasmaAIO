using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public class ScreenInfo
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x0005DA84 File Offset: 0x0005BC84
		public Vector2 Resolution
		{
			get
			{
				return this.resolution;
			}
			set
			{
				this.resolution = value;
				ResolutionMonitor.SetDirty();
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x0005DA92 File Offset: 0x0005BC92
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x0005DA9A File Offset: 0x0005BC9A
		public float Dpi
		{
			get
			{
				return this.dpi;
			}
			set
			{
				this.dpi = value;
				ResolutionMonitor.SetDirty();
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0005DAA8 File Offset: 0x0005BCA8
		public ScreenInfo(Vector2 resolution, float dpi)
		{

		}

		// Token: 0x04000F5D RID: 3933
		[SerializeField]
		private Vector2 resolution = new Vector2(1980f, 1020f);

		// Token: 0x04000F5E RID: 3934
		[SerializeField]
		private float dpi = 96f;
	}
}
