using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Behavior;
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x0200012C RID: 300
public class TextArrayComposerAgent : Agent
{
	// Token: 0x06000B54 RID: 2900 RVA: 0x0003B0E8 File Offset: 0x000392E8
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0003B190 File Offset: 0x00039390
	[SketchNodePortOperation(1)]
	public void Compose(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A18 RID: 2584
	private List<AgentProperty> _elementProperties;
}
}