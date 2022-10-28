using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200000A RID: 10
public class ScrollWheelBypass : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	// Token: 0x06000056 RID: 86 RVA: 0x00003417 File Offset: 0x00001617
	private void Start()
	{

	}

	// Token: 0x06000057 RID: 87 RVA: 0x00003425 File Offset: 0x00001625
	public void OnScroll(PointerEventData data)
	{

	}

	// Token: 0x04000045 RID: 69
	private ScrollRect _scrollRect;
}
}