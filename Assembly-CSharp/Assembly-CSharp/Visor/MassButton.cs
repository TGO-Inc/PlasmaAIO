using PlasmaAPI.GameClass.Behavior;
﻿using System;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using UnityEngine;
using UnityEngine.Events;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200029A RID: 666
	public class MassButton : MonoBehaviour
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x00084271 File Offset: 0x00082471
		public void Setup(IMassButtonHandler handler, bool state)
		{

		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00084281 File Offset: 0x00082481
		public void HandleValue(bool value)
		{

		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00084290 File Offset: 0x00082490
		public void SetValue(bool value)
		{

		}

		// Token: 0x04001540 RID: 5440
		public BetterToggle toggle;

		// Token: 0x04001541 RID: 5441
		public AgentGestalt.MassCategories mass;

		// Token: 0x04001542 RID: 5442
		private IMassButtonHandler _handler;
	}
}
