using PlasmaAPI.GameClass.Behavior;
﻿using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000265 RID: 613
	public class ProcessorUICategoryItem : MonoBehaviour
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00073CD3 File Offset: 0x00071ED3
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x00073CDB File Offset: 0x00071EDB
		public bool favorites { get; private set; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00073CE4 File Offset: 0x00071EE4
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00073CEC File Offset: 0x00071EEC
		public bool expanded { get; private set; }

		// Token: 0x06001746 RID: 5958 RVA: 0x00073CF8 File Offset: 0x00071EF8
		public void Setup(AgentCategoryEnum theCategory, ProcessorUINodeLibrary theProcessorUINodeLibrary, bool isFavorites)
		{

		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00073D68 File Offset: 0x00071F68
		public void Expand(bool notify = true)
		{

		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00073DDC File Offset: 0x00071FDC
		public void Collapse(bool notify = true)
		{

		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00073E4F File Offset: 0x0007204F
		public void Toggle()
		{

		}

		// Token: 0x040012EE RID: 4846
		public Image icon;

		// Token: 0x040012EF RID: 4847
		public TextMeshProUGUI label;

		// Token: 0x040012F0 RID: 4848
		private ProcessorUINodeLibrary _processorUINodeLibrary;

		// Token: 0x040012F1 RID: 4849
		private AgentCategoryEnum _category;
	}
}
