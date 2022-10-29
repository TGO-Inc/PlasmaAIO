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
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000061 RID: 97
public class CameraDriver : ComponentDriver
{
	// Token: 0x060005C3 RID: 1475 RVA: 0x00021BFD File Offset: 0x0001FDFD
	public override void Awake()
	{

	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00021C20 File Offset: 0x0001FE20
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00021C28 File Offset: 0x0001FE28
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00021C30 File Offset: 0x0001FE30
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00021C84 File Offset: 0x0001FE84
	private void UpdateVisuals()
	{

	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00021CB0 File Offset: 0x0001FEB0
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00021DE1 File Offset: 0x0001FFE1
	private IEnumerator PictureLEDEffect()
	{

        return default;
    }

	// Token: 0x060005CA RID: 1482 RVA: 0x00021DF0 File Offset: 0x0001FFF0
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x04000503 RID: 1283
	public MeshRenderer[] meshRenderers;

	// Token: 0x04000504 RID: 1284
	public Camera theCamera;

	// Token: 0x04000505 RID: 1285
	public StudioEventEmitter FMODEmitterOn;

	// Token: 0x04000506 RID: 1286
	public StudioEventEmitter FMODEmitterOff;

	// Token: 0x04000507 RID: 1287
	public StudioEventEmitter FMODEmitterPicture;

	// Token: 0x04000508 RID: 1288
	private AgentProperty _stateProperty;

	// Token: 0x04000509 RID: 1289
	private AgentProperty _fovProperty;

	// Token: 0x0400050A RID: 1290
	private AgentProperty _viewDistanceProperty;

	// Token: 0x0400050B RID: 1291
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400050C RID: 1292
	private CameraAgent _cameraAgent;

	// Token: 0x0400050D RID: 1293
	private int _colorId;
}
}