using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001FB RID: 507
	[Serializable]
	public class Vector2SizeModifier : ScreenDependentSize<Vector2>
	{
		// Token: 0x060011B8 RID: 4536 RVA: 0x0005C524 File Offset: 0x0005A724
		public Vector2SizeModifier(Vector2 optimizedSize, Vector2 minSize, Vector2 maxSize) : base(optimizedSize, minSize, maxSize, optimizedSize)
		{

		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0005C579 File Offset: 0x0005A779
		public override IEnumerable<SizeModifierCollection> GetModifiers()
		{

            return default;
        }

		// Token: 0x060011BA RID: 4538 RVA: 0x0005C589 File Offset: 0x0005A789
		protected override void AdjustSize(float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0005C5C2 File Offset: 0x0005A7C2
		protected override void CalculateOptimizedSize(Vector2 baseValue, float factor, SizeModifierCollection mod, int index)
		{

		}

		// Token: 0x04000F15 RID: 3861
		public SizeModifierCollection ModX;

		// Token: 0x04000F16 RID: 3862
		public SizeModifierCollection ModY;
	}
}
