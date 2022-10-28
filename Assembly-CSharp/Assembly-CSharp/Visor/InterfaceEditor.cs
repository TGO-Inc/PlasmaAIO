using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000297 RID: 663
	public class InterfaceEditor : DataEditor
	{
		// Token: 0x06001A16 RID: 6678 RVA: 0x00083C90 File Offset: 0x00081E90
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00083E9C File Offset: 0x0008209C
		public void SetInterface(int id)
		{

		}

		// Token: 0x0400152A RID: 5418
		public GameObject itemPrefab;

		// Token: 0x0400152B RID: 5419
		public RectTransform content;

		// Token: 0x0400152C RID: 5420
		public float gap;

		// Token: 0x0400152D RID: 5421
		private Data.ModuleInterface _currentModuleInterface;

		// Token: 0x0400152E RID: 5422
		private Dictionary<int, InterfaceItem> _items;

		// Token: 0x0400152F RID: 5423
		private Dictionary<int, string> _options;
	}
}
