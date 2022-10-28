using System;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001D1 RID: 465
	[AddComponentMenu("Better UI/Controls/Better Scroll Rect", 30)]
	public class BetterScrollRect : ScrollRect
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0005963F File Offset: 0x0005783F
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x00059647 File Offset: 0x00057847
		public Vector2 DragStartPosition
		{
			get
			{
				return this.m_ContentStartPosition;
			}
			set
			{
				this.m_ContentStartPosition = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00059650 File Offset: 0x00057850
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00059658 File Offset: 0x00057858
		public Bounds ContentBounds
		{
			get
			{
				return this.m_ContentBounds;
			}
			set
			{
				this.m_ContentBounds = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00059661 File Offset: 0x00057861
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x00059669 File Offset: 0x00057869
		public float HorizontalStartPosition
		{
			get
			{
				return this.horizontalStartPosition;
			}
			set
			{
				this.horizontalStartPosition = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00059672 File Offset: 0x00057872
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0005967A File Offset: 0x0005787A
		public float VerticalStartPosition
		{
			get
			{
				return this.verticalStartPosition;
			}
			set
			{
				this.verticalStartPosition = value;
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00059683 File Offset: 0x00057883
		protected override void Start()
		{

		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00059698 File Offset: 0x00057898
		public void ResetToStartPosition()
		{

		}

		// Token: 0x04000E8E RID: 3726
		[SerializeField]
		[Range(0f, 1f)]
		private float horizontalStartPosition;

		// Token: 0x04000E8F RID: 3727
		[SerializeField]
		[Range(0f, 1f)]
		private float verticalStartPosition = 1f;
	}
}
