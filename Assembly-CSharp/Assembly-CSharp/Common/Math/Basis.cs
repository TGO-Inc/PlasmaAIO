using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.Common.Math
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public struct Basis
	{
		// Token: 0x06001277 RID: 4727 RVA: 0x0005E4F3 File Offset: 0x0005C6F3
		public Basis(Vector3 forward, Vector3 upHint)
		{

		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0005E500 File Offset: 0x0005C700
		public Vector3 InverseTransformVector(Vector3 v)
		{

            return default;
        }

		// Token: 0x06001279 RID: 4729 RVA: 0x0005E547 File Offset: 0x0005C747
		public Vector3 TransformVector(Vector3 v)
		{

            return default;
        }

		// Token: 0x0600127A RID: 4730 RVA: 0x0005E588 File Offset: 0x0005C788
		public static void SetFromForwardAndUpHint(Vector3 forward, Vector3 upHint, out Basis b)
		{
            b = default;

		}

		// Token: 0x04000F7A RID: 3962
		public Vector3 right;

		// Token: 0x04000F7B RID: 3963
		public Vector3 up;

		// Token: 0x04000F7C RID: 3964
		public Vector3 forward;
	}
}
