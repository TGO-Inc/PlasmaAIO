using System;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000288 RID: 648
	public class SketchViewSelection : SerializedMonoBehaviour
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x00081FB5 File Offset: 0x000801B5
		private void Awake()
		{

		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00081FC4 File Offset: 0x000801C4
		public void Resize(Rect rect)
		{

		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000822AD File Offset: 0x000804AD
		public void SetState(SketchViewSelection.States state)
		{

		}

		// Token: 0x040014C1 RID: 5313
		public SpriteRenderer topLeftCorner;

		// Token: 0x040014C2 RID: 5314
		public SpriteRenderer topRightCorner;

		// Token: 0x040014C3 RID: 5315
		public SpriteRenderer bottomRightCorner;

		// Token: 0x040014C4 RID: 5316
		public SpriteRenderer bottomLeftCorner;

		// Token: 0x040014C5 RID: 5317
		public SpriteRenderer topSide;

		// Token: 0x040014C6 RID: 5318
		public SpriteRenderer rightSide;

		// Token: 0x040014C7 RID: 5319
		public SpriteRenderer bottomSide;

		// Token: 0x040014C8 RID: 5320
		public SpriteRenderer leftSide;

		// Token: 0x040014C9 RID: 5321
		public RectTransform hints;

		// Token: 0x040014CA RID: 5322
		private UIColorMapperController _mapperController;

		// Token: 0x040014CB RID: 5323
		private Rect _rect;

		// Token: 0x0200048A RID: 1162
		public enum States
		{
			// Token: 0x04001FED RID: 8173
			Normal,
			// Token: 0x04001FEE RID: 8174
			Invalid,
			// Token: 0x04001FEF RID: 8175
			Illegal
		}
	}
}
