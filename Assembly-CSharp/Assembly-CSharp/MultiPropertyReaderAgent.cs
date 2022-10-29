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

namespace PlasmaAPI.GameClass {
// Token: 0x02000110 RID: 272
public class MultiPropertyReaderAgent : Agent
{
	// Token: 0x06000AB3 RID: 2739 RVA: 0x000386A0 File Offset: 0x000368A0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0003870C File Offset: 0x0003690C
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0003872C File Offset: 0x0003692C
	public override bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000AB6 RID: 2742 RVA: 0x000387A9 File Offset: 0x000369A9
	[SketchNodePortOperation(1)]
	public void Read(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x000387C0 File Offset: 0x000369C0
	[SketchNodePortOperation(2)]
	public void ReadAndStep(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x000388AB File Offset: 0x00036AAB
	[SketchNodePortOperation(3)]
	public void Reset(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x000388B4 File Offset: 0x00036AB4
	private bool ReadInternal(SketchNode sketchNode, int index)
	{

        return default;
    }

	// Token: 0x040009A8 RID: 2472
	private AgentProperty _indexProperty;

	// Token: 0x040009A9 RID: 2473
	private AgentProperty _loopProperty;

	// Token: 0x040009AA RID: 2474
	private AgentProperty _doneProperty;

	// Token: 0x040009AB RID: 2475
	private AgentProperty _firstStepThenReadProperty;

	// Token: 0x040009AC RID: 2476
	private AgentProperty _backwardProperty;
}
}