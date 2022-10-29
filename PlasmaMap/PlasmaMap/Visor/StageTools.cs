using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000257 RID: 599
	public class StageTools : VisorElement
	{
		// Token: 0x06001662 RID: 5730 RVA: 0x00070A80 File Offset: 0x0006EC80
		private IList<ValueDropdownItem<int>> ColorList()
		{

            return default;
        }

		// Token: 0x06001663 RID: 5731 RVA: 0x00070B1C File Offset: 0x0006ED1C
		protected override void CustomSetup()
		{

		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00070B24 File Offset: 0x0006ED24
		private void Update()
		{

		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00070B58 File Offset: 0x0006ED58
		public void SwitchToSandboxMode()
		{

		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00070B6D File Offset: 0x0006ED6D
		public void SwitchToPlaytestMode()
		{

		}

		// Token: 0x04001221 RID: 4641
		public GameObject playtestArea;

		// Token: 0x04001222 RID: 4642
		public TextMeshProUGUI timeLabel;

		// Token: 0x04001223 RID: 4643
		private bool _inPlaytest;

		// Token: 0x04001224 RID: 4644
		private float _elapsedTime;
	}
}
