using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Sirenix.OdinInspector;
using TMPro;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000278 RID: 632
	public class ProcessorUIVariableEditorItem : SerializedMonoBehaviour
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00077FC3 File Offset: 0x000761C3
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00077FCB File Offset: 0x000761CB
		public AgentProperty variable { get; private set; }

		// Token: 0x06001803 RID: 6147 RVA: 0x00077FD4 File Offset: 0x000761D4
		public void Setup(AgentProperty theVariable, ProcessorUIVariableEditor editor)
		{

		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00077FFA File Offset: 0x000761FA
		public void OnClicked()
		{

		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00078008 File Offset: 0x00076208
		public void Select()
		{

		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0007801B File Offset: 0x0007621B
		public void Deselect()
		{

		}

		// Token: 0x04001384 RID: 4996
		public TextMeshProUGUI variableName;

		// Token: 0x04001385 RID: 4997
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x04001386 RID: 4998
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x04001387 RID: 4999
		private ProcessorUIVariableEditor _editor;
	}
}
