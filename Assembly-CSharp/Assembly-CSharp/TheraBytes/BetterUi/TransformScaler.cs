using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001FE RID: 510
	[AddComponentMenu("Better UI/Helpers/Transform Scaler", 30)]
	public class TransformScaler : ResolutionSizer<Vector3>
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0005C6AC File Offset: 0x0005A8AC
		public Vector3SizeModifier ScaleSizer
		{
			get
			{
				return this.customScaleSizers.GetCurrentItem(this.scaleSizerFallback);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0005C6BF File Offset: 0x0005A8BF
		protected override ScreenDependentSize<Vector3> sizer
		{
			get
			{
				return this.customScaleSizers.GetCurrentItem(this.scaleSizerFallback);
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0005C6D2 File Offset: 0x0005A8D2
		protected override void ApplySize(Vector3 newSize)
		{

		}

		// Token: 0x04000F1A RID: 3866
		[FormerlySerializedAs("scaleSizer")]
		[SerializeField]
		private Vector3SizeModifier scaleSizerFallback = new Vector3SizeModifier(Vector3.one, Vector3.zero, 4f * Vector3.one);

		// Token: 0x04000F1B RID: 3867
		[SerializeField]
		private Vector3SizeConfigCollection customScaleSizers = new Vector3SizeConfigCollection();
	}
}
