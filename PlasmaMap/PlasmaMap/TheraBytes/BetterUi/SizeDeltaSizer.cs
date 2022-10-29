using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001EF RID: 495
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Better UI/Layout/Size Delta Sizer", 30)]
	public class SizeDeltaSizer : ResolutionSizer<Vector2>
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0005BD20 File Offset: 0x00059F20
		public SizeDeltaSizer.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0005BD33 File Offset: 0x00059F33
		public Vector2SizeModifier DeltaSizer
		{
			get
			{
				return this.customDeltaSizers.GetCurrentItem(this.deltaSizerFallback);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0005BD46 File Offset: 0x00059F46
		protected override ScreenDependentSize<Vector2> sizer
		{
			get
			{
				return this.customDeltaSizers.GetCurrentItem(this.deltaSizerFallback);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0005BD5C File Offset: 0x00059F5C
		protected override void ApplySize(Vector2 newSize)
		{

		}

		// Token: 0x04000EFD RID: 3837
		[SerializeField]
		private SizeDeltaSizer.Settings settingsFallback = new SizeDeltaSizer.Settings();

		// Token: 0x04000EFE RID: 3838
		[SerializeField]
		private SizeDeltaSizer.SettingsConfigCollection customSettings = new SizeDeltaSizer.SettingsConfigCollection();

		// Token: 0x04000EFF RID: 3839
		[SerializeField]
		private Vector2SizeModifier deltaSizerFallback = new Vector2SizeModifier(100f * Vector2.one, Vector2.zero, 1000f * Vector2.one);

		// Token: 0x04000F00 RID: 3840
		[SerializeField]
		private Vector2SizeConfigCollection customDeltaSizers = new Vector2SizeConfigCollection();

		// Token: 0x02000405 RID: 1029
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x1700051F RID: 1311
			// (get) Token: 0x060021BD RID: 8637 RVA: 0x000A4188 File Offset: 0x000A2388
			// (set) Token: 0x060021BE RID: 8638 RVA: 0x000A4190 File Offset: 0x000A2390
			public bool ApplyWidth
			{
				get
				{
					return this.applyWidth;
				}
				set
				{
					this.applyWidth = value;
				}
			}

			// Token: 0x17000520 RID: 1312
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x000A4199 File Offset: 0x000A2399
			// (set) Token: 0x060021C0 RID: 8640 RVA: 0x000A41A1 File Offset: 0x000A23A1
			public bool ApplyHeight
			{
				get
				{
					return this.applyHeight;
				}
				set
				{
					this.applyHeight = value;
				}
			}

			// Token: 0x17000521 RID: 1313
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000A41AA File Offset: 0x000A23AA
			// (set) Token: 0x060021C2 RID: 8642 RVA: 0x000A41B2 File Offset: 0x000A23B2
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

			// Token: 0x04001E19 RID: 7705
			[SerializeField]
			private bool applyWidth;

			// Token: 0x04001E1A RID: 7706
			[SerializeField]
			private bool applyHeight;

			// Token: 0x04001E1B RID: 7707
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x02000406 RID: 1030
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<SizeDeltaSizer.Settings>
		{
		}
	}
}
