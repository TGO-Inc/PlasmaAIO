using System;
using System.Threading;
using UnityEngine;

// Token: 0x02000191 RID: 401
public static class TextureScale
{
	// Token: 0x06000EB3 RID: 3763 RVA: 0x0004B845 File Offset: 0x00049A45
	public static void Point(Texture2D tex, int newWidth, int newHeight)
	{

	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x0004B850 File Offset: 0x00049A50
	public static void Bilinear(Texture2D tex, int newWidth, int newHeight)
	{

	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0004B85C File Offset: 0x00049A5C
	private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear)
	{

	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x0004B9C4 File Offset: 0x00049BC4
	private static void BilinearScale(object obj)
	{

	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x0004BAE8 File Offset: 0x00049CE8
	private static void PointScale(object obj)
	{

	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x0004BB84 File Offset: 0x00049D84
	private static Color ColorLerpUnclamped(Color c1, Color c2, float value)
	{

        return default;
    }

	// Token: 0x04000C98 RID: 3224
	private static Color[] texColors;

	// Token: 0x04000C99 RID: 3225
	private static Color[] newColors;

	// Token: 0x04000C9A RID: 3226
	private static int w;

	// Token: 0x04000C9B RID: 3227
	private static float ratioX;

	// Token: 0x04000C9C RID: 3228
	private static float ratioY;

	// Token: 0x04000C9D RID: 3229
	private static int w2;

	// Token: 0x04000C9E RID: 3230
	private static int finishCount;

	// Token: 0x04000C9F RID: 3231
	private static Mutex mutex;

	// Token: 0x020003C8 RID: 968
	private class ThreadData
	{
		// Token: 0x060020F7 RID: 8439 RVA: 0x000A25E5 File Offset: 0x000A07E5
		public ThreadData(int s, int e)
		{

		}

		// Token: 0x04001D65 RID: 7525
		public int start;

		// Token: 0x04001D66 RID: 7526
		public int end;
	}
}
