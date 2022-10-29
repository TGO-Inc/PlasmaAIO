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
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000E5 RID: 229
public class TransceiverDriver : ComponentDriver
{
	// Token: 0x060009C3 RID: 2499 RVA: 0x0003405A File Offset: 0x0003225A
	public override void Awake()
	{

	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00034088 File Offset: 0x00032288
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00034125 File Offset: 0x00032325
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00034134 File Offset: 0x00032334
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00034150 File Offset: 0x00032350
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x0003421E File Offset: 0x0003241E
	private IEnumerator LEDController()
	{

        return default;
    }

	// Token: 0x060009C9 RID: 2505 RVA: 0x0003422D File Offset: 0x0003242D
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00034264 File Offset: 0x00032464
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x040008EF RID: 2287
	public float LEDOnDuration;

	// Token: 0x040008F0 RID: 2288
	public float LEDOffDuration;

	// Token: 0x040008F1 RID: 2289
	public MeshRenderer meshRenderer;

	// Token: 0x040008F2 RID: 2290
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040008F3 RID: 2291
	private AgentProperty _frequencyProperty;

	// Token: 0x040008F4 RID: 2292
	private AgentProperty _v1Property;

	// Token: 0x040008F5 RID: 2293
	private AgentProperty _v2Property;

	// Token: 0x040008F6 RID: 2294
	private AgentProperty _v3Property;

	// Token: 0x040008F7 RID: 2295
	private AgentProperty _v1ReceivedProperty;

	// Token: 0x040008F8 RID: 2296
	private AgentProperty _v2ReceivedProperty;

	// Token: 0x040008F9 RID: 2297
	private AgentProperty _v3ReceivedProperty;

	// Token: 0x040008FA RID: 2298
	private AgentProperty _hasReceivedValueProperty;

	// Token: 0x040008FB RID: 2299
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040008FC RID: 2300
	private int _colorId;

	// Token: 0x040008FD RID: 2301
	private bool _blink;
}
}