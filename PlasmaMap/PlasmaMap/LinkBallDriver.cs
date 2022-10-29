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
// Token: 0x020000A7 RID: 167
public class LinkBallDriver : ComponentDriver
{
	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0002C4F2 File Offset: 0x0002A6F2
	private ArticulationBody ballLink
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x0002C505 File Offset: 0x0002A705
	public override void Awake()
	{

	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x0002C528 File Offset: 0x0002A728
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x0002C5A4 File Offset: 0x0002A7A4
	private void SetPhysics()
	{

	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0002C6B7 File Offset: 0x0002A8B7
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x0002C6BF File Offset: 0x0002A8BF
	public override void OnReset()
	{

	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0002C6D7 File Offset: 0x0002A8D7
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0002C6E0 File Offset: 0x0002A8E0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0002C80C File Offset: 0x0002AA0C
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x060007EC RID: 2028 RVA: 0x0002C822 File Offset: 0x0002AA22
	public override float GetLimit(bool unscaled = false)
	{

        return default;
    }

	// Token: 0x04000743 RID: 1859
	public float maxMotorSpeed;

	// Token: 0x04000744 RID: 1860
	public float maxMotorTorque;

	// Token: 0x04000745 RID: 1861
	public PIDController positionHorizontalPidController;

	// Token: 0x04000746 RID: 1862
	public PIDController positionVerticalPidController;

	// Token: 0x04000747 RID: 1863
	private AgentProperty _targetHorizontalPositionProperty;

	// Token: 0x04000748 RID: 1864
	private AgentProperty _targetVerticalPositionProperty;

	// Token: 0x04000749 RID: 1865
	private AgentProperty _torqueProperty;

	// Token: 0x0400074A RID: 1866
	private AgentProperty _speedProperty;

	// Token: 0x0400074B RID: 1867
	private AgentProperty _currentHorizontalPositionProperty;

	// Token: 0x0400074C RID: 1868
	private AgentProperty _currentVerticalPositionProperty;

	// Token: 0x0400074D RID: 1869
	private ArticulationDrive _articulationYDrive;

	// Token: 0x0400074E RID: 1870
	private ArticulationDrive _articulationZDrive;
}
}