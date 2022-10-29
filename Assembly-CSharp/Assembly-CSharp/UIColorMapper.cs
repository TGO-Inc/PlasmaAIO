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
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000016 RID: 22
public abstract class UIColorMapper : MonoBehaviour
{
	// Token: 0x0600006D RID: 109
	protected abstract void RefreshColors(Holder holder, int stateToApply = 0);

	// Token: 0x0600006E RID: 110 RVA: 0x000044F4 File Offset: 0x000026F4
	private IList<ValueDropdownItem<int>> ColorList()
	{

        return default;
    }

	// Token: 0x0600006F RID: 111 RVA: 0x00004590 File Offset: 0x00002790
	private void Awake()
	{

	}

	// Token: 0x06000070 RID: 112 RVA: 0x000045AD File Offset: 0x000027AD
	public void Enable()
	{

	}

	// Token: 0x06000071 RID: 113 RVA: 0x000045B6 File Offset: 0x000027B6
	public void Disable()
	{

	}

	// Token: 0x06000072 RID: 114 RVA: 0x000045BF File Offset: 0x000027BF
	public void ApplyColors(Holder holder, bool force = false)
	{

	}

	// Token: 0x06000073 RID: 115 RVA: 0x000045D8 File Offset: 0x000027D8
	private void OnValidate()
	{

	}

	// Token: 0x06000074 RID: 116 RVA: 0x00004604 File Offset: 0x00002804
	private void Test()
	{

	}

	// Token: 0x04000092 RID: 146
	public bool obeysController;

	// Token: 0x04000093 RID: 147
	public string labels;

	// Token: 0x04000094 RID: 148
	public bool secondaryMap;

	// Token: 0x04000095 RID: 149
	private bool _enabled;
}
}