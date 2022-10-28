using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000AC RID: 172
public class NFCInterfaceAgent : Agent, IDataSelectionProvider
{
	// Token: 0x0600081A RID: 2074 RVA: 0x0002DF18 File Offset: 0x0002C118
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0002DF3E File Offset: 0x0002C13E
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0002DF64 File Offset: 0x0002C164
	[SketchNodePortOperation(1)]
	public void Write(SketchNode sketchNode)
	{

	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0002DF6D File Offset: 0x0002C16D
	[SketchNodePortOperation(2)]
	public void Read(SketchNode sketchNode)
	{

	}

	// Token: 0x0400077C RID: 1916
	private AgentProperty _valueProperty;

	// Token: 0x0400077D RID: 1917
	private AgentProperty _pendingProperty;

	// Token: 0x02000372 RID: 882
	public enum Commands
	{
		// Token: 0x04001C1B RID: 7195
		SetLEDStripColor = 1,
		// Token: 0x04001C1C RID: 7196
		WriteValue,
		// Token: 0x04001C1D RID: 7197
		ReadValue
	}
}
}