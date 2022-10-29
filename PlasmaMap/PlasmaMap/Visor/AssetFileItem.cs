using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.IO;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000248 RID: 584
	public class AssetFileItem : SerializedMonoBehaviour
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0006D12C File Offset: 0x0006B32C
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x0006D134 File Offset: 0x0006B334
		public string fullPath { get; private set; }

		// Token: 0x06001561 RID: 5473 RVA: 0x0006D13D File Offset: 0x0006B33D
		public void Setup(string theFilename, Importer importer)
		{

		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0006D15E File Offset: 0x0006B35E
		public void OnClicked()
		{

		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0006D16C File Offset: 0x0006B36C
		public void Select()
		{

		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0006D17F File Offset: 0x0006B37F
		public void Deselect()
		{

		}

		// Token: 0x0400116B RID: 4459
		public TextMeshProUGUI filename;

		// Token: 0x0400116C RID: 4460
		public Dictionary<UserAssetsController.AssetDescription.Types, Sprite> icons;

		// Token: 0x0400116D RID: 4461
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x0400116E RID: 4462
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x0400116F RID: 4463
		private Importer _importer;
	}
}
