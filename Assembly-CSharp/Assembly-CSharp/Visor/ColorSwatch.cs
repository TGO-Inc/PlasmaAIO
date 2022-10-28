using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000290 RID: 656
	public class ColorSwatch : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x060019E1 RID: 6625 RVA: 0x0008324F File Offset: 0x0008144F
		private void Awake()
		{

		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0008325D File Offset: 0x0008145D
		public void OnPointerDown(PointerEventData eventData)
		{

		}

		// Token: 0x040014F9 RID: 5369
		public int index;

		// Token: 0x040014FA RID: 5370
		private ColorEditor _editor;
	}
}
