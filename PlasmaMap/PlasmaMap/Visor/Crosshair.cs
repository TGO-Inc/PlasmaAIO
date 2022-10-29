using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200024E RID: 590
	public class Crosshair : VisorElement
	{
		// Token: 0x060015CE RID: 5582 RVA: 0x0006E45C File Offset: 0x0006C65C
		protected override void CustomSetup()
		{

		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0006E490 File Offset: 0x0006C690
		private void HandleComponentTargetUpdate(ComponentHandler componentHandler, SubComponentHandler subComponentHandler, Device.State state, DynamicProp newDynamicProp, bool interactive, bool dockable, bool reactsToRaycast)
		{

		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0006E7E3 File Offset: 0x0006C9E3
		public void Show()
		{

		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0006E7F5 File Offset: 0x0006C9F5
		public void Hide()
		{

		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0006E808 File Offset: 0x0006CA08
		public void SetState(Crosshair.States state, bool lockState)
		{

		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0006E888 File Offset: 0x0006CA88
		public void Unlock()
		{

		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0006E898 File Offset: 0x0006CA98
		private void OnDestroy()
		{

		}

		// Token: 0x040011B0 RID: 4528
		private Animator _animator;

		// Token: 0x040011B1 RID: 4529
		private ComponentHandler _componentHandler;

		// Token: 0x040011B2 RID: 4530
		private CanvasGroup _canvasGroup;

		// Token: 0x040011B3 RID: 4531
		private DynamicProp _dynamicProp;

		// Token: 0x040011B4 RID: 4532
		private bool _locked;

		// Token: 0x040011B5 RID: 4533
		private bool _wasLocked;

		// Token: 0x040011B6 RID: 4534
		private bool _lastComponentWasInteractive;

		// Token: 0x040011B7 RID: 4535
		private bool _lastComponentReactedToRaycast;

		// Token: 0x040011B8 RID: 4536
		private bool _wasDockable;

		// Token: 0x02000461 RID: 1121
		public new enum States
		{
			// Token: 0x04001F45 RID: 8005
			NoTarget,
			// Token: 0x04001F46 RID: 8006
			WireframeComponent,
			// Token: 0x04001F47 RID: 8007
			SolidComponent,
			// Token: 0x04001F48 RID: 8008
			InteractableComponent,
			// Token: 0x04001F49 RID: 8009
			OperatingOnWireframeComponent,
			// Token: 0x04001F4A RID: 8010
			OperatingOnSolidComponent,
			// Token: 0x04001F4B RID: 8011
			InteractingWithComponent,
			// Token: 0x04001F4C RID: 8012
			Radial,
			// Token: 0x04001F4D RID: 8013
			Loading,
			// Token: 0x04001F4E RID: 8014
			FocusableComponent = 10,
			// Token: 0x04001F4F RID: 8015
			WireframeComponentSurfing,
			// Token: 0x04001F50 RID: 8016
			Docking
		}
	}
}
