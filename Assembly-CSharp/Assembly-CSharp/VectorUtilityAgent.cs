using System;
using System.Collections.Generic;
using System.Globalization;
using Behavior;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x02000141 RID: 321
public class VectorUtilityAgent : Agent
{
	// Token: 0x06000BBC RID: 3004 RVA: 0x0003D428 File Offset: 0x0003B628
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x0003D450 File Offset: 0x0003B650
	[SketchNodePortOperation(1)]
	public void GetMagnitude(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0003D4A4 File Offset: 0x0003B6A4
	[SketchNodePortOperation(2)]
	public void Normalize(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0003D4FC File Offset: 0x0003B6FC
	[SketchNodePortOperation(3)]
	public void GetAngle(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0003D570 File Offset: 0x0003B770
	[SketchNodePortOperation(4)]
	public void Project(SketchNode sketchNode)
	{

	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x0003D5E8 File Offset: 0x0003B7E8
	private static Vector3? GetVector(string vector)
	{

        return default;
    }

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0003D664 File Offset: 0x0003B864
	private static string SerializeVector(Vector3 vector)
	{

        return default;
    }

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0003D6B4 File Offset: 0x0003B8B4
	private static void SendNotification(string message, SketchNode sketchNode)
	{

	}

	// Token: 0x04000A72 RID: 2674
	private AgentProperty _v1Property;

	// Token: 0x04000A73 RID: 2675
	private AgentProperty _v2Property;
}
