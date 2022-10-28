using System;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001E0 RID: 480
	[AddComponentMenu("Better UI/Layout/Better Aspect Ratio Fitter", 30)]
	public class BetterAspectRatioFitter : AspectRatioFitter, IResolutionDependency
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0005A4ED File Offset: 0x000586ED
		public BetterAspectRatioFitter.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0005A500 File Offset: 0x00058700
		protected override void OnEnable()
		{

		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0005A50E File Offset: 0x0005870E
		public void OnResolutionChanged()
		{

		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0005A516 File Offset: 0x00058716
		private void Apply()
		{

		}

		// Token: 0x04000EBA RID: 3770
		[SerializeField]
		private BetterAspectRatioFitter.Settings settingsFallback = new BetterAspectRatioFitter.Settings();

		// Token: 0x04000EBB RID: 3771
		[SerializeField]
		private BetterAspectRatioFitter.SettingsConfigCollection customSettings = new BetterAspectRatioFitter.SettingsConfigCollection();

		// Token: 0x020003F2 RID: 1010
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x000A3CB5 File Offset: 0x000A1EB5
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x000A3CBD File Offset: 0x000A1EBD
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

			// Token: 0x04001DDE RID: 7646
			public AspectRatioFitter.AspectMode AspectMode;

			// Token: 0x04001DDF RID: 7647
			public float AspectRatio = 1f;

			// Token: 0x04001DE0 RID: 7648
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x020003F3 RID: 1011
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<BetterAspectRatioFitter.Settings>
		{
		}
	}
}
