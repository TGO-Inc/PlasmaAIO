using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000144 RID: 324
public class Articulation : MonoBehaviour
{
	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0003D8A3 File Offset: 0x0003BAA3
	// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0003D8AB File Offset: 0x0003BAAB
	public ComponentHandler rootComponent { get; set; }

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0003D8B4 File Offset: 0x0003BAB4
	public List<ComponentHandler> allComponentsHierarchy
	{
		get
		{
			List<ComponentHandler> list = new List<ComponentHandler>();
			list.Add(this.rootComponent);
			this.rootComponent.GetChildren(true, list);
			return list;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0003D8E2 File Offset: 0x0003BAE2
	public ArticulationBody[] allArticulationBodies
	{
		get
		{
			return base.GetComponentsInChildren<ArticulationBody>();
		}
	}
}
}