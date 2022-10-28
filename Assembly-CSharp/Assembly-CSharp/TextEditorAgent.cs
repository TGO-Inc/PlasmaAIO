using System;
using Behavior;

// Token: 0x0200012F RID: 303
public class TextEditorAgent : Agent
{
	// Token: 0x06000B5D RID: 2909 RVA: 0x0003B3C7 File Offset: 0x000395C7
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0003B3FF File Offset: 0x000395FF
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x0003B421 File Offset: 0x00039621
	public override FloatRange GetLimitsForProperty(int propertyId)
	{

        return default;
    }

	// Token: 0x06000B60 RID: 2912 RVA: 0x0003B44C File Offset: 0x0003964C
	[SketchNodePortOperation(1)]
	public void InsertText(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0003B4DC File Offset: 0x000396DC
	[SketchNodePortOperation(9)]
	public void OverwriteText(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x0003B5C0 File Offset: 0x000397C0
	[SketchNodePortOperation(2)]
	public void DeleteCharacter(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0003B61C File Offset: 0x0003981C
	[SketchNodePortOperation(10)]
	public void SetCursorPosition(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0003B670 File Offset: 0x00039870
	[SketchNodePortOperation(3)]
	public void MoveCursorLeft(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x0003B6B4 File Offset: 0x000398B4
	[SketchNodePortOperation(4)]
	public void MoveCursorRight(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0003B706 File Offset: 0x00039906
	[SketchNodePortOperation(5)]
	public void MoveCursorHome(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0003B728 File Offset: 0x00039928
	[SketchNodePortOperation(6)]
	public void MoveCursorEnd(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0003B764 File Offset: 0x00039964
	[SketchNodePortOperation(7)]
	public void Backspace(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x0003B7CA File Offset: 0x000399CA
	[SketchNodePortOperation(8)]
	public void OutputText(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0003B7E8 File Offset: 0x000399E8
	[SketchNodePortOperation(11)]
	public void ClearText(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x0003B819 File Offset: 0x00039A19
	[SketchNodePortOperation(12)]
	public void SetText(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A1F RID: 2591
	private AgentProperty _textProperty;

	// Token: 0x04000A20 RID: 2592
	private AgentProperty _cursorPositionProperty;

	// Token: 0x04000A21 RID: 2593
	private AgentProperty _subtextProperty;
}
