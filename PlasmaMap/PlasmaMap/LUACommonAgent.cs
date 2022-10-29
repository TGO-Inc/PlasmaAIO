using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using MoonSharp.Interpreter;
using Newtonsoft.Json;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200010B RID: 267
public class LUACommonAgent : Agent
{
	// Token: 0x06000A8F RID: 2703 RVA: 0x000373AE File Offset: 0x000355AE
	protected override void OnSetupStarted()
	{

	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x000373D0 File Offset: 0x000355D0
	protected void AssignFunctions()
	{

	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x000374A4 File Offset: 0x000356A4
	protected void RunFunction(DynValue entryPoint, SketchNode sketchNode, bool triggerDonePort = false)
	{

	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00037600 File Offset: 0x00035800
	private void OutputValue(Data value, int port)
	{

	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0003765D File Offset: 0x0003585D
	private void Trigger(int port)
	{

	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00037668 File Offset: 0x00035868
	private void OutputDynamicValue(DynValue value, int port)
	{

	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x000376B8 File Offset: 0x000358B8
	private void OutputArrayValue(DynValue value, int port)
	{

	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00037754 File Offset: 0x00035954
	private void OutputImageValue(DynValue value, int imageIndex, int port)
	{

	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x000378A0 File Offset: 0x00035AA0
	private void WriteVariable(DynValue value, string variableName)
	{

	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00037950 File Offset: 0x00035B50
	private DynValue ReadVariable(string variableName)
	{

        return default;
    }

	// Token: 0x06000A99 RID: 2713 RVA: 0x000379E5 File Offset: 0x00035BE5
	private void PassProperty(AgentProperty value)
	{

	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00037A18 File Offset: 0x00035C18
	private static Data ConvertDynValueToData(DynValue value)
	{

        return default;
    }

	// Token: 0x06000A9B RID: 2715 RVA: 0x00037B08 File Offset: 0x00035D08
	private DynValue ConvertDataToDynValue(Data data)
	{

        return default;
    }

	// Token: 0x0400098C RID: 2444
	protected AgentProperty _v1Property;

	// Token: 0x0400098D RID: 2445
	protected AgentProperty _v2Property;

	// Token: 0x0400098E RID: 2446
	protected AgentProperty _v3Property;

	// Token: 0x0400098F RID: 2447
	protected AgentProperty _v4Property;

	// Token: 0x04000990 RID: 2448
	protected AgentProperty _v5Property;

	// Token: 0x04000991 RID: 2449
	protected AgentProperty _v6Property;

	// Token: 0x04000992 RID: 2450
	protected AgentProperty _v7Property;

	// Token: 0x04000993 RID: 2451
	protected AgentProperty _v8Property;

	// Token: 0x04000994 RID: 2452
	protected Script _script;

	// Token: 0x04000995 RID: 2453
	protected string _errorMessage;

	// Token: 0x04000996 RID: 2454
	protected int _firstOutputPort;

	// Token: 0x04000997 RID: 2455
	protected int _errorPort;

	// Token: 0x04000998 RID: 2456
	protected int _donePort;

	// Token: 0x04000999 RID: 2457
	private Color32[] _pixels;

	// Token: 0x0400099A RID: 2458
	private const int _maxCycles = 1000;
}
}