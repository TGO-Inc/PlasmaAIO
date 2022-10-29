using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000030 RID: 48
public class RigidbodyCharacterTriggerListener : MonoBehaviour
{
	// Token: 0x06000113 RID: 275 RVA: 0x00008253 File Offset: 0x00006453
	private void Awake()
	{

	}

	// Token: 0x06000114 RID: 276 RVA: 0x00008266 File Offset: 0x00006466
	private void OnTriggerEnter(Collider other)
	{

	}

	// Token: 0x06000115 RID: 277 RVA: 0x00008273 File Offset: 0x00006473
	private void OnTriggerStay(Collider other)
	{

	}

	// Token: 0x04000149 RID: 329
	private RigidbodyCharacter _character;
}
}