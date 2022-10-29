using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x020000ED RID: 237
public class DisplayUIButton : DisplayUIElement
{
	// Token: 0x06000A00 RID: 2560 RVA: 0x00034DA3 File Offset: 0x00032FA3
	public DisplayUIButton()
	{

	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00034DB4 File Offset: 0x00032FB4
	public override void CreateUI(Transform container)
	{

	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00034E73 File Offset: 0x00033073
	public override GameObject GetPrefab()
	{

        return default;
    }

	// Token: 0x06000A03 RID: 2563 RVA: 0x00034E80 File Offset: 0x00033080
	public override void OnPointerEnter()
	{

	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00034E93 File Offset: 0x00033093
	public override void OnPointerExit()
	{

	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00034EA6 File Offset: 0x000330A6
	public override void OnPointerPressed()
	{

	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00034EB8 File Offset: 0x000330B8
	public override void OnPointerReleased()
	{

	}

	// Token: 0x04000920 RID: 2336
	public string text;

	// Token: 0x04000921 RID: 2337
	public int fontSize;

	// Token: 0x04000922 RID: 2338
	public float backgroundColorR;

	// Token: 0x04000923 RID: 2339
	public float backgroundColorG;

	// Token: 0x04000924 RID: 2340
	public float backgroundColorB;

	// Token: 0x04000925 RID: 2341
	public float highlightColorR;

	// Token: 0x04000926 RID: 2342
	public float highlightColorG;

	// Token: 0x04000927 RID: 2343
	public float highlightColorB;

	// Token: 0x04000928 RID: 2344
	[NonSerialized]
	private Image _background;

	// Token: 0x04000929 RID: 2345
	[NonSerialized]
	private Color _backgroundColor;

	// Token: 0x0400092A RID: 2346
	[NonSerialized]
	private Color _highlightColor;
}
}