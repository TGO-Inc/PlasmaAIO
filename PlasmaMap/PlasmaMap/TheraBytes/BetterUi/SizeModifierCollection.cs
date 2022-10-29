using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	public class SizeModifierCollection
	{
		// Token: 0x060011B2 RID: 4530 RVA: 0x0005C30B File Offset: 0x0005A50B
		public SizeModifierCollection(params SizeModifierCollection.SizeModifier[] mods) : this(1f, mods)
		{
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0005C319 File Offset: 0x0005A519
		public SizeModifierCollection(float exponentialScale, params SizeModifierCollection.SizeModifier[] mods)
		{

		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0005C358 File Offset: 0x0005A558
		public float CalculateFactor(string screenConfig)
		{

            return default;
        }

		// Token: 0x060011B5 RID: 4533 RVA: 0x0005C474 File Offset: 0x0005A674
		public SizeModifierCollection Clone()
		{

            return default;
        }

		// Token: 0x060011B6 RID: 4534 RVA: 0x0005C49C File Offset: 0x0005A69C
		public void CopyTo(SizeModifierCollection other)
		{

		}

		// Token: 0x04000F13 RID: 3859
		public float ExponentialScale = 1f;

		// Token: 0x04000F14 RID: 3860
		public List<SizeModifierCollection.SizeModifier> SizeModifiers = new List<SizeModifierCollection.SizeModifier>
		{
			new SizeModifierCollection.SizeModifier()
		};

		// Token: 0x0200040C RID: 1036
		[Serializable]
		public class SizeModifier
		{
			// Token: 0x060021DC RID: 8668 RVA: 0x000A4449 File Offset: 0x000A2649
			public SizeModifier()
			{
			}

			// Token: 0x060021DD RID: 8669 RVA: 0x000A445C File Offset: 0x000A265C
			public SizeModifier(ImpactMode mode, float impact)
			{

			}

			// Token: 0x060021DF RID: 8671 RVA: 0x000A4564 File Offset: 0x000A2764
			private float CalculateSize(float optimizedValue, float actualValue, float impact)
			{

                return default;
            }

			// Token: 0x04001E28 RID: 7720
			public ImpactMode Mode;

			// Token: 0x04001E29 RID: 7721
			[Range(0f, 1f)]
			public float Impact = 1f;
		}
	}
}
