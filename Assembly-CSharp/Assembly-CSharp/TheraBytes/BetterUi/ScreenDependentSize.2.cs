using System;
using System.Collections.Generic;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001F6 RID: 502
	[Serializable]
	public abstract class ScreenDependentSize
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060011A5 RID: 4517
		// (set) Token: 0x060011A6 RID: 4518
		public abstract string ScreenConfigName { get; set; }

		// Token: 0x060011A7 RID: 4519 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
		protected void UpdateSize()
		{

		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0005C104 File Offset: 0x0005A304
		public virtual void DynamicInitialization()
		{
		}

		// Token: 0x060011A9 RID: 4521
		public abstract IEnumerable<SizeModifierCollection> GetModifiers();

		// Token: 0x060011AA RID: 4522
		protected abstract void AdjustSize(float factor, SizeModifierCollection mod, int index);
	}
}
