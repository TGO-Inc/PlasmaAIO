using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200003D RID: 61
public class LoggerController : Controller
{
	// Token: 0x060001D7 RID: 471 RVA: 0x0000BFE9 File Offset: 0x0000A1E9
	public override void Init()
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000BFEC File Offset: 0x0000A1EC
	public void Log(LoggerController.LogClass logClass, string message, string id = null)
	{

	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000C04C File Offset: 0x0000A24C
	public void LogVerbose(LoggerController.LogClass logClass, string message, string id = null)
	{

	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
	public void LogWarning(LoggerController.LogClass logClass, string message, string id = null)
	{

	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000C11B File Offset: 0x0000A31B
	public void LogError(LoggerController.LogClass logClass, string message)
	{

	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000C128 File Offset: 0x0000A328
	private void LogMessage(LogType type, LoggerController.LogClass logClass, string message)
	{

	}

	// Token: 0x0400020D RID: 525
	public bool verbose;

	// Token: 0x0400020E RID: 526
	public bool alwaysShowWarnings;

	// Token: 0x0400020F RID: 527
	public bool showCaller;

	// Token: 0x04000210 RID: 528
	public bool showFrame;

	// Token: 0x04000211 RID: 529
	public Dictionary<LoggerController.LogClass, bool> loggers;

	// Token: 0x04000212 RID: 530
	public string easyFSMFilter;

	// Token: 0x020002E6 RID: 742
	public enum LogClass
	{
		// Token: 0x0400199D RID: 6557
		Generic,
		// Token: 0x0400199E RID: 6558
		Sketch,
		// Token: 0x0400199F RID: 6559
		Wifi,
		// Token: 0x040019A0 RID: 6560
		WorldController,
		// Token: 0x040019A1 RID: 6561
		AssetController,
		// Token: 0x040019A2 RID: 6562
		Steamworks,
		// Token: 0x040019A3 RID: 6563
		Device,
		// Token: 0x040019A4 RID: 6564
		RenderPathController,
		// Token: 0x040019A5 RID: 6565
		EasyFSM,
		// Token: 0x040019A6 RID: 6566
		Agent,
		// Token: 0x040019A7 RID: 6567
		UserAssetController,
		// Token: 0x040019A8 RID: 6568
		GPS
	}
}
}