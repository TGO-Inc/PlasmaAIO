using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x0200029F RID: 671
	public class PropertyRow : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000864E6 File Offset: 0x000846E6
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x000864EE File Offset: 0x000846EE
		public PropertyList list { get; set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000864F7 File Offset: 0x000846F7
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x000864FF File Offset: 0x000846FF
		public int propertyIndex { get; set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00086508 File Offset: 0x00084708
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x00086510 File Offset: 0x00084710
		public int position { get; set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x00086519 File Offset: 0x00084719
		public bool isEnabled
		{
			get
			{
				return this._button.interactable;
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00086528 File Offset: 0x00084728
		private IList<ValueDropdownItem<int>> ColorList()
		{

            return default;
        }

		// Token: 0x06001A7E RID: 6782 RVA: 0x000865C4 File Offset: 0x000847C4
		private void Awake()
		{

		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000865E0 File Offset: 0x000847E0
		public void Select()
		{

		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00086644 File Offset: 0x00084844
		public void Deselect()
		{

		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000866A6 File Offset: 0x000848A6
		public void SetState(bool state)
		{

		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000866B4 File Offset: 0x000848B4
		public void OnClicked()
		{

		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000866C2 File Offset: 0x000848C2
		public void Click()
		{

		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000866D4 File Offset: 0x000848D4
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000866E2 File Offset: 0x000848E2
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x04001587 RID: 5511
		[ColorEntity]
		public int backgroundNormal;

		// Token: 0x04001588 RID: 5512
		[ColorEntity]
		public int backgroundSelected;

		// Token: 0x04001589 RID: 5513
		[ColorEntity]
		public int backgroundHighlighted;

		// Token: 0x0400158A RID: 5514
		[ColorEntity]
		public int backgroundSelectedHighlighted;

		// Token: 0x0400158B RID: 5515
		[ColorEntity]
		public int textNormal;

		// Token: 0x0400158C RID: 5516
		[ColorEntity]
		public int textSelected;

		// Token: 0x0400158D RID: 5517
		[ColorEntity]
		public int textHighlighted;

		// Token: 0x0400158E RID: 5518
		[ColorEntity]
		public int textSelectedHighlighted;

		// Token: 0x0400158F RID: 5519
		private UIBetterButtonColorMapper _mapper;

		// Token: 0x04001590 RID: 5520
		private BetterButton _button;
	}
}
