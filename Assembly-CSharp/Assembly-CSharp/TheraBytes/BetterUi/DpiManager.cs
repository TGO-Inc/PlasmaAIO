using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000204 RID: 516
	[Serializable]
	public class DpiManager
	{
		// Token: 0x060011D6 RID: 4566 RVA: 0x0005C84C File Offset: 0x0005AA4C
		public float GetDpi()
		{

            return default;
        }

		// Token: 0x04000F1C RID: 3868
		[SerializeField]
		private List<DpiManager.DpiOverride> overrides = new List<DpiManager.DpiOverride>();

		// Token: 0x02000410 RID: 1040
		[Serializable]
		public class DpiOverride
		{
			// Token: 0x1700052A RID: 1322
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x000A47B7 File Offset: 0x000A29B7
			public float Dpi
			{
				get
				{
					return this.dpi;
				}
			}

			// Token: 0x1700052B RID: 1323
			// (get) Token: 0x060021F4 RID: 8692 RVA: 0x000A47BF File Offset: 0x000A29BF
			public string DeviceModel
			{
				get
				{
					return this.deviceModel;
				}
			}

			// Token: 0x060021F5 RID: 8693 RVA: 0x000A47C7 File Offset: 0x000A29C7
			public DpiOverride(string deviceModel, float dpi)
			{

			}

			// Token: 0x04001E34 RID: 7732
			[SerializeField]
			private float dpi = 96f;

			// Token: 0x04001E35 RID: 7733
			[SerializeField]
			private string deviceModel;
		}
	}
}
