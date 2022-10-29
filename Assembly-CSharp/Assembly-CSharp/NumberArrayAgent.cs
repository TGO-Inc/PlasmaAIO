using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x02000111 RID: 273
public class NumberArrayAgent : Agent
{
	// Token: 0x06000ABB RID: 2747 RVA: 0x0003893B File Offset: 0x00036B3B
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00038973 File Offset: 0x00036B73
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0003898C File Offset: 0x00036B8C
	private void SetupArray()
	{

	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x000389EC File Offset: 0x00036BEC
	private string SerializeArray()
	{

        return default;
    }

	// Token: 0x06000ABF RID: 2751 RVA: 0x000389F9 File Offset: 0x00036BF9
	[AgentPropertyHandler(1)]
	public void HandleArray(AgentProperty property)
	{

	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00038A04 File Offset: 0x00036C04
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00038A6C File Offset: 0x00036C6C
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00038ADA File Offset: 0x00036CDA
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00038AE4 File Offset: 0x00036CE4
	[SketchNodePortOperation(1)]
	public void Read(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00038B3C File Offset: 0x00036D3C
	[SketchNodePortOperation(2)]
	public void ReadAndStep(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00038BA4 File Offset: 0x00036DA4
	[SketchNodePortOperation(14)]
	public void ReadFirst(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00038BE0 File Offset: 0x00036DE0
	[SketchNodePortOperation(15)]
	public void ReadLast(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00038C34 File Offset: 0x00036E34
	[SketchNodePortOperation(10)]
	public void Find(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00038C74 File Offset: 0x00036E74
	[SketchNodePortOperation(3)]
	public void Append(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00038CE0 File Offset: 0x00036EE0
	[SketchNodePortOperation(4)]
	public void Insert(SketchNode sketchNode)
	{

	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00038D7C File Offset: 0x00036F7C
	[SketchNodePortOperation(11)]
	public void Write(SketchNode sketchNode)
	{

	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00038DD0 File Offset: 0x00036FD0
	[SketchNodePortOperation(5)]
	public void Remove(SketchNode sketchNode)
	{

	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00038E17 File Offset: 0x00037017
	[SketchNodePortOperation(6)]
	public void EraseAll(SketchNode sketchNode)
	{

	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00038E24 File Offset: 0x00037024
	[SketchNodePortOperation(16)]
	public void Sort(SketchNode sketchNode)
	{

	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00038E31 File Offset: 0x00037031
	[SketchNodePortOperation(7)]
	public void GetCount(SketchNode sketchNode)
	{

	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00038E50 File Offset: 0x00037050
	[SketchNodePortOperation(8)]
	public void GetIndex(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x00038E6F File Offset: 0x0003706F
	[SketchNodePortOperation(9)]
	public void GetArray(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00038E89 File Offset: 0x00037089
	[SketchNodePortOperation(12)]
	public void StartEnumeration(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00038E99 File Offset: 0x00037099
	[SketchNodePortOperation(13)]
	public void StopEnumeration(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00038EA2 File Offset: 0x000370A2
	public override void PrepareForComposeRuntimeStorage()
	{

	}

	// Token: 0x040009AD RID: 2477
	private AgentProperty _arrayProperty;

	// Token: 0x040009AE RID: 2478
	private AgentProperty _indexProperty;

	// Token: 0x040009AF RID: 2479
	private AgentProperty _valueProperty;

	// Token: 0x040009B0 RID: 2480
	private List<float> _array;

	// Token: 0x040009B1 RID: 2481
	private int _counter;

	// Token: 0x040009B2 RID: 2482
	private bool _shouldRun;

	// Token: 0x040009B3 RID: 2483
	private const int _maxValues = 1024;
}
}