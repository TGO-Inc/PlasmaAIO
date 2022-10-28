using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000138 RID: 312
public class UIImageAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000B97 RID: 2967 RVA: 0x0003C750 File Offset: 0x0003A950
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x0003C7A0 File Offset: 0x0003A9A0
	[SketchNodePortOperation(1)]
	public void Generate(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A53 RID: 2643
	private AgentProperty _documentProperty;

	// Token: 0x04000A54 RID: 2644
	private AgentProperty _idProperty;

	// Token: 0x04000A55 RID: 2645
	private AgentProperty _imageProperty;

	// Token: 0x04000A56 RID: 2646
	private DisplayUIImage _uiImage;
}
}