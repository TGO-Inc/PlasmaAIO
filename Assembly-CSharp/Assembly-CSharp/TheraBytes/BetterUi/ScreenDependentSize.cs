using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001F5 RID: 501
	[Serializable]
	public abstract class ScreenDependentSize<T> : ScreenDependentSize, IScreenConfigConnection
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0005BFCA File Offset: 0x0005A1CA
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0005BFD2 File Offset: 0x0005A1D2
		public override string ScreenConfigName
		{
			get
			{
				return this.screenConfigName;
			}
			set
			{
				this.screenConfigName = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0005BFDB File Offset: 0x0005A1DB
		public T LastCalculatedSize
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0005BFE3 File Offset: 0x0005A1E3
		protected ScreenDependentSize(T opt, T min, T max, T initValue)
		{

		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0005C008 File Offset: 0x0005A208
		public T CalculateSize()
		{

            return default;
        }

		// Token: 0x060011A1 RID: 4513 RVA: 0x0005C016 File Offset: 0x0005A216
		protected float GetSize(float factor, float opt, float min, float max)
		{

            return default;
        }

		// Token: 0x060011A2 RID: 4514 RVA: 0x0005C024 File Offset: 0x0005A224
		public void SetSize(T size)
		{

		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0005C094 File Offset: 0x0005A294
		public void OverrideLastCalculatedSize(T newValue)
		{

		}

		// Token: 0x060011A4 RID: 4516
		protected abstract void CalculateOptimizedSize(T baseValue, float factor, SizeModifierCollection mod, int index);

		// Token: 0x04000F0C RID: 3852
		[SerializeField]
		private string screenConfigName;

		// Token: 0x04000F0D RID: 3853
		public T OptimizedSize;

		// Token: 0x04000F0E RID: 3854
		public T MinSize;

		// Token: 0x04000F0F RID: 3855
		public T MaxSize;

		// Token: 0x04000F10 RID: 3856
		protected T value;
	}
}
