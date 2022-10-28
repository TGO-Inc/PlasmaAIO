using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x020001AA RID: 426
public class CameraFakeControllerFPS : MonoBehaviour
{
	// Token: 0x06000FDF RID: 4063 RVA: 0x0005350C File Offset: 0x0005170C
	private void Awake()
	{

	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0005359C File Offset: 0x0005179C
	private Bounds CalculateObjectBounds(GameObject gob)
	{

        return default;
    }

	// Token: 0x06000FE1 RID: 4065 RVA: 0x000535E8 File Offset: 0x000517E8
	private void ShrinkObject()
	{

	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x000535F4 File Offset: 0x000517F4
	private void ExpandObject()
	{

	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00053600 File Offset: 0x00051800
	public void Update()
	{

	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0005396A File Offset: 0x00051B6A
	private float ClampAngle(float angle, float min, float max)
	{

        return default;
    }

	// Token: 0x04000D6D RID: 3437
	public GameObject attachedObject;

	// Token: 0x04000D6E RID: 3438
	public float minDistance;

	// Token: 0x04000D6F RID: 3439
	public float maxDistance;

	// Token: 0x04000D70 RID: 3440
	public GameObject debugSphere;

	// Token: 0x04000D71 RID: 3441
	public GameObject plasmaPrefab;

	// Token: 0x04000D72 RID: 3442
	public Text debugText;

	// Token: 0x04000D73 RID: 3443
	public float speed;

	// Token: 0x04000D74 RID: 3444
	public float rotationSensitivity = 3f;

	// Token: 0x04000D75 RID: 3445
	public float yMinLimit = -89f;

	// Token: 0x04000D76 RID: 3446
	public float yMaxLimit = 89f;

	// Token: 0x04000D77 RID: 3447
	public float objectPositionSmooth;

	// Token: 0x04000D78 RID: 3448
	public float wheelMUL = 10f;

	// Token: 0x04000D79 RID: 3449
	public float currentDistance;

	// Token: 0x04000D7A RID: 3450
	public GameObject plasmaObject;

	// Token: 0x04000D7B RID: 3451
	public Vector3 wantedObjectPosition;

	// Token: 0x04000D7C RID: 3452
	public int currentRay;

	// Token: 0x04000D7D RID: 3453
	public PlasmaRay plasmaRay;

	// Token: 0x04000D7E RID: 3454
	public Bounds objectBounds;

	// Token: 0x04000D7F RID: 3455
	private float x;

	// Token: 0x04000D80 RID: 3456
	private float y;

	// Token: 0x04000D81 RID: 3457
	private bool locked;

	// Token: 0x04000D82 RID: 3458
	private Vector3 vout;
}
}