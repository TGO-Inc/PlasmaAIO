using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000D1 RID: 209
public class SliderDriver : ComponentDriver
{
	// Token: 0x06000938 RID: 2360 RVA: 0x00032238 File Offset: 0x00030438
	public override void Awake()
	{

	}

	// Token: 0x06000939 RID: 2361 RVA: 0x0003225B File Offset: 0x0003045B
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00032293 File Offset: 0x00030493
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600093B RID: 2363 RVA: 0x000322BD File Offset: 0x000304BD
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600093C RID: 2364 RVA: 0x000322DC File Offset: 0x000304DC
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600093D RID: 2365 RVA: 0x00032312 File Offset: 0x00030512
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x0600093E RID: 2366 RVA: 0x00032318 File Offset: 0x00030518
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00032380 File Offset: 0x00030580
	public override void OnInteractionHold(Camera theCamera, Vector2 movement)
	{

	}

	// Token: 0x06000940 RID: 2368 RVA: 0x0003243C File Offset: 0x0003063C
	public override void OnInteractionUp()
	{

	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00032449 File Offset: 0x00030649
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00032460 File Offset: 0x00030660
	private void UpdateVisuals()
	{

	}

	// Token: 0x06000943 RID: 2371 RVA: 0x000324A8 File Offset: 0x000306A8
	private void SetLEDStripColor()
	{

	}

	// Token: 0x04000883 RID: 2179
	public MeshRenderer meshRenderer;

	// Token: 0x04000884 RID: 2180
	public GameObject knobGameObject;

	// Token: 0x04000885 RID: 2181
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000886 RID: 2182
	public float movementSpeed;

	// Token: 0x04000887 RID: 2183
	private float _currentValue;

	// Token: 0x04000888 RID: 2184
	private float _lastValue;

	// Token: 0x04000889 RID: 2185
	private float _lastDiff;

	// Token: 0x0400088A RID: 2186
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400088B RID: 2187
	private int _colorId;

	// Token: 0x0400088C RID: 2188
	private AgentProperty _positionProperty;

	// Token: 0x0400088D RID: 2189
	private AgentProperty _mappingProperty;

	// Token: 0x0400088E RID: 2190
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x0400088F RID: 2191
	private const float _zeroZPosition = -0.125f;

	// Token: 0x04000890 RID: 2192
	private const float _oneZPosition = 0.125f;

	// Token: 0x04000891 RID: 2193
	private const string _FMODParamSize = "Size";

	// Token: 0x04000892 RID: 2194
	private const string _FMODParamMovementSpeed = "MovmentSpeed";
}
}