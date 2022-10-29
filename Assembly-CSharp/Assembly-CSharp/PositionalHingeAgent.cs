using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000B9 RID: 185
public class PositionalHingeAgent : Agent
{
	// Token: 0x06000875 RID: 2165 RVA: 0x0002F2F4 File Offset: 0x0002D4F4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000876 RID: 2166 RVA: 0x0002F31A File Offset: 0x0002D51A
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000877 RID: 2167 RVA: 0x0002F330 File Offset: 0x0002D530
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x06000878 RID: 2168 RVA: 0x0002F33C File Offset: 0x0002D53C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000879 RID: 2169 RVA: 0x0002F3B4 File Offset: 0x0002D5B4
	[AgentPropertyHandler(1)]
	public void HandleTargetPosition(AgentProperty property)
	{

	}

	// Token: 0x040007DC RID: 2012
	public const float tolerance = 1f;

	// Token: 0x040007DD RID: 2013
	private AgentProperty _targetRotationProperty;

	// Token: 0x040007DE RID: 2014
	private AgentProperty _currentRotationProperty;

	// Token: 0x040007DF RID: 2015
	private bool _canTrigger;

	// Token: 0x040007E0 RID: 2016
	private bool _shouldTrigger;

	// Token: 0x0200037B RID: 891
	public enum Commands
	{
		// Token: 0x04001C36 RID: 7222
		SetPhysics = 1
	}
}
}