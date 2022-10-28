using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000AD RID: 173
public class NFCInterfaceDriver : ComponentDriver
{
	// Token: 0x0600081F RID: 2079 RVA: 0x0002DF7E File Offset: 0x0002C17E
	public override void Awake()
	{

	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0002DFBE File Offset: 0x0002C1BE
	private void HandleDeviceStateToggled(int guid)
	{

	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000822 RID: 2082 RVA: 0x0002E04F File Offset: 0x0002C24F
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000823 RID: 2083 RVA: 0x0002E057 File Offset: 0x0002C257
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000824 RID: 2084 RVA: 0x0002E07C File Offset: 0x0002C27C
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000825 RID: 2085 RVA: 0x0002E0E0 File Offset: 0x0002C2E0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
	public override void OnSensorTriggerEnter(Collider trigger)
	{

	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0002E200 File Offset: 0x0002C400
	public override void OnSensorTriggerExit(Collider trigger)
	{

	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0002E234 File Offset: 0x0002C434
	private void SetLEDStripColor()
	{

	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0002E274 File Offset: 0x0002C474
	private bool CheckIfTagValid(Collider trigger, out NFCTagDriver nfcTag)
	{
        nfcTag = default;

        return default;
    }

	// Token: 0x0600082A RID: 2090 RVA: 0x0002E2DC File Offset: 0x0002C4DC
	private void CheckForTags()
	{

	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0002E36A File Offset: 0x0002C56A
	private void OnDestroy()
	{

	}

	// Token: 0x0400077E RID: 1918
	public MeshRenderer meshRenderer;

	// Token: 0x0400077F RID: 1919
	public BoxCollider sensor;

	// Token: 0x04000780 RID: 1920
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000781 RID: 1921
	private AgentProperty _valueProperty;

	// Token: 0x04000782 RID: 1922
	private AgentProperty _pendingProperty;

	// Token: 0x04000783 RID: 1923
	private AgentProperty _autoreadProperty;

	// Token: 0x04000784 RID: 1924
	private AgentProperty _channelProperty;

	// Token: 0x04000785 RID: 1925
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x04000786 RID: 1926
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000787 RID: 1927
	private int _colorId;

	// Token: 0x04000788 RID: 1928
	private const int _maxTags = 8;

	// Token: 0x04000789 RID: 1929
	private Collider[] _hitColliders;

	// Token: 0x0400078A RID: 1930
	private NFCTagDriver _detectedTag;

	// Token: 0x0400078B RID: 1931
	private bool _valueRead;

	// Token: 0x0400078C RID: 1932
	private bool _shouldRead;

	// Token: 0x0400078D RID: 1933
	private bool _shouldWrite;
}
}