using System;
using Behavior;
using Steamworks;
using UnityEngine;

// Token: 0x020000F0 RID: 240
public class BrowserAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000A0E RID: 2574 RVA: 0x00035013 File Offset: 0x00033213
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0003503C File Offset: 0x0003323C
	[SketchNodePortOperation(1)]
	public void OpenURL(SketchNode sketchNode)
	{

	}

	// Token: 0x0400092F RID: 2351
	private AgentProperty _urlProperty;

	// Token: 0x04000930 RID: 2352
	private AgentProperty _modeProperty;
}
