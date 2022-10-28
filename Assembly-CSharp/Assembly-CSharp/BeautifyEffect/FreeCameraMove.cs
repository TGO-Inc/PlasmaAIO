using System;
using UnityEngine;

namespace BeautifyEffect
{
	// Token: 0x020002BE RID: 702
	public class FreeCameraMove : MonoBehaviour
	{
		// Token: 0x06001C88 RID: 7304 RVA: 0x0008DC2D File Offset: 0x0008BE2D
		private void Start()
		{

		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0008DC4C File Offset: 0x0008BE4C
		private void Update()
		{

		}

		// Token: 0x0400173B RID: 5947
		public float cameraSensitivity = 150f;

		// Token: 0x0400173C RID: 5948
		public float climbSpeed = 20f;

		// Token: 0x0400173D RID: 5949
		public float normalMoveSpeed = 20f;

		// Token: 0x0400173E RID: 5950
		public float slowMoveFactor = 0.25f;

		// Token: 0x0400173F RID: 5951
		public float fastMoveFactor = 3f;

		// Token: 0x04001740 RID: 5952
		private float rotationX;

		// Token: 0x04001741 RID: 5953
		private float rotationY;

		// Token: 0x04001742 RID: 5954
		private Quaternion originalRotation;
	}
}
