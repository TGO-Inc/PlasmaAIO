using System;
using System.Collections.Generic;
using UnityEngine;
using Visor;

// Token: 0x0200004E RID: 78
public class VisorUIController : Controller
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600028A RID: 650 RVA: 0x0001316A File Offset: 0x0001136A
	public Visor.Visor visor
	{
		get
		{
			return this._visor;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600028B RID: 651 RVA: 0x00013172 File Offset: 0x00011372
	// (set) Token: 0x0600028C RID: 652 RVA: 0x0001317A File Offset: 0x0001137A
	public Dictionary<AgentGestaltEnum, GameObject> componentLibraryItems { get; private set; }

	// Token: 0x0600028D RID: 653 RVA: 0x00013184 File Offset: 0x00011384
	public override void Init()
	{

	}

	// Token: 0x0600028E RID: 654 RVA: 0x0001322C File Offset: 0x0001142C
	public ComponentItem ActivateComponentLibraryItem(AgentGestaltEnum gestaltId, Transform destination)
	{

        return default;
    }

	// Token: 0x0600028F RID: 655 RVA: 0x00013284 File Offset: 0x00011484
	public void DeactivateAllComponentLibraryItems()
	{

	}

	// Token: 0x06000290 RID: 656 RVA: 0x00013300 File Offset: 0x00011500
	public void RefreshAllComponentLibraryItemsQuickbarSlot()
	{

	}

	// Token: 0x04000372 RID: 882
	public GameObject componentItemPrefab;

	// Token: 0x04000373 RID: 883
	private Visor.Visor _visor;
}
