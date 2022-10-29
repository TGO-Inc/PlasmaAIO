using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.UnityEngine.UI.Extensions
{
	// Token: 0x0200022C RID: 556
	public class BezierPath
	{
		// Token: 0x06001383 RID: 4995 RVA: 0x000643AC File Offset: 0x000625AC
		public BezierPath()
		{

		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000643DD File Offset: 0x000625DD
		public void SetControlPoints(List<Vector2> newControlPoints)
		{

		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0006440B File Offset: 0x0006260B
		public void SetControlPoints(Vector2[] newControlPoints)
		{

		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00064439 File Offset: 0x00062639
		public List<Vector2> GetControlPoints()
		{

            return default;
        }

		// Token: 0x06001387 RID: 4999 RVA: 0x00064444 File Offset: 0x00062644
		public void Interpolate(List<Vector2> segmentPoints, float scale)
		{

		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000645DC File Offset: 0x000627DC
		public void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale)
		{

		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000646E4 File Offset: 0x000628E4
		public Vector2 CalculateBezierPoint(int curveIndex, float t)
		{

            return default;
        }

		// Token: 0x0600138A RID: 5002 RVA: 0x0006473C File Offset: 0x0006293C
		public List<Vector2> GetDrawingPoints0()
		{

            return default;
        }

		// Token: 0x0600138B RID: 5003 RVA: 0x000647A0 File Offset: 0x000629A0
		public List<Vector2> GetDrawingPoints1()
		{

            return default;
        }

		// Token: 0x0600138C RID: 5004 RVA: 0x00064860 File Offset: 0x00062A60
		public List<Vector2> GetDrawingPoints2()
		{

            return default;
        }

		// Token: 0x0600138D RID: 5005 RVA: 0x000648A0 File Offset: 0x00062AA0
		private List<Vector2> FindDrawingPoints(int curveIndex)
		{

            return default;
        }

		// Token: 0x0600138E RID: 5006 RVA: 0x000648F0 File Offset: 0x00062AF0
		private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex)
		{

            return default;
        }

		// Token: 0x0600138F RID: 5007 RVA: 0x000649C4 File Offset: 0x00062BC4
		private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{

            return default;
        }

		// Token: 0x04000FF1 RID: 4081
		public int SegmentsPerCurve = 10;

		// Token: 0x04000FF2 RID: 4082
		public float MINIMUM_SQR_DISTANCE = 0.01f;

		// Token: 0x04000FF3 RID: 4083
		public float DIVISION_THRESHOLD = -0.99f;

		// Token: 0x04000FF4 RID: 4084
		private List<Vector2> controlPoints;

		// Token: 0x04000FF5 RID: 4085
		private int curveCount;
	}
}
