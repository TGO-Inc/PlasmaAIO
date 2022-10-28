using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000080 RID: 128
public class FrameAgent : Agent
{
	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600069D RID: 1693 RVA: 0x000262E7 File Offset: 0x000244E7
	// (set) Token: 0x0600069E RID: 1694 RVA: 0x000262EF File Offset: 0x000244EF
	public RenderTexture renderTexture { get; private set; }

	// Token: 0x0600069F RID: 1695 RVA: 0x000262F8 File Offset: 0x000244F8
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x060006A0 RID: 1696 RVA: 0x00026308 File Offset: 0x00024508
	public override void AllocResources()
	{

	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00026361 File Offset: 0x00024561
	public override void DeallocResources()
	{

	}

	// Token: 0x040005FF RID: 1535
	public int renderTextureIndex;

	// Token: 0x0200035D RID: 861
	public enum Commands
	{
		// Token: 0x04001BCE RID: 7118
		Render = 1
	}
}
}