using System;
using System.Collections.Generic;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class VertexMaterialData
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x0005DE1F File Offset: 0x0005C01F
		public void Apply(ref float uvX, ref float uvY, ref float tangentW)
		{

		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0005DE30 File Offset: 0x0005C030
		private static void Apply<T>(IEnumerable<VertexMaterialData.Property<T>> prop, ref float uvX, ref float uvY, ref float tangentW)
		{

		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005DE7C File Offset: 0x0005C07C
		public void Clear()
		{

		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005DE8A File Offset: 0x0005C08A
		public void CopyTo(VertexMaterialData target)
		{

		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005DEA0 File Offset: 0x0005C0A0
		public VertexMaterialData Clone()
		{

            return default;
        }

		// Token: 0x06001253 RID: 4691 RVA: 0x0005DEBC File Offset: 0x0005C0BC
		private static T[] CloneArray<T, TValue>(T[] array) where T : VertexMaterialData.Property<TValue>
		{

            return default;
        }

		// Token: 0x04000F69 RID: 3945
		public VertexMaterialData.FloatProperty[] FloatProperties;

		// Token: 0x0200041F RID: 1055
		[Serializable]
		public abstract class Property<T>
		{
			// Token: 0x06002224 RID: 8740
			public abstract void SetValue(ref float uvX, ref float uvY, ref float tangentW);

			// Token: 0x06002225 RID: 8741
			public abstract VertexMaterialData.Property<T> Clone();

			// Token: 0x04001E69 RID: 7785
			public string Name;

			// Token: 0x04001E6A RID: 7786
			public T Value;
		}

		// Token: 0x02000420 RID: 1056
		[Serializable]
		public class FloatProperty : VertexMaterialData.Property<float>
		{
			// Token: 0x17000532 RID: 1330
			// (get) Token: 0x06002227 RID: 8743 RVA: 0x000A4E97 File Offset: 0x000A3097
			public bool IsRestricted
			{
				get
				{
					return this.Min < this.Max;
				}
			}

			// Token: 0x06002228 RID: 8744 RVA: 0x000A4EA8 File Offset: 0x000A30A8
			public override void SetValue(ref float uvX, ref float uvY, ref float tangentW)
			{

			}

			// Token: 0x06002229 RID: 8745 RVA: 0x000A4EF0 File Offset: 0x000A30F0
			public override VertexMaterialData.Property<float> Clone()
			{

                return default;
            }

			// Token: 0x04001E6B RID: 7787
			public VertexMaterialData.FloatProperty.Mapping PropertyMap;

			// Token: 0x04001E6C RID: 7788
			public float Min;

			// Token: 0x04001E6D RID: 7789
			public float Max;

			// Token: 0x020004C0 RID: 1216
			public enum Mapping
			{
				// Token: 0x040020FE RID: 8446
				TexcoordX,
				// Token: 0x040020FF RID: 8447
				TexcoordY,
				// Token: 0x04002100 RID: 8448
				TangentW
			}
		}
	}
}
