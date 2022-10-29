using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200008F RID: 143
public class ImpactSensorDriver : ComponentDriver
{
	// Token: 0x06000711 RID: 1809 RVA: 0x0002881C File Offset: 0x00026A1C
	public override void Awake()
	{

	}

	// Token: 0x06000712 RID: 1810 RVA: 0x000289A8 File Offset: 0x00026BA8
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00028A10 File Offset: 0x00026C10
	public override void OnSensorCollisionEnter(Collision collision, DeviceComponentModifier modifier)
	{

	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00028A9C File Offset: 0x00026C9C
	private bool CheckIfCollisionValid(Collision collision, out ComponentHandler component, out int detectableLayer)
	{
        component = default;
        detectableLayer = default;

        return default;
    }

	// Token: 0x06000715 RID: 1813 RVA: 0x00028B48 File Offset: 0x00026D48
	private string GetEntity(int layer, ComponentHandler component)
	{

        return default;
    }

	// Token: 0x06000716 RID: 1814 RVA: 0x00028B84 File Offset: 0x00026D84
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x04000664 RID: 1636
	private AgentProperty _collisionBeginProperty;

	// Token: 0x04000665 RID: 1637
	private AgentProperty _hitForceProperty;

	// Token: 0x04000666 RID: 1638
	private AgentProperty _hitComponentProperty;

	// Token: 0x04000667 RID: 1639
	private AgentProperty _hitEntityProperty;

	// Token: 0x04000668 RID: 1640
	private AgentProperty _detectablesProperty;

	// Token: 0x04000669 RID: 1641
	private Dictionary<int, int> _detectablesLayers;

	// Token: 0x0400066A RID: 1642
	private Dictionary<int, string> _entityLayers;

	// Token: 0x0400066B RID: 1643
	private bool _hasBegunImpact;

	// Token: 0x0400066C RID: 1644
	private float _hitForce;

	// Token: 0x0400066D RID: 1645
	private string _hitComponentName;

	// Token: 0x0400066E RID: 1646
	private string _hitEntityName;

	// Token: 0x0400066F RID: 1647
	private int _projectilesLayer;
}
}