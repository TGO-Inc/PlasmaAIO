using System;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000253 RID: 595
	public class FunctionKeysPanel : VisorElement
	{
		// Token: 0x06001611 RID: 5649 RVA: 0x0006F5DE File Offset: 0x0006D7DE
		protected override void CustomSetup()
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0006F5E0 File Offset: 0x0006D7E0
		public void ForceUpdateKeys()
		{

		}

		// Token: 0x040011E3 RID: 4579
		public GameObject deviceBrowserKey;

		// Token: 0x040011E4 RID: 4580
		public GameObject saveWorldKey;

		// Token: 0x040011E5 RID: 4581
		public GameObject playtestKey;

		// Token: 0x040011E6 RID: 4582
		public GameObject stopPlaytestKey;

		// Token: 0x040011E7 RID: 4583
		public GameObject encyclopediaKey;

		// Token: 0x040011E8 RID: 4584
		public GameObject homeKey;

		// Token: 0x040011E9 RID: 4585
		private const int _fullHeight = 840;
	}
}
