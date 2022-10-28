using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001E8 RID: 488
	[AddComponentMenu("Better UI/Helpers/Game Object Activator", 30)]
	public class GameObjectActivator : UIBehaviour, IResolutionDependency
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0005B453 File Offset: 0x00059653
		public GameObjectActivator.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0005B466 File Offset: 0x00059666
		protected override void OnEnable()
		{

		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0005B474 File Offset: 0x00059674
		public void OnResolutionChanged()
		{

		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0005B47C File Offset: 0x0005967C
		public void Apply()
		{

		}

		// Token: 0x04000EEC RID: 3820
		[SerializeField]
		private GameObjectActivator.Settings settingsFallback = new GameObjectActivator.Settings();

		// Token: 0x04000EED RID: 3821
		[SerializeField]
		private GameObjectActivator.SettingsConfigCollection customSettings = new GameObjectActivator.SettingsConfigCollection();

		// Token: 0x02000402 RID: 1026
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x1700051E RID: 1310
			// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000A412A File Offset: 0x000A232A
			// (set) Token: 0x060021B6 RID: 8630 RVA: 0x000A4132 File Offset: 0x000A2332
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

			// Token: 0x04001E13 RID: 7699
			public List<GameObject> ActiveObjects = new List<GameObject>();

			// Token: 0x04001E14 RID: 7700
			public List<GameObject> InactiveObjects = new List<GameObject>();

			// Token: 0x04001E15 RID: 7701
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x02000403 RID: 1027
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<GameObjectActivator.Settings>
		{
		}
	}
}
