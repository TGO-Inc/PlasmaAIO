using System;
using System.Collections;
using System.Collections.Generic;
using Behavior;
using TMPro;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000267 RID: 615
	public class ProcessorUIComponentPropertyEditor : DataEditor
	{
		// Token: 0x06001752 RID: 5970 RVA: 0x00073EF4 File Offset: 0x000720F4
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0007402C File Offset: 0x0007222C
		private void PopulateComponents()
		{

		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00074158 File Offset: 0x00072358
		public void SelectComponentItem(ProcessorUIComponentItem componentItem, bool setData)
		{

		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00074374 File Offset: 0x00072574
		public void SelectPropertyItem(ProcessorUIPropertyItem propertyItem, bool setData)
		{

		}

		// Token: 0x040012F9 RID: 4857
		public RectTransform componentsContent;

		// Token: 0x040012FA RID: 4858
		public RectTransform propertiesContent;

		// Token: 0x040012FB RID: 4859
		public TextMeshProUGUI message;

		// Token: 0x040012FC RID: 4860
		public GameObject componentItemPrefab;

		// Token: 0x040012FD RID: 4861
		public GameObject propertyItemPrefab;

		// Token: 0x040012FE RID: 4862
		private ProcessorUIComponentItem _selectedComponentItem;

		// Token: 0x040012FF RID: 4863
		private ProcessorUIPropertyItem _selectedPropertyItem;
	}
}
