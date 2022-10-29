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
// Token: 0x02000186 RID: 390
public class SerializedComponent
{
	// Token: 0x06000E9B RID: 3739 RVA: 0x0004AD1F File Offset: 0x00048F1F
	public SerializedComponent()
	{

	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x0004AD30 File Offset: 0x00048F30
	public SerializedComponent(ComponentHandler componentHandler)
	{

	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x0004AFEC File Offset: 0x000491EC
	public List<SerializedComponent> GetChildrenRecursive()
	{

        return default;
    }

	// Token: 0x06000E9E RID: 3742 RVA: 0x0004B02C File Offset: 0x0004922C
	[OnDeserialized]
	public void Defaults()
	{

	}

	// Token: 0x04000C23 RID: 3107
	public AgentId agentId;

	// Token: 0x04000C24 RID: 3108
	public Vector3 position;

	// Token: 0x04000C25 RID: 3109
	public Quaternion rotation;

	// Token: 0x04000C26 RID: 3110
	public Vector3 scale;

	// Token: 0x04000C27 RID: 3111
	public int colorIndex;

	// Token: 0x04000C28 RID: 3112
	public int altColorIndex;

	// Token: 0x04000C29 RID: 3113
	public int baseComponentInternalIndex;

	// Token: 0x04000C2A RID: 3114
	public AgentGestalt.MassCategories massCategory;

	// Token: 0x04000C2B RID: 3115
	public float massMultiplier;

	// Token: 0x04000C2C RID: 3116
	public float bounciness;

	// Token: 0x04000C2D RID: 3117
	public float dynamicFriction;

	// Token: 0x04000C2E RID: 3118
	public float staticFriction;

	// Token: 0x04000C2F RID: 3119
	public float audioVolume;

	// Token: 0x04000C30 RID: 3120
	public int version;

	// Token: 0x04000C31 RID: 3121
	public Vector3 parentPositionReferenceFrame;

	// Token: 0x04000C32 RID: 3122
	public Vector3 childPositionReferenceFrame;

	// Token: 0x04000C33 RID: 3123
	public Quaternion parentRotationReferenceFrame;

	// Token: 0x04000C34 RID: 3124
	public Quaternion childRotationReferenceFrame;

	// Token: 0x04000C35 RID: 3125
	public Quaternion attachmentReferenceFrame;

	// Token: 0x04000C36 RID: 3126
	public int parentComponentId;

	// Token: 0x04000C37 RID: 3127
	public int parentSubComponentId;

	// Token: 0x04000C38 RID: 3128
	public int childSubComponentId;

	// Token: 0x04000C39 RID: 3129
	public Vector3 pitchYawRoll;

	// Token: 0x04000C3A RID: 3130
	public float extrusionAmount;

	// Token: 0x04000C3B RID: 3131
	public int childSocketIndex;

	// Token: 0x04000C3C RID: 3132
	public int parentSnappingObjectIndex;

	// Token: 0x04000C3D RID: 3133
	public int parentSocketIndex;

	// Token: 0x04000C3E RID: 3134
	public SerializedComponent[] children;

	// Token: 0x04000C3F RID: 3135
	public SerializedSocket[] sockets;

	// Token: 0x04000C40 RID: 3136
	[NonSerialized]
	private const int currentVersion = 4;
}
}