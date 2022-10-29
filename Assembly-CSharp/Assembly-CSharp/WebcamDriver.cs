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
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000E7 RID: 231
public class WebcamDriver : ComponentDriver
{
	// Token: 0x060009D9 RID: 2521 RVA: 0x00034653 File Offset: 0x00032853
	public override void Awake()
	{

	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00034676 File Offset: 0x00032876
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000346A8 File Offset: 0x000328A8
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060009DC RID: 2524 RVA: 0x000346DC File Offset: 0x000328DC
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00034743 File Offset: 0x00032943
	private void UpdateVisuals()
	{

	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00034770 File Offset: 0x00032970
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0003497C File Offset: 0x00032B7C
	private IEnumerator PictureLEDEffect()
	{

        return default;
    }

	// Token: 0x060009E0 RID: 2528 RVA: 0x0003498B File Offset: 0x00032B8B
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x000349C1 File Offset: 0x00032BC1
	private void OnDestroy()
	{

	}

	// Token: 0x04000902 RID: 2306
	public MeshRenderer meshRenderer;

	// Token: 0x04000903 RID: 2307
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000904 RID: 2308
	private int _colorId;

	// Token: 0x04000905 RID: 2309
	private WebcamAgent _webcamAgent;

	// Token: 0x04000906 RID: 2310
	private AgentProperty _webcamProperty;

	// Token: 0x04000907 RID: 2311
	private AgentProperty _stateProperty;

	// Token: 0x04000908 RID: 2312
	private WebCamTexture _webcamTexture;
}
}