using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x02000216 RID: 534
	[AddComponentMenu("Better UI/TextMeshPro/Better TextMeshPro - Dropdown", 30)]
	public class BetterTextMeshProDropdown : TMP_Dropdown, IBetterTransitionUiElement
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x0005DF0B File Offset: 0x0005C10B
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0005DF13 File Offset: 0x0005C113
		public List<Transitions> ShowHideTransitions
		{
			get
			{
				return this.showHideTransitions;
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0005DF1C File Offset: 0x0005C11C
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0005DF90 File Offset: 0x0005C190
		protected override GameObject CreateDropdownList(GameObject template)
		{

            return default;
        }

		// Token: 0x06001259 RID: 4697 RVA: 0x0005DFF0 File Offset: 0x0005C1F0
		protected override void DestroyDropdownList(GameObject dropdownList)
		{

		}

		// Token: 0x04000F6A RID: 3946
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();

		// Token: 0x04000F6B RID: 3947
		[SerializeField]
		private List<Transitions> showHideTransitions = new List<Transitions>();
	}
}
