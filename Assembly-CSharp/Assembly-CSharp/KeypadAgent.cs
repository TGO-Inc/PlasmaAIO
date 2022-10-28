using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Behavior;

// Token: 0x02000094 RID: 148
public class KeypadAgent : Agent
{
	// Token: 0x06000744 RID: 1860 RVA: 0x00029BB0 File Offset: 0x00027DB0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00029C05 File Offset: 0x00027E05
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00029C20 File Offset: 0x00027E20
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00029C6D File Offset: 0x00027E6D
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00029C78 File Offset: 0x00027E78
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00029ED4 File Offset: 0x000280D4
	private void OutputNumber(SketchNode sketchNode, string value)
	{

	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00029F19 File Offset: 0x00028119
	[SketchNodePortOperation(1)]
	public void Clear(SketchNode sketchNode)
	{

	}

	// Token: 0x040006A8 RID: 1704
	private AgentProperty _valueProperty;

	// Token: 0x040006A9 RID: 1705
	private AgentProperty _continuousOutputProperty;

	// Token: 0x040006AA RID: 1706
	private AgentProperty _clearAfterSendProperty;

	// Token: 0x040006AB RID: 1707
	private AgentProperty _pressedKeyProperty;

	// Token: 0x040006AC RID: 1708
	private KeypadAgent.Keys _previousKey;

	// Token: 0x040006AD RID: 1709
	private bool _shouldConsumeInput;

	// Token: 0x040006AE RID: 1710
	private bool _shouldOutputValue;

	// Token: 0x040006AF RID: 1711
	private const int _maxDigits = 8;

	// Token: 0x02000363 RID: 867
	public enum Commands
	{
		// Token: 0x04001BDF RID: 7135
		SetLEDStripColor = 1
	}

	// Token: 0x02000364 RID: 868
	public enum Keys
	{
		// Token: 0x04001BE1 RID: 7137
		Zero,
		// Token: 0x04001BE2 RID: 7138
		One,
		// Token: 0x04001BE3 RID: 7139
		Two,
		// Token: 0x04001BE4 RID: 7140
		Three,
		// Token: 0x04001BE5 RID: 7141
		Four,
		// Token: 0x04001BE6 RID: 7142
		Five,
		// Token: 0x04001BE7 RID: 7143
		Six,
		// Token: 0x04001BE8 RID: 7144
		Seven,
		// Token: 0x04001BE9 RID: 7145
		Eight,
		// Token: 0x04001BEA RID: 7146
		Nine,
		// Token: 0x04001BEB RID: 7147
		Dot,
		// Token: 0x04001BEC RID: 7148
		Clear,
		// Token: 0x04001BED RID: 7149
		Send,
		// Token: 0x04001BEE RID: 7150
		A,
		// Token: 0x04001BEF RID: 7151
		B,
		// Token: 0x04001BF0 RID: 7152
		C,
		// Token: 0x04001BF1 RID: 7153
		D,
		// Token: 0x04001BF2 RID: 7154
		PlusMinus,
		// Token: 0x04001BF3 RID: 7155
		None = 32
	}
}
