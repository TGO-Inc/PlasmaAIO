using System;
using System.Collections.Generic;
using System.Globalization;
using Behavior;
using Newtonsoft.Json;

// Token: 0x0200013E RID: 318
public class VectorComposerAgent : Agent
{
	// Token: 0x06000BAD RID: 2989 RVA: 0x0003CE0F File Offset: 0x0003B00F
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x0003CE48 File Offset: 0x0003B048
	[SketchNodePortOperation(1)]
	public void Compose(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A68 RID: 2664
	private AgentProperty _xProperty;

	// Token: 0x04000A69 RID: 2665
	private AgentProperty _yProperty;

	// Token: 0x04000A6A RID: 2666
	private AgentProperty _zProperty;
}
