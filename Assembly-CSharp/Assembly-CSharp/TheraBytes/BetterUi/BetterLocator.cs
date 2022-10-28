using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001E6 RID: 486
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Better UI/Layout/Better Locator", 30)]
	public class BetterLocator : MonoBehaviour, IResolutionDependency
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0005B321 File Offset: 0x00059521
		public RectTransformData CurrentTransformData
		{
			get
			{
				return this.transformConfigs.GetCurrentItem(this.transformFallback);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0005B334 File Offset: 0x00059534
		private RectTransform rectTransform
		{
			get
			{
				return base.transform as RectTransform;
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0005B341 File Offset: 0x00059541
		private void OnEnable()
		{

		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0005B354 File Offset: 0x00059554
		public void OnResolutionChanged()
		{

		}

		// Token: 0x04000EE8 RID: 3816
		[SerializeField]
		private RectTransformData transformFallback;

		// Token: 0x04000EE9 RID: 3817
		[SerializeField]
		private BetterLocator.RectTransformDataConfigCollection transformConfigs;

		// Token: 0x02000401 RID: 1025
		[Serializable]
		public class RectTransformDataConfigCollection : SizeConfigCollection<RectTransformData>
		{
		}
	}
}
