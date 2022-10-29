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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000092 RID: 146
public class KeyboardAgent : Agent
{
	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600072B RID: 1835 RVA: 0x0002906D File Offset: 0x0002726D
	public IEnumerable<KeyCode> validKeyCodes
	{
		get
		{
			return KeyboardAgent._keyCodesPorts.Keys;
		}
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x0002907C File Offset: 0x0002727C
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600072D RID: 1837 RVA: 0x000290DC File Offset: 0x000272DC
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600072E RID: 1838 RVA: 0x000290E5 File Offset: 0x000272E5
	public override void OnPostWorldTickUpdate()
	{

	}

	// Token: 0x0600072F RID: 1839 RVA: 0x000290F0 File Offset: 0x000272F0
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000685 RID: 1669
	public KeyValuePair<float, float> mouseDeltaXValues;

	// Token: 0x04000686 RID: 1670
	public KeyValuePair<float, float> mouseDeltaYValues;

	// Token: 0x04000687 RID: 1671
	public Dictionary<KeyboardPropertyEnum, KeyValuePair<bool, bool>> mouseButtonValues;

	// Token: 0x04000688 RID: 1672
	public bool isFocused;

	// Token: 0x04000689 RID: 1673
	private AgentProperty _charactersProperty;

	// Token: 0x0400068A RID: 1674
	private AgentProperty _pressedKeyProperty;

	// Token: 0x0400068B RID: 1675
	private AgentProperty _mouseDeltaXProperty;

	// Token: 0x0400068C RID: 1676
	private AgentProperty _mouseDeltaYProperty;

	// Token: 0x0400068D RID: 1677
	private static Dictionary<KeyCode, KeyboardPortEnum> _keyCodesPorts = new Dictionary<KeyCode, KeyboardPortEnum>
	{
		{
			KeyCode.Escape,
			KeyboardPortEnum.Escape
		},
		{
			KeyCode.F1,
			KeyboardPortEnum.F1
		},
		{
			KeyCode.F2,
			KeyboardPortEnum.F2
		},
		{
			KeyCode.F3,
			KeyboardPortEnum.F3
		},
		{
			KeyCode.F4,
			KeyboardPortEnum.F4
		},
		{
			KeyCode.F5,
			KeyboardPortEnum.F5
		},
		{
			KeyCode.F6,
			KeyboardPortEnum.F6
		},
		{
			KeyCode.F7,
			KeyboardPortEnum.F7
		},
		{
			KeyCode.F8,
			KeyboardPortEnum.F8
		},
		{
			KeyCode.Return,
			KeyboardPortEnum.Enter
		},
		{
			KeyCode.UpArrow,
			KeyboardPortEnum.ArrowUp
		},
		{
			KeyCode.LeftArrow,
			KeyboardPortEnum.ArrowLeft
		},
		{
			KeyCode.DownArrow,
			KeyboardPortEnum.ArrowDown
		},
		{
			KeyCode.RightArrow,
			KeyboardPortEnum.ArrowRight
		},
		{
			KeyCode.Delete,
			KeyboardPortEnum.Delete
		},
		{
			KeyCode.Backspace,
			KeyboardPortEnum.Backspace
		}
	};

	// Token: 0x0400068E RID: 1678
	private bool _shouldConsumeInput;

	// Token: 0x02000362 RID: 866
	public enum Commands
	{
		// Token: 0x04001BDC RID: 7132
		SetLEDStripColor = 1,
		// Token: 0x04001BDD RID: 7133
		SetLEDIndicatorColor
	}
}
}