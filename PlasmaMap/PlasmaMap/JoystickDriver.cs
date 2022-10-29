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
// Token: 0x02000091 RID: 145
public class JoystickDriver : ComponentDriver
{
	// Token: 0x0600071D RID: 1821 RVA: 0x00028D92 File Offset: 0x00026F92
	public override void Awake()
	{

	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00028DB8 File Offset: 0x00026FB8
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00028E0D File Offset: 0x0002700D
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00028E40 File Offset: 0x00027040
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00028EA0 File Offset: 0x000270A0
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00028EDC File Offset: 0x000270DC
	public override void OnReset()
	{

	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00028EF4 File Offset: 0x000270F4
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000724 RID: 1828 RVA: 0x00028EF7 File Offset: 0x000270F7
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00028F00 File Offset: 0x00027100
	public override void OnInteractionHold(Camera theCamera, Vector2 movement)
	{

	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00028F70 File Offset: 0x00027170
	public override void OnInteractionUp()
	{

	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00028FA2 File Offset: 0x000271A2
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00028FDD File Offset: 0x000271DD
	private void UpdateVisuals()
	{

	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00029014 File Offset: 0x00027214
	private void SetLEDStripColor()
	{

	}

	// Token: 0x04000678 RID: 1656
	public MeshRenderer meshRenderer;

	// Token: 0x04000679 RID: 1657
	public GameObject rotatingGameObject;

	// Token: 0x0400067A RID: 1658
	public float stickMovementSpeed;

	// Token: 0x0400067B RID: 1659
	private float _horizontal;

	// Token: 0x0400067C RID: 1660
	private float _vertical;

	// Token: 0x0400067D RID: 1661
	private const float _maxRotationRange = 45f;

	// Token: 0x0400067E RID: 1662
	private bool _isGrabbed;

	// Token: 0x0400067F RID: 1663
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000680 RID: 1664
	private int _colorId;

	// Token: 0x04000681 RID: 1665
	private AgentProperty _horizonalProperty;

	// Token: 0x04000682 RID: 1666
	private AgentProperty _verticalProperty;

	// Token: 0x04000683 RID: 1667
	private AgentProperty _isGrabbedProperty;

	// Token: 0x04000684 RID: 1668
	private AgentProperty _returnToCenterProperty;
}
}