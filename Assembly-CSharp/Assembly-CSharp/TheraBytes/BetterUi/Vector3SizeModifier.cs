using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class Vector3SizeModifier : ScreenDependentSize<Vector3>
	{
		// Token: 0x060011BD RID: 4541 RVA: 0x0005C5E4 File Offset: 0x0005A7E4
		public Vector3SizeModifier(Vector3 optimizedSize, Vector3 minSize, Vector3 maxSize) : base(optimizedSize, minSize, maxSize, optimizedSize)
		{

		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0005C649 File Offset: 0x0005A849
		public override IEnumerable<SizeModifierCollection> GetModifiers()
		{

            return default;
        }

		// Token: 0x060011BF RID: 4543 RVA: 0x0005C659 File Offset: 0x0005A859
		protected override void AdjustSize(float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0005C692 File Offset: 0x0005A892
		protected override void CalculateOptimizedSize(Vector3 baseValue, float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x04000F17 RID: 3863
		public SizeModifierCollection ModX;

		// Token: 0x04000F18 RID: 3864
		public SizeModifierCollection ModY;

		// Token: 0x04000F19 RID: 3865
		public SizeModifierCollection ModZ;
	}
}
