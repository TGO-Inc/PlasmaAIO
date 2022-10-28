using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PlasmaAPI.GameClass {
// Token: 0x02000184 RID: 388
public class SerializedAgent
{
	// Token: 0x06000E97 RID: 3735 RVA: 0x0004ABD8 File Offset: 0x00048DD8
	public SerializedAgent()
	{

	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0004ABE8 File Offset: 0x00048DE8
	[OnDeserialized]
	public void Defaults()
	{

	}

	// Token: 0x04000C1A RID: 3098
	public AgentId agentId;

	// Token: 0x04000C1B RID: 3099
	public Agent.ModuleInterface moduleInterface;

	// Token: 0x04000C1C RID: 3100
	public object persistentStorage;

	// Token: 0x04000C1D RID: 3101
	public object runtimeStorage;

	// Token: 0x04000C1E RID: 3102
	public Dictionary<AssetController.ResourceTypes, List<int>> resourceIds;

	// Token: 0x04000C1F RID: 3103
	public Dictionary<int, string> resourcesTextures;

	// Token: 0x04000C20 RID: 3104
	public int version;

	// Token: 0x04000C21 RID: 3105
	[NonSerialized]
	private const int currentVersion = 1;
}
}