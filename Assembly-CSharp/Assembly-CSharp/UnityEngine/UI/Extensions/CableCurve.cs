using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200022D RID: 557
	[Serializable]
	public class CableCurve
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00064A24 File Offset: 0x00062C24
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x00064A2C File Offset: 0x00062C2C
		public bool regenPoints
		{
			get
			{
				return this.m_regen;
			}
			set
			{
				this.m_regen = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00064A35 File Offset: 0x00062C35
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00064A3D File Offset: 0x00062C3D
		public Vector2 start
		{
			get
			{
				return this.m_start;
			}
			set
			{
				if (value != this.m_start)
				{
					this.m_regen = true;
				}
				this.m_start = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00064A5B File Offset: 0x00062C5B
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x00064A63 File Offset: 0x00062C63
		public Vector2 end
		{
			get
			{
				return this.m_end;
			}
			set
			{
				if (value != this.m_end)
				{
					this.m_regen = true;
				}
				this.m_end = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00064A81 File Offset: 0x00062C81
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00064A89 File Offset: 0x00062C89
		public float slack
		{
			get
			{
				return this.m_slack;
			}
			set
			{
				if (value != this.m_slack)
				{
					this.m_regen = true;
				}
				this.m_slack = Mathf.Max(0f, value);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00064AAC File Offset: 0x00062CAC
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00064AB4 File Offset: 0x00062CB4
		public int steps
		{
			get
			{
				return this.m_steps;
			}
			set
			{
				if (value != this.m_steps)
				{
					this.m_regen = true;
				}
				this.m_steps = Mathf.Max(2, value);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00064AD4 File Offset: 0x00062CD4
		public Vector2 midPoint
		{
			get
			{
				Vector2 result = Vector2.zero;
				if (this.m_steps == 2)
				{
					return (this.points[0] + this.points[1]) * 0.5f;
				}
				if (this.m_steps > 2)
				{
					int num = this.m_steps / 2;
					if (this.m_steps % 2 == 0)
					{
						result = (this.points[num] + this.points[num + 1]) * 0.5f;
					}
					else
					{
						result = this.points[num];
					}
				}
				return result;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00064B70 File Offset: 0x00062D70
		public CableCurve()
		{

		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00064BC8 File Offset: 0x00062DC8
		public CableCurve(Vector2[] inputPoints)
		{

		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00064C18 File Offset: 0x00062E18
		public CableCurve(CableCurve v)
		{

		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00064C74 File Offset: 0x00062E74
		public Vector2[] Points()
		{

            return default;
        }

		// Token: 0x04000FF6 RID: 4086
		[SerializeField]
		private Vector2 m_start;

		// Token: 0x04000FF7 RID: 4087
		[SerializeField]
		private Vector2 m_end;

		// Token: 0x04000FF8 RID: 4088
		[SerializeField]
		private float m_slack;

		// Token: 0x04000FF9 RID: 4089
		[SerializeField]
		private int m_steps;

		// Token: 0x04000FFA RID: 4090
		[SerializeField]
		private bool m_regen;

		// Token: 0x04000FFB RID: 4091
		private static Vector2[] emptyCurve = new Vector2[]
		{
			new Vector2(0f, 0f),
			new Vector2(0f, 0f)
		};

		// Token: 0x04000FFC RID: 4092
		[SerializeField]
		private Vector2[] points;
	}
}
