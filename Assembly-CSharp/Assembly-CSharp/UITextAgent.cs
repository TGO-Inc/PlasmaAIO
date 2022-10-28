using System;
using Behavior;

// Token: 0x02000139 RID: 313
public class UITextAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000B9A RID: 2970 RVA: 0x0003C810 File Offset: 0x0003AA10
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x0003C8E0 File Offset: 0x0003AAE0
	[SketchNodePortOperation(1)]
	public void Generate(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A57 RID: 2647
	private AgentProperty _documentProperty;

	// Token: 0x04000A58 RID: 2648
	private AgentProperty _idProperty;

	// Token: 0x04000A59 RID: 2649
	private AgentProperty _xProperty;

	// Token: 0x04000A5A RID: 2650
	private AgentProperty _yProperty;

	// Token: 0x04000A5B RID: 2651
	private AgentProperty _widthProperty;

	// Token: 0x04000A5C RID: 2652
	private AgentProperty _heightProperty;

	// Token: 0x04000A5D RID: 2653
	private AgentProperty _textProperty;

	// Token: 0x04000A5E RID: 2654
	private AgentProperty _colorProperty;

	// Token: 0x04000A5F RID: 2655
	private AgentProperty _fontSizeProperty;

	// Token: 0x04000A60 RID: 2656
	private AgentProperty _horizontalAlignmentProperty;

	// Token: 0x04000A61 RID: 2657
	private DisplayUIText _uiText;
}
