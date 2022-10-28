using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001ED RID: 493
	[ExecuteInEditMode]
	public abstract class ResolutionSizer<T> : UIBehaviour, ILayoutController, ILayoutSelfController, IResolutionDependency
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06001174 RID: 4468
		protected abstract ScreenDependentSize<T> sizer { get; }

		// Token: 0x06001175 RID: 4469 RVA: 0x0005BAAD File Offset: 0x00059CAD
		public virtual void SetLayoutHorizontal()
		{

		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0005BAB5 File Offset: 0x00059CB5
		public virtual void SetLayoutVertical()
		{

		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0005BABD File Offset: 0x00059CBD
		protected override void OnEnable()
		{

		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0005BACB File Offset: 0x00059CCB
		protected void SetDirty()
		{

		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0005BADC File Offset: 0x00059CDC
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0005BAEC File Offset: 0x00059CEC
		private void UpdateSize()
		{

		}

		// Token: 0x0600117B RID: 4475
		protected abstract void ApplySize(T newSize);

		// Token: 0x0600117C RID: 4476 RVA: 0x0005BB15 File Offset: 0x00059D15
		public void OnResolutionChanged()
		{

		}
	}
}
