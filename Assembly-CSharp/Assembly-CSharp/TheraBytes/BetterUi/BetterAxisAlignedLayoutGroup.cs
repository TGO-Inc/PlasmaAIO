using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001E1 RID: 481
	[AddComponentMenu("Better UI/Layout/Better Axis Aligned Layout Group", 30)]
	public class BetterAxisAlignedLayoutGroup : HorizontalOrVerticalLayoutGroup, IBetterHorizontalOrVerticalLayoutGroup, IResolutionDependency
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0005A558 File Offset: 0x00058758
		public MarginSizeModifier PaddingSizer
		{
			get
			{
				return this.customPaddingSizers.GetCurrentItem(this.paddingSizerFallback);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0005A56B File Offset: 0x0005876B
		public FloatSizeModifier SpacingSizer
		{
			get
			{
				return this.customSpacingSizers.GetCurrentItem(this.spacingSizerFallback);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0005A57E File Offset: 0x0005877E
		public BetterAxisAlignedLayoutGroup.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0005A591 File Offset: 0x00058791
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0005A599 File Offset: 0x00058799
		public BetterAxisAlignedLayoutGroup.Axis Orientation
		{
			get
			{
				return this.orientation;
			}
			set
			{
				this.orientation = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0005A5A2 File Offset: 0x000587A2
		private bool isVertical
		{
			get
			{
				return this.orientation == BetterAxisAlignedLayoutGroup.Axis.Vertical;
			}
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0005A5AD File Offset: 0x000587AD
		protected override void OnEnable()
		{

		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0005A5E3 File Offset: 0x000587E3
		protected override void OnTransformChildrenChanged()
		{

		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0005A600 File Offset: 0x00058800
		private IEnumerator SetDirtyDelayed()
		{

            return default;
        }

		// Token: 0x06001103 RID: 4355 RVA: 0x0005A60F File Offset: 0x0005880F
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0005A61D File Offset: 0x0005881D
		private IEnumerator InitDelayed()
		{

            return default;
        }

		// Token: 0x06001105 RID: 4357 RVA: 0x0005A62C File Offset: 0x0005882C
		public override void CalculateLayoutInputHorizontal()
		{

		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0005A641 File Offset: 0x00058841
		public override void CalculateLayoutInputVertical()
		{

		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0005A650 File Offset: 0x00058850
		public override void SetLayoutHorizontal()
		{

		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0005A65F File Offset: 0x0005885F
		public override void SetLayoutVertical()
		{

		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0005A66E File Offset: 0x0005886E
		public void OnResolutionChanged()
		{

		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0005A678 File Offset: 0x00058878
		public void CalculateCellSize()
		{

		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0005A6E4 File Offset: 0x000588E4
		private void ApplySettings(BetterAxisAlignedLayoutGroup.Settings settings)
		{

		}

		// Token: 0x04000EBC RID: 3772
		[SerializeField]
		private MarginSizeModifier paddingSizerFallback = new MarginSizeModifier(new Margin(), new Margin(), new Margin(1000, 1000, 1000, 1000));

		// Token: 0x04000EBD RID: 3773
		[SerializeField]
		private MarginSizeConfigCollection customPaddingSizers = new MarginSizeConfigCollection();

		// Token: 0x04000EBE RID: 3774
		[SerializeField]
		private FloatSizeModifier spacingSizerFallback = new FloatSizeModifier(0f, 0f, 300f);

		// Token: 0x04000EBF RID: 3775
		[SerializeField]
		private FloatSizeConfigCollection customSpacingSizers = new FloatSizeConfigCollection();

		// Token: 0x04000EC0 RID: 3776
		[SerializeField]
		private BetterAxisAlignedLayoutGroup.Settings settingsFallback;

		// Token: 0x04000EC1 RID: 3777
		[SerializeField]
		private BetterAxisAlignedLayoutGroup.SettingsConfigCollection customSettings = new BetterAxisAlignedLayoutGroup.SettingsConfigCollection();

		// Token: 0x04000EC2 RID: 3778
		[SerializeField]
		private BetterAxisAlignedLayoutGroup.Axis orientation;

		// Token: 0x020003F4 RID: 1012
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x0600218C RID: 8588 RVA: 0x000A3CE1 File Offset: 0x000A1EE1
			// (set) Token: 0x0600218D RID: 8589 RVA: 0x000A3CE9 File Offset: 0x000A1EE9
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

			// Token: 0x0600218E RID: 8590 RVA: 0x000A3CF4 File Offset: 0x000A1EF4
			public Settings(TextAnchor childAlignment, bool expandWidth, bool expandHeight, BetterAxisAlignedLayoutGroup.Axis orientation)
			{

			}

			// Token: 0x04001DE1 RID: 7649
			public TextAnchor ChildAlignment;

			// Token: 0x04001DE2 RID: 7650
			public bool ChildForceExpandHeight = true;

			// Token: 0x04001DE3 RID: 7651
			public bool ChildForceExpandWidth = true;

			// Token: 0x04001DE4 RID: 7652
			public bool ChildControlWidth = true;

			// Token: 0x04001DE5 RID: 7653
			public bool ChildControlHeight = true;

			// Token: 0x04001DE6 RID: 7654
			public BetterAxisAlignedLayoutGroup.Axis Orientation;

			// Token: 0x04001DE7 RID: 7655
			public bool UseReversedSiblingOrder;

			// Token: 0x04001DE8 RID: 7656
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x020003F5 RID: 1013
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<BetterAxisAlignedLayoutGroup.Settings>
		{
		}

		// Token: 0x020003F6 RID: 1014
		public enum Axis
		{
			// Token: 0x04001DEA RID: 7658
			Horizontal,
			// Token: 0x04001DEB RID: 7659
			Vertical
		}
	}
}
