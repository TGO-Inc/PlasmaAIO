using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000106 RID: 262
public class ImageExporterAgent : Agent
{
	// Token: 0x06000A73 RID: 2675 RVA: 0x00036BD7 File Offset: 0x00034DD7
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00036BFD File Offset: 0x00034DFD
	[SketchNodePortOperation(1)]
	public void Export(SketchNode sketchNode)
	{

	}

	// Token: 0x0400097B RID: 2427
	private AgentProperty _nameProperty;

	// Token: 0x0400097C RID: 2428
	private AgentProperty _imageProperty;
}
}