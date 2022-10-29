using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200009F RID: 159
public class LCDDriver : ComponentDriver
{
	// Token: 0x060007B3 RID: 1971 RVA: 0x0002B97C File Offset: 0x00029B7C
	public override void Awake()
	{

	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0002B998 File Offset: 0x00029B98
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0002BA90 File Offset: 0x00029C90
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x0002BAB4 File Offset: 0x00029CB4
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0002BB09 File Offset: 0x00029D09
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0002BB36 File Offset: 0x00029D36
	private IEnumerator RunCursor()
	{

        return default;
    }

	// Token: 0x060007B9 RID: 1977 RVA: 0x0002BB48 File Offset: 0x00029D48
	private void UpdateVisuals()
	{

	}

	// Token: 0x04000715 RID: 1813
	public MeshRenderer imageMeshRenderer;

	// Token: 0x04000716 RID: 1814
	public Camera theCamera;

	// Token: 0x04000717 RID: 1815
	public TextMeshProUGUI textField;

	// Token: 0x04000718 RID: 1816
	private LCDAgent _lcdAgent;

	// Token: 0x04000719 RID: 1817
	private AgentProperty _stateProperty;

	// Token: 0x0400071A RID: 1818
	private AgentProperty _bufferProperty;

	// Token: 0x0400071B RID: 1819
	private AgentProperty _modeProperty;

	// Token: 0x0400071C RID: 1820
	private AgentProperty _scrollPositionProperty;

	// Token: 0x0400071D RID: 1821
	private AgentProperty _foregroundColorProperty;

	// Token: 0x0400071E RID: 1822
	private AgentProperty _backgroundColorProperty;

	// Token: 0x0400071F RID: 1823
	private AgentProperty _cursorPositionProperty;

	// Token: 0x04000720 RID: 1824
	private AgentProperty _cursorProperty;

	// Token: 0x04000721 RID: 1825
	private IEnumerator _cursorCoroutine;

	// Token: 0x04000722 RID: 1826
	private bool _cursorOn;

	// Token: 0x04000723 RID: 1827
	private TMP_FontAsset _fontAsset;

	// Token: 0x04000724 RID: 1828
	private int _oldCursorPosition;

	// Token: 0x04000725 RID: 1829
	private const char _cursorCode = '©';

	// Token: 0x04000726 RID: 1830
	private const float _cursorBlinkInterval = 0.3f;
}
}