using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.BeautifyEffect
{
	// Token: 0x020002CA RID: 714
	[CreateAssetMenu(fileName = "BeautifyProfile", menuName = "Beautify Profile", order = 101)]
	public class BeautifyProfile : ScriptableObject
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x00094370 File Offset: 0x00092570
		public void Load(Beautify b)
		{

		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00094B9C File Offset: 0x00092D9C
		public void Save(Beautify b)
		{

		}

		// Token: 0x04001867 RID: 6247
		[Range(0f, 0.2f)]
		public float dither = 0.02f;

		// Token: 0x04001868 RID: 6248
		[Range(0f, 1f)]
		public float ditherDepth;

		// Token: 0x04001869 RID: 6249
		[Range(0f, 1f)]
		public float sharpenMinDepth;

		// Token: 0x0400186A RID: 6250
		[Range(0f, 1.1f)]
		public float sharpenMaxDepth = 0.999f;

		// Token: 0x0400186B RID: 6251
		[Range(0f, 15f)]
		public float sharpen = 2f;

		// Token: 0x0400186C RID: 6252
		[Range(0f, 1f)]
		public float sharpenMinMaxDepthFallOff;

		// Token: 0x0400186D RID: 6253
		[Range(0f, 0.05f)]
		public float sharpenDepthThreshold = 0.035f;

		// Token: 0x0400186E RID: 6254
		public Color tintColor = new Color(1f, 1f, 1f, 0f);

		// Token: 0x0400186F RID: 6255
		[Range(0f, 0.2f)]
		public float sharpenRelaxation = 0.08f;

		// Token: 0x04001870 RID: 6256
		[Range(0f, 1f)]
		public float sharpenClamp = 0.45f;

		// Token: 0x04001871 RID: 6257
		[Range(0f, 1f)]
		public float sharpenMotionSensibility = 0.5f;

		// Token: 0x04001872 RID: 6258
		[Header("Best performance mode only")]
		[Range(1f, 8f)]
		public int downscale = 1;

		// Token: 0x04001873 RID: 6259
		[Header("Best quality mode only")]
		[Range(1f, 3f)]
		public int superSampling = 1;

		// Token: 0x04001874 RID: 6260
		[Range(0f, 20f)]
		public float antialiasStrength = 5f;

		// Token: 0x04001875 RID: 6261
		[Range(0f, 0.05f)]
		public float antialiasDepthThreshold = 0.001f;

		// Token: 0x04001876 RID: 6262
		[Range(-2f, 3f)]
		public float saturate = 1f;

		// Token: 0x04001877 RID: 6263
		[Range(0.5f, 1.5f)]
		public float contrast = 1.02f;

		// Token: 0x04001878 RID: 6264
		[Range(0f, 2f)]
		public float brightness = 1.05f;

		// Token: 0x04001879 RID: 6265
		[Range(0f, 2f)]
		public float daltonize;

		// Token: 0x0400187A RID: 6266
		[Range(0f, 1f)]
		public float hardLightIntensity = 0.5f;

		// Token: 0x0400187B RID: 6267
		[Range(0f, 1f)]
		public float hardLightBlend;

		// Token: 0x0400187C RID: 6268
		public bool vignetting;

		// Token: 0x0400187D RID: 6269
		public Color vignettingColor = new Color(0.3f, 0.3f, 0.3f, 0.05f);

		// Token: 0x0400187E RID: 6270
		public float vignettingFade;

		// Token: 0x0400187F RID: 6271
		public bool vignettingCircularShape;

		// Token: 0x04001880 RID: 6272
		public float vignettingAspectRatio = 1f;

		// Token: 0x04001881 RID: 6273
		[Range(0f, 1f)]
		public float vignettingBlink;

		// Token: 0x04001882 RID: 6274
		public BEAUTIFY_BLINK_STYLE vignettingBlinkStyle;

		// Token: 0x04001883 RID: 6275
		public Texture2D vignettingMask;

		// Token: 0x04001884 RID: 6276
		public Vector2 vignettingCenter = new Vector2(0.5f, 0.5f);

		// Token: 0x04001885 RID: 6277
		public bool frame;

		// Token: 0x04001886 RID: 6278
		public Color frameColor = new Color(1f, 1f, 1f, 0.047f);

		// Token: 0x04001887 RID: 6279
		public Texture2D frameMask;

		// Token: 0x04001888 RID: 6280
		public bool lut;

		// Token: 0x04001889 RID: 6281
		[Range(0f, 1f)]
		public float lutIntensity = 1f;

		// Token: 0x0400188A RID: 6282
		public Texture2D lutTexture;

		// Token: 0x0400188B RID: 6283
		public bool nightVision;

		// Token: 0x0400188C RID: 6284
		public Color nightVisionColor = new Color(0.5f, 1f, 0.5f, 0.5f);

		// Token: 0x0400188D RID: 6285
		public bool outline;

		// Token: 0x0400188E RID: 6286
		public Color outlineColor = new Color(0f, 0f, 0f, 0.8f);

		// Token: 0x0400188F RID: 6287
		public bool outlineCustomize;

		// Token: 0x04001890 RID: 6288
		public BEAUTIFY_OUTLINE_STAGE outlineStage;

		// Token: 0x04001891 RID: 6289
		[Range(0f, 2f)]
		public float outlineSpread = 1f;

		// Token: 0x04001892 RID: 6290
		[Range(0f, 5f)]
		public int outlineBlurPassCount = 1;

		// Token: 0x04001893 RID: 6291
		[Range(0f, 8f)]
		public float outlineIntensityMultiplier = 1f;

		// Token: 0x04001894 RID: 6292
		public bool thermalVision;

		// Token: 0x04001895 RID: 6293
		public bool lensDirt;

		// Token: 0x04001896 RID: 6294
		[Range(0f, 1f)]
		public float lensDirtThreshold = 0.5f;

		// Token: 0x04001897 RID: 6295
		[Range(0f, 1f)]
		public float lensDirtIntensity = 0.9f;

		// Token: 0x04001898 RID: 6296
		public Texture2D lensDirtTexture;

		// Token: 0x04001899 RID: 6297
		public bool chromaticAberration;

		// Token: 0x0400189A RID: 6298
		[Range(0f, 0.05f)]
		public float chromaticAberrationIntensity;

		// Token: 0x0400189B RID: 6299
		[Range(0f, 32f)]
		public float chromaticAberrationSmoothing;

		// Token: 0x0400189C RID: 6300
		public bool bloom;

		// Token: 0x0400189D RID: 6301
		public LayerMask bloomCullingMask;

		// Token: 0x0400189E RID: 6302
		[Range(1f, 4f)]
		public float bloomLayerMaskDownsampling = 1f;

		// Token: 0x0400189F RID: 6303
		[Range(0f, 10f)]
		public float bloomIntensity = 1f;

		// Token: 0x040018A0 RID: 6304
		public float bloomMaxBrightness = 1000f;

		// Token: 0x040018A1 RID: 6305
		[Range(0f, 3f)]
		public float bloomBoost0;

		// Token: 0x040018A2 RID: 6306
		[Range(0f, 3f)]
		public float bloomBoost1;

		// Token: 0x040018A3 RID: 6307
		[Range(0f, 3f)]
		public float bloomBoost2;

		// Token: 0x040018A4 RID: 6308
		[Range(0f, 3f)]
		public float bloomBoost3;

		// Token: 0x040018A5 RID: 6309
		[Range(0f, 3f)]
		public float bloomBoost4;

		// Token: 0x040018A6 RID: 6310
		[Range(0f, 3f)]
		public float bloomBoost5;

		// Token: 0x040018A7 RID: 6311
		public bool bloomAntiflicker;

		// Token: 0x040018A8 RID: 6312
		public bool bloomUltra;

		// Token: 0x040018A9 RID: 6313
		[Range(1f, 10f)]
		public int bloomUltraResolution = 10;

		// Token: 0x040018AA RID: 6314
		[Range(0f, 5f)]
		public float bloomThreshold = 0.75f;

		// Token: 0x040018AB RID: 6315
		public bool bloomCustomize;

		// Token: 0x040018AC RID: 6316
		[Range(0f, 1f)]
		public float bloomWeight0 = 0.5f;

		// Token: 0x040018AD RID: 6317
		[Range(0f, 1f)]
		public float bloomWeight1 = 0.5f;

		// Token: 0x040018AE RID: 6318
		[Range(0f, 1f)]
		public float bloomWeight2 = 0.5f;

		// Token: 0x040018AF RID: 6319
		[Range(0f, 1f)]
		public float bloomWeight3 = 0.5f;

		// Token: 0x040018B0 RID: 6320
		[Range(0f, 1f)]
		public float bloomWeight4 = 0.5f;

		// Token: 0x040018B1 RID: 6321
		[Range(0f, 1f)]
		public float bloomWeight5 = 0.5f;

		// Token: 0x040018B2 RID: 6322
		public bool bloomBlur = true;

		// Token: 0x040018B3 RID: 6323
		[Range(0f, 1f)]
		public float bloomDepthAtten;

		// Token: 0x040018B4 RID: 6324
		public float bloomNearAtten;

		// Token: 0x040018B5 RID: 6325
		[Range(-1f, 1f)]
		public float bloomLayerZBias;

		// Token: 0x040018B6 RID: 6326
		public Color bloomTint = new Color(1f, 1f, 1f, 0f);

		// Token: 0x040018B7 RID: 6327
		public bool anamorphicFlares;

		// Token: 0x040018B8 RID: 6328
		[Range(0f, 10f)]
		public float anamorphicFlaresIntensity = 1f;

		// Token: 0x040018B9 RID: 6329
		public bool anamorphicFlaresAntiflicker;

		// Token: 0x040018BA RID: 6330
		public bool anamorphicFlaresUltra;

		// Token: 0x040018BB RID: 6331
		[Range(1f, 10f)]
		public int anamorphicFlaresUltraResolution = 10;

		// Token: 0x040018BC RID: 6332
		[Range(0f, 5f)]
		public float anamorphicFlaresThreshold = 0.75f;

		// Token: 0x040018BD RID: 6333
		[Range(0.1f, 2f)]
		public float anamorphicFlaresSpread = 1f;

		// Token: 0x040018BE RID: 6334
		public bool anamorphicFlaresVertical;

		// Token: 0x040018BF RID: 6335
		public Color anamorphicFlaresTint = new Color(0.5f, 0.5f, 1f, 0f);

		// Token: 0x040018C0 RID: 6336
		public bool anamorphicFlaresBlur = true;

		// Token: 0x040018C1 RID: 6337
		public bool depthOfField;

		// Token: 0x040018C2 RID: 6338
		public bool depthOfFieldTransparencySupport;

		// Token: 0x040018C3 RID: 6339
		public Transform depthOfFieldTargetFocus;

		// Token: 0x040018C4 RID: 6340
		public bool depthOfFieldAutofocus;

		// Token: 0x040018C5 RID: 6341
		public Vector2 depthofFieldAutofocusViewportPoint = new Vector2(0.5f, 0.5f);

		// Token: 0x040018C6 RID: 6342
		public LayerMask depthOfFieldAutofocusLayerMask = -1;

		// Token: 0x040018C7 RID: 6343
		public float depthOfFieldAutofocusMinDistance;

		// Token: 0x040018C8 RID: 6344
		public float depthOfFieldAutofocusMaxDistance = 10000f;

		// Token: 0x040018C9 RID: 6345
		public float depthOfFieldAutofocusDistanceShift;

		// Token: 0x040018CA RID: 6346
		public LayerMask depthOfFieldExclusionLayerMask = 0;

		// Token: 0x040018CB RID: 6347
		[Range(1f, 4f)]
		public float depthOfFieldExclusionLayerMaskDownsampling = 1f;

		// Token: 0x040018CC RID: 6348
		[Range(1f, 4f)]
		public float depthOfFieldTransparencySupportDownsampling = 1f;

		// Token: 0x040018CD RID: 6349
		[Range(0.9f, 1f)]
		public float depthOfFieldExclusionBias = 0.99f;

		// Token: 0x040018CE RID: 6350
		[Range(1f, 100f)]
		public float depthOfFieldDistance = 1f;

		// Token: 0x040018CF RID: 6351
		[Range(0.001f, 1f)]
		public float depthOfFieldFocusSpeed = 1f;

		// Token: 0x040018D0 RID: 6352
		[Range(1f, 5f)]
		public int depthOfFieldDownsampling = 2;

		// Token: 0x040018D1 RID: 6353
		[Range(2f, 16f)]
		public int depthOfFieldMaxSamples = 4;

		// Token: 0x040018D2 RID: 6354
		public BEAUTIFY_DOF_CAMERA_SETTINGS depthOfFieldCameraSettings;

		// Token: 0x040018D3 RID: 6355
		[Range(0.005f, 0.5f)]
		public float depthOfFieldFocalLength = 0.05f;

		// Token: 0x040018D4 RID: 6356
		public float depthOfFieldAperture = 2.8f;

		// Token: 0x040018D5 RID: 6357
		[Range(1f, 300f)]
		public float depthOfFieldFocalLengthReal = 50f;

		// Token: 0x040018D6 RID: 6358
		[Range(1f, 32f)]
		public float depthOfFieldFStop = 2f;

		// Token: 0x040018D7 RID: 6359
		[Range(1f, 48f)]
		public float depthOfFieldImageSensorHeight = 24f;

		// Token: 0x040018D8 RID: 6360
		public bool depthOfFieldForegroundBlur = true;

		// Token: 0x040018D9 RID: 6361
		public bool depthOfFieldForegroundBlurHQ;

		// Token: 0x040018DA RID: 6362
		[Range(0f, 32f)]
		public float depthOfFieldForegroundBlurHQSpread = 16f;

		// Token: 0x040018DB RID: 6363
		public float depthOfFieldForegroundDistance = 0.25f;

		// Token: 0x040018DC RID: 6364
		public bool depthOfFieldBokeh = true;

		// Token: 0x040018DD RID: 6365
		public BEAUTIFY_BOKEH_COMPOSITION depthOfFieldBokehComposition;

		// Token: 0x040018DE RID: 6366
		[Range(0.5f, 3f)]
		public float depthOfFieldBokehThreshold = 1f;

		// Token: 0x040018DF RID: 6367
		[Range(0f, 8f)]
		public float depthOfFieldBokehIntensity = 2f;

		// Token: 0x040018E0 RID: 6368
		public float depthOfFieldMaxBrightness = 1000f;

		// Token: 0x040018E1 RID: 6369
		public float depthOfFieldMaxDistance = 1f;

		// Token: 0x040018E2 RID: 6370
		public FilterMode depthOfFieldFilterMode = FilterMode.Bilinear;

		// Token: 0x040018E3 RID: 6371
		public LayerMask depthOfFieldTransparencyLayerMask = -1;

		// Token: 0x040018E4 RID: 6372
		public bool eyeAdaptation;

		// Token: 0x040018E5 RID: 6373
		[Range(0f, 1f)]
		public float eyeAdaptationMinExposure = 0.2f;

		// Token: 0x040018E6 RID: 6374
		[Range(1f, 100f)]
		public float eyeAdaptationMaxExposure = 5f;

		// Token: 0x040018E7 RID: 6375
		[Range(0f, 1f)]
		public float eyeAdaptationSpeedToLight = 1f;

		// Token: 0x040018E8 RID: 6376
		[Range(0f, 1f)]
		public float eyeAdaptationSpeedToDark = 0.7f;

		// Token: 0x040018E9 RID: 6377
		public bool purkinje;

		// Token: 0x040018EA RID: 6378
		[Range(0f, 5f)]
		public float purkinjeAmount = 1f;

		// Token: 0x040018EB RID: 6379
		[Range(0f, 1f)]
		public float purkinjeLuminanceThreshold = 0.15f;

		// Token: 0x040018EC RID: 6380
		public BEAUTIFY_TMO tonemap;

		// Token: 0x040018ED RID: 6381
		public bool sunFlares;

		// Token: 0x040018EE RID: 6382
		[Range(0f, 1f)]
		public float sunFlaresIntensity = 1f;

		// Token: 0x040018EF RID: 6383
		public float sunFlaresRevealSpeed = 1f;

		// Token: 0x040018F0 RID: 6384
		public float sunFlaresHideSpeed = 1f;

		// Token: 0x040018F1 RID: 6385
		[Range(0f, 1f)]
		public float sunFlaresSolarWindSpeed = 0.01f;

		// Token: 0x040018F2 RID: 6386
		public Color sunFlaresTint = new Color(1f, 1f, 1f);

		// Token: 0x040018F3 RID: 6387
		[Range(1f, 5f)]
		public int sunFlaresDownsampling = 1;

		// Token: 0x040018F4 RID: 6388
		[Range(0f, 1f)]
		public float sunFlaresSunIntensity = 0.1f;

		// Token: 0x040018F5 RID: 6389
		[Range(0f, 1f)]
		public float sunFlaresSunDiskSize = 0.05f;

		// Token: 0x040018F6 RID: 6390
		[Range(0f, 10f)]
		public float sunFlaresSunRayDiffractionIntensity = 3.5f;

		// Token: 0x040018F7 RID: 6391
		[Range(0f, 1f)]
		public float sunFlaresSunRayDiffractionThreshold = 0.13f;

		// Token: 0x040018F8 RID: 6392
		[Range(0f, 0.2f)]
		public float sunFlaresCoronaRays1Length = 0.02f;

		// Token: 0x040018F9 RID: 6393
		[Range(2f, 30f)]
		public int sunFlaresCoronaRays1Streaks = 12;

		// Token: 0x040018FA RID: 6394
		[Range(0f, 0.1f)]
		public float sunFlaresCoronaRays1Spread = 0.001f;

		// Token: 0x040018FB RID: 6395
		[Range(0f, 6.2831855f)]
		public float sunFlaresCoronaRays1AngleOffset;

		// Token: 0x040018FC RID: 6396
		[Range(0f, 0.2f)]
		public float sunFlaresCoronaRays2Length = 0.05f;

		// Token: 0x040018FD RID: 6397
		[Range(2f, 30f)]
		public int sunFlaresCoronaRays2Streaks = 12;

		// Token: 0x040018FE RID: 6398
		[Range(0f, 0.1f)]
		public float sunFlaresCoronaRays2Spread = 0.1f;

		// Token: 0x040018FF RID: 6399
		[Range(0f, 6.2831855f)]
		public float sunFlaresCoronaRays2AngleOffset;

		// Token: 0x04001900 RID: 6400
		[Range(0f, 1f)]
		public float sunFlaresGhosts1Size = 0.03f;

		// Token: 0x04001901 RID: 6401
		[Range(-3f, 3f)]
		public float sunFlaresGhosts1Offset = 1.04f;

		// Token: 0x04001902 RID: 6402
		[Range(0f, 1f)]
		public float sunFlaresGhosts1Brightness = 0.037f;

		// Token: 0x04001903 RID: 6403
		[Range(0f, 1f)]
		public float sunFlaresGhosts2Size = 0.1f;

		// Token: 0x04001904 RID: 6404
		[Range(-3f, 3f)]
		public float sunFlaresGhosts2Offset = 0.71f;

		// Token: 0x04001905 RID: 6405
		[Range(0f, 1f)]
		public float sunFlaresGhosts2Brightness = 0.03f;

		// Token: 0x04001906 RID: 6406
		[Range(0f, 1f)]
		public float sunFlaresGhosts3Size = 0.24f;

		// Token: 0x04001907 RID: 6407
		[Range(-3f, 3f)]
		public float sunFlaresGhosts3Brightness = 0.025f;

		// Token: 0x04001908 RID: 6408
		[Range(0f, 1f)]
		public float sunFlaresGhosts3Offset = 0.31f;

		// Token: 0x04001909 RID: 6409
		[Range(0f, 1f)]
		public float sunFlaresGhosts4Size = 0.016f;

		// Token: 0x0400190A RID: 6410
		[Range(-3f, 3f)]
		public float sunFlaresGhosts4Offset;

		// Token: 0x0400190B RID: 6411
		[Range(0f, 1f)]
		public float sunFlaresGhosts4Brightness = 0.017f;

		// Token: 0x0400190C RID: 6412
		[Range(0f, 1f)]
		public float sunFlaresHaloOffset = 0.22f;

		// Token: 0x0400190D RID: 6413
		[Range(0f, 50f)]
		public float sunFlaresHaloAmplitude = 15.1415f;

		// Token: 0x0400190E RID: 6414
		[Range(0f, 1f)]
		public float sunFlaresHaloIntensity = 0.01f;

		// Token: 0x0400190F RID: 6415
		public bool sunFlaresRotationDeadZone;

		// Token: 0x04001910 RID: 6416
		public bool blur;

		// Token: 0x04001911 RID: 6417
		[Range(0f, 4f)]
		public float blurIntensity = 1f;

		// Token: 0x04001912 RID: 6418
		public int pixelateAmount = 1;

		// Token: 0x04001913 RID: 6419
		public bool pixelateDownscale;
	}
}
