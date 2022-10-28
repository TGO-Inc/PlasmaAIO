using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using DG.Tweening;
using DG.Tweening.Timeline;
using PlasmaAPI.GameClass.EasyFSM;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002AF RID: 687
	public abstract class VisorElement : MonoBehaviour
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x000892F0 File Offset: 0x000874F0
		public void Setup()
		{

		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000894AE File Offset: 0x000876AE
		public void Enable()
		{

		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000894BD File Offset: 0x000876BD
		public void Disable()
		{

		}

		// Token: 0x06001B65 RID: 7013
		protected abstract void CustomSetup();

		// Token: 0x06001B66 RID: 7014 RVA: 0x000894CC File Offset: 0x000876CC
		public virtual void OnStartEnabled()
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000894CE File Offset: 0x000876CE
		public virtual void OnStartDisabled()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000894D0 File Offset: 0x000876D0
		public virtual void OnFinishEnabled()
		{
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x000894D2 File Offset: 0x000876D2
		public virtual void OnFinishDisabled()
		{
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x000894D4 File Offset: 0x000876D4
		private IEnumerator FromDisabledToEnabled()
		{

            return default;
        }

		// Token: 0x06001B6B RID: 7019 RVA: 0x000894E3 File Offset: 0x000876E3
		private IEnumerator FromEnabledToDisabled()
		{

            return default;
        }

		// Token: 0x06001B6C RID: 7020 RVA: 0x000894F2 File Offset: 0x000876F2
		private bool ShouldEnable()
		{

            return default;
        }

		// Token: 0x06001B6D RID: 7021 RVA: 0x000894FD File Offset: 0x000876FD
		private bool ShouldDisable()
		{

            return default;
        }

		// Token: 0x06001B6E RID: 7022 RVA: 0x00089508 File Offset: 0x00087708
		private void OnDestroy()
		{

		}

		// Token: 0x04001660 RID: 5728
		public EasyFSMEnum easyFSMId;

		// Token: 0x04001661 RID: 5729
		public DOVisualSequence enableSequence;

		// Token: 0x04001662 RID: 5730
		public DOVisualSequence disableSequence;

		// Token: 0x04001663 RID: 5731
		protected VisorElement.States _currentState;

		// Token: 0x04001664 RID: 5732
		protected VisorElement.States _nextState;

		// Token: 0x04001665 RID: 5733
		private Sequence _enableSequence;

		// Token: 0x04001666 RID: 5734
		private Sequence _disableSequence;

		// Token: 0x020004A5 RID: 1189
		protected enum States
		{
			// Token: 0x04002060 RID: 8288
			Enabled,
			// Token: 0x04002061 RID: 8289
			Disabled
		}
	}
}
