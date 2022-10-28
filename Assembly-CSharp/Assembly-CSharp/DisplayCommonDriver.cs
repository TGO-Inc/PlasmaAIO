using System;
using System.Runtime.CompilerServices;
using Behavior;
using FMODUnity;
using TMPro;
using UnityEngine;

// Token: 0x0200006F RID: 111
public class DisplayCommonDriver : ComponentDriver
{
	// Token: 0x06000624 RID: 1572 RVA: 0x000235E7 File Offset: 0x000217E7
	public override void Awake()
	{

	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0002360C File Offset: 0x0002180C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0002376C File Offset: 0x0002196C
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00023774 File Offset: 0x00021974
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0002377C File Offset: 0x0002197C
	private void StateSwitchSetup()
	{

	}

	// Token: 0x06000629 RID: 1577 RVA: 0x0002382C File Offset: 0x00021A2C
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00023999 File Offset: 0x00021B99
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x0600062B RID: 1579 RVA: 0x000239D0 File Offset: 0x00021BD0
	private void RenderContent()
	{

	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00023AAF File Offset: 0x00021CAF
	public DisplayCommonDriver()
	{

	}

	// Token: 0x04000566 RID: 1382
	public MeshRenderer meshRenderer;

	// Token: 0x04000567 RID: 1383
	public MeshRenderer imageMeshRenderer;

	// Token: 0x04000568 RID: 1384
	public Camera theCamera;

	// Token: 0x04000569 RID: 1385
	public TextMeshProUGUI text;

	// Token: 0x0400056A RID: 1386
	public StudioEventEmitter FMODEmitterOn;

	// Token: 0x0400056B RID: 1387
	public StudioEventEmitter FMODEmitterOff;

	// Token: 0x0400056C RID: 1388
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400056D RID: 1389
	private int _colorId;

	// Token: 0x0400056E RID: 1390
	private DisplayCommonnAgent _displayCommonAgent;

	// Token: 0x0400056F RID: 1391
	private AgentProperty _contentProperty;

	// Token: 0x04000570 RID: 1392
	private AgentProperty _stateProperty;

	// Token: 0x04000571 RID: 1393
	private AgentProperty _backgroundColorProperty;

	// Token: 0x04000572 RID: 1394
	private AgentProperty _foregroundColorProperty;

	// Token: 0x04000573 RID: 1395
	private AgentProperty _autosizeProperty;

	// Token: 0x04000574 RID: 1396
	private AgentProperty _fontSizeProperty;

	// Token: 0x04000575 RID: 1397
	private AgentProperty _horizontalAlignmentProperty;

	// Token: 0x04000576 RID: 1398
	private AgentProperty _verticalAlignmentProperty;

	// Token: 0x04000577 RID: 1399
	private AgentProperty _decimalDigitsProperty;

	// Token: 0x04000578 RID: 1400
	private TextAlignmentOptions[,] _alignments;
}
