using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001F8 RID: 504
	[Serializable]
	public class SizeConfigCollection<T> : ISizeConfigCollection where T : class, IScreenConfigConnection
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0005C10E File Offset: 0x0005A30E
		public List<T> Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0005C118 File Offset: 0x0005A318
		public void Sort()
		{

		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0005C184 File Offset: 0x0005A384
		public string GetCurrentConfigName()
		{

            return default;
        }

		// Token: 0x060011B0 RID: 4528 RVA: 0x0005C1B8 File Offset: 0x0005A3B8
		public T GetCurrentItem(T fallback)
		{

            return default;
        }

		// Token: 0x04000F11 RID: 3857
		[SerializeField]
		private List<T> items = new List<T>();

		// Token: 0x04000F12 RID: 3858
		private bool sorted;
	}
}
