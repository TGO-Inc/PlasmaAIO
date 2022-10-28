using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x02000136 RID: 310
public class UIButtonAgent : Agent
{
	// Token: 0x06000B89 RID: 2953 RVA: 0x0003BED0 File Offset: 0x0003A0D0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0003BFB4 File Offset: 0x0003A1B4
	[SketchNodePortOperation(1)]
	public void Generate(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A34 RID: 2612
	private AgentProperty _documentProperty;

	// Token: 0x04000A35 RID: 2613
	private AgentProperty _idProperty;

	// Token: 0x04000A36 RID: 2614
	private AgentProperty _xProperty;

	// Token: 0x04000A37 RID: 2615
	private AgentProperty _yProperty;

	// Token: 0x04000A38 RID: 2616
	private AgentProperty _widthProperty;

	// Token: 0x04000A39 RID: 2617
	private AgentProperty _heightProperty;

	// Token: 0x04000A3A RID: 2618
	private AgentProperty _textProperty;

	// Token: 0x04000A3B RID: 2619
	private AgentProperty _textColorProperty;

	// Token: 0x04000A3C RID: 2620
	private AgentProperty _fontSizeProperty;

	// Token: 0x04000A3D RID: 2621
	private AgentProperty _backgroundColorProperty;

	// Token: 0x04000A3E RID: 2622
	private AgentProperty _highlightColorProperty;

	// Token: 0x04000A3F RID: 2623
	private DisplayUIButton _uiButton;
}
}