using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000218 RID: 536
	[AddComponentMenu("Better UI/TextMeshPro/Better TextMeshPro Text", 30)]
	public class BetterTextMeshProUGUI : TextMeshProUGUI, IResolutionDependency
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0005E2C8 File Offset: 0x0005C4C8
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0005E2D0 File Offset: 0x0005C4D0
		public BetterText.FittingMode Fitting
		{
			get
			{
				return this.fitting;
			}
			set
			{
				if (this.fitting == value)
				{
					return;
				}
				this.fitting = value;
				this.CalculateSize();
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0005E2E9 File Offset: 0x0005C4E9
		public MarginSizeModifier MarginSizer
		{
			get
			{
				return this.customMarginSizers.GetCurrentItem(this.marginSizerFallback);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0005E2FC File Offset: 0x0005C4FC
		public FloatSizeModifier FontSizer
		{
			get
			{
				return this.customFontSizers.GetCurrentItem(this.fontSizerFallback);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0005E30F File Offset: 0x0005C50F
		public FloatSizeModifier MinFontSizer
		{
			get
			{
				return this.customMinFontSizers.GetCurrentItem(this.minFontSizerFallback);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0005E322 File Offset: 0x0005C522
		public FloatSizeModifier MaxFontSizer
		{
			get
			{
				return this.customMaxFontSizers.GetCurrentItem(this.maxFontSizerFallback);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0005E335 File Offset: 0x0005C535
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0005E33D File Offset: 0x0005C53D
		public bool IgnoreFontSizerOptions { get; set; }

		// Token: 0x06001271 RID: 4721 RVA: 0x0005E346 File Offset: 0x0005C546
		protected override void OnEnable()
		{

		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0005E354 File Offset: 0x0005C554
		public void OnResolutionChanged()
		{

		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0005E35C File Offset: 0x0005C55C
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0005E36C File Offset: 0x0005C56C
		public void CalculateSize()
		{

		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0005E42C File Offset: 0x0005C62C
		public void RegisterMaterials(Material[] materials)
		{

		}

		// Token: 0x04000F71 RID: 3953
		[SerializeField]
		private BetterText.FittingMode fitting;

		// Token: 0x04000F72 RID: 3954
		[FormerlySerializedAs("marginSizer")]
		[SerializeField]
		private MarginSizeModifier marginSizerFallback = new MarginSizeModifier(new Margin(), new Margin(), new Margin(1000, 1000, 1000, 1000));

		// Token: 0x04000F73 RID: 3955
		[SerializeField]
		private MarginSizeConfigCollection customMarginSizers = new MarginSizeConfigCollection();

		// Token: 0x04000F74 RID: 3956
		[FormerlySerializedAs("fontSizer")]
		[SerializeField]
		private FloatSizeModifier fontSizerFallback = new FloatSizeModifier(36f, 10f, 500f);

		// Token: 0x04000F75 RID: 3957
		[SerializeField]
		private FloatSizeConfigCollection customFontSizers = new FloatSizeConfigCollection();

		// Token: 0x04000F76 RID: 3958
		[FormerlySerializedAs("minFontSizer")]
		[SerializeField]
		private FloatSizeModifier minFontSizerFallback = new FloatSizeModifier(10f, 10f, 500f);

		// Token: 0x04000F77 RID: 3959
		[SerializeField]
		private FloatSizeConfigCollection customMinFontSizers = new FloatSizeConfigCollection();

		// Token: 0x04000F78 RID: 3960
		[FormerlySerializedAs("maxFontSizer")]
		[SerializeField]
		private FloatSizeModifier maxFontSizerFallback = new FloatSizeModifier(500f, 500f, 500f);

		// Token: 0x04000F79 RID: 3961
		[SerializeField]
		private FloatSizeConfigCollection customMaxFontSizers = new FloatSizeConfigCollection();
	}
}
