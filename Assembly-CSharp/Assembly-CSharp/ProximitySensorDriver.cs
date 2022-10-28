using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000C0 RID: 192
public class ProximitySensorDriver : ComponentDriver
{
	// Token: 0x060008C5 RID: 2245 RVA: 0x00030404 File Offset: 0x0002E604
	public override void Awake()
	{

	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x000305A2 File Offset: 0x0002E7A2
	private void HandleDeviceStateToggled(int guid)
	{

	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x000305C3 File Offset: 0x0002E7C3
	private void HandleProjectileDeleted(PlasmaProjectile projectile)
	{

	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x000305F4 File Offset: 0x0002E7F4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x000306B1 File Offset: 0x0002E8B1
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060008CA RID: 2250 RVA: 0x000306BC File Offset: 0x0002E8BC
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00030734 File Offset: 0x0002E934
	public override void OnPropertyEditorOpen()
	{

	}

	// Token: 0x060008CC RID: 2252 RVA: 0x000307F6 File Offset: 0x0002E9F6
	public override void OnPropertyEditorClose()
	{

	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00030804 File Offset: 0x0002EA04
	public override void OnReset()
	{

	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00030814 File Offset: 0x0002EA14
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00030980 File Offset: 0x0002EB80
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x000309D4 File Offset: 0x0002EBD4
	private string GetEntity(int layer, Device device)
	{

        return default;
    }

	// Token: 0x060008D1 RID: 2257 RVA: 0x00030A0C File Offset: 0x0002EC0C
	public override void OnSensorTriggerEnter(Collider trigger)
	{

	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x00030A94 File Offset: 0x0002EC94
	public override void OnSensorTriggerExit(Collider trigger)
	{

	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x00030B1C File Offset: 0x0002ED1C
	private void UpdateVisuals()
	{

	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00030B7C File Offset: 0x0002ED7C
	private bool CheckIfTriggerValid(Collider trigger, out Device device, out int detectableLayer)
	{
        device = default;
        detectableLayer = default;

        return default;
    }

	// Token: 0x060008D5 RID: 2261 RVA: 0x00030C30 File Offset: 0x0002EE30
	private void CheckForTriggers()
	{

	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00030D97 File Offset: 0x0002EF97
	private void OnDestroy()
	{

	}

	// Token: 0x04000816 RID: 2070
	public MeshRenderer meshRenderer;

	// Token: 0x04000817 RID: 2071
	public SphereCollider sphereSensor;

	// Token: 0x04000818 RID: 2072
	public BoxCollider boxSensor;

	// Token: 0x04000819 RID: 2073
	public GameObject preview;

	// Token: 0x0400081A RID: 2074
	public Transform spherePreview;

	// Token: 0x0400081B RID: 2075
	public Transform boxPreview;

	// Token: 0x0400081C RID: 2076
	private AgentProperty _foundProperty;

	// Token: 0x0400081D RID: 2077
	private AgentProperty _lostProperty;

	// Token: 0x0400081E RID: 2078
	private AgentProperty _detectionsProperty;

	// Token: 0x0400081F RID: 2079
	private AgentProperty _detectablesProperty;

	// Token: 0x04000820 RID: 2080
	private AgentProperty _sensorShapeProperty;

	// Token: 0x04000821 RID: 2081
	private AgentProperty _radiusProperty;

	// Token: 0x04000822 RID: 2082
	private AgentProperty _boxWidthProperty;

	// Token: 0x04000823 RID: 2083
	private AgentProperty _boxLengthProperty;

	// Token: 0x04000824 RID: 2084
	private AgentProperty _boxHeightProperty;

	// Token: 0x04000825 RID: 2085
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000826 RID: 2086
	private int _colorId;

	// Token: 0x04000827 RID: 2087
	private int _detections;

	// Token: 0x04000828 RID: 2088
	private string _enteredEntity;

	// Token: 0x04000829 RID: 2089
	private string _exitedEntity;

	// Token: 0x0400082A RID: 2090
	private Dictionary<int, int> _detectablesLayers;

	// Token: 0x0400082B RID: 2091
	private Dictionary<int, string> _entityLayers;

	// Token: 0x0400082C RID: 2092
	private Collider[] _hitColliders;

	// Token: 0x0400082D RID: 2093
	private HashSet<Device> _triggeredDevices;

	// Token: 0x0400082E RID: 2094
	private HashSet<PlasmaProjectile> _triggeredProjectiles;

	// Token: 0x0400082F RID: 2095
	private const int _maxColliders = 1024;
}
}