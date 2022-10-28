using System;
using TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x020002B1 RID: 689
	public class GlobalPermission : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x000896DC File Offset: 0x000878DC
		private void Awake()
		{

		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000896F6 File Offset: 0x000878F6
		public void OnToggle(bool value)
		{

		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0008970A File Offset: 0x0008790A
		public void UpdateState(bool value)
		{

		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00089725 File Offset: 0x00087925
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0008973D File Offset: 0x0008793D
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x04001671 RID: 5745
		public WorldController.GlobalPermissions permission;

		// Token: 0x04001672 RID: 5746
		[Multiline]
		public string description;

		// Token: 0x04001673 RID: 5747
		private BetterToggle _toggle;

		// Token: 0x04001674 RID: 5748
		private WorldSettingsPopup _popup;
	}
}
