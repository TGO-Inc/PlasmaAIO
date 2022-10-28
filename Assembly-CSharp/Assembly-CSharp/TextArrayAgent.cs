using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using Newtonsoft.Json;

namespace PlasmaAPI.GameClass {
// Token: 0x0200012B RID: 299
public class TextArrayAgent : Agent
{
	// Token: 0x06000B3A RID: 2874 RVA: 0x0003AB65 File Offset: 0x00038D65
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0003AB9D File Offset: 0x00038D9D
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0003ABB4 File Offset: 0x00038DB4
	private void SetupArray()
	{

	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x0003AC14 File Offset: 0x00038E14
	private string SerializeArray()
	{

        return default;
    }

	// Token: 0x06000B3E RID: 2878 RVA: 0x0003AC21 File Offset: 0x00038E21
	[AgentPropertyHandler(1)]
	public void HandleArray(AgentProperty property)
	{

	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0003AC2C File Offset: 0x00038E2C
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000B40 RID: 2880 RVA: 0x0003AC94 File Offset: 0x00038E94
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0003AD02 File Offset: 0x00038F02
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x06000B42 RID: 2882 RVA: 0x0003AD0C File Offset: 0x00038F0C
	[SketchNodePortOperation(1)]
	public void Read(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0003AD64 File Offset: 0x00038F64
	[SketchNodePortOperation(2)]
	public void ReadAndStep(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0003ADCC File Offset: 0x00038FCC
	[SketchNodePortOperation(14)]
	public void ReadFirst(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0003AE08 File Offset: 0x00039008
	[SketchNodePortOperation(15)]
	public void ReadLast(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x0003AE5C File Offset: 0x0003905C
	[SketchNodePortOperation(10)]
	public void Find(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0003AE9C File Offset: 0x0003909C
	[SketchNodePortOperation(3)]
	public void Append(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0003AF08 File Offset: 0x00039108
	[SketchNodePortOperation(4)]
	public void Insert(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0003AFA4 File Offset: 0x000391A4
	[SketchNodePortOperation(11)]
	public void Write(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0003AFF8 File Offset: 0x000391F8
	[SketchNodePortOperation(5)]
	public void Remove(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0003B03F File Offset: 0x0003923F
	[SketchNodePortOperation(6)]
	public void EraseAll(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x0003B04C File Offset: 0x0003924C
	[SketchNodePortOperation(16)]
	public void Sort(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x0003B059 File Offset: 0x00039259
	[SketchNodePortOperation(7)]
	public void GetCount(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x0003B078 File Offset: 0x00039278
	[SketchNodePortOperation(8)]
	public void GetIndex(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x0003B097 File Offset: 0x00039297
	[SketchNodePortOperation(9)]
	public void GetArray(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x0003B0B1 File Offset: 0x000392B1
	[SketchNodePortOperation(12)]
	public void StartEnumeration(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x0003B0C1 File Offset: 0x000392C1
	[SketchNodePortOperation(13)]
	public void StopEnumeration(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0003B0CA File Offset: 0x000392CA
	public override void PrepareForComposeRuntimeStorage()
	{

	}

	// Token: 0x04000A11 RID: 2577
	private AgentProperty _arrayProperty;

	// Token: 0x04000A12 RID: 2578
	private AgentProperty _indexProperty;

	// Token: 0x04000A13 RID: 2579
	private AgentProperty _valueProperty;

	// Token: 0x04000A14 RID: 2580
	private List<string> _array;

	// Token: 0x04000A15 RID: 2581
	private int _counter;

	// Token: 0x04000A16 RID: 2582
	private bool _shouldRun;

	// Token: 0x04000A17 RID: 2583
	private const int _maxValues = 1024;
}
}