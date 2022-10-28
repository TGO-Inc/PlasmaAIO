using PlasmaAPI.GameClass.Behavior;
﻿using System;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200023A RID: 570
	public class FindDevicePopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x000691F4 File Offset: 0x000673F4
		public string title
		{
			get
			{
				return "FIND DEVICE";
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x000691FB File Offset: 0x000673FB
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1600f, 1000f);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0006920C File Offset: 0x0006740C
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x00069214 File Offset: 0x00067414
		public bool canClose { get; private set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0006921D File Offset: 0x0006741D
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x00069225 File Offset: 0x00067425
		public object payload { get; private set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0006922E File Offset: 0x0006742E
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00069236 File Offset: 0x00067436
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0006923F File Offset: 0x0006743F
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00069247 File Offset: 0x00067447
		public object closeEventPayload { get; private set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x00069250 File Offset: 0x00067450
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x00069258 File Offset: 0x00067458
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00069261 File Offset: 0x00067461
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00069268 File Offset: 0x00067468
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0006926B File Offset: 0x0006746B
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0006926E File Offset: 0x0006746E
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00069280 File Offset: 0x00067480
		public void OnReveal()
		{

		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00069289 File Offset: 0x00067489
		public void OnFinishReveal()
		{

		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00069296 File Offset: 0x00067496
		public void OnConceal()
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00069298 File Offset: 0x00067498
		public void Close()
		{

		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000692A8 File Offset: 0x000674A8
		public void Find()
		{

		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00069300 File Offset: 0x00067500
		private void HandleQuery(bool success, WorkshopController.WorkshopQueryResult result)
		{

		}

		// Token: 0x040010AF RID: 4271
		public BetterTextMeshProInputField inputField;

		// Token: 0x040010B0 RID: 4272
		public GameObject loadingCircle;

		// Token: 0x040010B1 RID: 4273
		public GameObject errorMessage;

		// Token: 0x040010B2 RID: 4274
		public GameObject ownDeviceMessage;

		// Token: 0x040010B3 RID: 4275
		private Visor _visor;
	}
}
