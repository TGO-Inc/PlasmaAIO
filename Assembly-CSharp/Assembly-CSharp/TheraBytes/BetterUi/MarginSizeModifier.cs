using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001F4 RID: 500
	[Serializable]
	public class MarginSizeModifier : ScreenDependentSize<Margin>
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x0005BE8C File Offset: 0x0005A08C
		public MarginSizeModifier(Margin optimizedSize, Margin minSize, Margin maxSize) : base(optimizedSize, minSize, maxSize, optimizedSize.Clone())
		{

		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0005BF24 File Offset: 0x0005A124
		public override void DynamicInitialization()
		{

		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0005BF39 File Offset: 0x0005A139
		public override IEnumerable<SizeModifierCollection> GetModifiers()
		{

            return default;
        }

		// Token: 0x0600119A RID: 4506 RVA: 0x0005BF4C File Offset: 0x0005A14C
		protected override void AdjustSize(float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0005BFAB File Offset: 0x0005A1AB
		protected override void CalculateOptimizedSize(Margin baseValue, float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x04000F08 RID: 3848
		public SizeModifierCollection ModLeft;

		// Token: 0x04000F09 RID: 3849
		public SizeModifierCollection ModRight;

		// Token: 0x04000F0A RID: 3850
		public SizeModifierCollection ModTop;

		// Token: 0x04000F0B RID: 3851
		public SizeModifierCollection ModBottom;
	}
}
