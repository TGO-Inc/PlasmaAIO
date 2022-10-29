using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020001B3 RID: 435
public class PlasmaRay : VisualBehaviour
{
	// Token: 0x0600100E RID: 4110 RVA: 0x00054E0C File Offset: 0x0005300C
	private void Start()
	{

	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00054F1A File Offset: 0x0005311A
	public void PlasmON(bool stayON = true)
	{

	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00054F2A File Offset: 0x0005312A
	public void PlasmOFF()
	{

	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00054F3C File Offset: 0x0005313C
	private void LateUpdate()
	{

	}

	// Token: 0x06001012 RID: 4114 RVA: 0x000552D8 File Offset: 0x000534D8
	private void UpdatePlasmaActivation()
	{

	}

	// Token: 0x04000DD3 RID: 3539
	public TubeRayRenderer[] tubeRenderers;

	// Token: 0x04000DD4 RID: 3540
	public AnimationCurve tubeRadius;

	// Token: 0x04000DD5 RID: 3541
	public AnimationCurve sineEffector;

	// Token: 0x04000DD6 RID: 3542
	public AnimationCurve activationCurve;

	// Token: 0x04000DD7 RID: 3543
	public AnimationCurve deactivationCurve;

	// Token: 0x04000DD8 RID: 3544
	public Vector3 startOffset;

	// Token: 0x04000DD9 RID: 3545
	public int segmentCount = 32;

	// Token: 0x04000DDA RID: 3546
	public float defaultActivationSpeed;

	// Token: 0x04000DDB RID: 3547
	public float defaultDeactivationSpeed;

	// Token: 0x04000DDC RID: 3548
	public float alphaSmoothDamp;

	// Token: 0x04000DDD RID: 3549
	[HideInInspector]
	public Vector3 startPosition;

	// Token: 0x04000DDE RID: 3550
	[HideInInspector]
	public Vector3 realEndPosition;

	// Token: 0x04000DDF RID: 3551
	[HideInInspector]
	public Vector3 curvedEndPosition;

	// Token: 0x04000DE0 RID: 3552
	[HideInInspector]
	public Vector3 forwardVector;

	// Token: 0x04000DE1 RID: 3553
	[HideInInspector]
	public Transform viewTransform;

	// Token: 0x04000DE2 RID: 3554
	[Header("[DEBUG]")]
	public bool stayON;

	// Token: 0x04000DE3 RID: 3555
	public PlasmaRayStatus plasmaRayStatus;

	// Token: 0x04000DE4 RID: 3556
	public float activationStatus01;

	// Token: 0x04000DE5 RID: 3557
	public bool activateRequest;

	// Token: 0x04000DE6 RID: 3558
	public float currentAlpha;

	// Token: 0x04000DE7 RID: 3559
	public float wantedAlpha;

	// Token: 0x04000DE8 RID: 3560
	public float vAlpha;

	// Token: 0x04000DE9 RID: 3561
	public float defaultAlpha;

	// Token: 0x04000DEA RID: 3562
	private float dist;

	// Token: 0x04000DEB RID: 3563
	private Vector3 hitPosition;

	// Token: 0x04000DEC RID: 3564
	private Vector3 currentPosition;
}
}