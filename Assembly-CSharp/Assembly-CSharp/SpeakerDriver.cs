using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000D7 RID: 215
public class SpeakerDriver : ComponentDriver
{
	// Token: 0x06000968 RID: 2408 RVA: 0x00032C0C File Offset: 0x00030E0C
	public override void Awake()
	{

	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00032C5C File Offset: 0x00030E5C
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00032C79 File Offset: 0x00030E79
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00032C98 File Offset: 0x00030E98
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00032D16 File Offset: 0x00030F16
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00032D25 File Offset: 0x00030F25
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00032D58 File Offset: 0x00030F58
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00032FDC File Offset: 0x000311DC
	private void UpdateVisuals(bool playing)
	{

	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00033004 File Offset: 0x00031204
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00033086 File Offset: 0x00031286
	public override void OnMount()
	{

	}

	// Token: 0x06000972 RID: 2418 RVA: 0x0003309F File Offset: 0x0003129F
	public override void OnUnmount()
	{

	}

	// Token: 0x06000973 RID: 2419 RVA: 0x000330B8 File Offset: 0x000312B8
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x06000974 RID: 2420 RVA: 0x000330EE File Offset: 0x000312EE
	private IEnumerator LEDSequence()
	{

        return default;
    }

	// Token: 0x06000975 RID: 2421 RVA: 0x000330FD File Offset: 0x000312FD
	private void OnDestroy()
	{

	}

	// Token: 0x040008A8 RID: 2216
	public Animator animator;

	// Token: 0x040008A9 RID: 2217
	public MeshRenderer meshRenderer;

	// Token: 0x040008AA RID: 2218
	public float LEDOnDuration;

	// Token: 0x040008AB RID: 2219
	public float LEDOffDuration;

	// Token: 0x040008AC RID: 2220
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040008AD RID: 2221
	private int _colorId;

	// Token: 0x040008AE RID: 2222
	private AgentProperty _positionProperty;

	// Token: 0x040008AF RID: 2223
	private AgentProperty _soundProperty;

	// Token: 0x040008B0 RID: 2224
	private AgentProperty _volumeProperty;

	// Token: 0x040008B1 RID: 2225
	private AgentProperty _isLoopProperty;

	// Token: 0x040008B2 RID: 2226
	private AgentProperty _stateProperty;

	// Token: 0x040008B3 RID: 2227
	private Transform _transform;

	// Token: 0x040008B4 RID: 2228
	private EventInstance _eventInstance;

	// Token: 0x040008B5 RID: 2229
	private const string _FMODParamIsLoop = "IsLoop";

	// Token: 0x040008B6 RID: 2230
	private const float _maxRange = 50f;
}
}