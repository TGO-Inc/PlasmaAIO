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
// Token: 0x020000B4 RID: 180
public class PistonDriver : ComponentDriver
{
	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000851 RID: 2129 RVA: 0x0002EA9C File Offset: 0x0002CC9C
	private ArticulationBody piston
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0002EAAF File Offset: 0x0002CCAF
	public override void Awake()
	{

	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0002EB1C File Offset: 0x0002CD1C
	private void SetPhysics()
	{

	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0002EC20 File Offset: 0x0002CE20
	public float ConvertFrom01(float position)
	{

        return default;
    }

	// Token: 0x06000856 RID: 2134 RVA: 0x0002EC4C File Offset: 0x0002CE4C
	private float ConvertTo01(float position)
	{

        return default;
    }

	// Token: 0x06000857 RID: 2135 RVA: 0x0002EC78 File Offset: 0x0002CE78
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0002ECB5 File Offset: 0x0002CEB5
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0002ECC2 File Offset: 0x0002CEC2
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0002ECCC File Offset: 0x0002CECC
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0002EE57 File Offset: 0x0002D057
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x0600085D RID: 2141 RVA: 0x0002EE6D File Offset: 0x0002D06D
	public override float GetLimit(bool unscale = false)
	{

        return default;
    }

	// Token: 0x040007AD RID: 1965
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040007AE RID: 1966
	public float maxMotorSpeed;

	// Token: 0x040007AF RID: 1967
	public float maxMotorForce;

	// Token: 0x040007B0 RID: 1968
	public PIDController positionPidController;

	// Token: 0x040007B1 RID: 1969
	public float simulatedMotorDelta;

	// Token: 0x040007B2 RID: 1970
	public float simulatedMaxMotorSpeed;

	// Token: 0x040007B3 RID: 1971
	private AgentProperty _targetPositionProperty;

	// Token: 0x040007B4 RID: 1972
	private AgentProperty _forceProperty;

	// Token: 0x040007B5 RID: 1973
	private AgentProperty _maxSpeedProperty;

	// Token: 0x040007B6 RID: 1974
	private AgentProperty _currentPositionProperty;

	// Token: 0x040007B7 RID: 1975
	private ArticulationDrive _articulationDrive;

	// Token: 0x040007B8 RID: 1976
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x040007B9 RID: 1977
	private const string _FMODParamSize = "Size";
}
}