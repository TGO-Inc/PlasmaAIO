using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000046 RID: 70
public class RenderQueueController : Controller
{
	// Token: 0x06000208 RID: 520 RVA: 0x0000EB64 File Offset: 0x0000CD64
	public override void Init()
	{

	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000EC2C File Offset: 0x0000CE2C
	public void ScheduleClearTexture(Color destinationColor, bool noColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000EC90 File Offset: 0x0000CE90
	public void ScheduleApplyTexture(Color32[] pixels, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
	public void ScheduleCameraRender(Camera theCamera, int renderTextureIndex, string info)
	{

	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000ED4C File Offset: 0x0000CF4C
	public void ScheduleCopyTexture(int sourceTextureIndex, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
	public void ScheduleAdvancedCopyTexture(int sourceTextureIndex, int destinationTextureIndex, int sourceX, int sourceY, int sourceWidth, int sourceHeight, int destinationWidth, int destinationHeight, int destinationX, int destinationY, Color destinationColor, string info)
	{

	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000EE50 File Offset: 0x0000D050
	public void ScheduleDrawLine(int sourceX, int sourceY, int destinationX, int destinationY, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000EED4 File Offset: 0x0000D0D4
	public void ScheduleDrawRect(int sourceX, int sourceY, int destinationX, int destinationY, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000EF58 File Offset: 0x0000D158
	public void ScheduleDrawCircle(int sourceX, int sourceY, int radius, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
	public void ScheduleFillRect(int sourceX, int sourceY, int destinationX, int destinationY, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000F058 File Offset: 0x0000D258
	public void ScheduleFillCircle(int sourceX, int sourceY, int radius, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
	public void ScheduleDrawPolygon(float[] points, bool contiguous, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000F148 File Offset: 0x0000D348
	public void ScheduleDrawText(int destinationX, int destinationY, string text, Color destinationColor, int destinationTextureIndex, string info)
	{

	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000F204 File Offset: 0x0000D404
	public void ScheduleExportImage(int sourceTextureIndex, string assetName, string info)
	{

	}

	// Token: 0x06000216 RID: 534 RVA: 0x0000F27C File Offset: 0x0000D47C
	public void ProcessOperations()
	{

	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000F320 File Offset: 0x0000D520
	public void Log(string message)
	{

	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000F32F File Offset: 0x0000D52F
	public void LogVerbose(string message)
	{

	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000F33E File Offset: 0x0000D53E
	public void LogWarning(string message)
	{

	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000F34D File Offset: 0x0000D54D
	public void LogError(string message)
	{

	}

	// Token: 0x04000255 RID: 597
	public Material blitMaterial;

	// Token: 0x04000256 RID: 598
	public Texture2D fontAtlas;

	// Token: 0x04000257 RID: 599
	public int fontAtlasRows;

	// Token: 0x04000258 RID: 600
	public int fontAtlasColumns;

	// Token: 0x04000259 RID: 601
	public int fontAtlasGlyphWidth;

	// Token: 0x0400025A RID: 602
	public int fontAtlasGlyphHeight;

	// Token: 0x0400025B RID: 603
	public Shader drawLineShader;

	// Token: 0x0400025C RID: 604
	public Shader fillColorShader;

	// Token: 0x0400025D RID: 605
	public Shader drawRectShader;

	// Token: 0x0400025E RID: 606
	public Shader drawCircleShader;

	// Token: 0x0400025F RID: 607
	public Shader fillCircleShader;

	// Token: 0x04000260 RID: 608
	private List<RenderQueueController.Operation> _queuedOperations;

	// Token: 0x04000261 RID: 609
	private Material _blitMaterial;

	// Token: 0x04000262 RID: 610
	private float _lastImageExportTime;

	// Token: 0x04000263 RID: 611
	private const float _imageExportInterval = 10f;

	// Token: 0x04000264 RID: 612
	private static Texture2D temporaryTexture2D;

	// Token: 0x04000265 RID: 613
	private static int totalPixels;

	// Token: 0x04000266 RID: 614
	private static Material drawLineMaterial;

	// Token: 0x04000267 RID: 615
	private static Material fillColorMaterial;

	// Token: 0x04000268 RID: 616
	private static Material drawRectMaterial;

	// Token: 0x04000269 RID: 617
	private static Material drawCircleMaterial;

	// Token: 0x0400026A RID: 618
	private static Material fillCircleMaterial;

	// Token: 0x020002E8 RID: 744
	public class Operation
	{
		// Token: 0x06001E84 RID: 7812 RVA: 0x00096670 File Offset: 0x00094870
		public bool CheckSanity()
		{

            return default;
        }

		// Token: 0x06001E85 RID: 7813 RVA: 0x000967F4 File Offset: 0x000949F4
		public void Execute()
		{

		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00096A78 File Offset: 0x00094C78
		private void DrawShape(RenderQueueController.Operation.Types operation)
		{

		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00096B04 File Offset: 0x00094D04
		private void BlitSpecial(Texture sourceTexture, RenderTexture destinationTexture, int sX, int sY, int sWidth, int sHeight, int dX, int dY, int dWidth, int dHeight, Color dColor)
		{

		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00096C48 File Offset: 0x00094E48
		private void DrawLine()
		{

		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00096D7C File Offset: 0x00094F7C
		private void DrawRect()
		{

		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00096EB0 File Offset: 0x000950B0
		private void DrawCircle()
		{

		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00096FD4 File Offset: 0x000951D4
		private void FillRect()
		{

		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00097120 File Offset: 0x00095320
		private void FillCircle()
		{

		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00097244 File Offset: 0x00095444
		private void DrawPolygon()
		{

		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000973C8 File Offset: 0x000955C8
		public override string ToString()
		{

            return default;
        }

		// Token: 0x06001E8F RID: 7823 RVA: 0x000976D0 File Offset: 0x000958D0
		public bool IsEqualTo(RenderQueueController.Operation other)
		{

            return default;
        }

		// Token: 0x040019A9 RID: 6569
		public RenderQueueController.Operation.Types type;

		// Token: 0x040019AA RID: 6570
		public int sourceIndex;

		// Token: 0x040019AB RID: 6571
		public int destinationIndex;

		// Token: 0x040019AC RID: 6572
		public int sourceX;

		// Token: 0x040019AD RID: 6573
		public int sourceY;

		// Token: 0x040019AE RID: 6574
		public int sourceWidth;

		// Token: 0x040019AF RID: 6575
		public int sourceHeight;

		// Token: 0x040019B0 RID: 6576
		public int destinationX;

		// Token: 0x040019B1 RID: 6577
		public int destinationY;

		// Token: 0x040019B2 RID: 6578
		public int destinationWidth;

		// Token: 0x040019B3 RID: 6579
		public int destinationHeight;

		// Token: 0x040019B4 RID: 6580
		public int radius;

		// Token: 0x040019B5 RID: 6581
		public float[] points;

		// Token: 0x040019B6 RID: 6582
		public Color32[] pixels;

		// Token: 0x040019B7 RID: 6583
		public bool contiguous;

		// Token: 0x040019B8 RID: 6584
		public Color destinationColor;

		// Token: 0x040019B9 RID: 6585
		public string text;

		// Token: 0x040019BA RID: 6586
		public Texture2D fontAtlas;

		// Token: 0x040019BB RID: 6587
		public int fontAtlasRows;

		// Token: 0x040019BC RID: 6588
		public int fontAtlasColumns;

		// Token: 0x040019BD RID: 6589
		public int fontAtlasGlyphWidth;

		// Token: 0x040019BE RID: 6590
		public int fontAtlasGlyphHeight;

		// Token: 0x040019BF RID: 6591
		public bool noColor;

		// Token: 0x040019C0 RID: 6592
		public Material blitMaterial;

		// Token: 0x040019C1 RID: 6593
		public string info;

		// Token: 0x040019C2 RID: 6594
		public Camera camera;

		// Token: 0x020004BB RID: 1211
		public enum Types
		{
			// Token: 0x040020DF RID: 8415
			CameraRender,
			// Token: 0x040020E0 RID: 8416
			CopyTexture,
			// Token: 0x040020E1 RID: 8417
			AdvancedCopyTexture,
			// Token: 0x040020E2 RID: 8418
			DrawLine,
			// Token: 0x040020E3 RID: 8419
			DrawRect,
			// Token: 0x040020E4 RID: 8420
			DrawCircle,
			// Token: 0x040020E5 RID: 8421
			FillRect,
			// Token: 0x040020E6 RID: 8422
			FillCircle,
			// Token: 0x040020E7 RID: 8423
			DrawPolygon,
			// Token: 0x040020E8 RID: 8424
			ClearTexture,
			// Token: 0x040020E9 RID: 8425
			ApplyTexture,
			// Token: 0x040020EA RID: 8426
			DrawText,
			// Token: 0x040020EB RID: 8427
			ExportImage
		}
	}
}
