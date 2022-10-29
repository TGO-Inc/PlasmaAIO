using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200023E RID: 574
	public class DevicePermission : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x060014DD RID: 5341 RVA: 0x0006A2A8 File Offset: 0x000684A8
		private void Awake()
		{

		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0006A2DC File Offset: 0x000684DC
		public void Enable()
		{

		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0006A340 File Offset: 0x00068540
		public void Disable()
		{

		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0006A3A4 File Offset: 0x000685A4
		public void UpdatePermission(WorldController.GlobalPermissionStates state)
		{

		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0006A3D0 File Offset: 0x000685D0
		public void TrueClicked(bool setPermission = true)
		{

		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006A3F8 File Offset: 0x000685F8
		public void GlobalClicked(bool setPermission = true)
		{

		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0006A420 File Offset: 0x00068620
		public void FalseClicked(bool setPermission = true)
		{

		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0006A448 File Offset: 0x00068648
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0006A497 File Offset: 0x00068697
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x040010FA RID: 4346
		[Multiline]
		public string description;

		// Token: 0x040010FB RID: 4347
		public WorldController.GlobalPermissions permission;

		// Token: 0x040010FC RID: 4348
		private DeviceEditor _editor;

		// Token: 0x040010FD RID: 4349
		private UIColorMapperController _mapperController;

		// Token: 0x040010FE RID: 4350
		private List<BetterButton> _buttons;
	}
}
