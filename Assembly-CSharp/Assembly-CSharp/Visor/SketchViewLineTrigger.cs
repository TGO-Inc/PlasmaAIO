using System;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000283 RID: 643
	public class SketchViewLineTrigger : SketchViewTrigger
	{
		// Token: 0x0600191E RID: 6430 RVA: 0x0007DFFC File Offset: 0x0007C1FC
		public void Setup(SketchView sketchView)
		{

		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0007E008 File Offset: 0x0007C208
		public void UpdatePoints(Vector3 start, Vector3 end)
		{

		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0007E178 File Offset: 0x0007C378
		public Vector3 GetPositionOnLine(Vector3 position)
		{

            return default;
        }

		// Token: 0x06001921 RID: 6433 RVA: 0x0007E278 File Offset: 0x0007C478
		protected override void UnregisterPointProviders()
		{

		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0007E2D8 File Offset: 0x0007C4D8
		public override bool Contains(Vector2 position)
		{

            return default;
        }

		// Token: 0x06001923 RID: 6435 RVA: 0x0007E33F File Offset: 0x0007C53F
		public override void OnDrawGizmos()
		{

		}

		// Token: 0x04001448 RID: 5192
		private Vector3 _start;

		// Token: 0x04001449 RID: 5193
		private Vector3 _end;

		// Token: 0x0400144A RID: 5194
		private float _lineLength;

		// Token: 0x0400144B RID: 5195
		private float _slope;

		// Token: 0x0400144C RID: 5196
		private bool _vertical;

		// Token: 0x0400144D RID: 5197
		private bool _horizontal;

		// Token: 0x0400144E RID: 5198
		private const float _precision = 0.02f;
	}
}
