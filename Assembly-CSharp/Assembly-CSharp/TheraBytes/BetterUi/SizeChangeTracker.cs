using System;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001EE RID: 494
	[AddComponentMenu("Better UI/Helpers/Size Change Tracker", 30)]
	public class SizeChangeTracker : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x0600117E RID: 4478 RVA: 0x0005BB25 File Offset: 0x00059D25
		protected override void OnEnable()
		{

		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0005BB3F File Offset: 0x00059D3F
		protected override void OnDisable()
		{

		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0005BB5C File Offset: 0x00059D5C
		private void CallForAffectedObjects(Action<ILayoutChildDependency> function)
		{

		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0005BC68 File Offset: 0x00059E68
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0005BC82 File Offset: 0x00059E82
		protected override void OnTransformParentChanged()
		{

		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0005BC9C File Offset: 0x00059E9C
		public void SetLayoutHorizontal()
		{

		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0005BCB0 File Offset: 0x00059EB0
		public void SetLayoutVertical()
		{

		}

		// Token: 0x04000EFB RID: 3835
		public RectTransform[] AffectedObjects;

		// Token: 0x04000EFC RID: 3836
		private bool isInRecursion;
	}
}
