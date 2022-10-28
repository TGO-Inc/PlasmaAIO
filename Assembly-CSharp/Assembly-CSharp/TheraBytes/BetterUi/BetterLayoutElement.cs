using System;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001E5 RID: 485
	[AddComponentMenu("Better UI/Layout/Better Layout Element", 30)]
	public class BetterLayoutElement : LayoutElement, IResolutionDependency
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0005B117 File Offset: 0x00059317
		public BetterLayoutElement.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0005B12A File Offset: 0x0005932A
		public FloatSizeModifier MinWidthSizer
		{
			get
			{
				return this.customMinWidthSizers.GetCurrentItem(this.minWidthSizerFallback);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0005B13D File Offset: 0x0005933D
		public FloatSizeModifier MinHeightSizer
		{
			get
			{
				return this.customMinHeightSizers.GetCurrentItem(this.minHeightSizerFallback);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0005B150 File Offset: 0x00059350
		public FloatSizeModifier PreferredWidthSizer
		{
			get
			{
				return this.customPreferredWidthSizers.GetCurrentItem(this.preferredWidthSizerFallback);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0005B163 File Offset: 0x00059363
		public FloatSizeModifier PreferredHeightSizer
		{
			get
			{
				return this.customPreferredHeightSizers.GetCurrentItem(this.preferredHeightSizerFallback);
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0005B176 File Offset: 0x00059376
		protected override void OnEnable()
		{

		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0005B184 File Offset: 0x00059384
		public void OnResolutionChanged()
		{

		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0005B18C File Offset: 0x0005938C
		private void Apply()
		{

		}

		// Token: 0x04000EDE RID: 3806
		[SerializeField]
		private BetterLayoutElement.Settings settingsFallback = new BetterLayoutElement.Settings();

		// Token: 0x04000EDF RID: 3807
		[SerializeField]
		private BetterLayoutElement.SettingsConfigCollection customSettings = new BetterLayoutElement.SettingsConfigCollection();

		// Token: 0x04000EE0 RID: 3808
		[SerializeField]
		private FloatSizeModifier minWidthSizerFallback = new FloatSizeModifier(0f, 0f, 5000f);

		// Token: 0x04000EE1 RID: 3809
		[SerializeField]
		private FloatSizeConfigCollection customMinWidthSizers = new FloatSizeConfigCollection();

		// Token: 0x04000EE2 RID: 3810
		[SerializeField]
		private FloatSizeModifier minHeightSizerFallback = new FloatSizeModifier(0f, 0f, 5000f);

		// Token: 0x04000EE3 RID: 3811
		[SerializeField]
		private FloatSizeConfigCollection customMinHeightSizers = new FloatSizeConfigCollection();

		// Token: 0x04000EE4 RID: 3812
		[SerializeField]
		private FloatSizeModifier preferredWidthSizerFallback = new FloatSizeModifier(100f, 0f, 5000f);

		// Token: 0x04000EE5 RID: 3813
		[SerializeField]
		private FloatSizeConfigCollection customPreferredWidthSizers = new FloatSizeConfigCollection();

		// Token: 0x04000EE6 RID: 3814
		[SerializeField]
		private FloatSizeModifier preferredHeightSizerFallback = new FloatSizeModifier(100f, 0f, 5000f);

		// Token: 0x04000EE7 RID: 3815
		[SerializeField]
		private FloatSizeConfigCollection customPreferredHeightSizers = new FloatSizeConfigCollection();

		// Token: 0x020003FF RID: 1023
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x1700051D RID: 1309
			// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000A40EB File Offset: 0x000A22EB
			// (set) Token: 0x060021B1 RID: 8625 RVA: 0x000A40F3 File Offset: 0x000A22F3
			public string ScreenConfigName
			{
				get
				{
					return this.screenConfigName;
				}
				set
				{
					this.screenConfigName = value;
				}
			}

			// Token: 0x04001E09 RID: 7689
			public bool IgnoreLayout;

			// Token: 0x04001E0A RID: 7690
			public bool MinWidthEnabled;

			// Token: 0x04001E0B RID: 7691
			public bool MinHeightEnabled;

			// Token: 0x04001E0C RID: 7692
			public bool PreferredWidthEnabled;

			// Token: 0x04001E0D RID: 7693
			public bool PreferredHeightEnabled;

			// Token: 0x04001E0E RID: 7694
			public bool FlexibleWidthEnabled;

			// Token: 0x04001E0F RID: 7695
			public bool FlexibleHeightEnabled;

			// Token: 0x04001E10 RID: 7696
			public float FlexibleWidth = 1f;

			// Token: 0x04001E11 RID: 7697
			public float FlexibleHeight = 1f;

			// Token: 0x04001E12 RID: 7698
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x02000400 RID: 1024
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<BetterLayoutElement.Settings>
		{
		}
	}
}
