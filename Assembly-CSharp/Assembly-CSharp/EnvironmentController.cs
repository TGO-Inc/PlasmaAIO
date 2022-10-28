using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using PlasmaAPI.GameClass.BeautifyEffect;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using FMODUnity;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

namespace PlasmaAPI.GameClass {
// Token: 0x0200003A RID: 58
public class EnvironmentController : Controller
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000187 RID: 391 RVA: 0x000098A8 File Offset: 0x00007AA8
	// (set) Token: 0x06000188 RID: 392 RVA: 0x000098B0 File Offset: 0x00007AB0
	public Camera gameCamera { get; private set; }

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000189 RID: 393 RVA: 0x000098B9 File Offset: 0x00007AB9
	// (set) Token: 0x0600018A RID: 394 RVA: 0x000098C1 File Offset: 0x00007AC1
	public Transform sun { get; private set; }

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600018B RID: 395 RVA: 0x000098CA File Offset: 0x00007ACA
	// (set) Token: 0x0600018C RID: 396 RVA: 0x000098D2 File Offset: 0x00007AD2
	public Transform flare { get; private set; }

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600018D RID: 397 RVA: 0x000098DB File Offset: 0x00007ADB
	// (set) Token: 0x0600018E RID: 398 RVA: 0x000098E3 File Offset: 0x00007AE3
	public Transform moon { get; private set; }

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600018F RID: 399 RVA: 0x000098EC File Offset: 0x00007AEC
	// (set) Token: 0x06000190 RID: 400 RVA: 0x000098F4 File Offset: 0x00007AF4
	public float sunIntensity { get; private set; }

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000191 RID: 401 RVA: 0x000098FD File Offset: 0x00007AFD
	// (set) Token: 0x06000192 RID: 402 RVA: 0x00009905 File Offset: 0x00007B05
	public float moonIntensity { get; private set; }

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000193 RID: 403 RVA: 0x0000990E File Offset: 0x00007B0E
	// (set) Token: 0x06000194 RID: 404 RVA: 0x00009916 File Offset: 0x00007B16
	public bool canRun { get; set; }

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000195 RID: 405 RVA: 0x0000991F File Offset: 0x00007B1F
	public Light keyLight
	{
		get
		{
			return this._keyLight;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000196 RID: 406 RVA: 0x00009928 File Offset: 0x00007B28
	public Vector3 keyLightRotation
	{
		get
		{
			return this._keyLightTransform.transform.rotation.eulerAngles;
		}
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00009950 File Offset: 0x00007B50
	private void Start()
	{

	}

	// Token: 0x06000198 RID: 408 RVA: 0x000099B4 File Offset: 0x00007BB4
	public override void Init()
	{

	}

	// Token: 0x06000199 RID: 409 RVA: 0x00009A4C File Offset: 0x00007C4C
	public void Setup()
	{

	}

	// Token: 0x0600019A RID: 410 RVA: 0x00009E90 File Offset: 0x00008090
	private void UpdateTreesParams()
	{

	}

	// Token: 0x0600019B RID: 411 RVA: 0x00009F79 File Offset: 0x00008179
	private void SetCameraParameters()
	{

	}

	// Token: 0x0600019C RID: 412 RVA: 0x00009FAE File Offset: 0x000081AE
	private void Update()
	{

	}

	// Token: 0x0600019D RID: 413 RVA: 0x00009FC8 File Offset: 0x000081C8
	public void PerformTick()
	{

	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000A28B File Offset: 0x0000848B
	public void OverrideKeyLightRotation(Vector3 rotation)
	{

	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000A2A4 File Offset: 0x000084A4
	private int FindPrevPresetID(float hour)
	{

        return default;
    }

	// Token: 0x060001A0 RID: 416 RVA: 0x0000A310 File Offset: 0x00008510
	private int FindNextPresetID(float hour)
	{

        return default;
    }

	// Token: 0x060001A1 RID: 417 RVA: 0x0000A36C File Offset: 0x0000856C
	private float LerpValueBetweenPresets(float hour, int prevID, int nextID)
	{

        return default;
    }

	// Token: 0x060001A2 RID: 418 RVA: 0x0000A3C8 File Offset: 0x000085C8
	private void SetEnvironmentValues()
	{

	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0000AAB4 File Offset: 0x00008CB4
	private void TurnOnVignetteEffect(float intensity, float smoothness, float roundness)
	{

	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0000AB00 File Offset: 0x00008D00
	private void TurnOnColorGradingEffect(float saturation)
	{

	}

	// Token: 0x060001A5 RID: 421 RVA: 0x0000AB29 File Offset: 0x00008D29
	private void TurnOffSpecialEffects()
	{

	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0000AB64 File Offset: 0x00008D64
	public void TurnOnFocusEffect()
	{

	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public void TurnOffFocusEffect()
	{

	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000AC64 File Offset: 0x00008E64
	public void TurnOnGhostEffect()
	{

	}

	// Token: 0x060001A9 RID: 425 RVA: 0x0000ACD0 File Offset: 0x00008ED0
	public void TurnOffGhostEffect()
	{

	}

	// Token: 0x060001AA RID: 426 RVA: 0x0000AD1E File Offset: 0x00008F1E
	public void SetFOV(float value)
	{

	}

	// Token: 0x060001AB RID: 427 RVA: 0x0000AD3E File Offset: 0x00008F3E
	private void OnDestroy()
	{

	}

	// Token: 0x04000184 RID: 388
	public bool interpolateSun = true;

	// Token: 0x04000185 RID: 389
	public bool javierOverrideForTests;

	// Token: 0x04000186 RID: 390
	public bool showDebugInEditor;

	// Token: 0x04000187 RID: 391
	public bool advanceTimeInPlay;

	// Token: 0x04000188 RID: 392
	public string ppVolumeLayerName;

	// Token: 0x04000189 RID: 393
	public PostProcessProfile specialEffectsProfile;

	// Token: 0x0400018A RID: 394
	public float cloudRotationSpeed;

	// Token: 0x0400018B RID: 395
	public float focusEffectDuration;

	// Token: 0x0400018C RID: 396
	public float focusVignetteSmoothness;

	// Token: 0x0400018D RID: 397
	public float focusVignetteRoundness;

	// Token: 0x0400018E RID: 398
	public float focusVignetteIntensity;

	// Token: 0x0400018F RID: 399
	public float focusEffectFov;

	// Token: 0x04000190 RID: 400
	public float ghostEffectDuration;

	// Token: 0x04000191 RID: 401
	public float ghostVignetteSmoothness;

	// Token: 0x04000192 RID: 402
	public float ghostVignetteRoundness;

	// Token: 0x04000193 RID: 403
	public float ghostVignetteIntensity;

	// Token: 0x04000194 RID: 404
	public float ghostColorGradingSaturation;

	// Token: 0x04000195 RID: 405
	public float transMUL = 0.2f;

	// Token: 0x04000196 RID: 406
	public float wrapLight = 0.6f;

	// Token: 0x04000197 RID: 407
	[Range(0f, 5f)]
	public float treesWindSpeed = 1f;

	// Token: 0x04000198 RID: 408
	public float treesWindFreq = 10f;

	// Token: 0x04000199 RID: 409
	public float treesWindAmplitude = 0.02f;

	// Token: 0x0400019A RID: 410
	public float plantsWindSpeed = 1f;

	// Token: 0x0400019B RID: 411
	public float plantsWindFreq = 10f;

	// Token: 0x0400019C RID: 412
	public float plantsWindAmplitude = 0.02f;

	// Token: 0x0400019D RID: 413
	[Space(40f)]
	public Vector4 windDirection;

	// Token: 0x0400019E RID: 414
	[Range(5f, 50f)]
	public float windSize;

	// Token: 0x0400019F RID: 415
	[Range(0f, 1f)]
	public float treeSwayStutterInfluence;

	// Token: 0x040001A0 RID: 416
	[Range(0f, 10f)]
	public float treeSwayStutter;

	// Token: 0x040001A1 RID: 417
	[Range(0f, 10f)]
	public float treeSwaySpeed;

	// Token: 0x040001A2 RID: 418
	[Range(0f, 5f)]
	public float treeSwayDisp;

	// Token: 0x040001A3 RID: 419
	[Range(0f, 0.5f)]
	public float branchesVertDisp;

	// Token: 0x040001A4 RID: 420
	public Transform pivotsTransform;

	// Token: 0x040001A5 RID: 421
	public bool reinitializeInEditor;

	// Token: 0x040001A6 RID: 422
	public float nearPlane;

	// Token: 0x040001A7 RID: 423
	public float farPlane;

	// Token: 0x040001A8 RID: 424
	public float fov;

	// Token: 0x040001A9 RID: 425
	[Range(0f, 24f)]
	public float timeOfDay;

	// Token: 0x040001AA RID: 426
	public float timeSpeed;

	// Token: 0x040001AB RID: 427
	public AnimationCurve timeCurve;

	// Token: 0x040001AC RID: 428
	public float flareDistance;

	// Token: 0x040001AD RID: 429
	public float shaBias = 0.05f;

	// Token: 0x040001AE RID: 430
	public float shaNormalBias = 0.5f;

	// Token: 0x040001AF RID: 431
	public float shaNearPlane = 0.27f;

	// Token: 0x040001B0 RID: 432
	public float shadowHorizonExp;

	// Token: 0x040001B1 RID: 433
	[Range(0f, 0.5f)]
	public float sunShadowsAnticipation;

	// Token: 0x040001B2 RID: 434
	public float _timeOfDay01;

	// Token: 0x040001B3 RID: 435
	public List<PostProcessVolume> ppVolumes;

	// Token: 0x040001B4 RID: 436
	public BiomeReferences biomeReferences;

	// Token: 0x040001B5 RID: 437
	public const float defaultTimeSpeed = 0.01f;

	// Token: 0x040001B6 RID: 438
	[Multiline(10)]
	public string debugStr;

	// Token: 0x040001B7 RID: 439
	private Transform _slideRingTransformSun;

	// Token: 0x040001B8 RID: 440
	private Transform _lighting;

	// Token: 0x040001B9 RID: 441
	private Transform _keyLightTransform;

	// Token: 0x040001BA RID: 442
	private Transform _fakeSkyLightTransform;

	// Token: 0x040001BB RID: 443
	private Transform _cloudsTransform;

	// Token: 0x040001BC RID: 444
	private Light _keyLight;

	// Token: 0x040001BD RID: 445
	private Light _backLight;

	// Token: 0x040001BE RID: 446
	private Light _fakeSkyLight;

	// Token: 0x040001BF RID: 447
	private PostProcessVolume _ppSpecialVolume;

	// Token: 0x040001C0 RID: 448
	private float[] _weights;

	// Token: 0x040001C1 RID: 449
	private Material _skyboxMaterial;

	// Token: 0x040001C2 RID: 450
	private int _prevEnvID;

	// Token: 0x040001C3 RID: 451
	private int _nextEnvID;

	// Token: 0x040001C4 RID: 452
	private float _envLerpValue;

	// Token: 0x040001C5 RID: 453
	private VFXController _vfxController;

	// Token: 0x040001C6 RID: 454
	private List<Material> _cloudsMaterials;

	// Token: 0x040001C7 RID: 455
	private Material _moonMaterial;

	// Token: 0x040001C8 RID: 456
	private Material _sunMaterial;

	// Token: 0x040001C9 RID: 457
	private Beautify _beautify;
}
}