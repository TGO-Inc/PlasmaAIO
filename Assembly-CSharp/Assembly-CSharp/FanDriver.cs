using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200007F RID: 127
public class FanDriver : ComponentDriver
{
	// Token: 0x0600068F RID: 1679 RVA: 0x00025DFC File Offset: 0x00023FFC
	public override void Awake()
	{

	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00025E5A File Offset: 0x0002405A
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00025E67 File Offset: 0x00024067
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00025E74 File Offset: 0x00024074
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00025EC8 File Offset: 0x000240C8
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00025F10 File Offset: 0x00024110
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00025F20 File Offset: 0x00024120
	public override void OnPropertyEditorOpen()
	{

	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00025F79 File Offset: 0x00024179
	public override void OnPropertyEditorClose()
	{

	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00025F8C File Offset: 0x0002418C
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00025FEC File Offset: 0x000241EC
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000699 RID: 1689 RVA: 0x000261A0 File Offset: 0x000243A0
	private void Update()
	{

	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00026218 File Offset: 0x00024418
	private bool CheckIfHitValid(RaycastHit hit, out ArticulationBody articulationBody, out Rigidbody theRigidbody)
	{
        articulationBody = default;
        theRigidbody = default;

        return default;
    }

	// Token: 0x0600069B RID: 1691 RVA: 0x000262BB File Offset: 0x000244BB
	private void OnDestroy()
	{

	}

	// Token: 0x040005F3 RID: 1523
	public GameObject bladeMesh;

	// Token: 0x040005F4 RID: 1524
	public Transform boxPreview;

	// Token: 0x040005F5 RID: 1525
	public Transform points;

	// Token: 0x040005F6 RID: 1526
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040005F7 RID: 1527
	public float maxSpeed;

	// Token: 0x040005F8 RID: 1528
	public FloatRange maxForce;

	// Token: 0x040005F9 RID: 1529
	private AgentProperty _speedProperty;

	// Token: 0x040005FA RID: 1530
	private AgentProperty _airflowProperty;

	// Token: 0x040005FB RID: 1531
	private AgentProperty _airflowReachProperty;

	// Token: 0x040005FC RID: 1532
	private int _layers;

	// Token: 0x040005FD RID: 1533
	private const string _FMODParamSpeed = "FanSpeed";

	// Token: 0x040005FE RID: 1534
	private const string _FMODParamSize = "Size";
}
}