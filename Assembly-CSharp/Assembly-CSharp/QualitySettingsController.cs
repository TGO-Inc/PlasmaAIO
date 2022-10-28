using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

namespace PlasmaAPI.GameClass {
// Token: 0x0200003F RID: 63
[ExecuteInEditMode]
public class QualitySettingsController : Controller
{
	// Token: 0x14000004 RID: 4
	// (add) Token: 0x060001E9 RID: 489 RVA: 0x0000DD30 File Offset: 0x0000BF30
	// (remove) Token: 0x060001EA RID: 490 RVA: 0x0000DD64 File Offset: 0x0000BF64
	public static event QualitySettingsController.QualitySettingsEvent OnQualitySettingsChanged;

	// Token: 0x060001EB RID: 491 RVA: 0x0000DD98 File Offset: 0x0000BF98
	public override void Init()
	{

	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000DE04 File Offset: 0x0000C004
	private void SetLowerGraphicsQuality()
	{

	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000DE61 File Offset: 0x0000C061
	public void OnAfterInternalRenderings()
	{

	}

	// Token: 0x060001EE RID: 494 RVA: 0x0000DE72 File Offset: 0x0000C072
	public void OnBeforeInternalRenderings()
	{

	}

	// Token: 0x060001EF RID: 495 RVA: 0x0000DE89 File Offset: 0x0000C089
	private void SaveCurrentGraphicsRenderSettings()
	{

	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
	private void RestoreGraphicsRenderSettings()
	{

	}

	// Token: 0x060001F1 RID: 497 RVA: 0x0000DF56 File Offset: 0x0000C156
	public LightShadows GetSpotlightsShadowType()
	{

        return default;
    }

	// Token: 0x060001F2 RID: 498 RVA: 0x0000DF60 File Offset: 0x0000C160
	public List<string> GetScreenResolutions()
	{

        return default;
    }

	// Token: 0x060001F3 RID: 499 RVA: 0x0000E020 File Offset: 0x0000C220
	public int GetCurrentScreenResolution()
	{

        return default;
    }

	// Token: 0x060001F4 RID: 500 RVA: 0x0000E06C File Offset: 0x0000C26C
	public void SetScreenResolution(int resID)
	{

	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000E0CC File Offset: 0x0000C2CC
	public void SetVSync(bool value)
	{

	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000E0E5 File Offset: 0x0000C2E5
	public bool GetVSync()
	{

        return default;
    }

	// Token: 0x060001F7 RID: 503 RVA: 0x0000E0EF File Offset: 0x0000C2EF
	public int GetScreensCount()
	{

        return default;
    }

	// Token: 0x060001F8 RID: 504 RVA: 0x0000E0FC File Offset: 0x0000C2FC
	public int GetActiveScreen()
	{

        return default;
    }

	// Token: 0x060001F9 RID: 505 RVA: 0x0000E109 File Offset: 0x0000C309
	public void ActivateScreen(int screenNum)
	{

	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000E120 File Offset: 0x0000C320
	private void SetReflectionProbesQuality(ReflectionProbesQuality quality)
	{

	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000E310 File Offset: 0x0000C510
	private void SetTerrainQuality(TerrainQuality quality)
	{

	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000E3BC File Offset: 0x0000C5BC
	private void SetGrassQuality(int qualityID, bool forceSlowGrassFlowFrefresh)
	{

	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000E564 File Offset: 0x0000C764
	private void SetPostEffectsQualitySlow()
	{

	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000E808 File Offset: 0x0000CA08
	public List<string> GetQualitySettings()
	{

        return default;
    }

	// Token: 0x060001FF RID: 511 RVA: 0x0000E844 File Offset: 0x0000CA44
	public void SetQualitySetting(int id, bool includeSceneSetup)
	{

	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000E894 File Offset: 0x0000CA94
	public void SetCurrentQualitySettingsToSceneObjects()
	{

	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000E968 File Offset: 0x0000CB68
	public int GetCurrentQualitySetting()
	{

        return default;
    }

	// Token: 0x06000202 RID: 514 RVA: 0x0000E970 File Offset: 0x0000CB70
	public void SaveSettings()
	{

	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000E9EC File Offset: 0x0000CBEC
	private void LoadAndApplySettings()
	{

	}

	// Token: 0x04000214 RID: 532
	private const bool chrisDebug = false;

	// Token: 0x04000216 RID: 534
	public bool bypassInteralCamerasOptimization;

	// Token: 0x04000217 RID: 535
	public bool globalTerrainDrawInstanced;

	// Token: 0x04000218 RID: 536
	public PlasmaQualitySetting[] settings;

	// Token: 0x04000219 RID: 537
	[Space]
	public bool debugValues;

	// Token: 0x0400021A RID: 538
	public Terrain terrain;

	// Token: 0x0400021B RID: 539
	public GrassFlowRenderer grassFlowRenderer;

	// Token: 0x0400021C RID: 540
	public ReflectionProbe[] reflectionProbes;

	// Token: 0x0400021D RID: 541
	public List<Resolution> currentScreenResolutions;

	// Token: 0x0400021E RID: 542
	public int currentScreenNum;

	// Token: 0x0400021F RID: 543
	public int currentVSync;

	// Token: 0x04000220 RID: 544
	public int currentQualitySettingId;

	// Token: 0x04000221 RID: 545
	public int savedPixelLightCount;

	// Token: 0x04000222 RID: 546
	public ShadowQuality savedShadowQuality;

	// Token: 0x04000223 RID: 547
	public float savedLodBias;

	// Token: 0x04000224 RID: 548
	public bool savedSoftParticles;

	// Token: 0x04000225 RID: 549
	public TerrainQuality savedTerrainQuality;

	// Token: 0x04000226 RID: 550
	public bool savedRealtimeReflectionProbes;

	// Token: 0x04000227 RID: 551
	public LightShadows spotlightShadows;

	// Token: 0x04000228 RID: 552
	public AnisotropicFiltering savedAnisotropicFiltering;

	// Token: 0x04000229 RID: 553
	public ReflectionProbesQuality savedReflectionProbesQuality;

	// Token: 0x0400022A RID: 554
	public BiomeReferences biomeReferences;

	// Token: 0x0400022B RID: 555
	private DisplayChanger _displayChanger;

	// Token: 0x0400022C RID: 556
	private Resolution _currentResolution;

	// Token: 0x0400022D RID: 557
	private bool canChangeGrassSettings;

	// Token: 0x020002E7 RID: 743
	// (Invoke) Token: 0x06001E81 RID: 7809
	public delegate void QualitySettingsEvent();
}
}