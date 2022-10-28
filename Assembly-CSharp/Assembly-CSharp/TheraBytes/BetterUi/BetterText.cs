using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001D4 RID: 468
	[AddComponentMenu("Better UI/Controls/Better Text", 30)]
	public class BetterText : Text, IResolutionDependency
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00059843 File Offset: 0x00057A43
		public FloatSizeModifier FontSizer
		{
			get
			{
				return this.customFontSizers.GetCurrentItem(this.fontSizerFallback);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00059856 File Offset: 0x00057A56
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x0005985E File Offset: 0x00057A5E
		public BetterText.FittingMode Fitting
		{
			get
			{
				return this.fitting;
			}
			set
			{
				this.fitting = value;
				this.CalculateSize();
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0005986D File Offset: 0x00057A6D
		protected override void OnEnable()
		{

		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0005987B File Offset: 0x00057A7B
		public void OnResolutionChanged()
		{

		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00059883 File Offset: 0x00057A83
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00059891 File Offset: 0x00057A91
		public override void SetVerticesDirty()
		{

		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000598A0 File Offset: 0x00057AA0
		private void CalculateSize()
		{

		}

		// Token: 0x04000E92 RID: 3730
		[SerializeField]
		private BetterText.FittingMode fitting = BetterText.FittingMode.StayInBounds;

		// Token: 0x04000E93 RID: 3731
		[FormerlySerializedAs("fontSizer")]
		[SerializeField]
		private FloatSizeModifier fontSizerFallback = new FloatSizeModifier(40f, 0f, 500f);

		// Token: 0x04000E94 RID: 3732
		[SerializeField]
		private FloatSizeConfigCollection customFontSizers = new FloatSizeConfigCollection();

		// Token: 0x04000E95 RID: 3733
		private bool isCalculatingSize;

		// Token: 0x020003DB RID: 987
		public enum FittingMode
		{
			// Token: 0x04001D9B RID: 7579
			SizerOnly,
			// Token: 0x04001D9C RID: 7580
			StayInBounds,
			// Token: 0x04001D9D RID: 7581
			BestFit
		}
	}
}
