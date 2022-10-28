using PlasmaAPI.GameClass.Behavior;
﻿using System;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002B7 RID: 695
	public class WorldPermission : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06001C2A RID: 7210 RVA: 0x0008BF55 File Offset: 0x0008A155
		private void Awake()
		{

		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0008BF6F File Offset: 0x0008A16F
		public void OnToggle(bool value)
		{

		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0008BF83 File Offset: 0x0008A183
		public void UpdateState(bool value)
		{

		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0008BF9E File Offset: 0x0008A19E
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0008BFB6 File Offset: 0x0008A1B6
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x040016F1 RID: 5873
		public WorldController.WorldPermissions permission;

		// Token: 0x040016F2 RID: 5874
		[Multiline]
		public string description;

		// Token: 0x040016F3 RID: 5875
		private BetterToggle _toggle;

		// Token: 0x040016F4 RID: 5876
		private WorldSettingsPopup _popup;
	}
}
