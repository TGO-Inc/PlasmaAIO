using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000BA RID: 186
public class PositionalHingeDriver : ComponentDriver
{
	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600087B RID: 2171 RVA: 0x0002F3FA File Offset: 0x0002D5FA
	private ArticulationBody hinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x0002F410 File Offset: 0x0002D610
	public override void Awake()
	{

	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0002F45D File Offset: 0x0002D65D
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0002F46A File Offset: 0x0002D66A
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0002F478 File Offset: 0x0002D678
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0002F4D0 File Offset: 0x0002D6D0
	private void SetPhysics()
	{

	}

	// Token: 0x06000881 RID: 2177 RVA: 0x0002F590 File Offset: 0x0002D790
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0002F5CD File Offset: 0x0002D7CD
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0002F5DA File Offset: 0x0002D7DA
	public override void OnReset()
	{

	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0002F5F2 File Offset: 0x0002D7F2
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000885 RID: 2181 RVA: 0x0002F5FC File Offset: 0x0002D7FC
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000886 RID: 2182 RVA: 0x0002F7B8 File Offset: 0x0002D9B8
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x06000887 RID: 2183 RVA: 0x0002F854 File Offset: 0x0002DA54
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x06000888 RID: 2184 RVA: 0x0002F879 File Offset: 0x0002DA79
	private void OnDestroy()
	{

	}

	// Token: 0x040007E1 RID: 2017
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040007E2 RID: 2018
	public float maxMotorSpeed;

	// Token: 0x040007E3 RID: 2019
	public float maxMotorTorque;

	// Token: 0x040007E4 RID: 2020
	public PIDController positionPidController;

	// Token: 0x040007E5 RID: 2021
	public float simulatedMotorDelta;

	// Token: 0x040007E6 RID: 2022
	public float simulatedMaxMotorSpeed;

	// Token: 0x040007E7 RID: 2023
	public FloatRange attenuationRange;

	// Token: 0x040007E8 RID: 2024
	public float attenuationMinDistance;

	// Token: 0x040007E9 RID: 2025
	private AgentProperty _targetRotationProperty;

	// Token: 0x040007EA RID: 2026
	private AgentProperty _torqueProperty;

	// Token: 0x040007EB RID: 2027
	private AgentProperty _maxSpeedProperty;

	// Token: 0x040007EC RID: 2028
	private AgentProperty _currentRotationProperty;

	// Token: 0x040007ED RID: 2029
	private ArticulationDrive _articulationDrive;

	// Token: 0x040007EE RID: 2030
	private float _oldTargetDistance;

	// Token: 0x040007EF RID: 2031
	private const string _FMODParamSize = "Size";

	// Token: 0x040007F0 RID: 2032
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x040007F1 RID: 2033
	private const string _FMODParamPower = "Power";

	// Token: 0x040007F2 RID: 2034
	private const string _FMODParamResistance = "Resistance";
}
}