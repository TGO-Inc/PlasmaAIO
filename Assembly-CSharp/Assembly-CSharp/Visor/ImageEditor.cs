using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000294 RID: 660
	public class ImageEditor : DataEditor
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x000837F7 File Offset: 0x000819F7
		public override TMP_InputField mainTextField
		{
			get
			{
				return this.searchField;
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00083800 File Offset: 0x00081A00
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000838F4 File Offset: 0x00081AF4
		public override void CleanUp()
		{

		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000839AC File Offset: 0x00081BAC
		public void HandleChange(string text)
		{

		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00083A2C File Offset: 0x00081C2C
		public void HandleSubmit(string text)
		{

		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00083A88 File Offset: 0x00081C88
		public void SetImage(ImageRow imageRow)
		{

		}

		// Token: 0x0400151D RID: 5405
		public TMP_InputField searchField;

		// Token: 0x0400151E RID: 5406
		public ImageBrowser browser;

		// Token: 0x0400151F RID: 5407
		private Data _oldConfiguredData;

		// Token: 0x04001520 RID: 5408
		private Data _oldRuntimeData;
	}
}
