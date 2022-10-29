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
using System.Runtime.Serialization;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000183 RID: 387
public class SerializedDevice
{
	// Token: 0x06000E95 RID: 3733 RVA: 0x0004AB1A File Offset: 0x00048D1A
	public SerializedDevice()
	{

	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0004AB2C File Offset: 0x00048D2C
	[OnDeserialized]
	public void Defaults()
	{

	}

	// Token: 0x04000C06 RID: 3078
	public int guid;

	// Token: 0x04000C07 RID: 3079
	public string displayName;

	// Token: 0x04000C08 RID: 3080
	public Device.State state;

	// Token: 0x04000C09 RID: 3081
	public Quaternion wireframeRootComponentRotation;

	// Token: 0x04000C0A RID: 3082
	public float wireframeDistanceFromTerrain;

	// Token: 0x04000C0B RID: 3083
	public bool kinematicBase;

	// Token: 0x04000C0C RID: 3084
	public float rotationOffset;

	// Token: 0x04000C0D RID: 3085
	public int primaryColorId;

	// Token: 0x04000C0E RID: 3086
	public int secondaryColorId;

	// Token: 0x04000C0F RID: 3087
	public bool showTreeLine;

	// Token: 0x04000C10 RID: 3088
	public int version;

	// Token: 0x04000C11 RID: 3089
	public SerializedAgent[] agents;

	// Token: 0x04000C12 RID: 3090
	public SerializedComponent rootComponent;

	// Token: 0x04000C13 RID: 3091
	public SerializedComponent[] components;

	// Token: 0x04000C14 RID: 3092
	public MechanicState mechanicState;

	// Token: 0x04000C15 RID: 3093
	public Device.Permissions permissions;

	// Token: 0x04000C16 RID: 3094
	public Dictionary<WorldController.GlobalPermissions, WorldController.GlobalPermissionStates> devicePermissions;

	// Token: 0x04000C17 RID: 3095
	public Device.State stageState;

	// Token: 0x04000C18 RID: 3096
	public bool stageReset;

	// Token: 0x04000C19 RID: 3097
	[NonSerialized]
	private const int currentVersion = 2;
}
}