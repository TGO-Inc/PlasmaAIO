using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001E7 RID: 487
	[AddComponentMenu("Better UI/Obsolete/Better Vertical Layout Group", 30)]
	public class BetterVerticalLayoutGroup : VerticalLayoutGroup, IBetterHorizontalOrVerticalLayoutGroup, IResolutionDependency
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0005B36F File Offset: 0x0005956F
		public MarginSizeModifier PaddingSizer
		{
			get
			{
				return this.paddingSizerFallback;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0005B377 File Offset: 0x00059577
		public FloatSizeModifier SpacingSizer
		{
			get
			{
				return this.spacingSizerFallback;
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0005B37F File Offset: 0x0005957F
		protected override void OnEnable()
		{

		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0005B38D File Offset: 0x0005958D
		public void OnResolutionChanged()
		{

		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0005B398 File Offset: 0x00059598
		public void CalculateCellSize()
		{

		}

		// Token: 0x04000EEA RID: 3818
		[FormerlySerializedAs("paddingSizer")]
		[SerializeField]
		private MarginSizeModifier paddingSizerFallback = new MarginSizeModifier(new Margin(), new Margin(), new Margin(1000, 1000, 1000, 1000));

		// Token: 0x04000EEB RID: 3819
		[FormerlySerializedAs("spacingSizer")]
		[SerializeField]
		private FloatSizeModifier spacingSizerFallback = new FloatSizeModifier(0f, 0f, 300f);
	}
}
