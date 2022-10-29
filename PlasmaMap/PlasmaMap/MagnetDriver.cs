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
// Token: 0x020000A9 RID: 169
public class MagnetDriver : ComponentDriver
{
	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060007EF RID: 2031 RVA: 0x0002C839 File Offset: 0x0002AA39
	public float force
	{
		get
		{
			return this._force;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0002C841 File Offset: 0x0002AA41
	public bool isPolarityInverted
	{
		get
		{
			return this._polarityInverted;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0002C849 File Offset: 0x0002AA49
	public float range
	{
		get
		{
			return this._rangeProperty.GetValueNumberAsFloat();
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0002C858 File Offset: 0x0002AA58
	public override void Awake()
	{

	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x0002C8D4 File Offset: 0x0002AAD4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x0002C93A File Offset: 0x0002AB3A
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x0002C942 File Offset: 0x0002AB42
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0002C94C File Offset: 0x0002AB4C
	public override void OnSensorTriggerStay(Collider trigger)
	{

	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x0002CA5C File Offset: 0x0002AC5C
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x0002CB90 File Offset: 0x0002AD90
	public override void OnPropertyEditorOpen()
	{

	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0002CBCD File Offset: 0x0002ADCD
	public override void OnPropertyEditorClose()
	{

	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0002CC4F File Offset: 0x0002AE4F
	private void SetPhysics()
	{

	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0002CC90 File Offset: 0x0002AE90
	private bool IsValidMagnet(Collider triggerCollider)
	{

        return default;
    }

	// Token: 0x060007FD RID: 2045 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
	private void UpdateVisuals()
	{

	}

	// Token: 0x0400074F RID: 1871
	public MeshRenderer meshRenderer;

	// Token: 0x04000750 RID: 1872
	public Transform forcePosition;

	// Token: 0x04000751 RID: 1873
	public Transform rangePreview;

	// Token: 0x04000752 RID: 1874
	public SphereCollider sensorSphereCollider;

	// Token: 0x04000753 RID: 1875
	public float maxForce;

	// Token: 0x04000754 RID: 1876
	public Collider frictionCollider;

	// Token: 0x04000755 RID: 1877
	private bool _applyForce;

	// Token: 0x04000756 RID: 1878
	private float _force;

	// Token: 0x04000757 RID: 1879
	private float _otherMagnetForce;

	// Token: 0x04000758 RID: 1880
	private float _otherMagnetRange;

	// Token: 0x04000759 RID: 1881
	private bool _polarityInverted;

	// Token: 0x0400075A RID: 1882
	private Vector3 _offset;

	// Token: 0x0400075B RID: 1883
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400075C RID: 1884
	private int _colorIdPlus;

	// Token: 0x0400075D RID: 1885
	private int _colorIdMinus;

	// Token: 0x0400075E RID: 1886
	private AgentProperty _polarityProperty;

	// Token: 0x0400075F RID: 1887
	private AgentProperty _stateProperty;

	// Token: 0x04000760 RID: 1888
	private AgentProperty _forceProperty;

	// Token: 0x04000761 RID: 1889
	private AgentProperty _rangeProperty;

	// Token: 0x04000762 RID: 1890
	private PhysicMaterial _highFrictionMaterial;

	// Token: 0x04000763 RID: 1891
	private bool _usingHighFrictionMaterial;
}
}