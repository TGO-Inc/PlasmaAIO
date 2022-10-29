using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000C8 RID: 200
public class RotationalHingeOtherDriver : ComponentDriver
{
	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000312AC File Offset: 0x0002F4AC
	private ArticulationBody hinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x000312C0 File Offset: 0x0002F4C0
	public override void Awake()
	{

	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00031343 File Offset: 0x0002F543
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00031350 File Offset: 0x0002F550
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00031360 File Offset: 0x0002F560
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x000313C8 File Offset: 0x0002F5C8
	private void SetPhysics()
	{

	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x000314A4 File Offset: 0x0002F6A4
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00031530 File Offset: 0x0002F730
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060008FB RID: 2299 RVA: 0x0003153D File Offset: 0x0002F73D
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00031548 File Offset: 0x0002F748
	public override void OnReset()
	{

	}

	// Token: 0x060008FD RID: 2301 RVA: 0x0003158C File Offset: 0x0002F78C
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00031672 File Offset: 0x0002F872
	public override void OnMount()
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00031674 File Offset: 0x0002F874
	public override void OnUnmount()
	{

	}

	// Token: 0x06000900 RID: 2304 RVA: 0x0003167C File Offset: 0x0002F87C
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x06000901 RID: 2305 RVA: 0x000316EA File Offset: 0x0002F8EA
	private void OnDestroy()
	{

	}

	// Token: 0x04000843 RID: 2115
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000844 RID: 2116
	public float simulatedPowerDelta;

	// Token: 0x04000845 RID: 2117
	public float accelerationKp;

	// Token: 0x04000846 RID: 2118
	public float accelerationKd;

	// Token: 0x04000847 RID: 2119
	public float torqueDelta;

	// Token: 0x04000848 RID: 2120
	private AgentProperty _targetSpeedProperty;

	// Token: 0x04000849 RID: 2121
	private AgentProperty _maxTorqueProperty;

	// Token: 0x0400084A RID: 2122
	private AgentProperty _currentVelocityProperty;

	// Token: 0x0400084B RID: 2123
	private AgentProperty _inversedProperty;

	// Token: 0x0400084C RID: 2124
	private AgentProperty _accelerationProperty;

	// Token: 0x0400084D RID: 2125
	private ArticulationDrive _articulationDrive;

	// Token: 0x0400084E RID: 2126
	private FloatRange _attenuationRange;

	// Token: 0x0400084F RID: 2127
	private PIDController _pidController;

	// Token: 0x04000850 RID: 2128
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x04000851 RID: 2129
	private const string _FMODParamSize = "Size";

	// Token: 0x04000852 RID: 2130
	private const string _FMODParamPower = "Power";

	// Token: 0x04000853 RID: 2131
	private const string _FMODParamFriction = "Friction";

	// Token: 0x04000854 RID: 2132
	private const string _FMODParamIsPushed = "IsPushed";

	// Token: 0x04000855 RID: 2133
	private const string _FMODParamIsBlocked = "IsBlocked";
}
}