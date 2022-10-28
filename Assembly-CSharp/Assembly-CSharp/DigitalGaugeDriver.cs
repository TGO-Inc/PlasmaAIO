using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200006B RID: 107
public class DigitalGaugeDriver : ComponentDriver
{
	// Token: 0x060005FE RID: 1534 RVA: 0x00022BBF File Offset: 0x00020DBF
	public override void Awake()
	{

	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00022BE4 File Offset: 0x00020DE4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00022C90 File Offset: 0x00020E90
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00022C98 File Offset: 0x00020E98
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00022CA0 File Offset: 0x00020EA0
	private void StateSwitchSetup()
	{

	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00022D30 File Offset: 0x00020F30
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00022DFA File Offset: 0x00020FFA
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00022E30 File Offset: 0x00021030
	private void RenderContent()
	{

	}

	// Token: 0x04000537 RID: 1335
	public MeshRenderer meshRenderer;

	// Token: 0x04000538 RID: 1336
	public MeshRenderer imageMeshRenderer;

	// Token: 0x04000539 RID: 1337
	public Camera theCamera;

	// Token: 0x0400053A RID: 1338
	public TextMeshProUGUI text;

	// Token: 0x0400053B RID: 1339
	public Image radial;

	// Token: 0x0400053C RID: 1340
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400053D RID: 1341
	private DigitalGaugeAgent _digitalGaugeAgent;

	// Token: 0x0400053E RID: 1342
	private AgentProperty _stateProperty;

	// Token: 0x0400053F RID: 1343
	private AgentProperty _contentProperty;

	// Token: 0x04000540 RID: 1344
	private AgentProperty _lowerLimitProperty;

	// Token: 0x04000541 RID: 1345
	private AgentProperty _upperLimitProperty;

	// Token: 0x04000542 RID: 1346
	private int _colorId;
}
}