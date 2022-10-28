using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000264 RID: 612
	public class ProcessorUIBlocker : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x0600173F RID: 5951 RVA: 0x00073CAD File Offset: 0x00071EAD
		public void Setup(ProcessorUIBlocker.BlockerClicked callback)
		{

		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00073CB6 File Offset: 0x00071EB6
		public void OnPointerClick(PointerEventData eventData)
		{

		}

		// Token: 0x040012ED RID: 4845
		private ProcessorUIBlocker.BlockerClicked _callback;

		// Token: 0x02000473 RID: 1139
		// (Invoke) Token: 0x0600233C RID: 9020
		public delegate void BlockerClicked();
	}
}
