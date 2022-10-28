using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000099 RID: 153
public class LabelDriver : ComponentDriver
{
	// Token: 0x06000771 RID: 1905 RVA: 0x0002A8A3 File Offset: 0x00028AA3
	public override void Awake()
	{

	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0002A8C4 File Offset: 0x00028AC4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000773 RID: 1907 RVA: 0x0002A91F File Offset: 0x00028B1F
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0002A927 File Offset: 0x00028B27
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0002A92F File Offset: 0x00028B2F
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0002A938 File Offset: 0x00028B38
	public override void OnScaleChanged()
	{

	}

	// Token: 0x06000777 RID: 1911 RVA: 0x0002A9A0 File Offset: 0x00028BA0
	private void UpdateVisuals()
	{

	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0002AA1E File Offset: 0x00028C1E
	public LabelDriver()
	{

	}

	// Token: 0x040006D9 RID: 1753
	public TextMeshPro textField;

	// Token: 0x040006DA RID: 1754
	private AgentProperty _textProperty;

	// Token: 0x040006DB RID: 1755
	private AgentProperty _textColorProperty;

	// Token: 0x040006DC RID: 1756
	private AgentProperty _fontSizeProperty;

	// Token: 0x040006DD RID: 1757
	private AgentProperty _alignmentProperty;

	// Token: 0x040006DE RID: 1758
	private Vector2 _originalSize;

	// Token: 0x040006DF RID: 1759
	private TextAlignmentOptions[] _alignments;
}
}