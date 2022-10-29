using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace PlasmaAPI.GameClass.BeautifyEffect
{
	// Token: 0x020002C9 RID: 713
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Beautify")]
	[HelpURL("https://kronnect.com/support")]
	[ImageEffectAllowedInSceneView]
	public class Beautify : MonoBehaviour
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0008E0ED File Offset: 0x0008C2ED
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x0008E0F5 File Offset: 0x0008C2F5
		public BEAUTIFY_PRESET preset
		{
			get
			{
				return this._preset;
			}
			set
			{
				if (this._preset != value)
				{
					this._preset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0008E10D File Offset: 0x0008C30D
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x0008E115 File Offset: 0x0008C315
		public BEAUTIFY_QUALITY quality
		{
			get
			{
				return this._quality;
			}
			set
			{
				if (this._quality != value)
				{
					this._quality = value;
					this.UpdateQualitySettings();
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0008E133 File Offset: 0x0008C333
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x0008E13B File Offset: 0x0008C33B
		public BeautifyProfile profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				if (this._profile != value)
				{
					this._profile = value;
					if (this._profile != null)
					{
						this._profile.Load(this);
						this._preset = BEAUTIFY_PRESET.Custom;
					}
				}
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0008E177 File Offset: 0x0008C377
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0008E17F File Offset: 0x0008C37F
		public bool syncWithProfile
		{
			get
			{
				return this._syncWithProfile;
			}
			set
			{
				this._syncWithProfile = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0008E188 File Offset: 0x0008C388
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0008E190 File Offset: 0x0008C390
		public bool compareMode
		{
			get
			{
				return this._compareMode;
			}
			set
			{
				if (this._compareMode != value)
				{
					this._compareMode = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0008E1A8 File Offset: 0x0008C3A8
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0008E1B0 File Offset: 0x0008C3B0
		public float compareLineAngle
		{
			get
			{
				return this._compareLineAngle;
			}
			set
			{
				if (this._compareLineAngle != value)
				{
					this._compareLineAngle = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x0008E1C8 File Offset: 0x0008C3C8
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0008E1D0 File Offset: 0x0008C3D0
		public float compareLineWidth
		{
			get
			{
				return this._compareLineWidth;
			}
			set
			{
				if (this._compareLineWidth != value)
				{
					this._compareLineWidth = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0008E1E8 File Offset: 0x0008C3E8
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0008E1F0 File Offset: 0x0008C3F0
		public float dither
		{
			get
			{
				return this._dither;
			}
			set
			{
				if (this._dither != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._dither = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0008E213 File Offset: 0x0008C413
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0008E21B File Offset: 0x0008C41B
		public float ditherDepth
		{
			get
			{
				return this._ditherDepth;
			}
			set
			{
				if (this._ditherDepth != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._ditherDepth = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0008E23E File Offset: 0x0008C43E
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0008E246 File Offset: 0x0008C446
		public float sharpenMinDepth
		{
			get
			{
				return this._sharpenMinDepth;
			}
			set
			{
				if (this._sharpenMinDepth != value)
				{
					this._sharpenMinDepth = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0008E25E File Offset: 0x0008C45E
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0008E266 File Offset: 0x0008C466
		public float sharpenMaxDepth
		{
			get
			{
				return this._sharpenMaxDepth;
			}
			set
			{
				if (this._sharpenMaxDepth != value)
				{
					this._sharpenMaxDepth = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0008E27E File Offset: 0x0008C47E
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0008E286 File Offset: 0x0008C486
		public float sharpenMinMaxDepthFallOff
		{
			get
			{
				return this._sharpenMinMaxDepthFallOff;
			}
			set
			{
				if (this._sharpenMinMaxDepthFallOff != value)
				{
					this._sharpenMinMaxDepthFallOff = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0008E29E File Offset: 0x0008C49E
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0008E2A6 File Offset: 0x0008C4A6
		public float sharpen
		{
			get
			{
				return this._sharpen;
			}
			set
			{
				if (this._sharpen != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._sharpen = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0008E2C9 File Offset: 0x0008C4C9
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0008E2D1 File Offset: 0x0008C4D1
		public float sharpenDepthThreshold
		{
			get
			{
				return this._sharpenDepthThreshold;
			}
			set
			{
				if (this._sharpenDepthThreshold != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._sharpenDepthThreshold = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0008E2F4 File Offset: 0x0008C4F4
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0008E2FC File Offset: 0x0008C4FC
		public Color tintColor
		{
			get
			{
				return this._tintColor;
			}
			set
			{
				if (this._tintColor != value)
				{
					this._tintColor = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0008E319 File Offset: 0x0008C519
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0008E321 File Offset: 0x0008C521
		public float sharpenRelaxation
		{
			get
			{
				return this._sharpenRelaxation;
			}
			set
			{
				if (this._sharpenRelaxation != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._sharpenRelaxation = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0008E344 File Offset: 0x0008C544
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0008E34C File Offset: 0x0008C54C
		public float sharpenClamp
		{
			get
			{
				return this._sharpenClamp;
			}
			set
			{
				if (this._sharpenClamp != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._sharpenClamp = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0008E36F File Offset: 0x0008C56F
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0008E377 File Offset: 0x0008C577
		public float sharpenMotionSensibility
		{
			get
			{
				return this._sharpenMotionSensibility;
			}
			set
			{
				if (this._sharpenMotionSensibility != value)
				{
					this._sharpenMotionSensibility = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0008E38F File Offset: 0x0008C58F
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0008E397 File Offset: 0x0008C597
		public float saturate
		{
			get
			{
				return this._saturate;
			}
			set
			{
				if (this._saturate != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._saturate = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0008E3BA File Offset: 0x0008C5BA
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0008E3C2 File Offset: 0x0008C5C2
		public float contrast
		{
			get
			{
				return this._contrast;
			}
			set
			{
				if (this._contrast != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._contrast = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0008E3E5 File Offset: 0x0008C5E5
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x0008E3ED File Offset: 0x0008C5ED
		public float brightness
		{
			get
			{
				return this._brightness;
			}
			set
			{
				if (this._brightness != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._brightness = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0008E410 File Offset: 0x0008C610
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0008E418 File Offset: 0x0008C618
		public float daltonize
		{
			get
			{
				return this._daltonize;
			}
			set
			{
				if (this._daltonize != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._daltonize = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0008E43B File Offset: 0x0008C63B
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x0008E443 File Offset: 0x0008C643
		public float hardLightIntensity
		{
			get
			{
				return this._hardLightIntensity;
			}
			set
			{
				if (this._hardLightIntensity != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._hardLightIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0008E466 File Offset: 0x0008C666
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x0008E46E File Offset: 0x0008C66E
		public float hardLightBlend
		{
			get
			{
				return this._hardLightBlend;
			}
			set
			{
				if (this._hardLightBlend != value)
				{
					this._preset = BEAUTIFY_PRESET.Custom;
					this._hardLightBlend = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0008E491 File Offset: 0x0008C691
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0008E499 File Offset: 0x0008C699
		public bool vignetting
		{
			get
			{
				return this._vignetting;
			}
			set
			{
				if (this._vignetting != value)
				{
					this._vignetting = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0008E4B1 File Offset: 0x0008C6B1
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0008E4B9 File Offset: 0x0008C6B9
		public Color vignettingColor
		{
			get
			{
				return this._vignettingColor;
			}
			set
			{
				if (this._vignettingColor != value)
				{
					this._vignettingColor = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0008E4D6 File Offset: 0x0008C6D6
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0008E4DE File Offset: 0x0008C6DE
		public float vignettingFade
		{
			get
			{
				return this._vignettingFade;
			}
			set
			{
				if (this._vignettingFade != value)
				{
					this._vignettingFade = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0008E4F6 File Offset: 0x0008C6F6
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0008E4FE File Offset: 0x0008C6FE
		public bool vignettingCircularShape
		{
			get
			{
				return this._vignettingCircularShape;
			}
			set
			{
				if (this._vignettingCircularShape != value)
				{
					this._vignettingCircularShape = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0008E516 File Offset: 0x0008C716
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0008E51E File Offset: 0x0008C71E
		public float vignettingAspectRatio
		{
			get
			{
				return this._vignettingAspectRatio;
			}
			set
			{
				if (this._vignettingAspectRatio != value)
				{
					this._vignettingAspectRatio = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0008E536 File Offset: 0x0008C736
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0008E53E File Offset: 0x0008C73E
		public float vignettingBlink
		{
			get
			{
				return this._vignettingBlink;
			}
			set
			{
				if (this._vignettingBlink != value)
				{
					this._vignettingBlink = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0008E556 File Offset: 0x0008C756
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0008E55E File Offset: 0x0008C75E
		public BEAUTIFY_BLINK_STYLE vignettingBlinkStyle
		{
			get
			{
				return this._vignettingBlinkStyle;
			}
			set
			{
				if (this._vignettingBlinkStyle != value)
				{
					this._vignettingBlinkStyle = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0008E576 File Offset: 0x0008C776
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0008E57E File Offset: 0x0008C77E
		public Vector2 vignettingCenter
		{
			get
			{
				return this._vignettingCenter;
			}
			set
			{
				if (this._vignettingCenter != value)
				{
					this._vignettingCenter = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0008E59B File Offset: 0x0008C79B
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0008E5A3 File Offset: 0x0008C7A3
		public Texture2D vignettingMask
		{
			get
			{
				return this._vignettingMask;
			}
			set
			{
				if (this._vignettingMask != value)
				{
					this._vignettingMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0008E5C0 File Offset: 0x0008C7C0
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0008E5C8 File Offset: 0x0008C7C8
		public bool frame
		{
			get
			{
				return this._frame;
			}
			set
			{
				if (this._frame != value)
				{
					this._frame = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0008E5E0 File Offset: 0x0008C7E0
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0008E5E8 File Offset: 0x0008C7E8
		public Color frameColor
		{
			get
			{
				return this._frameColor;
			}
			set
			{
				if (this._frameColor != value)
				{
					this._frameColor = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0008E605 File Offset: 0x0008C805
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0008E60D File Offset: 0x0008C80D
		public Texture2D frameMask
		{
			get
			{
				return this._frameMask;
			}
			set
			{
				if (this._frameMask != value)
				{
					this._frameMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x0008E62A File Offset: 0x0008C82A
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0008E632 File Offset: 0x0008C832
		public bool lut
		{
			get
			{
				return this._lut;
			}
			set
			{
				if (this._lut != value)
				{
					this._lut = value;
					if (this._lut)
					{
						this._nightVision = false;
						this._thermalVision = false;
					}
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0008E660 File Offset: 0x0008C860
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0008E668 File Offset: 0x0008C868
		public float lutIntensity
		{
			get
			{
				return this._lutIntensity;
			}
			set
			{
				if (this._lutIntensity != value)
				{
					this._lutIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0008E680 File Offset: 0x0008C880
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0008E688 File Offset: 0x0008C888
		public Texture2D lutTexture
		{
			get
			{
				return this._lutTexture;
			}
			set
			{
				if (this._lutTexture != value)
				{
					this._lutTexture = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0008E6A5 File Offset: 0x0008C8A5
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0008E6B0 File Offset: 0x0008C8B0
		public bool nightVision
		{
			get
			{
				return this._nightVision;
			}
			set
			{
				if (this._nightVision != value)
				{
					this._nightVision = value;
					if (this._nightVision)
					{
						this._thermalVision = false;
						this._lut = false;
						this._vignetting = true;
						this._vignettingFade = 0f;
						this._vignettingColor = new Color(0f, 0f, 0f, 0.1254902f);
						this._vignettingCircularShape = true;
					}
					else
					{
						this._vignetting = false;
					}
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0008E72A File Offset: 0x0008C92A
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0008E732 File Offset: 0x0008C932
		public Color nightVisionColor
		{
			get
			{
				return this._nightVisionColor;
			}
			set
			{
				if (this._nightVisionColor != value)
				{
					this._nightVisionColor = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0008E74F File Offset: 0x0008C94F
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0008E757 File Offset: 0x0008C957
		public bool outline
		{
			get
			{
				return this._outline;
			}
			set
			{
				if (this._outline != value)
				{
					this._outline = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0008E76F File Offset: 0x0008C96F
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0008E777 File Offset: 0x0008C977
		public Color outlineColor
		{
			get
			{
				return this._outlineColor;
			}
			set
			{
				if (this._outlineColor != value)
				{
					this._outlineColor = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0008E794 File Offset: 0x0008C994
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0008E79C File Offset: 0x0008C99C
		public bool outlineCustomize
		{
			get
			{
				return this._outlineCustomize;
			}
			set
			{
				if (this._outlineCustomize != value)
				{
					this._outlineCustomize = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x0008E7B4 File Offset: 0x0008C9B4
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0008E7BC File Offset: 0x0008C9BC
		public BEAUTIFY_OUTLINE_STAGE outlineStage
		{
			get
			{
				return this._outlineStage;
			}
			set
			{
				if (this._outlineStage != value)
				{
					this._outlineStage = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x0008E7D4 File Offset: 0x0008C9D4
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x0008E7DC File Offset: 0x0008C9DC
		public float outlineSpread
		{
			get
			{
				return this._outlineSpread;
			}
			set
			{
				if (this._outlineSpread != value)
				{
					this._outlineSpread = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x0008E7F4 File Offset: 0x0008C9F4
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0008E7FC File Offset: 0x0008C9FC
		public int outlineBlurPassCount
		{
			get
			{
				return this._outlineBlurPassCount;
			}
			set
			{
				if (this._outlineBlurPassCount != value)
				{
					this._outlineBlurPassCount = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0008E814 File Offset: 0x0008CA14
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0008E81C File Offset: 0x0008CA1C
		public float outlineIntensityMultiplier
		{
			get
			{
				return this._outlineIntensityMultiplier;
			}
			set
			{
				if (this._outlineIntensityMultiplier != value)
				{
					this._outlineIntensityMultiplier = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0008E834 File Offset: 0x0008CA34
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0008E83C File Offset: 0x0008CA3C
		public bool thermalVision
		{
			get
			{
				return this._thermalVision;
			}
			set
			{
				if (this._thermalVision != value)
				{
					this._thermalVision = value;
					if (this._thermalVision)
					{
						this._nightVision = false;
						this._lut = false;
						this._vignetting = true;
						this._vignettingFade = 0f;
						this._vignettingColor = new Color(1f, 0.0627451f, 0.0627451f, 0.07058824f);
						this._vignettingCircularShape = true;
					}
					else
					{
						this._vignetting = false;
					}
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0008E8B6 File Offset: 0x0008CAB6
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0008E8BE File Offset: 0x0008CABE
		public bool lensDirt
		{
			get
			{
				return this._lensDirt;
			}
			set
			{
				if (this._lensDirt != value)
				{
					this._lensDirt = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0008E8D6 File Offset: 0x0008CAD6
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0008E8DE File Offset: 0x0008CADE
		public float lensDirtThreshold
		{
			get
			{
				return this._lensDirtThreshold;
			}
			set
			{
				if (this._lensDirtThreshold != value)
				{
					this._lensDirtThreshold = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x0008E8F6 File Offset: 0x0008CAF6
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0008E8FE File Offset: 0x0008CAFE
		public float lensDirtIntensity
		{
			get
			{
				return this._lensDirtIntensity;
			}
			set
			{
				if (this._lensDirtIntensity != value)
				{
					this._lensDirtIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0008E916 File Offset: 0x0008CB16
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0008E91E File Offset: 0x0008CB1E
		public Texture2D lensDirtTexture
		{
			get
			{
				return this._lensDirtTexture;
			}
			set
			{
				if (this._lensDirtTexture != value)
				{
					this._lensDirtTexture = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0008E93B File Offset: 0x0008CB3B
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0008E943 File Offset: 0x0008CB43
		public bool bloom
		{
			get
			{
				return this._bloom;
			}
			set
			{
				if (this._bloom != value)
				{
					this._bloom = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0008E95B File Offset: 0x0008CB5B
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0008E963 File Offset: 0x0008CB63
		public LayerMask bloomCullingMask
		{
			get
			{
				return this._bloomCullingMask;
			}
			set
			{
				if (this._bloomCullingMask != value)
				{
					this._bloomCullingMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0008E985 File Offset: 0x0008CB85
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0008E98D File Offset: 0x0008CB8D
		public float bloomLayerMaskDownsampling
		{
			get
			{
				return this._bloomLayerMaskDownsampling;
			}
			set
			{
				if (this._bloomLayerMaskDownsampling != value)
				{
					this._bloomLayerMaskDownsampling = Mathf.Max(value, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0008E9AF File Offset: 0x0008CBAF
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0008E9B7 File Offset: 0x0008CBB7
		public float bloomIntensity
		{
			get
			{
				return this._bloomIntensity;
			}
			set
			{
				if (this._bloomIntensity != value)
				{
					this._bloomIntensity = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0008E9DC File Offset: 0x0008CBDC
		public float bloomMaxBrightness
		{
			get
			{
				return this._bloomMaxBrightness;
			}
			set
			{
				if (this._bloomMaxBrightness != value)
				{
					this._bloomMaxBrightness = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0008E9F9 File Offset: 0x0008CBF9
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0008EA01 File Offset: 0x0008CC01
		public float bloomBoost0
		{
			get
			{
				return this._bloomBoost0;
			}
			set
			{
				if (this._bloomBoost0 != value)
				{
					this._bloomBoost0 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0008EA19 File Offset: 0x0008CC19
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0008EA21 File Offset: 0x0008CC21
		public float bloomBoost1
		{
			get
			{
				return this._bloomBoost1;
			}
			set
			{
				if (this._bloomBoost1 != value)
				{
					this._bloomBoost1 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0008EA39 File Offset: 0x0008CC39
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x0008EA41 File Offset: 0x0008CC41
		public float bloomBoost2
		{
			get
			{
				return this._bloomBoost2;
			}
			set
			{
				if (this._bloomBoost2 != value)
				{
					this._bloomBoost2 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x0008EA59 File Offset: 0x0008CC59
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x0008EA61 File Offset: 0x0008CC61
		public float bloomBoost3
		{
			get
			{
				return this._bloomBoost3;
			}
			set
			{
				if (this._bloomBoost3 != value)
				{
					this._bloomBoost3 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0008EA79 File Offset: 0x0008CC79
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0008EA81 File Offset: 0x0008CC81
		public float bloomBoost4
		{
			get
			{
				return this._bloomBoost4;
			}
			set
			{
				if (this._bloomBoost4 != value)
				{
					this._bloomBoost4 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0008EA99 File Offset: 0x0008CC99
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x0008EAA1 File Offset: 0x0008CCA1
		public float bloomBoost5
		{
			get
			{
				return this._bloomBoost5;
			}
			set
			{
				if (this._bloomBoost5 != value)
				{
					this._bloomBoost5 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0008EAB9 File Offset: 0x0008CCB9
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x0008EAC1 File Offset: 0x0008CCC1
		public bool bloomAntiflicker
		{
			get
			{
				return this._bloomAntiflicker;
			}
			set
			{
				if (this._bloomAntiflicker != value)
				{
					this._bloomAntiflicker = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0008EAD9 File Offset: 0x0008CCD9
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x0008EAE1 File Offset: 0x0008CCE1
		public bool bloomUltra
		{
			get
			{
				return this._bloomUltra;
			}
			set
			{
				if (this._bloomUltra != value)
				{
					this._bloomUltra = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0008EAF9 File Offset: 0x0008CCF9
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0008EB01 File Offset: 0x0008CD01
		public int bloomUltraResolution
		{
			get
			{
				return this._bloomUltraResolution;
			}
			set
			{
				if (this._bloomUltraResolution != value)
				{
					this._bloomUltraResolution = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0008EB19 File Offset: 0x0008CD19
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x0008EB21 File Offset: 0x0008CD21
		public float bloomThreshold
		{
			get
			{
				return this._bloomThreshold;
			}
			set
			{
				if (this._bloomThreshold != value)
				{
					this._bloomThreshold = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0008EB39 File Offset: 0x0008CD39
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x0008EB41 File Offset: 0x0008CD41
		public Color bloomTint
		{
			get
			{
				return this._bloomTint;
			}
			set
			{
				if (this._bloomTint != value)
				{
					this._bloomTint = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x0008EB5E File Offset: 0x0008CD5E
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x0008EB66 File Offset: 0x0008CD66
		public bool bloomCustomize
		{
			get
			{
				return this._bloomCustomize;
			}
			set
			{
				if (this._bloomCustomize != value)
				{
					this._bloomCustomize = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0008EB7E File Offset: 0x0008CD7E
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x0008EB86 File Offset: 0x0008CD86
		public bool bloomDebug
		{
			get
			{
				return this._bloomDebug;
			}
			set
			{
				if (this._bloomDebug != value)
				{
					this._bloomDebug = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0008EB9E File Offset: 0x0008CD9E
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0008EBA6 File Offset: 0x0008CDA6
		public float bloomWeight0
		{
			get
			{
				return this._bloomWeight0;
			}
			set
			{
				if (this._bloomWeight0 != value)
				{
					this._bloomWeight0 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0008EBBE File Offset: 0x0008CDBE
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x0008EBC6 File Offset: 0x0008CDC6
		public float bloomWeight1
		{
			get
			{
				return this._bloomWeight1;
			}
			set
			{
				if (this._bloomWeight1 != value)
				{
					this._bloomWeight1 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0008EBDE File Offset: 0x0008CDDE
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x0008EBE6 File Offset: 0x0008CDE6
		public float bloomWeight2
		{
			get
			{
				return this._bloomWeight2;
			}
			set
			{
				if (this._bloomWeight2 != value)
				{
					this._bloomWeight2 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0008EBFE File Offset: 0x0008CDFE
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x0008EC06 File Offset: 0x0008CE06
		public float bloomWeight3
		{
			get
			{
				return this._bloomWeight3;
			}
			set
			{
				if (this._bloomWeight3 != value)
				{
					this._bloomWeight3 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0008EC1E File Offset: 0x0008CE1E
		// (set) Token: 0x06001D29 RID: 7465 RVA: 0x0008EC26 File Offset: 0x0008CE26
		public float bloomWeight4
		{
			get
			{
				return this._bloomWeight4;
			}
			set
			{
				if (this._bloomWeight4 != value)
				{
					this._bloomWeight4 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0008EC3E File Offset: 0x0008CE3E
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0008EC46 File Offset: 0x0008CE46
		public float bloomWeight5
		{
			get
			{
				return this._bloomWeight5;
			}
			set
			{
				if (this._bloomWeight5 != value)
				{
					this._bloomWeight5 = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0008EC5E File Offset: 0x0008CE5E
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0008EC66 File Offset: 0x0008CE66
		public bool bloomBlur
		{
			get
			{
				return this._bloomBlur;
			}
			set
			{
				if (this._bloomBlur != value)
				{
					this._bloomBlur = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0008EC7E File Offset: 0x0008CE7E
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0008EC86 File Offset: 0x0008CE86
		public bool bloomQuickerBlur
		{
			get
			{
				return this._bloomQuickerBlur;
			}
			set
			{
				if (this._bloomQuickerBlur != value)
				{
					this._bloomQuickerBlur = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0008EC9E File Offset: 0x0008CE9E
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x0008ECA6 File Offset: 0x0008CEA6
		public float bloomDepthAtten
		{
			get
			{
				return this._bloomDepthAtten;
			}
			set
			{
				if (this._bloomDepthAtten != value)
				{
					this._bloomDepthAtten = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0008ECBE File Offset: 0x0008CEBE
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x0008ECC6 File Offset: 0x0008CEC6
		public float bloomNearAtten
		{
			get
			{
				return this._bloomNearAtten;
			}
			set
			{
				if (this._bloomNearAtten != value)
				{
					this._bloomNearAtten = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x0008ECDE File Offset: 0x0008CEDE
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x0008ECE6 File Offset: 0x0008CEE6
		public float bloomLayerZBias
		{
			get
			{
				return this._bloomLayerZBias;
			}
			set
			{
				if (this._bloomLayerZBias != value)
				{
					this._bloomLayerZBias = Mathf.Clamp(value, -1f, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0008ED0D File Offset: 0x0008CF0D
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x0008ED15 File Offset: 0x0008CF15
		public BEAUTIFY_PRERENDER_EVENT preRenderCameraEvent
		{
			get
			{
				return this._preRenderCameraEvent;
			}
			set
			{
				if (this._preRenderCameraEvent != value)
				{
					this._preRenderCameraEvent = value;
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0008ED27 File Offset: 0x0008CF27
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x0008ED2F File Offset: 0x0008CF2F
		public bool anamorphicFlares
		{
			get
			{
				return this._anamorphicFlares;
			}
			set
			{
				if (this._anamorphicFlares != value)
				{
					this._anamorphicFlares = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0008ED47 File Offset: 0x0008CF47
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x0008ED4F File Offset: 0x0008CF4F
		public LayerMask anamorphicFlaresCullingMask
		{
			get
			{
				return this._anamorphicFlaresCullingMask;
			}
			set
			{
				if (this._anamorphicFlaresCullingMask != value)
				{
					this._anamorphicFlaresCullingMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x0008ED71 File Offset: 0x0008CF71
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x0008ED79 File Offset: 0x0008CF79
		public float anamorphicFlaresIntensity
		{
			get
			{
				return this._anamorphicFlaresIntensity;
			}
			set
			{
				if (this._anamorphicFlaresIntensity != value)
				{
					this._anamorphicFlaresIntensity = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x0008ED96 File Offset: 0x0008CF96
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0008ED9E File Offset: 0x0008CF9E
		public bool anamorphicFlaresAntiflicker
		{
			get
			{
				return this._anamorphicFlaresAntiflicker;
			}
			set
			{
				if (this._anamorphicFlaresAntiflicker != value)
				{
					this._anamorphicFlaresAntiflicker = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0008EDB6 File Offset: 0x0008CFB6
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0008EDBE File Offset: 0x0008CFBE
		public bool anamorphicFlaresUltra
		{
			get
			{
				return this._anamorphicFlaresUltra;
			}
			set
			{
				if (this._anamorphicFlaresUltra != value)
				{
					this._anamorphicFlaresUltra = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0008EDD6 File Offset: 0x0008CFD6
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0008EDDE File Offset: 0x0008CFDE
		public int anamorphicFlaresUltraResolution
		{
			get
			{
				return this._anamorphicFlaresUltraResolution;
			}
			set
			{
				if (this._anamorphicFlaresUltraResolution != value)
				{
					this._anamorphicFlaresUltraResolution = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0008EDF6 File Offset: 0x0008CFF6
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0008EDFE File Offset: 0x0008CFFE
		public float anamorphicFlaresThreshold
		{
			get
			{
				return this._anamorphicFlaresThreshold;
			}
			set
			{
				if (this._anamorphicFlaresThreshold != value)
				{
					this._anamorphicFlaresThreshold = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x0008EE16 File Offset: 0x0008D016
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0008EE1E File Offset: 0x0008D01E
		public float anamorphicFlaresSpread
		{
			get
			{
				return this._anamorphicFlaresSpread;
			}
			set
			{
				if (this._anamorphicFlaresSpread != value)
				{
					this._anamorphicFlaresSpread = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x0008EE36 File Offset: 0x0008D036
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x0008EE3E File Offset: 0x0008D03E
		public bool anamorphicFlaresVertical
		{
			get
			{
				return this._anamorphicFlaresVertical;
			}
			set
			{
				if (this._anamorphicFlaresVertical != value)
				{
					this._anamorphicFlaresVertical = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x0008EE56 File Offset: 0x0008D056
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x0008EE5E File Offset: 0x0008D05E
		public Color anamorphicFlaresTint
		{
			get
			{
				return this._anamorphicFlaresTint;
			}
			set
			{
				if (this._anamorphicFlaresTint != value)
				{
					this._anamorphicFlaresTint = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0008EE7B File Offset: 0x0008D07B
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0008EE83 File Offset: 0x0008D083
		public bool anamorphicFlaresBlur
		{
			get
			{
				return this._anamorphicFlaresBlur;
			}
			set
			{
				if (this._anamorphicFlaresBlur != value)
				{
					this._anamorphicFlaresBlur = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0008EE9B File Offset: 0x0008D09B
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0008EEA3 File Offset: 0x0008D0A3
		public bool depthOfField
		{
			get
			{
				return this._depthOfField;
			}
			set
			{
				if (this._depthOfField != value)
				{
					this._depthOfField = value;
					this.dofPrevDistance = -1f;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0008EEC6 File Offset: 0x0008D0C6
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0008EECE File Offset: 0x0008D0CE
		public bool depthOfFieldTransparencySupport
		{
			get
			{
				return this._depthOfFieldTransparencySupport;
			}
			set
			{
				if (this._depthOfFieldTransparencySupport != value)
				{
					this._depthOfFieldTransparencySupport = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0008EEE6 File Offset: 0x0008D0E6
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0008EEEE File Offset: 0x0008D0EE
		public LayerMask depthOfFieldTransparencyLayerMask
		{
			get
			{
				return this._depthOfFieldTransparencyLayerMask;
			}
			set
			{
				if (this._depthOfFieldTransparencyLayerMask != value)
				{
					this._depthOfFieldTransparencyLayerMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0008EF10 File Offset: 0x0008D110
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0008EF18 File Offset: 0x0008D118
		public Transform depthOfFieldTargetFocus
		{
			get
			{
				return this._depthOfFieldTargetFocus;
			}
			set
			{
				if (this._depthOfFieldTargetFocus != value)
				{
					this._depthOfFieldTargetFocus = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0008EF35 File Offset: 0x0008D135
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0008EF3D File Offset: 0x0008D13D
		public bool depthOfFieldDebug
		{
			get
			{
				return this._depthOfFieldDebug;
			}
			set
			{
				if (this._depthOfFieldDebug != value)
				{
					this._depthOfFieldDebug = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0008EF55 File Offset: 0x0008D155
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0008EF5D File Offset: 0x0008D15D
		public bool depthOfFieldAutofocus
		{
			get
			{
				return this._depthOfFieldAutofocus;
			}
			set
			{
				if (this._depthOfFieldAutofocus != value)
				{
					this._depthOfFieldAutofocus = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0008EF75 File Offset: 0x0008D175
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0008EF7D File Offset: 0x0008D17D
		public Vector2 depthofFieldAutofocusViewportPoint
		{
			get
			{
				return this._depthofFieldAutofocusViewportPoint;
			}
			set
			{
				if (this._depthofFieldAutofocusViewportPoint != value)
				{
					this._depthofFieldAutofocusViewportPoint = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0008EF9A File Offset: 0x0008D19A
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0008EFA2 File Offset: 0x0008D1A2
		public float depthOfFieldAutofocusMinDistance
		{
			get
			{
				return this._depthOfFieldAutofocusMinDistance;
			}
			set
			{
				if (this._depthOfFieldAutofocusMinDistance != value)
				{
					this._depthOfFieldAutofocusMinDistance = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0008EFBA File Offset: 0x0008D1BA
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0008EFC2 File Offset: 0x0008D1C2
		public float depthOfFieldAutofocusDistanceShift
		{
			get
			{
				return this._depthOfFieldAutofocusDistanceShift;
			}
			set
			{
				if (this._depthOfFieldAutofocusDistanceShift != value)
				{
					this._depthOfFieldAutofocusDistanceShift = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0008EFDA File Offset: 0x0008D1DA
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0008EFE2 File Offset: 0x0008D1E2
		public float depthOfFieldAutofocusMaxDistance
		{
			get
			{
				return this._depthOfFieldAutofocusMaxDistance;
			}
			set
			{
				if (this._depthOfFieldAutofocusMaxDistance != value)
				{
					this._depthOfFieldAutofocusMaxDistance = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0008EFFA File Offset: 0x0008D1FA
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0008F002 File Offset: 0x0008D202
		public LayerMask depthOfFieldAutofocusLayerMask
		{
			get
			{
				return this._depthOfFieldAutofocusLayerMask;
			}
			set
			{
				if (this._depthOfFieldAutofocusLayerMask != value)
				{
					this._depthOfFieldAutofocusLayerMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0008F024 File Offset: 0x0008D224
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0008F02C File Offset: 0x0008D22C
		public LayerMask depthOfFieldExclusionLayerMask
		{
			get
			{
				return this._depthOfFieldExclusionLayerMask;
			}
			set
			{
				if (this._depthOfFieldExclusionLayerMask != value)
				{
					this._depthOfFieldExclusionLayerMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0008F04E File Offset: 0x0008D24E
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0008F056 File Offset: 0x0008D256
		public float depthOfFieldExclusionLayerMaskDownsampling
		{
			get
			{
				return this._depthOfFieldExclusionLayerMaskDownsampling;
			}
			set
			{
				if (this._depthOfFieldExclusionLayerMaskDownsampling != value)
				{
					this._depthOfFieldExclusionLayerMaskDownsampling = Mathf.Max(value, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0008F078 File Offset: 0x0008D278
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0008F080 File Offset: 0x0008D280
		public float depthOfFieldTransparencySupportDownsampling
		{
			get
			{
				return this._depthOfFieldTransparencySupportDownsampling;
			}
			set
			{
				if (this._depthOfFieldTransparencySupportDownsampling != value)
				{
					this._depthOfFieldTransparencySupportDownsampling = Mathf.Max(value, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0008F0A2 File Offset: 0x0008D2A2
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0008F0AA File Offset: 0x0008D2AA
		public float depthOfFieldExclusionBias
		{
			get
			{
				return this._depthOfFieldExclusionBias;
			}
			set
			{
				if (this._depthOfFieldExclusionBias != value)
				{
					this._depthOfFieldExclusionBias = Mathf.Clamp01(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0008F0C7 File Offset: 0x0008D2C7
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0008F0CF File Offset: 0x0008D2CF
		public float depthOfFieldDistance
		{
			get
			{
				return this._depthOfFieldDistance;
			}
			set
			{
				if (this._depthOfFieldDistance != value)
				{
					this._depthOfFieldDistance = Mathf.Max(value, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0008F0F1 File Offset: 0x0008D2F1
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0008F0F9 File Offset: 0x0008D2F9
		public float depthOfFieldFocusSpeed
		{
			get
			{
				return this._depthOfFieldFocusSpeed;
			}
			set
			{
				if (this._depthOfFieldFocusSpeed != value)
				{
					this._depthOfFieldFocusSpeed = Mathf.Clamp(value, 0.001f, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0008F120 File Offset: 0x0008D320
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0008F128 File Offset: 0x0008D328
		public int depthOfFieldDownsampling
		{
			get
			{
				return this._depthOfFieldDownsampling;
			}
			set
			{
				if (this._depthOfFieldDownsampling != value)
				{
					this._depthOfFieldDownsampling = Mathf.Max(value, 1);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0008F146 File Offset: 0x0008D346
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0008F14E File Offset: 0x0008D34E
		public int depthOfFieldMaxSamples
		{
			get
			{
				return this._depthOfFieldMaxSamples;
			}
			set
			{
				if (this._depthOfFieldMaxSamples != value)
				{
					this._depthOfFieldMaxSamples = Mathf.Max(value, 2);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0008F16C File Offset: 0x0008D36C
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x0008F174 File Offset: 0x0008D374
		public BEAUTIFY_DOF_CAMERA_SETTINGS depthOfFieldCameraSettings
		{
			get
			{
				return this._depthOfFieldCameraSettings;
			}
			set
			{
				if (this._depthOfFieldCameraSettings != value)
				{
					this._depthOfFieldCameraSettings = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0008F18C File Offset: 0x0008D38C
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0008F194 File Offset: 0x0008D394
		public float depthOfFieldFocalLengthReal
		{
			get
			{
				return this._depthOfFieldFocalLengthReal;
			}
			set
			{
				if (this._depthOfFieldFocalLengthReal != value)
				{
					this._depthOfFieldFocalLengthReal = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0008F1B1 File Offset: 0x0008D3B1
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0008F1B9 File Offset: 0x0008D3B9
		public float depthOfFieldFStop
		{
			get
			{
				return this._depthOfFieldFStop;
			}
			set
			{
				if (this._depthOfFieldFStop != value)
				{
					this._depthOfFieldFStop = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0008F1D6 File Offset: 0x0008D3D6
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0008F1DE File Offset: 0x0008D3DE
		public float depthOfFieldImageSensorHeight
		{
			get
			{
				return this._depthOfFieldImageSensorHeight;
			}
			set
			{
				if (this._depthOfFieldImageSensorHeight != value)
				{
					this._depthOfFieldImageSensorHeight = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x0008F1FB File Offset: 0x0008D3FB
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0008F203 File Offset: 0x0008D403
		public float depthOfFieldFocalLength
		{
			get
			{
				return this._depthOfFieldFocalLength;
			}
			set
			{
				if (this._depthOfFieldFocalLength != value)
				{
					this._depthOfFieldFocalLength = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0008F220 File Offset: 0x0008D420
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x0008F228 File Offset: 0x0008D428
		public float depthOfFieldAperture
		{
			get
			{
				return this._depthOfFieldAperture;
			}
			set
			{
				if (this._depthOfFieldAperture != value)
				{
					this._depthOfFieldAperture = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0008F245 File Offset: 0x0008D445
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0008F24D File Offset: 0x0008D44D
		public bool depthOfFieldForegroundBlur
		{
			get
			{
				return this._depthOfFieldForegroundBlur;
			}
			set
			{
				if (this._depthOfFieldForegroundBlur != value)
				{
					this._depthOfFieldForegroundBlur = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0008F265 File Offset: 0x0008D465
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0008F26D File Offset: 0x0008D46D
		public bool depthOfFieldForegroundBlurHQ
		{
			get
			{
				return this._depthOfFieldForegroundBlurHQ;
			}
			set
			{
				if (this._depthOfFieldForegroundBlurHQ != value)
				{
					this._depthOfFieldForegroundBlurHQ = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0008F285 File Offset: 0x0008D485
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0008F28D File Offset: 0x0008D48D
		public float depthOfFieldForegroundBlurHQSpread
		{
			get
			{
				return this._depthOfFieldForegroundBlurHQSpread;
			}
			set
			{
				if (this._depthOfFieldForegroundBlurHQSpread != value)
				{
					this._depthOfFieldForegroundBlurHQSpread = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0008F2A5 File Offset: 0x0008D4A5
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0008F2AD File Offset: 0x0008D4AD
		public float depthOfFieldForegroundDistance
		{
			get
			{
				return this._depthOfFieldForegroundDistance;
			}
			set
			{
				if (this._depthOfFieldForegroundDistance != value)
				{
					this._depthOfFieldForegroundDistance = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0008F2C5 File Offset: 0x0008D4C5
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0008F2CD File Offset: 0x0008D4CD
		public bool depthOfFieldBokeh
		{
			get
			{
				return this._depthOfFieldBokeh;
			}
			set
			{
				if (this._depthOfFieldBokeh != value)
				{
					this._depthOfFieldBokeh = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0008F2E5 File Offset: 0x0008D4E5
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0008F2ED File Offset: 0x0008D4ED
		public BEAUTIFY_BOKEH_COMPOSITION depthOfFieldBokehComposition
		{
			get
			{
				return this._depthOfFieldBokehComposition;
			}
			set
			{
				if (this._depthOfFieldBokehComposition != value)
				{
					this._depthOfFieldBokehComposition = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0008F305 File Offset: 0x0008D505
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0008F30D File Offset: 0x0008D50D
		public float depthOfFieldBokehThreshold
		{
			get
			{
				return this._depthOfFieldBokehThreshold;
			}
			set
			{
				if (this._depthOfFieldBokehThreshold != value)
				{
					this._depthOfFieldBokehThreshold = Mathf.Max(value, 0f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0008F32F File Offset: 0x0008D52F
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x0008F337 File Offset: 0x0008D537
		public float depthOfFieldBokehIntensity
		{
			get
			{
				return this._depthOfFieldBokehIntensity;
			}
			set
			{
				if (this._depthOfFieldBokehIntensity != value)
				{
					this._depthOfFieldBokehIntensity = Mathf.Max(value, 0f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x0008F359 File Offset: 0x0008D559
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0008F361 File Offset: 0x0008D561
		public float depthOfFieldMaxBrightness
		{
			get
			{
				return this._depthOfFieldMaxBrightness;
			}
			set
			{
				if (this._depthOfFieldMaxBrightness != value)
				{
					this._depthOfFieldMaxBrightness = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x0008F37E File Offset: 0x0008D57E
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0008F386 File Offset: 0x0008D586
		public float depthOfFieldMaxDistance
		{
			get
			{
				return this._depthOfFieldMaxDistance;
			}
			set
			{
				if (this._depthOfFieldMaxDistance != value)
				{
					this._depthOfFieldMaxDistance = Mathf.Abs(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0008F3A3 File Offset: 0x0008D5A3
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0008F3AB File Offset: 0x0008D5AB
		public FilterMode depthOfFieldFilterMode
		{
			get
			{
				return this._depthOfFieldFilterMode;
			}
			set
			{
				if (this._depthOfFieldFilterMode != value)
				{
					this._depthOfFieldFilterMode = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0008F3C3 File Offset: 0x0008D5C3
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0008F3CB File Offset: 0x0008D5CB
		public bool eyeAdaptation
		{
			get
			{
				return this._eyeAdaptation;
			}
			set
			{
				if (this._eyeAdaptation != value)
				{
					this._eyeAdaptation = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x0008F3E3 File Offset: 0x0008D5E3
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0008F3EB File Offset: 0x0008D5EB
		public float eyeAdaptationMinExposure
		{
			get
			{
				return this._eyeAdaptationMinExposure;
			}
			set
			{
				if (this._eyeAdaptationMinExposure != value)
				{
					this._eyeAdaptationMinExposure = Mathf.Clamp01(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0008F408 File Offset: 0x0008D608
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0008F410 File Offset: 0x0008D610
		public float eyeAdaptationMaxExposure
		{
			get
			{
				return this._eyeAdaptationMaxExposure;
			}
			set
			{
				if (this._eyeAdaptationMaxExposure != value)
				{
					this._eyeAdaptationMaxExposure = Mathf.Clamp(value, 1f, 100f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0008F437 File Offset: 0x0008D637
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0008F43F File Offset: 0x0008D63F
		public float eyeAdaptationSpeedToLight
		{
			get
			{
				return this._eyeAdaptationSpeedToLight;
			}
			set
			{
				if (this._eyeAdaptationSpeedToLight != value)
				{
					this._eyeAdaptationSpeedToLight = Mathf.Clamp01(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0008F45C File Offset: 0x0008D65C
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0008F464 File Offset: 0x0008D664
		public float eyeAdaptationSpeedToDark
		{
			get
			{
				return this._eyeAdaptationSpeedToDark;
			}
			set
			{
				if (this._eyeAdaptationSpeedToDark != value)
				{
					this._eyeAdaptationSpeedToDark = Mathf.Clamp01(value);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0008F481 File Offset: 0x0008D681
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0008F489 File Offset: 0x0008D689
		public bool eyeAdaptationInEditor
		{
			get
			{
				return this._eyeAdaptationInEditor;
			}
			set
			{
				if (this._eyeAdaptationInEditor != value)
				{
					this._eyeAdaptationInEditor = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0008F4A1 File Offset: 0x0008D6A1
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0008F4A9 File Offset: 0x0008D6A9
		public bool purkinje
		{
			get
			{
				return this._purkinje;
			}
			set
			{
				if (this._purkinje != value)
				{
					this._purkinje = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0008F4C1 File Offset: 0x0008D6C1
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0008F4C9 File Offset: 0x0008D6C9
		public float purkinjeAmount
		{
			get
			{
				return this._purkinjeAmount;
			}
			set
			{
				if (this._purkinjeAmount != value)
				{
					this._purkinjeAmount = Mathf.Clamp(value, 0f, 5f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
		public float purkinjeLuminanceThreshold
		{
			get
			{
				return this._purkinjeLuminanceThreshold;
			}
			set
			{
				if (this.purkinjeLuminanceThreshold != value)
				{
					this._purkinjeLuminanceThreshold = Mathf.Clamp(value, 0f, 1f);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0008F51F File Offset: 0x0008D71F
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0008F527 File Offset: 0x0008D727
		public BEAUTIFY_TMO tonemap
		{
			get
			{
				return this._tonemap;
			}
			set
			{
				if (this._tonemap != value)
				{
					this._tonemap = value;
					if (this._tonemap == BEAUTIFY_TMO.ACES)
					{
						this._saturate = 0f;
						this._contrast = 1f;
					}
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0008F55F File Offset: 0x0008D75F
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x0008F567 File Offset: 0x0008D767
		public bool sunFlares
		{
			get
			{
				return this._sunFlares;
			}
			set
			{
				if (this._sunFlares != value)
				{
					this._sunFlares = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0008F57F File Offset: 0x0008D77F
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0008F587 File Offset: 0x0008D787
		public Transform sun
		{
			get
			{
				return this._sun;
			}
			set
			{
				if (this._sun != value)
				{
					this._sun = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0008F5A4 File Offset: 0x0008D7A4
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x0008F5AC File Offset: 0x0008D7AC
		public LayerMask sunFlaresLayerMask
		{
			get
			{
				return this._sunFlaresLayerMask;
			}
			set
			{
				if (this._sunFlaresLayerMask != value)
				{
					this._sunFlaresLayerMask = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x0008F5CE File Offset: 0x0008D7CE
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x0008F5D6 File Offset: 0x0008D7D6
		public float sunFlaresIntensity
		{
			get
			{
				return this._sunFlaresIntensity;
			}
			set
			{
				if (this._sunFlaresIntensity != value)
				{
					this._sunFlaresIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0008F5EE File Offset: 0x0008D7EE
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0008F5F6 File Offset: 0x0008D7F6
		public float sunFlaresRevealSpeed
		{
			get
			{
				return this._sunFlaresRevealSpeed;
			}
			set
			{
				if (this._sunFlaresRevealSpeed != value)
				{
					this._sunFlaresRevealSpeed = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0008F60E File Offset: 0x0008D80E
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0008F616 File Offset: 0x0008D816
		public float sunFlaresHideSpeed
		{
			get
			{
				return this._sunFlaresHideSpeed;
			}
			set
			{
				if (this._sunFlaresHideSpeed != value)
				{
					this._sunFlaresHideSpeed = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0008F62E File Offset: 0x0008D82E
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x0008F636 File Offset: 0x0008D836
		public float sunFlaresSolarWindSpeed
		{
			get
			{
				return this._sunFlaresSolarWindSpeed;
			}
			set
			{
				if (this._sunFlaresSolarWindSpeed != value)
				{
					this._sunFlaresSolarWindSpeed = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x0008F64E File Offset: 0x0008D84E
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x0008F656 File Offset: 0x0008D856
		public Color sunFlaresTint
		{
			get
			{
				return this._sunFlaresTint;
			}
			set
			{
				if (this._sunFlaresTint != value)
				{
					this._sunFlaresTint = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x0008F673 File Offset: 0x0008D873
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x0008F67B File Offset: 0x0008D87B
		public int sunFlaresDownsampling
		{
			get
			{
				return this._sunFlaresDownsampling;
			}
			set
			{
				if (this._sunFlaresDownsampling != value)
				{
					this._sunFlaresDownsampling = Mathf.Max(value, 1);
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x0008F699 File Offset: 0x0008D899
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x0008F6A1 File Offset: 0x0008D8A1
		public float sunFlaresSunIntensity
		{
			get
			{
				return this._sunFlaresSunIntensity;
			}
			set
			{
				if (this._sunFlaresSunIntensity != value)
				{
					this._sunFlaresSunIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0008F6B9 File Offset: 0x0008D8B9
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0008F6C1 File Offset: 0x0008D8C1
		public float sunFlaresSunDiskSize
		{
			get
			{
				return this._sunFlaresSunDiskSize;
			}
			set
			{
				if (this._sunFlaresSunDiskSize != value)
				{
					this._sunFlaresSunDiskSize = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x0008F6D9 File Offset: 0x0008D8D9
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0008F6E1 File Offset: 0x0008D8E1
		public float sunFlaresSunRayDiffractionIntensity
		{
			get
			{
				return this._sunFlaresSunRayDiffractionIntensity;
			}
			set
			{
				if (this._sunFlaresSunRayDiffractionIntensity != value)
				{
					this._sunFlaresSunRayDiffractionIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0008F6F9 File Offset: 0x0008D8F9
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0008F701 File Offset: 0x0008D901
		public float sunFlaresSunRayDiffractionThreshold
		{
			get
			{
				return this._sunFlaresSunRayDiffractionThreshold;
			}
			set
			{
				if (this._sunFlaresSunRayDiffractionThreshold != value)
				{
					this._sunFlaresSunRayDiffractionThreshold = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0008F719 File Offset: 0x0008D919
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0008F721 File Offset: 0x0008D921
		public float sunFlaresCoronaRays1Length
		{
			get
			{
				return this._sunFlaresCoronaRays1Length;
			}
			set
			{
				if (this._sunFlaresCoronaRays1Length != value)
				{
					this._sunFlaresCoronaRays1Length = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0008F739 File Offset: 0x0008D939
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0008F741 File Offset: 0x0008D941
		public int sunFlaresCoronaRays1Streaks
		{
			get
			{
				return this._sunFlaresCoronaRays1Streaks;
			}
			set
			{
				if (this._sunFlaresCoronaRays1Streaks != value)
				{
					this._sunFlaresCoronaRays1Streaks = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0008F759 File Offset: 0x0008D959
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0008F761 File Offset: 0x0008D961
		public float sunFlaresCoronaRays1Spread
		{
			get
			{
				return this._sunFlaresCoronaRays1Spread;
			}
			set
			{
				if (this._sunFlaresCoronaRays1Spread != value)
				{
					this._sunFlaresCoronaRays1Spread = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x0008F779 File Offset: 0x0008D979
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0008F781 File Offset: 0x0008D981
		public float sunFlaresCoronaRays1AngleOffset
		{
			get
			{
				return this._sunFlaresCoronaRays1AngleOffset;
			}
			set
			{
				if (this._sunFlaresCoronaRays1AngleOffset != value)
				{
					this._sunFlaresCoronaRays1AngleOffset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x0008F799 File Offset: 0x0008D999
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0008F7A1 File Offset: 0x0008D9A1
		public float sunFlaresCoronaRays2Length
		{
			get
			{
				return this._sunFlaresCoronaRays2Length;
			}
			set
			{
				if (this._sunFlaresCoronaRays2Length != value)
				{
					this._sunFlaresCoronaRays2Length = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0008F7B9 File Offset: 0x0008D9B9
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0008F7C1 File Offset: 0x0008D9C1
		public int sunFlaresCoronaRays2Streaks
		{
			get
			{
				return this._sunFlaresCoronaRays2Streaks;
			}
			set
			{
				if (this._sunFlaresCoronaRays2Streaks != value)
				{
					this._sunFlaresCoronaRays2Streaks = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0008F7D9 File Offset: 0x0008D9D9
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0008F7E1 File Offset: 0x0008D9E1
		public float sunFlaresCoronaRays2Spread
		{
			get
			{
				return this._sunFlaresCoronaRays2Spread;
			}
			set
			{
				if (this._sunFlaresCoronaRays2Spread != value)
				{
					this._sunFlaresCoronaRays2Spread = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0008F7F9 File Offset: 0x0008D9F9
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0008F801 File Offset: 0x0008DA01
		public float sunFlaresCoronaRays2AngleOffset
		{
			get
			{
				return this._sunFlaresCoronaRays2AngleOffset;
			}
			set
			{
				if (this._sunFlaresCoronaRays2AngleOffset != value)
				{
					this._sunFlaresCoronaRays2AngleOffset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0008F819 File Offset: 0x0008DA19
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0008F821 File Offset: 0x0008DA21
		public float sunFlaresGhosts1Size
		{
			get
			{
				return this._sunFlaresGhosts1Size;
			}
			set
			{
				if (this._sunFlaresGhosts1Size != value)
				{
					this._sunFlaresGhosts1Size = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0008F839 File Offset: 0x0008DA39
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0008F841 File Offset: 0x0008DA41
		public float sunFlaresGhosts1Offset
		{
			get
			{
				return this._sunFlaresGhosts1Offset;
			}
			set
			{
				if (this._sunFlaresGhosts1Offset != value)
				{
					this._sunFlaresGhosts1Offset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0008F859 File Offset: 0x0008DA59
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0008F861 File Offset: 0x0008DA61
		public float sunFlaresGhosts1Brightness
		{
			get
			{
				return this._sunFlaresGhosts1Brightness;
			}
			set
			{
				if (this._sunFlaresGhosts1Brightness != value)
				{
					this._sunFlaresGhosts1Brightness = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0008F879 File Offset: 0x0008DA79
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0008F881 File Offset: 0x0008DA81
		public float sunFlaresGhosts2Size
		{
			get
			{
				return this._sunFlaresGhosts2Size;
			}
			set
			{
				if (this._sunFlaresGhosts2Size != value)
				{
					this._sunFlaresGhosts2Size = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0008F899 File Offset: 0x0008DA99
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0008F8A1 File Offset: 0x0008DAA1
		public float sunFlaresGhosts2Offset
		{
			get
			{
				return this._sunFlaresGhosts2Offset;
			}
			set
			{
				if (this._sunFlaresGhosts2Offset != value)
				{
					this._sunFlaresGhosts2Offset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x0008F8B9 File Offset: 0x0008DAB9
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x0008F8C1 File Offset: 0x0008DAC1
		public float sunFlaresGhosts2Brightness
		{
			get
			{
				return this._sunFlaresGhosts2Brightness;
			}
			set
			{
				if (this._sunFlaresGhosts2Brightness != value)
				{
					this._sunFlaresGhosts2Brightness = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0008F8D9 File Offset: 0x0008DAD9
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x0008F8E1 File Offset: 0x0008DAE1
		public float sunFlaresGhosts3Size
		{
			get
			{
				return this._sunFlaresGhosts3Size;
			}
			set
			{
				if (this._sunFlaresGhosts3Size != value)
				{
					this._sunFlaresGhosts3Size = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x0008F8F9 File Offset: 0x0008DAF9
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0008F901 File Offset: 0x0008DB01
		public float sunFlaresGhosts3Brightness
		{
			get
			{
				return this._sunFlaresGhosts3Brightness;
			}
			set
			{
				if (this._sunFlaresGhosts3Brightness != value)
				{
					this._sunFlaresGhosts3Brightness = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0008F919 File Offset: 0x0008DB19
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0008F921 File Offset: 0x0008DB21
		public float sunFlaresGhosts3Offset
		{
			get
			{
				return this._sunFlaresGhosts3Offset;
			}
			set
			{
				if (this._sunFlaresGhosts3Offset != value)
				{
					this._sunFlaresGhosts3Offset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0008F939 File Offset: 0x0008DB39
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0008F941 File Offset: 0x0008DB41
		public float sunFlaresGhosts4Size
		{
			get
			{
				return this._sunFlaresGhosts4Size;
			}
			set
			{
				if (this._sunFlaresGhosts4Size != value)
				{
					this._sunFlaresGhosts4Size = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0008F959 File Offset: 0x0008DB59
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0008F961 File Offset: 0x0008DB61
		public float sunFlaresGhosts4Offset
		{
			get
			{
				return this._sunFlaresGhosts4Offset;
			}
			set
			{
				if (this._sunFlaresGhosts4Offset != value)
				{
					this._sunFlaresGhosts4Offset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0008F979 File Offset: 0x0008DB79
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0008F981 File Offset: 0x0008DB81
		public float sunFlaresGhosts4Brightness
		{
			get
			{
				return this._sunFlaresGhosts4Brightness;
			}
			set
			{
				if (this._sunFlaresGhosts4Brightness != value)
				{
					this._sunFlaresGhosts4Brightness = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0008F999 File Offset: 0x0008DB99
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0008F9A1 File Offset: 0x0008DBA1
		public float sunFlaresHaloOffset
		{
			get
			{
				return this._sunFlaresHaloOffset;
			}
			set
			{
				if (this._sunFlaresHaloOffset != value)
				{
					this._sunFlaresHaloOffset = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0008F9B9 File Offset: 0x0008DBB9
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0008F9C1 File Offset: 0x0008DBC1
		public float sunFlaresHaloAmplitude
		{
			get
			{
				return this._sunFlaresHaloAmplitude;
			}
			set
			{
				if (this._sunFlaresHaloAmplitude != value)
				{
					this._sunFlaresHaloAmplitude = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0008F9D9 File Offset: 0x0008DBD9
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0008F9E1 File Offset: 0x0008DBE1
		public float sunFlaresHaloIntensity
		{
			get
			{
				return this._sunFlaresHaloIntensity;
			}
			set
			{
				if (this._sunFlaresHaloIntensity != value)
				{
					this._sunFlaresHaloIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0008F9F9 File Offset: 0x0008DBF9
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0008FA01 File Offset: 0x0008DC01
		public bool sunFlaresRotationDeadZone
		{
			get
			{
				return this._sunFlaresRotationDeadZone;
			}
			set
			{
				if (this._sunFlaresRotationDeadZone != value)
				{
					this._sunFlaresRotationDeadZone = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0008FA19 File Offset: 0x0008DC19
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x0008FA21 File Offset: 0x0008DC21
		public bool blur
		{
			get
			{
				return this._blur;
			}
			set
			{
				if (this._blur != value)
				{
					this._blur = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0008FA39 File Offset: 0x0008DC39
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x0008FA41 File Offset: 0x0008DC41
		public float blurIntensity
		{
			get
			{
				return this._blurIntensity;
			}
			set
			{
				if (this._blurIntensity != value)
				{
					this._blurIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0008FA59 File Offset: 0x0008DC59
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x0008FA61 File Offset: 0x0008DC61
		public int downscale
		{
			get
			{
				return this._downscale;
			}
			set
			{
				if (this._downscale != value)
				{
					this._downscale = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0008FA79 File Offset: 0x0008DC79
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0008FA81 File Offset: 0x0008DC81
		public int superSampling
		{
			get
			{
				return this._superSampling;
			}
			set
			{
				if (this._superSampling != value)
				{
					this._superSampling = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x0008FA9C File Offset: 0x0008DC9C
		private float renderScale
		{
			get
			{
				if (this._quality == BEAUTIFY_QUALITY.BestPerformance)
				{
					return (float)this._downscale;
				}
				if (this._quality == BEAUTIFY_QUALITY.BestQuality && !Application.isMobilePlatform)
				{
					return 1f / (0.5f + (float)this._superSampling / 2f);
				}
				return 1f;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0008FAE8 File Offset: 0x0008DCE8
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0008FAF0 File Offset: 0x0008DCF0
		public int pixelateAmount
		{
			get
			{
				return this._pixelateAmount;
			}
			set
			{
				if (this._pixelateAmount != value)
				{
					this._pixelateAmount = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0008FB08 File Offset: 0x0008DD08
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0008FB10 File Offset: 0x0008DD10
		public bool pixelateDownscale
		{
			get
			{
				return this._pixelateDownscale;
			}
			set
			{
				if (this._pixelateDownscale != value)
				{
					this._pixelateDownscale = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0008FB28 File Offset: 0x0008DD28
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0008FB30 File Offset: 0x0008DD30
		public float antialiasStrength
		{
			get
			{
				return this._antialiasStrength;
			}
			set
			{
				if (this._antialiasStrength != value)
				{
					this._antialiasStrength = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0008FB48 File Offset: 0x0008DD48
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0008FB50 File Offset: 0x0008DD50
		public float antialiasDepthThreshold
		{
			get
			{
				return this._antialiasDepthThreshold;
			}
			set
			{
				if (this._antialiasDepthThreshold != value)
				{
					this._antialiasDepthThreshold = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0008FB68 File Offset: 0x0008DD68
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0008FB70 File Offset: 0x0008DD70
		public bool chromaticAberration
		{
			get
			{
				return this._chromaticAberration;
			}
			set
			{
				if (this._chromaticAberration != value)
				{
					this._chromaticAberration = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0008FB88 File Offset: 0x0008DD88
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0008FB90 File Offset: 0x0008DD90
		public float chromaticAberrationIntensity
		{
			get
			{
				return this._chromaticAberrationIntensity;
			}
			set
			{
				if (this._chromaticAberrationIntensity != value)
				{
					this._chromaticAberrationIntensity = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0008FBA8 File Offset: 0x0008DDA8
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0008FBB0 File Offset: 0x0008DDB0
		public float chromaticAberrationSmoothing
		{
			get
			{
				return this._chromaticAberrationSmoothing;
			}
			set
			{
				if (this._chromaticAberrationSmoothing != value)
				{
					this._chromaticAberrationSmoothing = value;
					this.UpdateMaterialProperties();
				}
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0008FBC8 File Offset: 0x0008DDC8
		public static Beautify instance
		{
			get
			{
				if (Beautify._beautify == null)
				{
					Camera[] allCameras = Camera.allCameras;
					for (int i = 0; i < allCameras.Length; i++)
					{
						Beautify._beautify = allCameras[i].GetComponent<Beautify>();
						if (Beautify._beautify != null)
						{
							break;
						}
					}
				}
				return Beautify._beautify;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0008FC15 File Offset: 0x0008DE15
		public Camera cameraEffect
		{
			get
			{
				return this.currentCamera;
			}
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0008FC20 File Offset: 0x0008DE20
		private void OnEnable()
		{

		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0008FCDC File Offset: 0x0008DEDC
		private void OnDestroy()
		{

		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0008FDA8 File Offset: 0x0008DFA8
		private void Reset()
		{

		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0008FDB0 File Offset: 0x0008DFB0
		private void LateUpdate()
		{

		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0008FF17 File Offset: 0x0008E117
		private void OnPreCull()
		{

		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0008FF28 File Offset: 0x0008E128
		private void DoOnPreRenderTasks()
		{

		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00090028 File Offset: 0x0008E228
		private void OnPreRender()
		{

		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x000901EC File Offset: 0x0008E3EC
		private void CleanUpRT()
		{

		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0009035C File Offset: 0x0008E55C
		private RenderTextureDescriptor GetDefaultRenderTextureDescriptor()
		{

            return default;
        }

		// Token: 0x06001E16 RID: 7702 RVA: 0x000903AC File Offset: 0x0008E5AC
		private void CheckDoFTransparencySupport()
		{

		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0009057C File Offset: 0x0008E77C
		private void CheckDoFExclusionMask()
		{

		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00090748 File Offset: 0x0008E948
		private void CheckBloomCullingLayer()
		{

		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00090B4C File Offset: 0x0008ED4C
		private void RenderLeftEyeDepth()
		{

		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00090C10 File Offset: 0x0008EE10
		private void RenderRightEyeDepth()
		{

		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00090CD4 File Offset: 0x0008EED4
		private void RenderLeftEyeDepthAF()
		{

		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00090D98 File Offset: 0x0008EF98
		private void RenderRightEyeDepthAF()
		{

		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00090E5C File Offset: 0x0008F05C
		private int GetRawCopyPass()
		{

            return default;
        }

		// Token: 0x06001E1E RID: 7710 RVA: 0x00090E6C File Offset: 0x0008F06C
		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{

		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0009244C File Offset: 0x0009064C
		private void SeparateOutlinePass(RenderTexture source)
		{

		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000924B8 File Offset: 0x000906B8
		private void OnPostRender()
		{

		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00092558 File Offset: 0x00090758
		private void BlurThis(RenderTexture rt, float blurScale = 1f)
		{

		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x000925AC File Offset: 0x000907AC
		private void BlurThisOutline(RenderTexture rt, float blurScale = 1f, int downscale = 1)
		{

		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00092654 File Offset: 0x00090854
		private void BlurThisDownscaling(RenderTexture rt, RenderTexture downscaled, float blurScale = 1f)
		{

		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000926E8 File Offset: 0x000908E8
		private RenderTexture BlurThisOneDirection(RenderTexture rt, bool vertical, float blurScale = 1f)
		{

            return default;
        }

		// Token: 0x06001E25 RID: 7717 RVA: 0x00092734 File Offset: 0x00090934
		private void BlurThisDoF(RenderTexture rt, int renderPass)
		{

		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000927E4 File Offset: 0x000909E4
		private void BlurThisAlpha(RenderTexture rt, float blurScale = 1f)
		{

		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00092839 File Offset: 0x00090A39
		public void OnDidApplyAnimationProperties()
		{

		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00092844 File Offset: 0x00090A44
		public void UpdateQualitySettings()
		{

		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0009289F File Offset: 0x00090A9F
		public void UpdateMaterialProperties()
		{

		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000928B8 File Offset: 0x00090AB8
		public void UpdateMaterialPropertiesNow()
		{

		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00093940 File Offset: 0x00091B40
		private void UpdateMaterialBloomIntensityAndThreshold()
		{

		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0009399C File Offset: 0x00091B9C
		private void UpdateMaterialAnamorphicIntensityAndThreshold()
		{

		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000939F1 File Offset: 0x00091BF1
		private void UpdateSharpenParams(float sharpen)
		{

		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00093A1C File Offset: 0x00091C1C
		private void UpdateDepthOfFieldData()
		{

		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00093C68 File Offset: 0x00091E68
		private void UpdateDepthOfFieldBlurData(Vector2 blurDir)
		{

		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00093CC4 File Offset: 0x00091EC4
		private void UpdateDoFAutofocusDistance()
		{

		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00093D64 File Offset: 0x00091F64
		public void Blink(float duration, float maxValue = 1f)
		{

		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00093D7E File Offset: 0x00091F7E
		private IEnumerator DoBlink(float duration, float maxValue)
		{

            return default;
        }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00093D9B File Offset: 0x00091F9B
		public float depthOfFieldCurrentFocalPointDistance
		{
			get
			{
				return this.dofLastAutofocusDistance;
			}
		}

		// Token: 0x04001760 RID: 5984
		[SerializeField]
		private BEAUTIFY_PRESET _preset = BEAUTIFY_PRESET.Medium;

		// Token: 0x04001761 RID: 5985
		[SerializeField]
		private BEAUTIFY_QUALITY _quality;

		// Token: 0x04001762 RID: 5986
		[SerializeField]
		private BeautifyProfile _profile;

		// Token: 0x04001763 RID: 5987
		[SerializeField]
		private bool _syncWithProfile = true;

		// Token: 0x04001764 RID: 5988
		[SerializeField]
		private bool _compareMode;

		// Token: 0x04001765 RID: 5989
		[SerializeField]
		[Range(-3.1415927f, 3.1415927f)]
		private float _compareLineAngle = 1.4f;

		// Token: 0x04001766 RID: 5990
		[SerializeField]
		[Range(0.0001f, 0.05f)]
		private float _compareLineWidth = 0.002f;

		// Token: 0x04001767 RID: 5991
		[SerializeField]
		[Range(0f, 0.2f)]
		private float _dither = 0.02f;

		// Token: 0x04001768 RID: 5992
		[SerializeField]
		[Range(0f, 1f)]
		private float _ditherDepth;

		// Token: 0x04001769 RID: 5993
		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenMinDepth;

		// Token: 0x0400176A RID: 5994
		[SerializeField]
		[Range(0f, 1.1f)]
		private float _sharpenMaxDepth = 0.999f;

		// Token: 0x0400176B RID: 5995
		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenMinMaxDepthFallOff;

		// Token: 0x0400176C RID: 5996
		[SerializeField]
		[Range(0f, 15f)]
		private float _sharpen = 2f;

		// Token: 0x0400176D RID: 5997
		[SerializeField]
		[Range(0f, 0.05f)]
		private float _sharpenDepthThreshold = 0.035f;

		// Token: 0x0400176E RID: 5998
		[SerializeField]
		private Color _tintColor = new Color(1f, 1f, 1f, 0f);

		// Token: 0x0400176F RID: 5999
		[SerializeField]
		[Range(0f, 0.2f)]
		private float _sharpenRelaxation = 0.08f;

		// Token: 0x04001770 RID: 6000
		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenClamp = 0.45f;

		// Token: 0x04001771 RID: 6001
		[SerializeField]
		[Range(0f, 1f)]
		private float _sharpenMotionSensibility = 0.5f;

		// Token: 0x04001772 RID: 6002
		[SerializeField]
		[Range(-2f, 3f)]
		private float _saturate = 1f;

		// Token: 0x04001773 RID: 6003
		[SerializeField]
		[Range(0.5f, 1.5f)]
		private float _contrast = 1.02f;

		// Token: 0x04001774 RID: 6004
		[SerializeField]
		private float _brightness = 1.05f;

		// Token: 0x04001775 RID: 6005
		[SerializeField]
		[Range(0f, 2f)]
		private float _daltonize;

		// Token: 0x04001776 RID: 6006
		[SerializeField]
		[Range(0f, 1f)]
		private float _hardLightIntensity = 0.5f;

		// Token: 0x04001777 RID: 6007
		[SerializeField]
		[Range(0f, 1f)]
		private float _hardLightBlend;

		// Token: 0x04001778 RID: 6008
		[SerializeField]
		private bool _vignetting;

		// Token: 0x04001779 RID: 6009
		[SerializeField]
		private Color _vignettingColor = new Color(0.3f, 0.3f, 0.3f, 0.05f);

		// Token: 0x0400177A RID: 6010
		[SerializeField]
		[Range(0f, 1f)]
		private float _vignettingFade;

		// Token: 0x0400177B RID: 6011
		[SerializeField]
		private bool _vignettingCircularShape;

		// Token: 0x0400177C RID: 6012
		[SerializeField]
		private float _vignettingAspectRatio = 1f;

		// Token: 0x0400177D RID: 6013
		[SerializeField]
		[Range(0f, 1f)]
		private float _vignettingBlink;

		// Token: 0x0400177E RID: 6014
		[SerializeField]
		private BEAUTIFY_BLINK_STYLE _vignettingBlinkStyle;

		// Token: 0x0400177F RID: 6015
		[SerializeField]
		private Vector2 _vignettingCenter = new Vector2(0.5f, 0.5f);

		// Token: 0x04001780 RID: 6016
		[SerializeField]
		private Texture2D _vignettingMask;

		// Token: 0x04001781 RID: 6017
		[SerializeField]
		private bool _frame;

		// Token: 0x04001782 RID: 6018
		[SerializeField]
		private Color _frameColor = new Color(1f, 1f, 1f, 0.047f);

		// Token: 0x04001783 RID: 6019
		[SerializeField]
		private Texture2D _frameMask;

		// Token: 0x04001784 RID: 6020
		[SerializeField]
		private bool _lut;

		// Token: 0x04001785 RID: 6021
		[SerializeField]
		[Range(0f, 1f)]
		private float _lutIntensity = 1f;

		// Token: 0x04001786 RID: 6022
		[SerializeField]
		private Texture2D _lutTexture;

		// Token: 0x04001787 RID: 6023
		[SerializeField]
		private bool _nightVision;

		// Token: 0x04001788 RID: 6024
		[SerializeField]
		private Color _nightVisionColor = new Color(0.5f, 1f, 0.5f, 0.5f);

		// Token: 0x04001789 RID: 6025
		[SerializeField]
		private bool _outline;

		// Token: 0x0400178A RID: 6026
		[SerializeField]
		private Color _outlineColor = new Color(0f, 0f, 0f, 0.8f);

		// Token: 0x0400178B RID: 6027
		[SerializeField]
		private bool _outlineCustomize;

		// Token: 0x0400178C RID: 6028
		[SerializeField]
		private BEAUTIFY_OUTLINE_STAGE _outlineStage;

		// Token: 0x0400178D RID: 6029
		[SerializeField]
		[Range(0f, 1.3f)]
		private float _outlineSpread = 1f;

		// Token: 0x0400178E RID: 6030
		[SerializeField]
		[Range(1f, 5f)]
		private int _outlineBlurPassCount = 1;

		// Token: 0x0400178F RID: 6031
		[SerializeField]
		[Range(0f, 8f)]
		private float _outlineIntensityMultiplier = 1f;

		// Token: 0x04001790 RID: 6032
		[SerializeField]
		private bool _thermalVision;

		// Token: 0x04001791 RID: 6033
		[SerializeField]
		private bool _lensDirt;

		// Token: 0x04001792 RID: 6034
		[SerializeField]
		[Range(0f, 1f)]
		private float _lensDirtThreshold = 0.5f;

		// Token: 0x04001793 RID: 6035
		[SerializeField]
		[Range(0f, 1f)]
		private float _lensDirtIntensity = 0.9f;

		// Token: 0x04001794 RID: 6036
		[SerializeField]
		private Texture2D _lensDirtTexture;

		// Token: 0x04001795 RID: 6037
		[SerializeField]
		private bool _bloom;

		// Token: 0x04001796 RID: 6038
		[SerializeField]
		private LayerMask _bloomCullingMask = 0;

		// Token: 0x04001797 RID: 6039
		[SerializeField]
		[Range(1f, 4f)]
		private float _bloomLayerMaskDownsampling = 1f;

		// Token: 0x04001798 RID: 6040
		[SerializeField]
		[Range(0f, 10f)]
		private float _bloomIntensity = 1f;

		// Token: 0x04001799 RID: 6041
		[SerializeField]
		private float _bloomMaxBrightness = 1000f;

		// Token: 0x0400179A RID: 6042
		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost0;

		// Token: 0x0400179B RID: 6043
		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost1;

		// Token: 0x0400179C RID: 6044
		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost2;

		// Token: 0x0400179D RID: 6045
		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost3;

		// Token: 0x0400179E RID: 6046
		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost4;

		// Token: 0x0400179F RID: 6047
		[SerializeField]
		[Range(0f, 3f)]
		private float _bloomBoost5;

		// Token: 0x040017A0 RID: 6048
		[SerializeField]
		private bool _bloomAntiflicker;

		// Token: 0x040017A1 RID: 6049
		[SerializeField]
		private bool _bloomUltra;

		// Token: 0x040017A2 RID: 6050
		[SerializeField]
		[Range(1f, 10f)]
		private int _bloomUltraResolution = 10;

		// Token: 0x040017A3 RID: 6051
		[SerializeField]
		[Range(0f, 5f)]
		private float _bloomThreshold = 0.75f;

		// Token: 0x040017A4 RID: 6052
		[SerializeField]
		private Color _bloomTint = new Color(1f, 1f, 1f, 0f);

		// Token: 0x040017A5 RID: 6053
		[SerializeField]
		private bool _bloomCustomize;

		// Token: 0x040017A6 RID: 6054
		[SerializeField]
		private bool _bloomDebug;

		// Token: 0x040017A7 RID: 6055
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight0 = 0.5f;

		// Token: 0x040017A8 RID: 6056
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight1 = 0.5f;

		// Token: 0x040017A9 RID: 6057
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight2 = 0.5f;

		// Token: 0x040017AA RID: 6058
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight3 = 0.5f;

		// Token: 0x040017AB RID: 6059
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight4 = 0.5f;

		// Token: 0x040017AC RID: 6060
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomWeight5 = 0.5f;

		// Token: 0x040017AD RID: 6061
		[SerializeField]
		private bool _bloomBlur = true;

		// Token: 0x040017AE RID: 6062
		[SerializeField]
		private bool _bloomQuickerBlur;

		// Token: 0x040017AF RID: 6063
		[SerializeField]
		[Range(0f, 1f)]
		private float _bloomDepthAtten;

		// Token: 0x040017B0 RID: 6064
		[SerializeField]
		private float _bloomNearAtten;

		// Token: 0x040017B1 RID: 6065
		[SerializeField]
		[Range(-1f, 1f)]
		private float _bloomLayerZBias = 0.0001f;

		// Token: 0x040017B2 RID: 6066
		[SerializeField]
		private BEAUTIFY_PRERENDER_EVENT _preRenderCameraEvent;

		// Token: 0x040017B3 RID: 6067
		[SerializeField]
		private bool _anamorphicFlares;

		// Token: 0x040017B4 RID: 6068
		[SerializeField]
		private LayerMask _anamorphicFlaresCullingMask = 0;

		// Token: 0x040017B5 RID: 6069
		[SerializeField]
		[Range(0f, 10f)]
		private float _anamorphicFlaresIntensity = 1f;

		// Token: 0x040017B6 RID: 6070
		[SerializeField]
		private bool _anamorphicFlaresAntiflicker;

		// Token: 0x040017B7 RID: 6071
		[SerializeField]
		private bool _anamorphicFlaresUltra;

		// Token: 0x040017B8 RID: 6072
		[SerializeField]
		[Range(1f, 10f)]
		private int _anamorphicFlaresUltraResolution = 10;

		// Token: 0x040017B9 RID: 6073
		[SerializeField]
		[Range(0f, 5f)]
		private float _anamorphicFlaresThreshold = 0.75f;

		// Token: 0x040017BA RID: 6074
		[SerializeField]
		[Range(0.1f, 2f)]
		private float _anamorphicFlaresSpread = 1f;

		// Token: 0x040017BB RID: 6075
		[SerializeField]
		private bool _anamorphicFlaresVertical;

		// Token: 0x040017BC RID: 6076
		[SerializeField]
		private Color _anamorphicFlaresTint = new Color(0.5f, 0.5f, 1f, 0f);

		// Token: 0x040017BD RID: 6077
		[SerializeField]
		private bool _anamorphicFlaresBlur = true;

		// Token: 0x040017BE RID: 6078
		[SerializeField]
		private bool _depthOfField;

		// Token: 0x040017BF RID: 6079
		[SerializeField]
		private bool _depthOfFieldTransparencySupport;

		// Token: 0x040017C0 RID: 6080
		[SerializeField]
		private LayerMask _depthOfFieldTransparencyLayerMask = -1;

		// Token: 0x040017C1 RID: 6081
		[SerializeField]
		private Transform _depthOfFieldTargetFocus;

		// Token: 0x040017C2 RID: 6082
		[SerializeField]
		private bool _depthOfFieldDebug;

		// Token: 0x040017C3 RID: 6083
		[SerializeField]
		private bool _depthOfFieldAutofocus;

		// Token: 0x040017C4 RID: 6084
		[SerializeField]
		private Vector2 _depthofFieldAutofocusViewportPoint = new Vector2(0.5f, 0.5f);

		// Token: 0x040017C5 RID: 6085
		[SerializeField]
		private float _depthOfFieldAutofocusMinDistance;

		// Token: 0x040017C6 RID: 6086
		[SerializeField]
		private float _depthOfFieldAutofocusDistanceShift;

		// Token: 0x040017C7 RID: 6087
		[SerializeField]
		private float _depthOfFieldAutofocusMaxDistance = 10000f;

		// Token: 0x040017C8 RID: 6088
		[SerializeField]
		private LayerMask _depthOfFieldAutofocusLayerMask = -1;

		// Token: 0x040017C9 RID: 6089
		[SerializeField]
		private LayerMask _depthOfFieldExclusionLayerMask = 0;

		// Token: 0x040017CA RID: 6090
		[SerializeField]
		[Range(1f, 4f)]
		private float _depthOfFieldExclusionLayerMaskDownsampling = 1f;

		// Token: 0x040017CB RID: 6091
		[SerializeField]
		[Range(1f, 4f)]
		private float _depthOfFieldTransparencySupportDownsampling = 1f;

		// Token: 0x040017CC RID: 6092
		[SerializeField]
		[Range(0.9f, 1f)]
		private float _depthOfFieldExclusionBias = 0.99f;

		// Token: 0x040017CD RID: 6093
		[SerializeField]
		[Range(1f, 100f)]
		private float _depthOfFieldDistance = 1f;

		// Token: 0x040017CE RID: 6094
		[SerializeField]
		[Range(0.001f, 5f)]
		private float _depthOfFieldFocusSpeed = 1f;

		// Token: 0x040017CF RID: 6095
		[SerializeField]
		[Range(1f, 5f)]
		private int _depthOfFieldDownsampling = 2;

		// Token: 0x040017D0 RID: 6096
		[SerializeField]
		[Range(2f, 16f)]
		private int _depthOfFieldMaxSamples = 4;

		// Token: 0x040017D1 RID: 6097
		[SerializeField]
		private BEAUTIFY_DOF_CAMERA_SETTINGS _depthOfFieldCameraSettings;

		// Token: 0x040017D2 RID: 6098
		[SerializeField]
		[Range(1f, 300f)]
		private float _depthOfFieldFocalLengthReal = 50f;

		// Token: 0x040017D3 RID: 6099
		[SerializeField]
		[Range(1f, 32f)]
		private float _depthOfFieldFStop = 2f;

		// Token: 0x040017D4 RID: 6100
		[SerializeField]
		[Range(1f, 48f)]
		private float _depthOfFieldImageSensorHeight = 24f;

		// Token: 0x040017D5 RID: 6101
		[SerializeField]
		[Range(0.005f, 0.5f)]
		private float _depthOfFieldFocalLength = 0.05f;

		// Token: 0x040017D6 RID: 6102
		[SerializeField]
		private float _depthOfFieldAperture = 2.8f;

		// Token: 0x040017D7 RID: 6103
		[SerializeField]
		private bool _depthOfFieldForegroundBlur = true;

		// Token: 0x040017D8 RID: 6104
		[SerializeField]
		private bool _depthOfFieldForegroundBlurHQ;

		// Token: 0x040017D9 RID: 6105
		[SerializeField]
		[Range(0f, 32f)]
		private float _depthOfFieldForegroundBlurHQSpread = 16f;

		// Token: 0x040017DA RID: 6106
		[SerializeField]
		private float _depthOfFieldForegroundDistance = 0.25f;

		// Token: 0x040017DB RID: 6107
		[SerializeField]
		private bool _depthOfFieldBokeh = true;

		// Token: 0x040017DC RID: 6108
		[SerializeField]
		private BEAUTIFY_BOKEH_COMPOSITION _depthOfFieldBokehComposition;

		// Token: 0x040017DD RID: 6109
		[SerializeField]
		[Range(0.5f, 3f)]
		private float _depthOfFieldBokehThreshold = 1f;

		// Token: 0x040017DE RID: 6110
		[SerializeField]
		[Range(0f, 8f)]
		private float _depthOfFieldBokehIntensity = 2f;

		// Token: 0x040017DF RID: 6111
		[SerializeField]
		private float _depthOfFieldMaxBrightness = 1000f;

		// Token: 0x040017E0 RID: 6112
		[SerializeField]
		[Range(0f, 1f)]
		private float _depthOfFieldMaxDistance = 1f;

		// Token: 0x040017E1 RID: 6113
		[SerializeField]
		private FilterMode _depthOfFieldFilterMode = FilterMode.Bilinear;

		// Token: 0x040017E2 RID: 6114
		[NonSerialized]
		public OnBeforeFocusEvent OnBeforeFocus;

		// Token: 0x040017E3 RID: 6115
		[SerializeField]
		private bool _eyeAdaptation;

		// Token: 0x040017E4 RID: 6116
		[SerializeField]
		[Range(0f, 1f)]
		private float _eyeAdaptationMinExposure = 0.2f;

		// Token: 0x040017E5 RID: 6117
		[SerializeField]
		[Range(1f, 100f)]
		private float _eyeAdaptationMaxExposure = 5f;

		// Token: 0x040017E6 RID: 6118
		[SerializeField]
		[Range(0f, 1f)]
		private float _eyeAdaptationSpeedToLight = 0.4f;

		// Token: 0x040017E7 RID: 6119
		[SerializeField]
		[Range(0f, 1f)]
		private float _eyeAdaptationSpeedToDark = 0.2f;

		// Token: 0x040017E8 RID: 6120
		[SerializeField]
		private bool _eyeAdaptationInEditor = true;

		// Token: 0x040017E9 RID: 6121
		[SerializeField]
		private bool _purkinje;

		// Token: 0x040017EA RID: 6122
		[SerializeField]
		[Range(0f, 5f)]
		private float _purkinjeAmount = 1f;

		// Token: 0x040017EB RID: 6123
		[SerializeField]
		[Range(0f, 1f)]
		private float _purkinjeLuminanceThreshold = 0.15f;

		// Token: 0x040017EC RID: 6124
		[SerializeField]
		private BEAUTIFY_TMO _tonemap;

		// Token: 0x040017ED RID: 6125
		[SerializeField]
		private bool _sunFlares;

		// Token: 0x040017EE RID: 6126
		[SerializeField]
		private Transform _sun;

		// Token: 0x040017EF RID: 6127
		[SerializeField]
		private LayerMask _sunFlaresLayerMask = -1;

		// Token: 0x040017F0 RID: 6128
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresIntensity = 1f;

		// Token: 0x040017F1 RID: 6129
		[SerializeField]
		private float _sunFlaresRevealSpeed = 1f;

		// Token: 0x040017F2 RID: 6130
		[SerializeField]
		private float _sunFlaresHideSpeed = 1f;

		// Token: 0x040017F3 RID: 6131
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSolarWindSpeed = 0.01f;

		// Token: 0x040017F4 RID: 6132
		[SerializeField]
		private Color _sunFlaresTint = new Color(1f, 1f, 1f);

		// Token: 0x040017F5 RID: 6133
		[SerializeField]
		[Range(1f, 5f)]
		private int _sunFlaresDownsampling = 1;

		// Token: 0x040017F6 RID: 6134
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSunIntensity = 0.1f;

		// Token: 0x040017F7 RID: 6135
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSunDiskSize = 0.05f;

		// Token: 0x040017F8 RID: 6136
		[SerializeField]
		[Range(0f, 10f)]
		private float _sunFlaresSunRayDiffractionIntensity = 3.5f;

		// Token: 0x040017F9 RID: 6137
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresSunRayDiffractionThreshold = 0.13f;

		// Token: 0x040017FA RID: 6138
		[SerializeField]
		[Range(0f, 0.2f)]
		private float _sunFlaresCoronaRays1Length = 0.02f;

		// Token: 0x040017FB RID: 6139
		[SerializeField]
		[Range(2f, 30f)]
		private int _sunFlaresCoronaRays1Streaks = 12;

		// Token: 0x040017FC RID: 6140
		[SerializeField]
		[Range(0f, 0.1f)]
		private float _sunFlaresCoronaRays1Spread = 0.001f;

		// Token: 0x040017FD RID: 6141
		[SerializeField]
		[Range(0f, 6.2831855f)]
		private float _sunFlaresCoronaRays1AngleOffset;

		// Token: 0x040017FE RID: 6142
		[SerializeField]
		[Range(0f, 0.2f)]
		private float _sunFlaresCoronaRays2Length = 0.05f;

		// Token: 0x040017FF RID: 6143
		[SerializeField]
		[Range(2f, 30f)]
		private int _sunFlaresCoronaRays2Streaks = 12;

		// Token: 0x04001800 RID: 6144
		[SerializeField]
		[Range(0f, 0.1f)]
		private float _sunFlaresCoronaRays2Spread = 0.1f;

		// Token: 0x04001801 RID: 6145
		[SerializeField]
		[Range(0f, 6.2831855f)]
		private float _sunFlaresCoronaRays2AngleOffset;

		// Token: 0x04001802 RID: 6146
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts1Size = 0.03f;

		// Token: 0x04001803 RID: 6147
		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts1Offset = 1.04f;

		// Token: 0x04001804 RID: 6148
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts1Brightness = 0.037f;

		// Token: 0x04001805 RID: 6149
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts2Size = 0.1f;

		// Token: 0x04001806 RID: 6150
		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts2Offset = 0.71f;

		// Token: 0x04001807 RID: 6151
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts2Brightness = 0.03f;

		// Token: 0x04001808 RID: 6152
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts3Size = 0.24f;

		// Token: 0x04001809 RID: 6153
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts3Brightness = 0.025f;

		// Token: 0x0400180A RID: 6154
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts3Offset = 0.31f;

		// Token: 0x0400180B RID: 6155
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts4Size = 0.016f;

		// Token: 0x0400180C RID: 6156
		[SerializeField]
		[Range(-3f, 3f)]
		private float _sunFlaresGhosts4Offset;

		// Token: 0x0400180D RID: 6157
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresGhosts4Brightness = 0.017f;

		// Token: 0x0400180E RID: 6158
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresHaloOffset = 0.22f;

		// Token: 0x0400180F RID: 6159
		[SerializeField]
		[Range(0f, 50f)]
		private float _sunFlaresHaloAmplitude = 15.1415f;

		// Token: 0x04001810 RID: 6160
		[SerializeField]
		[Range(0f, 1f)]
		private float _sunFlaresHaloIntensity = 0.01f;

		// Token: 0x04001811 RID: 6161
		[SerializeField]
		private bool _sunFlaresRotationDeadZone;

		// Token: 0x04001812 RID: 6162
		[SerializeField]
		private bool _blur;

		// Token: 0x04001813 RID: 6163
		[SerializeField]
		[Range(0f, 4f)]
		private float _blurIntensity = 1f;

		// Token: 0x04001814 RID: 6164
		[SerializeField]
		[Range(1f, 8f)]
		private int _downscale = 1;

		// Token: 0x04001815 RID: 6165
		[SerializeField]
		[Range(1f, 3f)]
		private int _superSampling = 1;

		// Token: 0x04001816 RID: 6166
		[SerializeField]
		[Range(1f, 256f)]
		private int _pixelateAmount = 1;

		// Token: 0x04001817 RID: 6167
		[SerializeField]
		private bool _pixelateDownscale;

		// Token: 0x04001818 RID: 6168
		[SerializeField]
		[Range(0f, 20f)]
		private float _antialiasStrength = 5f;

		// Token: 0x04001819 RID: 6169
		[SerializeField]
		[Range(0f, 0.05f)]
		private float _antialiasDepthThreshold = 0.001f;

		// Token: 0x0400181A RID: 6170
		[SerializeField]
		private bool _chromaticAberration;

		// Token: 0x0400181B RID: 6171
		[SerializeField]
		[Range(0f, 0.05f)]
		private float _chromaticAberrationIntensity;

		// Token: 0x0400181C RID: 6172
		[SerializeField]
		[Range(0f, 32f)]
		private float _chromaticAberrationSmoothing;

		// Token: 0x0400181D RID: 6173
		public bool isDirty;

		// Token: 0x0400181E RID: 6174
		private static Beautify _beautify;

		// Token: 0x0400181F RID: 6175
		public const string SKW_BLOOM = "BEAUTIFY_BLOOM";

		// Token: 0x04001820 RID: 6176
		public const string SKW_LUT = "BEAUTIFY_LUT";

		// Token: 0x04001821 RID: 6177
		public const string SKW_NIGHT_VISION = "BEAUTIFY_NIGHT_VISION";

		// Token: 0x04001822 RID: 6178
		public const string SKW_THERMAL_VISION = "BEAUTIFY_THERMAL_VISION";

		// Token: 0x04001823 RID: 6179
		public const string SKW_OUTLINE = "BEAUTIFY_OUTLINE";

		// Token: 0x04001824 RID: 6180
		public const string SKW_FRAME = "BEAUTIFY_FRAME";

		// Token: 0x04001825 RID: 6181
		public const string SKW_FRAME_MASK = "BEAUTIFY_FRAME_MASK";

		// Token: 0x04001826 RID: 6182
		public const string SKW_DALTONIZE = "BEAUTIFY_DALTONIZE";

		// Token: 0x04001827 RID: 6183
		public const string SKW_DIRT = "BEAUTIFY_DIRT";

		// Token: 0x04001828 RID: 6184
		public const string SKW_VIGNETTING = "BEAUTIFY_VIGNETTING";

		// Token: 0x04001829 RID: 6185
		public const string SKW_VIGNETTING_MASK = "BEAUTIFY_VIGNETTING_MASK";

		// Token: 0x0400182A RID: 6186
		public const string SKW_DEPTH_OF_FIELD = "BEAUTIFY_DEPTH_OF_FIELD";

		// Token: 0x0400182B RID: 6187
		public const string SKW_DEPTH_OF_FIELD_TRANSPARENT = "BEAUTIFY_DEPTH_OF_FIELD_TRANSPARENT";

		// Token: 0x0400182C RID: 6188
		public const string SKW_EYE_ADAPTATION = "BEAUTIFY_EYE_ADAPTATION";

		// Token: 0x0400182D RID: 6189
		public const string SKW_TONEMAP_ACES = "BEAUTIFY_TONEMAP_ACES";

		// Token: 0x0400182E RID: 6190
		public const string SKW_PURKINJE = "BEAUTIFY_PURKINJE";

		// Token: 0x0400182F RID: 6191
		public const string SKW_BLOOM_USE_DEPTH = "BEAUTIFY_BLOOM_USE_DEPTH";

		// Token: 0x04001830 RID: 6192
		public const string SKW_BLOOM_USE_LAYER = "BEAUTIFY_BLOOM_USE_LAYER";

		// Token: 0x04001831 RID: 6193
		public const string SKW_CHROMATIC_ABERRATION = "BEAUTIFY_CHROMATIC_ABERRATION";

		// Token: 0x04001832 RID: 6194
		private Material bMatDesktop;

		// Token: 0x04001833 RID: 6195
		private Material bMatMobile;

		// Token: 0x04001834 RID: 6196
		private Material bMatBasic;

		// Token: 0x04001835 RID: 6197
		private static Color ColorTransparent = new Color(0f, 0f, 0f, 0f);

		// Token: 0x04001836 RID: 6198
		[SerializeField]
		private Material bMat;

		// Token: 0x04001837 RID: 6199
		private Camera currentCamera;

		// Token: 0x04001838 RID: 6200
		private Vector3 camPrevForward;

		// Token: 0x04001839 RID: 6201
		private Vector3 camPrevPos;

		// Token: 0x0400183A RID: 6202
		private float currSens;

		// Token: 0x0400183B RID: 6203
		private int renderPass;

		// Token: 0x0400183C RID: 6204
		private RenderTextureFormat rtFormat;

		// Token: 0x0400183D RID: 6205
		private RenderTexture[] rt;

		// Token: 0x0400183E RID: 6206
		private RenderTexture[] rtAF;

		// Token: 0x0400183F RID: 6207
		private RenderTexture[] rtEA;

		// Token: 0x04001840 RID: 6208
		private RenderTexture rtEAacum;

		// Token: 0x04001841 RID: 6209
		private RenderTexture rtEAHist;

		// Token: 0x04001842 RID: 6210
		private float dofPrevDistance;

		// Token: 0x04001843 RID: 6211
		private float dofLastAutofocusDistance;

		// Token: 0x04001844 RID: 6212
		private Vector4 dofLastBokehData;

		// Token: 0x04001845 RID: 6213
		private Camera depthCam;

		// Token: 0x04001846 RID: 6214
		private GameObject depthCamObj;

		// Token: 0x04001847 RID: 6215
		private List<string> shaderKeywords;

		// Token: 0x04001848 RID: 6216
		private Shader depthShader;

		// Token: 0x04001849 RID: 6217
		private Shader dofExclusionShader;

		// Token: 0x0400184A RID: 6218
		private bool shouldUpdateMaterialProperties;

		// Token: 0x0400184B RID: 6219
		private const string BEAUTIFY_BUILD_HINT = "BeautifyBuildHint86RC1";

		// Token: 0x0400184C RID: 6220
		private float sunFlareCurrentIntensity;

		// Token: 0x0400184D RID: 6221
		private bool sunIsSpotlight;

		// Token: 0x0400184E RID: 6222
		private Vector4 sunLastScrPos;

		// Token: 0x0400184F RID: 6223
		private float sunLastRot;

		// Token: 0x04001850 RID: 6224
		private Texture2D flareNoise;

		// Token: 0x04001851 RID: 6225
		private RenderTexture dofDepthTexture;

		// Token: 0x04001852 RID: 6226
		private RenderTexture dofExclusionTexture;

		// Token: 0x04001853 RID: 6227
		private RenderTexture bloomSourceTexture;

		// Token: 0x04001854 RID: 6228
		private RenderTexture bloomSourceDepthTexture;

		// Token: 0x04001855 RID: 6229
		private RenderTexture bloomSourceTextureRightEye;

		// Token: 0x04001856 RID: 6230
		private RenderTexture bloomSourceDepthTextureRightEye;

		// Token: 0x04001857 RID: 6231
		private RenderTexture anamorphicFlaresSourceTexture;

		// Token: 0x04001858 RID: 6232
		private RenderTexture anamorphicFlaresSourceDepthTexture;

		// Token: 0x04001859 RID: 6233
		private RenderTexture anamorphicFlaresSourceTextureRightEye;

		// Token: 0x0400185A RID: 6234
		private RenderTexture anamorphicFlaresSourceDepthTextureRightEye;

		// Token: 0x0400185B RID: 6235
		private RenderTexture pixelateTexture;

		// Token: 0x0400185C RID: 6236
		private RenderTextureDescriptor rtDescBase;

		// Token: 0x0400185D RID: 6237
		private float sunFlareTime;

		// Token: 0x0400185E RID: 6238
		private int dofCurrentLayerMaskValue;

		// Token: 0x0400185F RID: 6239
		private int bloomCurrentLayerMaskValue;

		// Token: 0x04001860 RID: 6240
		private int anamorphicFlaresCurrentLayerMaskValue;

		// Token: 0x04001861 RID: 6241
		private int eyeWidth;

		// Token: 0x04001862 RID: 6242
		private int eyeHeight;

		// Token: 0x04001863 RID: 6243
		private bool isSuperSamplingActive;

		// Token: 0x04001864 RID: 6244
		private RenderTextureFormat rtOutlineColorFormat;

		// Token: 0x04001865 RID: 6245
		private bool isVRActive;

		// Token: 0x04001866 RID: 6246
		private bool linearColorSpace;

		// Token: 0x020004B5 RID: 1205
		public static class ShaderParams
		{
			// Token: 0x04002093 RID: 8339
			public static int BokehData = Shader.PropertyToID("_BokehData");

			// Token: 0x04002094 RID: 8340
			public static int BokehData3 = Shader.PropertyToID("_BokehData3");

			// Token: 0x04002095 RID: 8341
			public static int BokehData2 = Shader.PropertyToID("_BokehData2");

			// Token: 0x04002096 RID: 8342
			public static int Sharpen = Shader.PropertyToID("_Sharpen");

			// Token: 0x04002097 RID: 8343
			public static int Bloom = Shader.PropertyToID("_Bloom");

			// Token: 0x04002098 RID: 8344
			public static int BloomTexture = Shader.PropertyToID("_BloomTex");

			// Token: 0x04002099 RID: 8345
			public static int BloomTexture1 = Shader.PropertyToID("_BloomTex1");

			// Token: 0x0400209A RID: 8346
			public static int BloomTexture2 = Shader.PropertyToID("_BloomTex2");

			// Token: 0x0400209B RID: 8347
			public static int BloomTexture3 = Shader.PropertyToID("_BloomTex3");

			// Token: 0x0400209C RID: 8348
			public static int BloomTexture4 = Shader.PropertyToID("_BloomTex4");

			// Token: 0x0400209D RID: 8349
			public static int BloomWeights2 = Shader.PropertyToID("_BloomWeights2");

			// Token: 0x0400209E RID: 8350
			public static int BloomWeights = Shader.PropertyToID("_BloomWeights");

			// Token: 0x0400209F RID: 8351
			public static int BloomZDepthBias = Shader.PropertyToID("_BloomLayerZBias");

			// Token: 0x040020A0 RID: 8352
			public static int BloomTint = Shader.PropertyToID("_BloomTint");

			// Token: 0x040020A1 RID: 8353
			public static int BloomDepthNearThreshold = Shader.PropertyToID("_BloomNearThreshold");

			// Token: 0x040020A2 RID: 8354
			public static int BloomDepthThreshold = Shader.PropertyToID("_BloomDepthThreshold");

			// Token: 0x040020A3 RID: 8355
			public static int BloomSourceTexture = Shader.PropertyToID("_BloomSourceTex");

			// Token: 0x040020A4 RID: 8356
			public static int BloomSourceDepthTexture = Shader.PropertyToID("_BloomSourceDepth");

			// Token: 0x040020A5 RID: 8357
			public static int BloomSourceRightEyeDepthTexture = Shader.PropertyToID("_BloomSourceDepthRightEye");

			// Token: 0x040020A6 RID: 8358
			public static int BloomSourceRightEyeTexture = Shader.PropertyToID("_BloomSourceTexRightEye");

			// Token: 0x040020A7 RID: 8359
			public static int Purkinje = Shader.PropertyToID("_Purkinje");

			// Token: 0x040020A8 RID: 8360
			public static int EyeAdaptation = Shader.PropertyToID("_EyeAdaptation");

			// Token: 0x040020A9 RID: 8361
			public static int CompareData = Shader.PropertyToID("_CompareParams");

			// Token: 0x040020AA RID: 8362
			public static int CompareTexture = Shader.PropertyToID("_CompareTex");

			// Token: 0x040020AB RID: 8363
			public static int DoFDepthBias = Shader.PropertyToID("_BeautifyDepthBias");

			// Token: 0x040020AC RID: 8364
			public static int DoFTexture = Shader.PropertyToID("_DoFTex");

			// Token: 0x040020AD RID: 8365
			public static int DoFExclusionTexture = Shader.PropertyToID("_DofExclusionTexture");

			// Token: 0x040020AE RID: 8366
			public static int DoFBokehRT = Shader.PropertyToID("_DoFBokeh");

			// Token: 0x040020AF RID: 8367
			public static int DepthTexture = Shader.PropertyToID("_DepthTexture");

			// Token: 0x040020B0 RID: 8368
			public static int AFTint = Shader.PropertyToID("_AFTint");

			// Token: 0x040020B1 RID: 8369
			public static int OverlayTexture = Shader.PropertyToID("_OverlayTex");

			// Token: 0x040020B2 RID: 8370
			public static int SFMainTexture = Shader.PropertyToID("_SFMainTex");

			// Token: 0x040020B3 RID: 8371
			public static int SFHalo = Shader.PropertyToID("_SunHalo");

			// Token: 0x040020B4 RID: 8372
			public static int SFSunTint = Shader.PropertyToID("_SunTint");

			// Token: 0x040020B5 RID: 8373
			public static int SFGhosts4 = Shader.PropertyToID("_SunGhosts4");

			// Token: 0x040020B6 RID: 8374
			public static int SFGhosts3 = Shader.PropertyToID("_SunGhosts3");

			// Token: 0x040020B7 RID: 8375
			public static int SFGhosts2 = Shader.PropertyToID("_SunGhosts2");

			// Token: 0x040020B8 RID: 8376
			public static int SFGhosts1 = Shader.PropertyToID("_SunGhosts1");

			// Token: 0x040020B9 RID: 8377
			public static int SFCoronaRays1 = Shader.PropertyToID("_SunCoronaRays1");

			// Token: 0x040020BA RID: 8378
			public static int SFCoronaRays2 = Shader.PropertyToID("_SunCoronaRays2");

			// Token: 0x040020BB RID: 8379
			public static int SFSunData = Shader.PropertyToID("_SunData");

			// Token: 0x040020BC RID: 8380
			public static int SFSunPos = Shader.PropertyToID("_SunPos");

			// Token: 0x040020BD RID: 8381
			public static int SFSunPosRightEye = Shader.PropertyToID("_SunPosRightEye");

			// Token: 0x040020BE RID: 8382
			public static int Frame = Shader.PropertyToID("_Frame");

			// Token: 0x040020BF RID: 8383
			public static int FrameMaskTexture = Shader.PropertyToID("_FrameMask");

			// Token: 0x040020C0 RID: 8384
			public static int OutlineColor = Shader.PropertyToID("_Outline");

			// Token: 0x040020C1 RID: 8385
			public static int OutlineIntensityMultiplier = Shader.PropertyToID("_OutlineIntensityMultiplier");

			// Token: 0x040020C2 RID: 8386
			public static int VignetteAspectRatio = Shader.PropertyToID("_VignettingAspectRatio");

			// Token: 0x040020C3 RID: 8387
			public static int Vignette = Shader.PropertyToID("_Vignetting");

			// Token: 0x040020C4 RID: 8388
			public static int VignetteMaskTexture = Shader.PropertyToID("_VignettingMask");

			// Token: 0x040020C5 RID: 8389
			public static int FXData = Shader.PropertyToID("_FXData");

			// Token: 0x040020C6 RID: 8390
			public static int FXColor = Shader.PropertyToID("_FXColor");

			// Token: 0x040020C7 RID: 8391
			public static int HardLight = Shader.PropertyToID("_HardLight");

			// Token: 0x040020C8 RID: 8392
			public static int ColorBoost = Shader.PropertyToID("_ColorBoost");

			// Token: 0x040020C9 RID: 8393
			public static int AntialiasData = Shader.PropertyToID("_AntialiasData");

			// Token: 0x040020CA RID: 8394
			public static int Dither = Shader.PropertyToID("_Dither");

			// Token: 0x040020CB RID: 8395
			public static int Dirt = Shader.PropertyToID("_Dirt");

			// Token: 0x040020CC RID: 8396
			public static int ScreenLum = Shader.PropertyToID("_ScreenLum");

			// Token: 0x040020CD RID: 8397
			public static int TintColor = Shader.PropertyToID("_TintColor");

			// Token: 0x040020CE RID: 8398
			public static int LUT = Shader.PropertyToID("_LUTTex");

			// Token: 0x040020CF RID: 8399
			public static int BlurScale = Shader.PropertyToID("_BlurScale");

			// Token: 0x040020D0 RID: 8400
			public static int EAHist = Shader.PropertyToID("_EAHist");

			// Token: 0x040020D1 RID: 8401
			public static int EALumSrc = Shader.PropertyToID("_EALumSrc");

			// Token: 0x040020D2 RID: 8402
			public static int FlareTexture = Shader.PropertyToID("_FlareTex");

			// Token: 0x040020D3 RID: 8403
			public static int ChromaticAberration = Shader.PropertyToID("_ChromaticAberrationData");

			// Token: 0x040020D4 RID: 8404
			public static int LUTPreview = Shader.PropertyToID("_LUTPreview");

			// Token: 0x040020D5 RID: 8405
			public static int LUTTex = Shader.PropertyToID("_LUTTex");
		}
	}
}
