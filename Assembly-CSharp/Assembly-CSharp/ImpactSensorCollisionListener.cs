using System;
using System.Linq;
using UnityEngine;

// Token: 0x02000173 RID: 371
public class ImpactSensorCollisionListener : DeviceComponentModifier
{
	// Token: 0x06000E3D RID: 3645 RVA: 0x00048B74 File Offset: 0x00046D74
	public override void OnComponentSet()
	{

	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00048B91 File Offset: 0x00046D91
	public void OnCollisionEnter(Collision collision)
	{

	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00048BAE File Offset: 0x00046DAE
	public void OnCollisionStay(Collision collision)
	{

	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00048BCB File Offset: 0x00046DCB
	public void OnCollisionExit(Collision collision)
	{

	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00048BE8 File Offset: 0x00046DE8
	private bool Allow(Collision collision)
	{

        return default;
    }

	// Token: 0x04000BCC RID: 3020
	private Collider[] _colliders;
}
