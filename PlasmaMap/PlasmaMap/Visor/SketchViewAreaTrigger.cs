using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200027C RID: 636
	public class SketchViewAreaTrigger : SketchViewTrigger
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0007BD18 File Offset: 0x00079F18
		public Bounds worldBounds
		{
			get
			{
				Vector3 center;
				center.x = base.transform.position.x + this.offset.x + this._bounds.size.x / 2f;
				center.y = base.transform.position.y + this.offset.y - this._bounds.size.y / 2f;
				center.z = 0f;
				this._bounds.center = center;
				return this._bounds;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0007BDB8 File Offset: 0x00079FB8
		public Bounds localBounds
		{
			get
			{
				Vector3 center;
				center.x = base.transform.localPosition.x + this.offset.x + this._bounds.size.x / 2f;
				center.y = base.transform.localPosition.y + this.offset.y - this._bounds.size.y / 2f;
				center.z = 0f;
				this._bounds.center = center;
				return this._bounds;
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0007BE58 File Offset: 0x0007A058
		public void Setup(SketchView sketchView)
		{

		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0007BECC File Offset: 0x0007A0CC
		public void Setup(SketchView sketchView, Vector2 overrideSize)
		{

		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0007BF58 File Offset: 0x0007A158
		private void UpdatePoints()
		{

		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0007C034 File Offset: 0x0007A234
		protected override void UnregisterPointProviders()
		{

		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0007C094 File Offset: 0x0007A294
		public override bool Contains(Vector2 position)
		{

            return default;
        }

		// Token: 0x060018AB RID: 6315 RVA: 0x0007C0C4 File Offset: 0x0007A2C4
		public override void OnDrawGizmos()
		{

		}

		// Token: 0x040013F1 RID: 5105
		public bool useSpriteSize;

		// Token: 0x040013F2 RID: 5106
		public bool overrideWidth;

		// Token: 0x040013F3 RID: 5107
		public bool overrideHeight;

		// Token: 0x040013F4 RID: 5108
		public Vector2 size;

		// Token: 0x040013F5 RID: 5109
		public Vector2 offset;

		// Token: 0x040013F6 RID: 5110
		private Bounds _bounds;
	}
}
