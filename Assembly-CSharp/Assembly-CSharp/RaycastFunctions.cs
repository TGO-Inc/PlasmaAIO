using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000181 RID: 385
public static class RaycastFunctions
{
	// Token: 0x06000E8A RID: 3722 RVA: 0x0004A3C9 File Offset: 0x000485C9
	public static void Setup()
	{

	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x0004A3D8 File Offset: 0x000485D8
	public static Vector3? ComponentRaycastWithRay<T>(Ray ray, int layerMask, out Vector3 angle, out float distance, out T hitComponent, float rayCastDistance, bool averageNormal = true)
	{
        angle = default;
        distance = default;
        hitComponent = default;

        return default;
    }

	// Token: 0x06000E8C RID: 3724 RVA: 0x0004A59C File Offset: 0x0004879C
	public static float DistanceFromTerrain(Ray ray, int layerMask)
	{

        return default;
    }

	// Token: 0x06000E8D RID: 3725 RVA: 0x0004A668 File Offset: 0x00048868
	public static float PlayerDistanceFromTerrain(Ray ray, int layerMask, Device ignoreDevice, ref Vector3 point)
	{

        return default;
    }

	// Token: 0x06000E8E RID: 3726 RVA: 0x0004A714 File Offset: 0x00048914
	public static Vector3? TerrainRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000E8F RID: 3727 RVA: 0x0004A7E0 File Offset: 0x000489E0
	public static Transform FindCollider(Ray ray, int layerMask, string tag = null)
	{

        return default;
    }

	// Token: 0x06000E90 RID: 3728 RVA: 0x0004A820 File Offset: 0x00048A20
	public static Vector3? FindPointOnCollider(Ray ray, int layerMask, out Vector3 angle)
	{
        angle = default;

        return default;
    }

	// Token: 0x06000E91 RID: 3729 RVA: 0x0004A840 File Offset: 0x00048A40
	public static List<DynamicGridProjector> DynamicGridRaycast(Camera camera)
	{

        return default;
    }

	// Token: 0x06000E92 RID: 3730 RVA: 0x0004A9D0 File Offset: 0x00048BD0
	public static FemaleSocketPoint FindSocket(Ray ray, Camera camera, float maxDistance)
	{

        return default;
    }

	// Token: 0x04000C04 RID: 3076
	private const float maxRayCastDistance = 1000f;

	// Token: 0x04000C05 RID: 3077
	private static RaycastHit[] _hits;
}
}