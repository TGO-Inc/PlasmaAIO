using System;
using System.Collections.Generic;
using System.Globalization;
using Behavior;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x0200008A RID: 138
public class GPSTrackerAgent : Agent
{
	// Token: 0x060006EF RID: 1775 RVA: 0x00027E17 File Offset: 0x00026017
	protected override void OnDriverSet()
	{

	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00027E2C File Offset: 0x0002602C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00027E83 File Offset: 0x00026083
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00027EA7 File Offset: 0x000260A7
	[SketchNodePortOperation(1)]
	public void GetTagData(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00027EB0 File Offset: 0x000260B0
	[SketchNodePortOperation(2)]
	public void GetPlayerData(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00027EB9 File Offset: 0x000260B9
	[SketchNodePortOperation(3)]
	public void GetSelfData(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00027EC4 File Offset: 0x000260C4
	private void OutputTagData(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00027FA8 File Offset: 0x000261A8
	private void OutputPlayerData(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00028070 File Offset: 0x00026270
	private void OutputSelfData(SketchNode sketchNode)
	{

	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000280C4 File Offset: 0x000262C4
	private string SerializeVector(Vector3 vector)
	{

        return default;
    }

	// Token: 0x0400063D RID: 1597
	private AgentProperty _gpsTagIdProperty;

	// Token: 0x0400063E RID: 1598
	private AgentProperty _continuousOutputProperty;

	// Token: 0x0400063F RID: 1599
	private List<float> _xyz;

	// Token: 0x04000640 RID: 1600
	private JsonSerializerSettings _serializerSettings;

	// Token: 0x04000641 RID: 1601
	private GPSTrackerDriver _gpsTrackerDriver;
}
