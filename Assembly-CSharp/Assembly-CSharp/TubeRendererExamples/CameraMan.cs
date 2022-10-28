using System;
using UnityEngine;

namespace TubeRendererExamples
{
	// Token: 0x020001BF RID: 447
	public class CameraMan : MonoBehaviour
	{
		// Token: 0x06001036 RID: 4150 RVA: 0x000562F7 File Offset: 0x000544F7
		private void Awake()
		{

		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0005631C File Offset: 0x0005451C
		private void LateUpdate()
		{

		}

		// Token: 0x04000E4C RID: 3660
		public float speed = 4f;

		// Token: 0x04000E4D RID: 3661
		public Vector3 focusPoint = Vector3.zero;

		// Token: 0x04000E4E RID: 3662
		public bool hover;

		// Token: 0x04000E4F RID: 3663
		public float hoverRange = 0.5f;

		// Token: 0x04000E50 RID: 3664
		private Camera _cam;
	}
}
