using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Sirenix.OdinInspector;
using TMPro;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000266 RID: 614
	public class ProcessorUIComponentItem : SerializedMonoBehaviour
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00073E70 File Offset: 0x00072070
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x00073E78 File Offset: 0x00072078
		public AgentId agentId { get; private set; }

		// Token: 0x0600174D RID: 5965 RVA: 0x00073E81 File Offset: 0x00072081
		public void Setup(AgentId theAgentId, ProcessorUIComponentPropertyEditor editor)
		{

		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00073EB7 File Offset: 0x000720B7
		public void OnClicked()
		{

		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00073EC6 File Offset: 0x000720C6
		public void Select()
		{

		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00073ED9 File Offset: 0x000720D9
		public void Deselect()
		{

		}

		// Token: 0x040012F4 RID: 4852
		public TextMeshProUGUI displayNameLabel;

		// Token: 0x040012F5 RID: 4853
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x040012F6 RID: 4854
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x040012F7 RID: 4855
		private ProcessorUIComponentPropertyEditor _editor;
	}
}
