using System;
using UnityEngine;

namespace UnityTemplateProjects
{
	// Token: 0x020001BE RID: 446
	public class SimpleCameraControllerino : MonoBehaviour
	{
		// Token: 0x06001032 RID: 4146 RVA: 0x00055FA7 File Offset: 0x000541A7
		private void OnEnable()
		{

		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00055FCC File Offset: 0x000541CC
		private Vector3 GetInputTranslationDirection()
		{

            return default;
        }

		// Token: 0x06001034 RID: 4148 RVA: 0x00056098 File Offset: 0x00054298
		private void Update()
		{

		}

		// Token: 0x04000E45 RID: 3653
		private SimpleCameraControllerino.CameraState m_TargetCameraState = new SimpleCameraControllerino.CameraState();

		// Token: 0x04000E46 RID: 3654
		private SimpleCameraControllerino.CameraState m_InterpolatingCameraState = new SimpleCameraControllerino.CameraState();

		// Token: 0x04000E47 RID: 3655
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost = 3.5f;

		// Token: 0x04000E48 RID: 3656
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime = 0.2f;

		// Token: 0x04000E49 RID: 3657
		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0.5f, 0f, 5f),
			new Keyframe(1f, 2.5f, 0f, 0f)
		});

		// Token: 0x04000E4A RID: 3658
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime = 0.01f;

		// Token: 0x04000E4B RID: 3659
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		// Token: 0x020003D6 RID: 982
		private class CameraState
		{
			// Token: 0x06002116 RID: 8470 RVA: 0x000A28D0 File Offset: 0x000A0AD0
			public void SetFromTransform(Transform t)
			{

			}

			// Token: 0x06002117 RID: 8471 RVA: 0x000A2944 File Offset: 0x000A0B44
			public void Translate(Vector3 translation)
			{

			}

			// Token: 0x06002118 RID: 8472 RVA: 0x000A29A8 File Offset: 0x000A0BA8
			public void LerpTowards(SimpleCameraControllerino.CameraState target, float positionLerpPct, float rotationLerpPct)
			{

			}

			// Token: 0x06002119 RID: 8473 RVA: 0x000A2A45 File Offset: 0x000A0C45
			public void UpdateTransform(Transform t)
			{

			}

			// Token: 0x04001D8C RID: 7564
			public float yaw;

			// Token: 0x04001D8D RID: 7565
			public float pitch;

			// Token: 0x04001D8E RID: 7566
			public float roll;

			// Token: 0x04001D8F RID: 7567
			public float x;

			// Token: 0x04001D90 RID: 7568
			public float y;

			// Token: 0x04001D91 RID: 7569
			public float z;
		}
	}
}
