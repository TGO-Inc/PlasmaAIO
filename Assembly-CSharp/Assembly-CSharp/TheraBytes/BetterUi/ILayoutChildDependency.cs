using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001E9 RID: 489
	public interface ILayoutChildDependency
	{
		// Token: 0x06001150 RID: 4432
		void ChildSizeChanged(Transform child);

		// Token: 0x06001151 RID: 4433
		void ChildAddedOrEnabled(Transform child);

		// Token: 0x06001152 RID: 4434
		void ChildRemovedOrDisabled(Transform child);
	}
}
