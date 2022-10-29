using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200019F RID: 415
public class EvilScreenShotterStandalone : MonoBehaviour
{
	// Token: 0x06000FB0 RID: 4016 RVA: 0x000528C0 File Offset: 0x00050AC0
	private void Start()
	{

	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x000528D0 File Offset: 0x00050AD0
	private void Update()
	{

	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0005290C File Offset: 0x00050B0C
	private string GetIsoDate(bool _useUtc = false, bool _appendTime = false, bool _appendMs = false)
	{

        return default;
    }

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00052A08 File Offset: 0x00050C08
	public Texture2D SaveScreenshotToFile(string _fileName, bool _alpha)
	{

        return default;
    }

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00052BC4 File Offset: 0x00050DC4
	public void DBGCMD_OPENDIR()
	{

	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00052C36 File Offset: 0x00050E36
	private void CMI_FixedRes_FullHD()
	{

	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00052C4D File Offset: 0x00050E4D
	private void CMI_FixedRes_4K()
	{

	}

	// Token: 0x04000D25 RID: 3365
	[Space]
	public KeyCode keyShot = KeyCode.Tab;

	// Token: 0x04000D26 RID: 3366
	public bool worksInBuild;

	// Token: 0x04000D27 RID: 3367
	public bool withAlpha;

	// Token: 0x04000D28 RID: 3368
	public EvilScreenShotterStandalone.RESOLUTIONMODE resMode = EvilScreenShotterStandalone.RESOLUTIONMODE.AspectRatio;

	// Token: 0x04000D29 RID: 3369
	private Vector2Int aspectRatio = new Vector2Int(16, 9);

	// Token: 0x04000D2A RID: 3370
	public int superSize = 2;

	// Token: 0x04000D2B RID: 3371
	public Vector2Int fixedResolution = new Vector2Int(1920, 1080);

	// Token: 0x04000D2C RID: 3372
	public bool changeFov = true;

	// Token: 0x04000D2D RID: 3373
	public float newFov = 60f;

	// Token: 0x04000D2E RID: 3374
	public string saveDir = "C:\\Screenhots";

	// Token: 0x020003D4 RID: 980
	public enum RESOLUTIONMODE
	{
		// Token: 0x04001D8A RID: 7562
		FixedResolution,
		// Token: 0x04001D8B RID: 7563
		AspectRatio
	}
}
}