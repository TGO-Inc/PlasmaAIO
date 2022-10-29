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
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000AF RID: 175
public class NFCTagDriver : ComponentDriver
{
	// Token: 0x0600082E RID: 2094 RVA: 0x0002E38D File Offset: 0x0002C58D
	public override void Awake()
	{

	}

	// Token: 0x0600082F RID: 2095 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
	public Data GetData()
	{

        return default;
    }

	// Token: 0x06000830 RID: 2096 RVA: 0x0002E3E3 File Offset: 0x0002C5E3
	public void SetData(Data data)
	{

	}

	// Token: 0x06000831 RID: 2097 RVA: 0x0002E41A File Offset: 0x0002C61A
	public int GetChannel()
	{

        return default;
    }

	// Token: 0x06000832 RID: 2098 RVA: 0x0002E427 File Offset: 0x0002C627
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0002E44D File Offset: 0x0002C64D
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000834 RID: 2100 RVA: 0x0002E45A File Offset: 0x0002C65A
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000835 RID: 2101 RVA: 0x0002E467 File Offset: 0x0002C667
	private IEnumerator ReadSequence()
	{

        return default;
    }

	// Token: 0x06000836 RID: 2102 RVA: 0x0002E476 File Offset: 0x0002C676
	private IEnumerator WriteSequence()
	{

        return default;
    }

	// Token: 0x06000837 RID: 2103 RVA: 0x0002E485 File Offset: 0x0002C685
	private void UpdateVisuals(Color color)
	{

	}

	// Token: 0x0400078E RID: 1934
	public MeshRenderer meshRenderer;

	// Token: 0x0400078F RID: 1935
	private AgentProperty _valueProperty;

	// Token: 0x04000790 RID: 1936
	private AgentProperty _channelProperty;

	// Token: 0x04000791 RID: 1937
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000792 RID: 1938
	private int _colorId;

	// Token: 0x04000793 RID: 1939
	private Coroutine _coroutine;
}
}