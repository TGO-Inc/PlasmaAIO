using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000D3 RID: 211
public class SmallerHingeDriver : ComponentDriver
{
	// Token: 0x1700008D RID: 141
	// (get) Token: 0x0600094B RID: 2379 RVA: 0x00032606 File Offset: 0x00030806
	private ArticulationBody hinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00032619 File Offset: 0x00030819
	public override void Awake()
	{

	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0003264F File Offset: 0x0003084F
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x0600094E RID: 2382 RVA: 0x0003265C File Offset: 0x0003085C
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x0600094F RID: 2383 RVA: 0x0003266C File Offset: 0x0003086C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000950 RID: 2384 RVA: 0x000326C4 File Offset: 0x000308C4
	private void SetPhysics()
	{

	}

	// Token: 0x06000951 RID: 2385 RVA: 0x000327A8 File Offset: 0x000309A8
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000952 RID: 2386 RVA: 0x000327E5 File Offset: 0x000309E5
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000327F2 File Offset: 0x000309F2
	public override void OnReset()
	{

	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000327FF File Offset: 0x000309FF
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00032808 File Offset: 0x00030A08
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000956 RID: 2390 RVA: 0x000328F4 File Offset: 0x00030AF4
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x06000957 RID: 2391 RVA: 0x0003298E File Offset: 0x00030B8E
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x06000958 RID: 2392 RVA: 0x000329A4 File Offset: 0x00030BA4
	public override float GetLimit(bool unscaled = false)
	{

        return default;
    }

	// Token: 0x06000959 RID: 2393 RVA: 0x000329AB File Offset: 0x00030BAB
	private void OnDestroy()
	{

	}

	// Token: 0x04000898 RID: 2200
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000899 RID: 2201
	public float maxMotorSpeed;

	// Token: 0x0400089A RID: 2202
	public float maxMotorTorque;

	// Token: 0x0400089B RID: 2203
	public PIDController positionPidController;

	// Token: 0x0400089C RID: 2204
	public float simulatedMotorDelta;

	// Token: 0x0400089D RID: 2205
	public float simulatedMaxMotorSpeed;

	// Token: 0x0400089E RID: 2206
	private AgentProperty _targetRotationProperty;

	// Token: 0x0400089F RID: 2207
	private AgentProperty _torqueProperty;

	// Token: 0x040008A0 RID: 2208
	private AgentProperty _maxSpeedProperty;

	// Token: 0x040008A1 RID: 2209
	private AgentProperty _currentRotationProperty;

	// Token: 0x040008A2 RID: 2210
	private ArticulationDrive _articulationDrive;

	// Token: 0x040008A3 RID: 2211
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x040008A4 RID: 2212
	private const string _FMODParamSize = "Size";
}
}