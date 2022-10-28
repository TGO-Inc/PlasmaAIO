using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

// Token: 0x02000083 RID: 131
public class FrontalExtenderDriver : ComponentDriver
{
	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x00026578 File Offset: 0x00024778
	private ArticulationBody extender
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x0002658C File Offset: 0x0002478C
	public override void Awake()
	{

	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000265F9 File Offset: 0x000247F9
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00026606 File Offset: 0x00024806
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00026614 File Offset: 0x00024814
	public float ConvertFrom01(float position)
	{

        return default;
    }

	// Token: 0x060006B3 RID: 1715 RVA: 0x00026644 File Offset: 0x00024844
	private float ConvertTo01(float position)
	{

        return default;
    }

	// Token: 0x060006B4 RID: 1716 RVA: 0x00026668 File Offset: 0x00024868
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x000266C4 File Offset: 0x000248C4
	private void SetPhysics()
	{

	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000267CD File Offset: 0x000249CD
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000267E0 File Offset: 0x000249E0
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00026820 File Offset: 0x00024A20
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00026848 File Offset: 0x00024A48
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000269C8 File Offset: 0x00024BC8
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00026A75 File Offset: 0x00024C75
	public override void OnScaleChanged()
	{

	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00026A84 File Offset: 0x00024C84
	private IEnumerator DelayedUpdateVisuals()
	{

        return default;
    }

	// Token: 0x060006BD RID: 1725 RVA: 0x00026A94 File Offset: 0x00024C94
	private void SetLEDStripColor()
	{

	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00026B1C File Offset: 0x00024D1C
	private void UpdateVisuals()
	{

	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00026C4C File Offset: 0x00024E4C
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x060006C0 RID: 1728 RVA: 0x00026C62 File Offset: 0x00024E62
	public override float GetLimit(bool unscale = false)
	{

        return default;
    }

	// Token: 0x060006C1 RID: 1729 RVA: 0x00026C83 File Offset: 0x00024E83
	private void OnDestroy()
	{

	}

	// Token: 0x0400060A RID: 1546
	public StudioEventEmitter FMODEmitter;

	// Token: 0x0400060B RID: 1547
	public Transform beam;

	// Token: 0x0400060C RID: 1548
	public float maxMotorSpeed;

	// Token: 0x0400060D RID: 1549
	public float maxMotorForce;

	// Token: 0x0400060E RID: 1550
	public PIDController positionPidController;

	// Token: 0x0400060F RID: 1551
	public MeshRenderer meshRenderer1;

	// Token: 0x04000610 RID: 1552
	public MeshRenderer meshRenderer2;

	// Token: 0x04000611 RID: 1553
	public float simulatedMotorDelta;

	// Token: 0x04000612 RID: 1554
	public float simulatedMaxMotorSpeed;

	// Token: 0x04000613 RID: 1555
	private AgentProperty _targetPositionProperty;

	// Token: 0x04000614 RID: 1556
	private AgentProperty _forceProperty;

	// Token: 0x04000615 RID: 1557
	private AgentProperty _maxSpeedProperty;

	// Token: 0x04000616 RID: 1558
	private AgentProperty _currentPositionProperty;

	// Token: 0x04000617 RID: 1559
	private ArticulationDrive _articulationDrive;

	// Token: 0x04000618 RID: 1560
	private Transform _beamsParent;

	// Token: 0x04000619 RID: 1561
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400061A RID: 1562
	private int _colorId;

	// Token: 0x0400061B RID: 1563
	private const float _extension = 0.115f;

	// Token: 0x0400061C RID: 1564
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x0400061D RID: 1565
	private const string _FMODParamPower = "Power";

	// Token: 0x0400061E RID: 1566
	private const string _FMODParamSize = "Size";

	// Token: 0x0400061F RID: 1567
	private const string _FMODParamIsBlocked = "IsBlocked";
}
