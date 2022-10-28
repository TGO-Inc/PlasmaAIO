using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Rewired;
using Sirenix.OdinInspector;

namespace PlasmaAPI.GameClass {
// Token: 0x02000004 RID: 4
public class AgentDebugger : SerializedMonoBehaviour
{
	// Token: 0x04000006 RID: 6
	public AgentDebuggerPanel dynamicPanel;

	// Token: 0x04000007 RID: 7
	public Dictionary<RewiredEnum, AgentDebuggerPanel> panels;

	// Token: 0x04000008 RID: 8
	private ComponentHandler _candidateComponent;

	// Token: 0x04000009 RID: 9
	private Player _input;

	// Token: 0x0400000A RID: 10
	private bool _panelsVisible;
}
}