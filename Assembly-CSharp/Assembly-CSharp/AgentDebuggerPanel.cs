using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000006 RID: 6
public class AgentDebuggerPanel : MonoBehaviour
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000F RID: 15 RVA: 0x000023A9 File Offset: 0x000005A9
	// (set) Token: 0x06000010 RID: 16 RVA: 0x000023B1 File Offset: 0x000005B1
	public ComponentHandler component { get; private set; }

	// Token: 0x06000011 RID: 17 RVA: 0x000023BA File Offset: 0x000005BA
	private void OnEnable()
	{

	}

	// Token: 0x06000012 RID: 18 RVA: 0x000023CD File Offset: 0x000005CD
	private void OnDisable()
	{

	}

	// Token: 0x06000013 RID: 19 RVA: 0x000023F2 File Offset: 0x000005F2
	private void HandleDeviceDeleted(int guid, string deviceName, string componentName)
	{

	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002424 File Offset: 0x00000624
	public void Setup(ComponentHandler componentHandler)
	{

	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002510 File Offset: 0x00000710
	public void Show()
	{

	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000252A File Offset: 0x0000072A
	public void Hide()
	{

	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002544 File Offset: 0x00000744
	private void OnApplicationQuit()
	{

	}

	// Token: 0x0400001B RID: 27
	public Transform content;

	// Token: 0x0400001C RID: 28
	public GameObject properties;

	// Token: 0x0400001D RID: 29
	public GameObject cellTemplate;

	// Token: 0x0400001E RID: 30
	public TextMeshProUGUI agentName;

	// Token: 0x0400001F RID: 31
	public GameObject label;
}
}