using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200007B RID: 123
public class EmissiveLabelDriver : ComponentDriver
{
	// Token: 0x06000683 RID: 1667 RVA: 0x00025B4B File Offset: 0x00023D4B
	public override void Awake()
	{

	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00025B84 File Offset: 0x00023D84
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00025BDF File Offset: 0x00023DDF
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00025BE7 File Offset: 0x00023DE7
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00025BEF File Offset: 0x00023DEF
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00025BF8 File Offset: 0x00023DF8
	public override void OnScaleChanged()
	{

	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00025C60 File Offset: 0x00023E60
	private void UpdateVisuals()
	{

	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00025D6F File Offset: 0x00023F6F
	public EmissiveLabelDriver()
	{

	}

	// Token: 0x040005E7 RID: 1511
	public TextMeshPro textField;

	// Token: 0x040005E8 RID: 1512
	public MeshRenderer meshRenderer;

	// Token: 0x040005E9 RID: 1513
	public Shader litTextShader;

	// Token: 0x040005EA RID: 1514
	public Shader unlitTextShader;

	// Token: 0x040005EB RID: 1515
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040005EC RID: 1516
	private int _colorId;

	// Token: 0x040005ED RID: 1517
	private AgentProperty _textProperty;

	// Token: 0x040005EE RID: 1518
	private AgentProperty _textColorProperty;

	// Token: 0x040005EF RID: 1519
	private AgentProperty _fontSizeProperty;

	// Token: 0x040005F0 RID: 1520
	private AgentProperty _alignmentProperty;

	// Token: 0x040005F1 RID: 1521
	private Vector2 _originalSize;

	// Token: 0x040005F2 RID: 1522
	private TextAlignmentOptions[] _alignments;
}
}