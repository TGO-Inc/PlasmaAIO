using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200003E RID: 62
public static class MechanicFunctions
{
	// Token: 0x060001DE RID: 478 RVA: 0x0000C29B File Offset: 0x0000A49B
	public static void Setup()
	{

	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000C2AC File Offset: 0x0000A4AC
	private static SnappingGeneric DoSnappingGenericRaycast(Camera camera, Quaternion cameraOffset, ref SubComponentHandler candidateSubComponent, float maxDistance)
	{

        return default;
    }

	// Token: 0x060001E0 RID: 480 RVA: 0x0000C37C File Offset: 0x0000A57C
	public static SubComponentHandler UpdateComponentPosition(RigidbodyCharacter character, ComponentHandler component, float componentDistanceFromCamera, Quaternion cameraOffset, ref Vector3 endPosition, ref Quaternion endRotation, ref Vector3 positionReferenceFrame, ref Quaternion rotationReferenceFrame, bool skipRaycasting, bool disableGrid, List<DynamicGridProjector> dynamicGridProjectors, out DynamicGridProjector chosenGridProjector, ref SnappingGeneric snappingObject, Vector3 posOffset, Quaternion newBaseRotation, bool setTransforms = true)
	{
        chosenGridProjector = default;

        return default;
    }

	// Token: 0x060001E1 RID: 481 RVA: 0x0000C90C File Offset: 0x0000AB0C
	public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation)
	{

        return default;
    }

	// Token: 0x060001E2 RID: 482 RVA: 0x0000C924 File Offset: 0x0000AB24
	public static void CopyArticulationBodyForSwapping(ArticulationBody childOldArticulationBody, ArticulationBody parentOldArticulationBody)
	{

	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000CA88 File Offset: 0x0000AC88
	public static void RebaseDeviceFromSubComponent(Device device, SubComponentHandler subComponentHandler, SubComponentHandler parentSubComponent)
	{

	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
	private static void MergeUpstreamAfterRebase(ComponentHandler component)
	{

	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
	private static void RebaseComponent(SubComponentHandler subComponentHandler, SubComponentHandler newParentSubComponent)
	{

	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0000D170 File Offset: 0x0000B370
	public static Articulation SplitDeviceAtComponent(ComponentHandler component, Device newDevice)
	{

        return default;
    }

	// Token: 0x060001E7 RID: 487 RVA: 0x0000D650 File Offset: 0x0000B850
	public static void FixUpHierarchyAfterRebase(Device device)
	{

	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
	public static void MergeArticulations(SubComponentHandler childSubComponent, SubComponentHandler parentSubComponent)
	{

	}

	// Token: 0x04000213 RID: 531
	private static RaycastHit[] _hits;
}
}