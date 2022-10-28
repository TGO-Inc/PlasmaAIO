using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Sirenix.Serialization;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000174 RID: 372
public class MechanicState
{
	// Token: 0x06000E43 RID: 3651 RVA: 0x00048C41 File Offset: 0x00046E41
	public MechanicState()
	{

	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00048C60 File Offset: 0x00046E60
	public MechanicState(MechanicState state)
	{

	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00048CDC File Offset: 0x00046EDC
	public void Reset(Device device)
	{

	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00048DBC File Offset: 0x00046FBC
	public void CreateDefaults(Vector3 basePosition, Quaternion baseRotation, int baseComponentGuid, ComponentHandler componentHandler = null)
	{

	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00048E18 File Offset: 0x00047018
	public void CreateDefaults(Device device)
	{

	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00048E90 File Offset: 0x00047090
	public byte[] ToBytes()
	{

        return default;
    }

	// Token: 0x06000E49 RID: 3657 RVA: 0x00048E9A File Offset: 0x0004709A
	public static MechanicState Load(byte[] bytes)
	{

        return default;
    }

	// Token: 0x06000E4A RID: 3658 RVA: 0x00048EAC File Offset: 0x000470AC
	public static MechanicState GenerateMechanicState(Device device)
	{

        return default;
    }

	// Token: 0x06000E4B RID: 3659 RVA: 0x000492A4 File Offset: 0x000474A4
	public MechanicState.MechanicStateArticulation ArticulatorForBaseComponentWithGuid(int guid)
	{

        return default;
    }

	// Token: 0x06000E4C RID: 3660 RVA: 0x00049300 File Offset: 0x00047500
	public MechanicState.ComponentState GetComponentState(int componentGuid)
	{

        return default;
    }

	// Token: 0x06000E4D RID: 3661 RVA: 0x0004935C File Offset: 0x0004755C
	public void AddArticulation(MechanicState.MechanicStateArticulation newArticulation)
	{

	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x0004936C File Offset: 0x0004756C
	public void Merge(MechanicState otherMechanicState, int currentGuid, int newGuid)
	{

	}

	// Token: 0x04000BCD RID: 3021
	public List<MechanicState.MechanicStateArticulation> articulations;

	// Token: 0x04000BCE RID: 3022
	public List<MechanicState.ComponentState> componentStates;

	// Token: 0x020003BA RID: 954
	public class ComponentState
	{
		// Token: 0x060020DA RID: 8410 RVA: 0x000A2048 File Offset: 0x000A0248
		public ComponentState()
		{

		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000A205C File Offset: 0x000A025C
		public ComponentState(ComponentHandler componentHandler)
		{

		}

		// Token: 0x060020DC RID: 8412 RVA: 0x000A20B8 File Offset: 0x000A02B8
		public ComponentState(MechanicState.ComponentState state)
		{

		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000A2148 File Offset: 0x000A0348
		public float[] GetRawPosVars(int index)
		{

            return default;
        }

		// Token: 0x060020DE RID: 8414 RVA: 0x000A219A File Offset: 0x000A039A
		public float[] GetRawDofVars(int index)
		{

            return default;
        }

		// Token: 0x060020DF RID: 8415 RVA: 0x000A21B0 File Offset: 0x000A03B0
		public void Reset()
		{

		}

		// Token: 0x04001D26 RID: 7462
		public int guid;

		// Token: 0x04001D27 RID: 7463
		public Dictionary<int, MechanicState.SubComponentState> subComponentStates;
	}

	// Token: 0x020003BB RID: 955
	public class SubComponentState
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x000A2214 File Offset: 0x000A0414
		public SubComponentState()
		{

		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000A2240 File Offset: 0x000A0440
		public SubComponentState(MechanicState.SubComponentState state)
		{

		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000A22B4 File Offset: 0x000A04B4
		public void Reset()
		{

		}

		// Token: 0x04001D28 RID: 7464
		public int subComponentIndex;

		// Token: 0x04001D29 RID: 7465
		public float[] stateRawPosVars;

		// Token: 0x04001D2A RID: 7466
		public float[] stateRawVelVars;

		// Token: 0x04001D2B RID: 7467
		public bool supportsScaling;

		// Token: 0x04001D2C RID: 7468
		public Vector3 axisA;

		// Token: 0x04001D2D RID: 7469
		public Vector3 axisB;

		// Token: 0x04001D2E RID: 7470
		public float[] relativePositions;

		// Token: 0x04001D2F RID: 7471
		public Quaternion localRotation;
	}

	// Token: 0x020003BC RID: 956
	public class MechanicStateArticulation
	{
		// Token: 0x060020E3 RID: 8419 RVA: 0x000A2334 File Offset: 0x000A0534
		public MechanicStateArticulation()
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000A233C File Offset: 0x000A053C
		public MechanicStateArticulation(ComponentHandler componentHandler)
		{

		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000A2370 File Offset: 0x000A0570
		public MechanicStateArticulation(MechanicState.MechanicStateArticulation articulation)
		{

		}

		// Token: 0x04001D30 RID: 7472
		public int baseComponentGuid;

		// Token: 0x04001D31 RID: 7473
		public Vector3 baseRawPosition;

		// Token: 0x04001D32 RID: 7474
		public Vector3 baseRawLinearVelocity;

		// Token: 0x04001D33 RID: 7475
		public Vector3 baseRawAngleVelocity;

		// Token: 0x04001D34 RID: 7476
		public Quaternion baseRawOrientation;

		// Token: 0x04001D35 RID: 7477
		public Vector3 relativeBaseLinearVelocity;

		// Token: 0x04001D36 RID: 7478
		public Vector3 relativeBaseAngularVelocity;
	}

	// Token: 0x020003BD RID: 957
	private struct ChildLinkAndItsStateDesc
	{
		// Token: 0x04001D37 RID: 7479
		public int m_linkIndex;

		// Token: 0x04001D38 RID: 7480
		public int m_dofCount;

		// Token: 0x04001D39 RID: 7481
		public int m_dofOffset;

		// Token: 0x04001D3A RID: 7482
		public float position;

		// Token: 0x04001D3B RID: 7483
		public float velocity;
	}
}
}