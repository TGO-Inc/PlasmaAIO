using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x0200020D RID: 525
	[Serializable]
	public class IsCertainAspectRatio : IScreenTypeCheck, IIsActive
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0005D758 File Offset: 0x0005B958
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0005D760 File Offset: 0x0005B960
		public float MinAspect
		{
			get
			{
				return this.minAspect;
			}
			set
			{
				this.minAspect = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0005D769 File Offset: 0x0005B969
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0005D771 File Offset: 0x0005B971
		public float MaxAspect
		{
			get
			{
				return this.maxAspect;
			}
			set
			{
				this.maxAspect = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0005D77A File Offset: 0x0005B97A
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0005D782 File Offset: 0x0005B982
		public bool Inverse
		{
			get
			{
				return this.inverse;
			}
			set
			{
				this.inverse = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0005D78B File Offset: 0x0005B98B
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x0005D793 File Offset: 0x0005B993
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

		// Token: 0x06001219 RID: 4633 RVA: 0x0005D79C File Offset: 0x0005B99C
		public bool IsScreenType()
		{

            return default;
        }

		// Token: 0x04000F50 RID: 3920
		[SerializeField]
		private float minAspect = 0.66f;

		// Token: 0x04000F51 RID: 3921
		[SerializeField]
		private float maxAspect = 1.5f;

		// Token: 0x04000F52 RID: 3922
		[SerializeField]
		private bool inverse;

		// Token: 0x04000F53 RID: 3923
		[SerializeField]
		private bool isActive;
	}
}
