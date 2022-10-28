using System;
using System.Collections.Generic;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001F1 RID: 497
	[Serializable]
	public class FloatSizeModifier : ScreenDependentSize<float>
	{
		// Token: 0x06001192 RID: 4498 RVA: 0x0005BE1A File Offset: 0x0005A01A
		public FloatSizeModifier(float optimizedSize, float minSize, float maxSize) : base(optimizedSize, minSize, maxSize, optimizedSize)
		{

		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0005BE45 File Offset: 0x0005A045
		public override IEnumerable<SizeModifierCollection> GetModifiers()
		{

            return default;
        }

		// Token: 0x06001194 RID: 4500 RVA: 0x0005BE55 File Offset: 0x0005A055
		protected override void AdjustSize(float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0005BE76 File Offset: 0x0005A076
		protected override void CalculateOptimizedSize(float baseValue, float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x04000F01 RID: 3841
		public SizeModifierCollection Mod;
	}
}
