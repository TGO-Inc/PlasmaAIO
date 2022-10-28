using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001E3 RID: 483
	[AddComponentMenu("Better UI/Layout/Better Grid Layout Group", 30)]
	public class BetterGridLayoutGroup : GridLayoutGroup, IResolutionDependency
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0005ACC4 File Offset: 0x00058EC4
		public MarginSizeModifier PaddingSizer
		{
			get
			{
				return this.customPaddingSizers.GetCurrentItem(this.paddingSizerFallback);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0005ACD7 File Offset: 0x00058ED7
		public Vector2SizeModifier CellSizer
		{
			get
			{
				return this.customCellSizers.GetCurrentItem(this.cellSizerFallback);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0005ACEA File Offset: 0x00058EEA
		public Vector2SizeModifier SpacingSizer
		{
			get
			{
				return this.customSpacingSizers.GetCurrentItem(this.spacingSizerFallback);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0005ACFD File Offset: 0x00058EFD
		public BetterGridLayoutGroup.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0005AD10 File Offset: 0x00058F10
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x0005AD18 File Offset: 0x00058F18
		public bool Fit
		{
			get
			{
				return this.fit;
			}
			set
			{
				if (this.fit == value)
				{
					return;
				}
				this.fit = value;
				this.CalculateCellSize();
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0005AD31 File Offset: 0x00058F31
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0005AD3F File Offset: 0x00058F3F
		protected override void OnEnable()
		{

		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0005AD75 File Offset: 0x00058F75
		private IEnumerator InitDelayed()
		{

            return default;
        }

		// Token: 0x0600112B RID: 4395 RVA: 0x0005AD84 File Offset: 0x00058F84
		public void OnResolutionChanged()
		{

		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0005ADA0 File Offset: 0x00058FA0
		public void CalculateCellSize()
		{

		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0005AE74 File Offset: 0x00059074
		public float GetCellWidth()
		{

            return default;
        }

		// Token: 0x0600112E RID: 4398 RVA: 0x0005AEC0 File Offset: 0x000590C0
		public float GetCellHeight()
		{

            return default;
        }

		// Token: 0x0600112F RID: 4399 RVA: 0x0005AF0C File Offset: 0x0005910C
		private void ApplySettings(BetterGridLayoutGroup.Settings settings)
		{

		}

		// Token: 0x04000ED3 RID: 3795
		[FormerlySerializedAs("paddingSizer")]
		[SerializeField]
		private MarginSizeModifier paddingSizerFallback = new MarginSizeModifier(new Margin(), new Margin(), new Margin(1000, 1000, 1000, 1000));

		// Token: 0x04000ED4 RID: 3796
		[SerializeField]
		private MarginSizeConfigCollection customPaddingSizers = new MarginSizeConfigCollection();

		// Token: 0x04000ED5 RID: 3797
		[FormerlySerializedAs("cellSizer")]
		[SerializeField]
		private Vector2SizeModifier cellSizerFallback = new Vector2SizeModifier(new Vector2(100f, 100f), new Vector2(10f, 10f), new Vector2(300f, 300f));

		// Token: 0x04000ED6 RID: 3798
		[SerializeField]
		private Vector2SizeConfigCollection customCellSizers = new Vector2SizeConfigCollection();

		// Token: 0x04000ED7 RID: 3799
		[FormerlySerializedAs("spacingSizer")]
		[SerializeField]
		private Vector2SizeModifier spacingSizerFallback = new Vector2SizeModifier(Vector2.zero, Vector2.zero, new Vector2(300f, 300f));

		// Token: 0x04000ED8 RID: 3800
		[SerializeField]
		private Vector2SizeConfigCollection customSpacingSizers = new Vector2SizeConfigCollection();

		// Token: 0x04000ED9 RID: 3801
		[SerializeField]
		private BetterGridLayoutGroup.Settings settingsFallback;

		// Token: 0x04000EDA RID: 3802
		[SerializeField]
		private BetterGridLayoutGroup.SettingsConfigCollection customSettings = new BetterGridLayoutGroup.SettingsConfigCollection();

		// Token: 0x04000EDB RID: 3803
		[SerializeField]
		private bool fit;

		// Token: 0x020003FC RID: 1020
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000A3FEE File Offset: 0x000A21EE
			// (set) Token: 0x060021A7 RID: 8615 RVA: 0x000A3FF6 File Offset: 0x000A21F6
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

			// Token: 0x060021A8 RID: 8616 RVA: 0x000A4000 File Offset: 0x000A2200
			public Settings(BetterGridLayoutGroup grid)
			{

			}

			// Token: 0x04001DFF RID: 7679
			public GridLayoutGroup.Constraint Constraint;

			// Token: 0x04001E00 RID: 7680
			public int ConstraintCount;

			// Token: 0x04001E01 RID: 7681
			public TextAnchor ChildAlignment;

			// Token: 0x04001E02 RID: 7682
			public GridLayoutGroup.Axis StartAxis;

			// Token: 0x04001E03 RID: 7683
			public GridLayoutGroup.Corner StartCorner;

			// Token: 0x04001E04 RID: 7684
			public bool Fit;

			// Token: 0x04001E05 RID: 7685
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x020003FD RID: 1021
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<BetterGridLayoutGroup.Settings>
		{
		}
	}
}
