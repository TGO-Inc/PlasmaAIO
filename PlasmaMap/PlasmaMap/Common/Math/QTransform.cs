using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.Common.Math
{
	// Token: 0x0200021B RID: 539
	[Serializable]
	public struct QTransform
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x0005E60C File Offset: 0x0005C80C
		public QTransform(in Vector3 position, in Quaternion rotation)
		{

		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0005E628 File Offset: 0x0005C828
		public static implicit operator QTransform(Transform t)
		{

            return default;
        }

		// Token: 0x0600127F RID: 4735 RVA: 0x0005E658 File Offset: 0x0005C858
		public void SetFrom(Transform t)
		{

		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0005E666 File Offset: 0x0005C866
		public void ApplyTo(Transform t)
		{

		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0005E680 File Offset: 0x0005C880
		public static QTransform operator *(in QTransform t0, in QTransform t1)
		{

            return default;
        }

		// Token: 0x06001282 RID: 4738 RVA: 0x0005E6D4 File Offset: 0x0005C8D4
		public static QTransform InvMul(in QTransform t0, in QTransform t1)
		{

            return default;
        }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0005E727 File Offset: 0x0005C927
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0005E739 File Offset: 0x0005C939
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0005E74B File Offset: 0x0005C94B
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0005E760 File Offset: 0x0005C960
		public override bool Equals(object obj)
		{

            return default;
        }

		// Token: 0x06001287 RID: 4743 RVA: 0x0005E786 File Offset: 0x0005C986
		public override int GetHashCode()
		{

            return default;
        }

		// Token: 0x06001288 RID: 4744 RVA: 0x0005E7AB File Offset: 0x0005C9AB
		public static bool operator ==(in QTransform a, in QTransform b)
		{

            return default;
        }

		// Token: 0x06001289 RID: 4745 RVA: 0x0005E7D4 File Offset: 0x0005C9D4
		public static bool operator ==(in QTransform qt, Transform t)
		{

            return default;
        }

		// Token: 0x0600128A RID: 4746 RVA: 0x0005E7F0 File Offset: 0x0005C9F0
		public static bool operator !=(in QTransform a, in QTransform b)
		{

            return default;
        }

		// Token: 0x0600128B RID: 4747 RVA: 0x0005E7FC File Offset: 0x0005C9FC
		public static bool operator !=(in QTransform qt, Transform t)
		{

            return default;
        }

		// Token: 0x04000F7D RID: 3965
		public Vector3 position;

		// Token: 0x04000F7E RID: 3966
		public Quaternion rotation;
	}
}
