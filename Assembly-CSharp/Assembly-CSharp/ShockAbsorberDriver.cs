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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000CF RID: 207
public class ShockAbsorberDriver : ComponentDriver
{
	// Token: 0x1700008C RID: 140
	// (get) Token: 0x0600091F RID: 2335 RVA: 0x00031E33 File Offset: 0x00030033
	private ArticulationBody spring
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00031E46 File Offset: 0x00030046
	public override void Awake()
	{

	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00031E75 File Offset: 0x00030075
	private float StiffnessFromPercentage(float percentage)
	{

        return default;
    }

	// Token: 0x06000922 RID: 2338 RVA: 0x00031E9C File Offset: 0x0003009C
	private float DampingFromPercentage(float percentage)
	{

        return default;
    }

	// Token: 0x06000923 RID: 2339 RVA: 0x00031EC3 File Offset: 0x000300C3
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00031F04 File Offset: 0x00030104
	public float ConvertFrom01(float position)
	{

        return default;
    }

	// Token: 0x06000925 RID: 2341 RVA: 0x00031F34 File Offset: 0x00030134
	private float ConvertTo01(float position)
	{

        return default;
    }

	// Token: 0x06000926 RID: 2342 RVA: 0x00031F50 File Offset: 0x00030150
	private void SetPhysics()
	{

	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00031FEB File Offset: 0x000301EB
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00031FF3 File Offset: 0x000301F3
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00031FFF File Offset: 0x000301FF
	public override void OnReset()
	{

	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00032018 File Offset: 0x00030218
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x0600092B RID: 2347 RVA: 0x0003205C File Offset: 0x0003025C
	public override void OnScaleChanged()
	{

	}

	// Token: 0x0600092C RID: 2348 RVA: 0x0003206B File Offset: 0x0003026B
	private IEnumerator DelayedUpdateVisuals()
	{

        return default;
    }

	// Token: 0x0600092D RID: 2349 RVA: 0x0003207C File Offset: 0x0003027C
	private void SetLEDStripColor()
	{

	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00032104 File Offset: 0x00030304
	private void UpdateVisuals()
	{

	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0003214A File Offset: 0x0003034A
	public override float GetLimit(bool unscale = false)
	{

        return default;
    }

	// Token: 0x04000873 RID: 2163
	public Transform beam;

	// Token: 0x04000874 RID: 2164
	public MeshRenderer meshRenderer1;

	// Token: 0x04000875 RID: 2165
	public MeshRenderer meshRenderer2;

	// Token: 0x04000876 RID: 2166
	public FloatRange stiffnessRange;

	// Token: 0x04000877 RID: 2167
	public FloatRange dampingRange;

	// Token: 0x04000878 RID: 2168
	public float springScaleValue;

	// Token: 0x04000879 RID: 2169
	private ArticulationDrive _articulationDrive;

	// Token: 0x0400087A RID: 2170
	private AgentProperty _springStiffnessProperty;

	// Token: 0x0400087B RID: 2171
	private AgentProperty _springDampingProperty;

	// Token: 0x0400087C RID: 2172
	private AgentProperty _currentPositionProperty;

	// Token: 0x0400087D RID: 2173
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400087E RID: 2174
	private int _colorId;

	// Token: 0x0400087F RID: 2175
	private const float _restScale = 0.15f;
}
}