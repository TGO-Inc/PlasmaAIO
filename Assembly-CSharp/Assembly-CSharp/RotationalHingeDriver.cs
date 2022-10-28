using System;
using FMODUnity;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public class RotationalHingeDriver : ComponentDriver
{
	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00030E49 File Offset: 0x0002F049
	private ArticulationBody hinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00030E5C File Offset: 0x0002F05C
	public override void Awake()
	{

	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00030EB9 File Offset: 0x0002F0B9
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00030EC6 File Offset: 0x0002F0C6
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00030ED4 File Offset: 0x0002F0D4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00030F3C File Offset: 0x0002F13C
	private void SetPhysics()
	{

	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00030FD4 File Offset: 0x0002F1D4
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00031011 File Offset: 0x0002F211
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x0003101E File Offset: 0x0002F21E
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00031028 File Offset: 0x0002F228
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060008EB RID: 2283 RVA: 0x000311CC File Offset: 0x0002F3CC
	public override void OnMount()
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x000311CE File Offset: 0x0002F3CE
	public override void OnUnmount()
	{

	}

	// Token: 0x060008ED RID: 2285 RVA: 0x000311D8 File Offset: 0x0002F3D8
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x060008EE RID: 2286 RVA: 0x00031246 File Offset: 0x0002F446
	private void OnDestroy()
	{

	}

	// Token: 0x04000831 RID: 2097
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000832 RID: 2098
	public float simulatedPowerDelta;

	// Token: 0x04000833 RID: 2099
	public FloatRange attenuationRange;

	// Token: 0x04000834 RID: 2100
	public float attenuationMinDistance;

	// Token: 0x04000835 RID: 2101
	private AgentProperty _inversedProperty;

	// Token: 0x04000836 RID: 2102
	private AgentProperty _powerProperty;

	// Token: 0x04000837 RID: 2103
	private AgentProperty _maxTorqueProperty;

	// Token: 0x04000838 RID: 2104
	private AgentProperty _currentVelocityProperty;

	// Token: 0x04000839 RID: 2105
	private AgentProperty _frictionProperty;

	// Token: 0x0400083A RID: 2106
	private ArticulationReducedSpace _articulationReducedSpace;

	// Token: 0x0400083B RID: 2107
	private ArticulationDrive _articulationDrive;

	// Token: 0x0400083C RID: 2108
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x0400083D RID: 2109
	private const string _FMODParamSize = "Size";

	// Token: 0x0400083E RID: 2110
	private const string _FMODParamPower = "Power";

	// Token: 0x0400083F RID: 2111
	private const string _FMODParamFriction = "Friction";

	// Token: 0x04000840 RID: 2112
	private const string _FMODParamIsPushed = "IsPushed";

	// Token: 0x04000841 RID: 2113
	private const string _FMODParamIsBlocked = "IsBlocked";
}
