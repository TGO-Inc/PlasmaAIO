using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Common.Extension;
using PlasmaAPI.GameClass.Common.Math;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200002A RID: 42
public class ComponentRotator : MonoBehaviour
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000CB RID: 203 RVA: 0x00005FA9 File Offset: 0x000041A9
	// (set) Token: 0x060000CC RID: 204 RVA: 0x00005FB1 File Offset: 0x000041B1
	private bool reverseRotation { get; set; }

	// Token: 0x060000CD RID: 205 RVA: 0x00005FBC File Offset: 0x000041BC
	public void OnMouseDownCallback(Transform cameraIn)
	{

	}

	// Token: 0x060000CE RID: 206 RVA: 0x00006230 File Offset: 0x00004430
	public void OnMouseUpCallback()
	{

	}

	// Token: 0x060000CF RID: 207 RVA: 0x00006250 File Offset: 0x00004450
	public Vector3 OnMouseDragCallback(Vector2 deltaMouse)
	{

        return default;
    }

	// Token: 0x060000D0 RID: 208 RVA: 0x000064B8 File Offset: 0x000046B8
	private Vector3 ClampToHalfSphere(Vector3 cameraToTargetAngleAxis, Vector3 to, Vector3 clampingNormal, Vector3 refToCamera)
	{

        return default;
    }

	// Token: 0x060000D1 RID: 209 RVA: 0x00006574 File Offset: 0x00004774
	private void DynamicClampToHalfSphere(Vector3 oldAngleAxis, Vector3 newAngleAxis, Vector3 clampingNormal, Vector3 refDir, out Vector3 clampedUp, out Vector3 clampedAngleAxis)
	{
        clampedUp = default;
        clampedAngleAxis = default;

	}

	// Token: 0x060000D2 RID: 210 RVA: 0x000066FC File Offset: 0x000048FC
	private Vector2 CalcMouseControlPointFromUpVector(Vector3 camera, Vector3 cameraUp, Vector3 socket, bool isReversed, Vector3 upVector)
	{

        return default;
    }

	// Token: 0x060000D3 RID: 211 RVA: 0x00006754 File Offset: 0x00004954
	private static Vector3 CalcUpVectorFromMouseControlPoint(Vector3 camera, Vector3 cameraUp, Vector3 socket, bool isReversed, Vector2 mouseControlPoint, out Vector3 angleAxisOut)
	{
        angleAxisOut = default;

        return default;
    }

	// Token: 0x060000D4 RID: 212 RVA: 0x000067C4 File Offset: 0x000049C4
	private void OnDrawGizmos()
	{

	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000069E4 File Offset: 0x00004BE4
	private Vector2 UpdateFlipping(Vector2 updatedControlPoint)
	{

        return default;
    }

	// Token: 0x060000D6 RID: 214 RVA: 0x00006A9C File Offset: 0x00004C9C
	private Vector2 UpdateMirroring(Vector2 mouseControlPoint, Vector2 mouseDelta)
	{

        return default;
    }

	// Token: 0x060000D7 RID: 215 RVA: 0x00006B08 File Offset: 0x00004D08
	private void UpadateLimiterColor(bool updateAlpha = true)
	{

	}

	// Token: 0x040000EF RID: 239
	public ComponentRotatorSettings settings;

	// Token: 0x040000F0 RID: 240
	public ComponentRotator.Mode mode;

	// Token: 0x040000F1 RID: 241
	[Tooltip("Min angle from camera direction to socket's reference up direction, to allow reversed attachment control. Value of 180f effectively disables rotation")]
	[Range(90f, 180f)]
	public float minSocketAngleForReversing = 125f;

	// Token: 0x040000F2 RID: 242
	[Tooltip("Min angle from camera direction to attachment's reference up direction, to allow reversed attachment control. Value of 0f means attachment rotation is ignored.")]
	[Range(0f, 180f)]
	public float minAttachmentAngleForReversing;

	// Token: 0x040000F3 RID: 243
	[Tooltip("When angle from camera direction to socket's reference up direction is above this, control projection will be rotated. This is only applied for non-reversed control")]
	[Range(0f, 90f)]
	public float maxControlAngle = 67.5f;

	// Token: 0x040000F4 RID: 244
	[Tooltip("Min angle to enable stabilization of attachment control direction is stabilized when sliding along limit. This is to prevent attachment 'escaping' easily to backward 180 deg rotation.")]
	[Range(90f, 180f)]
	public float minAngleToEnableStabilization = 135f;

	// Token: 0x040000F5 RID: 245
	public float mouseDeltaMultiplier = 6f;

	// Token: 0x040000F6 RID: 246
	public bool drawGizmo;

	// Token: 0x040000F7 RID: 247
	public bool drawLimitGizmo;

	// Token: 0x040000F8 RID: 248
	public bool drawGravityGun;

	// Token: 0x040000F9 RID: 249
	[Header("Exposed for Debug")]
	public float rollAngle;

	// Token: 0x040000FA RID: 250
	public RotatorProcessData processData = new RotatorProcessData();

	// Token: 0x040000FC RID: 252
	private Vector3 cameraPosition;

	// Token: 0x040000FD RID: 253
	private Vector3 cameraUp;

	// Token: 0x040000FE RID: 254
	private Transform camera_debug;

	// Token: 0x040000FF RID: 255
	private Vector2 mouseControlPoint;

	// Token: 0x04000100 RID: 256
	private float mouseControlDistanceToAngleInDeg = 0.45f;

	// Token: 0x04000101 RID: 257
	private ComponentRotator.FlipSettingsAndState flipInfo = new ComponentRotator.FlipSettingsAndState();

	// Token: 0x04000102 RID: 258
	private ComponentRotator.MirrorState mirrorInfo = new ComponentRotator.MirrorState();

	// Token: 0x04000103 RID: 259
	private float limiterAlpha;

	// Token: 0x020002D4 RID: 724
	public enum Mode
	{
		// Token: 0x04001953 RID: 6483
		Raw,
		// Token: 0x04001954 RID: 6484
		FlipToBack,
		// Token: 0x04001955 RID: 6485
		SmartClamp,
		// Token: 0x04001956 RID: 6486
		MirrorOnBack
	}

	// Token: 0x020002D5 RID: 725
	private class FlipSettingsAndState
	{
		// Token: 0x04001957 RID: 6487
		private static float tmpFlipAngle = 10f;

		// Token: 0x04001958 RID: 6488
		public float flipAngle = ComponentRotator.FlipSettingsAndState.tmpFlipAngle;

		// Token: 0x04001959 RID: 6489
		public float controlFlipThresholdAngle = 90f + ComponentRotator.FlipSettingsAndState.tmpFlipAngle;

		// Token: 0x0400195A RID: 6490
		public float releaseFlipThresholdAngle = 90f - ComponentRotator.FlipSettingsAndState.tmpFlipAngle - 5f;

		// Token: 0x0400195B RID: 6491
		public bool movedPastThresholdAngle;

		// Token: 0x0400195C RID: 6492
		public bool canFlip;

		// Token: 0x0400195D RID: 6493
		public float doNotFilpIfExtraAngleBelowThreshold = 30f;
	}

	// Token: 0x020002D6 RID: 726
	private class MirrorState
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x000961C5 File Offset: 0x000943C5
		public float sign
		{
			get
			{
				if (!this.isMirrored)
				{
					return 1f;
				}
				return -1f;
			}
		}

		// Token: 0x0400195E RID: 6494
		public bool isMirrored;

		// Token: 0x0400195F RID: 6495
		public bool canMirror;
	}
}
}