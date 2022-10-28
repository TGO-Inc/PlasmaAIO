using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000247 RID: 583
	public interface IGenericWindow
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06001550 RID: 5456
		string title { get; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06001551 RID: 5457
		Vector2 requiredSize { get; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06001552 RID: 5458
		bool canClose { get; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06001553 RID: 5459
		object payload { get; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06001554 RID: 5460
		Visor.Events closeEvent { get; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06001555 RID: 5461
		object closeEventPayload { get; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001556 RID: 5462
		// (set) Token: 0x06001557 RID: 5463
		bool escapeKeyConsumed { get; set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06001558 RID: 5464
		string exitKey { get; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001559 RID: 5465
		bool redirect { get; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600155A RID: 5466
		bool useDefaultInputSystem { get; }

		// Token: 0x0600155B RID: 5467
		void Setup(object setupData);

		// Token: 0x0600155C RID: 5468
		void OnReveal();

		// Token: 0x0600155D RID: 5469
		void OnFinishReveal();

		// Token: 0x0600155E RID: 5470
		void OnConceal();
	}
}
