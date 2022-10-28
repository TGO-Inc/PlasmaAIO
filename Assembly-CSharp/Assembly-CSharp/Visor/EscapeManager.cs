using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000240 RID: 576
	public class EscapeManager : MonoBehaviour
	{
		// Token: 0x060014F2 RID: 5362 RVA: 0x0006A741 File Offset: 0x00068941
		private void Awake()
		{

		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0006A74E File Offset: 0x0006894E
		public void PushHandler(IEscapeHandler handler)
		{

		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0006A75C File Offset: 0x0006895C
		public void PopHandler()
		{

		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0006A776 File Offset: 0x00068976
		private void Update()
		{

		}

		// Token: 0x0400110D RID: 4365
		private List<IEscapeHandler> _handlers;
	}
}
