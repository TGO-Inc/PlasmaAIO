using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002A0 RID: 672
	public class SelectionEditor : DataEditor
	{
		// Token: 0x06001A87 RID: 6791 RVA: 0x000866F8 File Offset: 0x000848F8
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00086874 File Offset: 0x00084A74
		public void SetSelection(int id)
		{

		}

		// Token: 0x04001594 RID: 5524
		public GameObject itemPrefab;

		// Token: 0x04001595 RID: 5525
		public RectTransform content;

		// Token: 0x04001596 RID: 5526
		public float gap;

		// Token: 0x04001597 RID: 5527
		private Data.Selection _currentSelection;

		// Token: 0x04001598 RID: 5528
		private Dictionary<int, SelectionItem> _items;
	}
}
