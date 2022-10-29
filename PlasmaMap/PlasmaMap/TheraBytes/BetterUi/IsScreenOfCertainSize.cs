using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x02000211 RID: 529
	[Serializable]
	public class IsScreenOfCertainSize : IScreenTypeCheck, IIsActive
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x0005D922 File Offset: 0x0005BB22
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x0005D92A File Offset: 0x0005BB2A
		public IsScreenOfCertainSize.ScreenMeasure MeasureType
		{
			get
			{
				return this.measureType;
			}
			set
			{
				this.measureType = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0005D933 File Offset: 0x0005BB33
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x0005D93B File Offset: 0x0005BB3B
		public IsScreenOfCertainSize.UnitType Units
		{
			get
			{
				return this.unitType;
			}
			set
			{
				this.unitType = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0005D944 File Offset: 0x0005BB44
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x0005D962 File Offset: 0x0005BB62
		public float MinSize
		{
			get
			{
				if (this.unitType != IsScreenOfCertainSize.UnitType.Centimeters)
				{
					return this.minSizeInInches;
				}
				return 2.54f * this.minSizeInInches;
			}
			set
			{
				this.minSizeInInches = ((this.unitType == IsScreenOfCertainSize.UnitType.Centimeters) ? (value / 2.54f) : value);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0005D97D File Offset: 0x0005BB7D
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x0005D99B File Offset: 0x0005BB9B
		public float MaxSize
		{
			get
			{
				if (this.unitType != IsScreenOfCertainSize.UnitType.Centimeters)
				{
					return this.maxSizeInInches;
				}
				return 2.54f * this.maxSizeInInches;
			}
			set
			{
				this.maxSizeInInches = ((this.unitType == IsScreenOfCertainSize.UnitType.Centimeters) ? (value / 2.54f) : value);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0005D9B6 File Offset: 0x0005BBB6
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x0005D9BE File Offset: 0x0005BBBE
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

		// Token: 0x06001232 RID: 4658 RVA: 0x0005D9C8 File Offset: 0x0005BBC8
		public bool IsScreenType()
		{

            return default;
        }

		// Token: 0x04000F58 RID: 3928
		[SerializeField]
		private IsScreenOfCertainSize.ScreenMeasure measureType = IsScreenOfCertainSize.ScreenMeasure.Height;

		// Token: 0x04000F59 RID: 3929
		[SerializeField]
		private IsScreenOfCertainSize.UnitType unitType;

		// Token: 0x04000F5A RID: 3930
		[SerializeField]
		private float minSizeInInches = 4.7f;

		// Token: 0x04000F5B RID: 3931
		[SerializeField]
		private float maxSizeInInches = 7.6f;

		// Token: 0x04000F5C RID: 3932
		[SerializeField]
		private bool isActive;

		// Token: 0x0200041D RID: 1053
		public enum ScreenMeasure
		{
			// Token: 0x04001E63 RID: 7779
			Width,
			// Token: 0x04001E64 RID: 7780
			Height,
			// Token: 0x04001E65 RID: 7781
			Diagonal
		}

		// Token: 0x0200041E RID: 1054
		public enum UnitType
		{
			// Token: 0x04001E67 RID: 7783
			Inches,
			// Token: 0x04001E68 RID: 7784
			Centimeters
		}
	}
}
