using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001E4 RID: 484
	[AddComponentMenu("Better UI/Obsolete/Better Horizontal Layout Group", 30)]
	public class BetterHorizontalLayoutGroup : HorizontalLayoutGroup, IBetterHorizontalOrVerticalLayoutGroup, IResolutionDependency
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0005B035 File Offset: 0x00059235
		public MarginSizeModifier PaddingSizer
		{
			get
			{
				return this.paddingSizerFallback;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0005B03D File Offset: 0x0005923D
		public FloatSizeModifier SpacingSizer
		{
			get
			{
				return this.spacingSizerFallback;
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0005B045 File Offset: 0x00059245
		protected override void OnEnable()
		{

		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0005B053 File Offset: 0x00059253
		public void OnResolutionChanged()
		{

		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0005B05C File Offset: 0x0005925C
		public void CalculateCellSize()
		{

		}

		// Token: 0x04000EDC RID: 3804
		[FormerlySerializedAs("paddingSizer")]
		[SerializeField]
		private MarginSizeModifier paddingSizerFallback = new MarginSizeModifier(new Margin(), new Margin(), new Margin(1000, 1000, 1000, 1000));

		// Token: 0x04000EDD RID: 3805
		[FormerlySerializedAs("spacingSizer")]
		[SerializeField]
		private FloatSizeModifier spacingSizerFallback = new FloatSizeModifier(0f, 0f, 300f);
	}
}
