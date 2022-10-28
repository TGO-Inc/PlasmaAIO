using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001EC RID: 492
	[Serializable]
	public class RectTransformData : IScreenConfigConnection
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0005B759 File Offset: 0x00059959
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0005B784 File Offset: 0x00059984
		public Vector2 OffsetMax
		{
			get
			{
				return this.AnchoredPosition + Vector2.Scale(this.SizeDelta, Vector2.one - this.Pivot);
			}
			set
			{
				Vector2 vector = value - (this.AnchoredPosition + Vector2.Scale(this.SizeDelta, Vector2.one - this.Pivot));
				this.SizeDelta += vector;
				this.AnchoredPosition += Vector2.Scale(vector, this.Pivot);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0005B7ED File Offset: 0x000599ED
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0005B80C File Offset: 0x00059A0C
		public Vector2 OffsetMin
		{
			get
			{
				return this.AnchoredPosition - Vector2.Scale(this.SizeDelta, this.Pivot);
			}
			set
			{
				Vector2 vector = value - (this.AnchoredPosition - Vector2.Scale(this.SizeDelta, this.Pivot));
				this.SizeDelta -= vector;
				this.AnchoredPosition += Vector2.Scale(vector, Vector2.one - this.Pivot);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0005B875 File Offset: 0x00059A75
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0005B87D File Offset: 0x00059A7D
		public string ScreenConfigName
		{
			get
			{
				return this.screenConfigName;
			}
			set
			{
				this.screenConfigName = value;
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005B888 File Offset: 0x00059A88
		public void PullFromTransform(RectTransform transform)
		{

		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0005B8F8 File Offset: 0x00059AF8
		public void PushToTransform(RectTransform transform)
		{

		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0005B968 File Offset: 0x00059B68
		public static RectTransformData Lerp(RectTransformData a, RectTransformData b, float amount)
		{

            return default;
        }

		// Token: 0x06001172 RID: 4466 RVA: 0x0005BA3C File Offset: 0x00059C3C
		public override string ToString()
		{

            return default;
        }

		// Token: 0x04000EF2 RID: 3826
		public Vector3 LocalPosition;

		// Token: 0x04000EF3 RID: 3827
		public Vector2 AnchoredPosition;

		// Token: 0x04000EF4 RID: 3828
		public Vector2 SizeDelta;

		// Token: 0x04000EF5 RID: 3829
		public Vector2 AnchorMin;

		// Token: 0x04000EF6 RID: 3830
		public Vector2 AnchorMax;

		// Token: 0x04000EF7 RID: 3831
		public Vector2 Pivot;

		// Token: 0x04000EF8 RID: 3832
		public Vector3 Scale;

		// Token: 0x04000EF9 RID: 3833
		public Quaternion Rotation;

		// Token: 0x04000EFA RID: 3834
		[SerializeField]
		private string screenConfigName;
	}
}
