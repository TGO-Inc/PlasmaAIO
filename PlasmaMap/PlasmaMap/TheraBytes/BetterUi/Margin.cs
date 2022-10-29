using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001EB RID: 491
	[Serializable]
	public class Margin
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0005B54E File Offset: 0x0005974E
		public float Horizontal
		{
			get
			{
				return (float)(this.left + this.right);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0005B55E File Offset: 0x0005975E
		public float Vertical
		{
			get
			{
				return (float)(this.top + this.bottom);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0005B56E File Offset: 0x0005976E
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0005B576 File Offset: 0x00059776
		public int Left
		{
			get
			{
				return this.left;
			}
			set
			{
				this.left = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0005B57F File Offset: 0x0005977F
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0005B587 File Offset: 0x00059787
		public int Right
		{
			get
			{
				return this.right;
			}
			set
			{
				this.right = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0005B590 File Offset: 0x00059790
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0005B598 File Offset: 0x00059798
		public int Top
		{
			get
			{
				return this.top;
			}
			set
			{
				this.top = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0005B5A1 File Offset: 0x000597A1
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0005B5A9 File Offset: 0x000597A9
		public int Bottom
		{
			get
			{
				return this.bottom;
			}
			set
			{
				this.bottom = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		public int this[int idx]
		{
			get
			{
				switch (idx)
				{
				case 0:
					return this.left;
				case 1:
					return this.right;
				case 2:
					return this.top;
				default:
					return this.bottom;
				}
			}
			set
			{
				switch (idx)
				{
				case 0:
					this.left = value;
					return;
				case 1:
					this.right = value;
					return;
				case 2:
					this.top = value;
					return;
				default:
					this.bottom = value;
					return;
				}
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0005B618 File Offset: 0x00059818
		public Margin() : this(0, 0, 0, 0)
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0005B624 File Offset: 0x00059824
		public Margin(Vector4 source) : this((int)source.x, (int)source.z, (int)source.y, (int)source.w)
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0005B648 File Offset: 0x00059848
		public Margin(RectOffset source) : this(source.left, source.right, source.top, source.bottom)
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0005B668 File Offset: 0x00059868
		public Margin(int left, int right, int top, int bottom)
		{

		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0005B68D File Offset: 0x0005988D
		public Margin Clone()
		{

            return default;
        }

		// Token: 0x06001166 RID: 4454 RVA: 0x0005B6AC File Offset: 0x000598AC
		public void CopyValuesTo(RectOffset target)
		{

		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0005B6DE File Offset: 0x000598DE
		public Vector4 ToVector4()
		{

            return default;
        }

		// Token: 0x06001168 RID: 4456 RVA: 0x0005B704 File Offset: 0x00059904
		public override string ToString()
		{

            return default;
        }

		// Token: 0x04000EEE RID: 3822
		[SerializeField]
		private int left;

		// Token: 0x04000EEF RID: 3823
		[SerializeField]
		private int right;

		// Token: 0x04000EF0 RID: 3824
		[SerializeField]
		private int top;

		// Token: 0x04000EF1 RID: 3825
		[SerializeField]
		private int bottom;
	}
}
