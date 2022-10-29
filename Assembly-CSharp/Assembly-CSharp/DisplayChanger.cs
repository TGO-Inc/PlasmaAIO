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
using System.Runtime.InteropServices;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000164 RID: 356
public class DisplayChanger : MonoBehaviour
{
	// Token: 0x06000DFF RID: 3583
	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	private static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

	// Token: 0x06000E00 RID: 3584
	[DllImport("user32.dll")]
	private static extern IntPtr GetActiveWindow();

	// Token: 0x06000E01 RID: 3585
	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	private static extern bool GetWindowRect(IntPtr hWnd, ref DisplayChanger.RECT rect);

	// Token: 0x06000E02 RID: 3586
	[DllImport("user32.dll")]
	private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, DisplayChanger.MonitorEnumDelegate lpfnEnum, IntPtr dwData);

	// Token: 0x06000E03 RID: 3587
	[DllImport("user32.dll")]
	private static extern IntPtr MonitorFromWindow(IntPtr hWnd, IntPtr dwFlags);

	// Token: 0x06000E04 RID: 3588
	[DllImport("User32.dll", CharSet = CharSet.Auto)]
	private static extern bool GetMonitorInfo(IntPtr hmonitor, [In] [Out] DisplayChanger.MONITORINFOEX info);

	// Token: 0x06000E05 RID: 3589 RVA: 0x000477F8 File Offset: 0x000459F8
	public void Setup()
	{

	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00047898 File Offset: 0x00045A98
	private static List<DisplayChanger.DisplayInfo> GetDisplays()
	{

        return default;
    }

	// Token: 0x06000E07 RID: 3591 RVA: 0x000478DD File Offset: 0x00045ADD
	public int GetScreensCount()
	{

        return default;
    }

	// Token: 0x06000E08 RID: 3592 RVA: 0x000478EC File Offset: 0x00045AEC
	public void ActivateScreen(int screenNum)
	{

	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00047964 File Offset: 0x00045B64
	public int GetActiveScreen()
	{

        return default;
    }

	// Token: 0x04000B61 RID: 2913
	private List<DisplayChanger.DisplayInfo> _displays = new List<DisplayChanger.DisplayInfo>();

	// Token: 0x04000B62 RID: 2914
	private List<DisplayChanger.Monitor> _monitors = new List<DisplayChanger.Monitor>();

	// Token: 0x020003B4 RID: 948
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
	private class MONITORINFOEX
	{
		// Token: 0x04001D13 RID: 7443
		public int cbSize = Marshal.SizeOf(typeof(DisplayChanger.MONITORINFOEX));

		// Token: 0x04001D14 RID: 7444
		public DisplayChanger.RECT rcMonitor;

		// Token: 0x04001D15 RID: 7445
		public DisplayChanger.RECT rcWork;

		// Token: 0x04001D16 RID: 7446
		public int dwFlags;

		// Token: 0x04001D17 RID: 7447
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] szDevice = new char[32];
	}

	// Token: 0x020003B5 RID: 949
	// (Invoke) Token: 0x060020D3 RID: 8403
	private delegate bool MonitorEnumDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref DisplayChanger.RECT lprcMonitor, IntPtr dwData);

	// Token: 0x020003B6 RID: 950
	private struct RECT
	{
		// Token: 0x04001D18 RID: 7448
		public int left;

		// Token: 0x04001D19 RID: 7449
		public int top;

		// Token: 0x04001D1A RID: 7450
		public int right;

		// Token: 0x04001D1B RID: 7451
		public int bottom;
	}

	// Token: 0x020003B7 RID: 951
	private class DisplayInfo
	{
		// Token: 0x04001D1C RID: 7452
		public IntPtr monitorId;

		// Token: 0x04001D1D RID: 7453
		public string screenHeight;

		// Token: 0x04001D1E RID: 7454
		public string screenWidth;

		// Token: 0x04001D1F RID: 7455
		public DisplayChanger.RECT workArea;
	}

	// Token: 0x020003B8 RID: 952
	private class Monitor
	{
		// Token: 0x060020D7 RID: 8407 RVA: 0x000A1F79 File Offset: 0x000A0179
		public Monitor(IntPtr monitorId, int targetX, int monitorNumber, int height, int width)
		{

		}

		// Token: 0x04001D20 RID: 7456
		public IntPtr monitorId;

		// Token: 0x04001D21 RID: 7457
		public int targetX;

		// Token: 0x04001D22 RID: 7458
		public int monitorNumber;

		// Token: 0x04001D23 RID: 7459
		public int height;

		// Token: 0x04001D24 RID: 7460
		public int width;
	}
}
}