using System;
using System.Collections.Generic;
using Behavior;
using Newtonsoft.Json;

// Token: 0x02000130 RID: 304
public class TextManipulatorAgent : Agent
{
	// Token: 0x06000B6D RID: 2925 RVA: 0x0003B846 File Offset: 0x00039A46
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x0003B85C File Offset: 0x00039A5C
	[SketchNodePortOperation(1)]
	public void GetCharacters(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0003B8B2 File Offset: 0x00039AB2
	[SketchNodePortOperation(2)]
	public void MakeUppercase(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x0003B8D5 File Offset: 0x00039AD5
	[SketchNodePortOperation(3)]
	public void MakeLowercase(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A22 RID: 2594
	private AgentProperty _textProperty;
}
