using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200024A RID: 586
	public class ImageManager : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0006D4E2 File Offset: 0x0006B6E2
		public string title
		{
			get
			{
				return "IMAGE MANAGER";
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0006D4E9 File Offset: 0x0006B6E9
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2656f, 1530f);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0006D4FA File Offset: 0x0006B6FA
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x0006D502 File Offset: 0x0006B702
		public bool canClose { get; private set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0006D50B File Offset: 0x0006B70B
		public object payload
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0006D50E File Offset: 0x0006B70E
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0006D516 File Offset: 0x0006B716
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0006D51F File Offset: 0x0006B71F
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x0006D527 File Offset: 0x0006B727
		public object closeEventPayload { get; private set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0006D530 File Offset: 0x0006B730
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0006D538 File Offset: 0x0006B738
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0006D541 File Offset: 0x0006B741
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0006D548 File Offset: 0x0006B748
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0006D550 File Offset: 0x0006B750
		public AssetItem lastEditedItem { get; set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0006D559 File Offset: 0x0006B759
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0006D561 File Offset: 0x0006B761
		public bool itemIsBeingEdited { get; set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0006D56A File Offset: 0x0006B76A
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0006D56D File Offset: 0x0006B76D
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0006D570 File Offset: 0x0006B770
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0006D5C5 File Offset: 0x0006B7C5
		public void OnReveal()
		{

		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0006D5D4 File Offset: 0x0006B7D4
		public void OnFinishReveal()
		{

		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0006D5EA File Offset: 0x0006B7EA
		public void OnConceal()
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0006D5EC File Offset: 0x0006B7EC
		public void ShowDeleteDialogBox(UserAssetsController.AssetDescription assetDescription)
		{

		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0006D646 File Offset: 0x0006B846
		public void ShowImporter()
		{

		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0006D67C File Offset: 0x0006B87C
		private void HandleImporterClose(object thePayload)
		{

		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0006D694 File Offset: 0x0006B894
		private void HandleDeleteResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0006D718 File Offset: 0x0006B918
		private void HandleChange(string text)
		{

		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0006D720 File Offset: 0x0006B920
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0006D784 File Offset: 0x0006B984
		public void Populate()
		{

		}

		// Token: 0x0400117D RID: 4477
		public TMP_InputField searchField;

		// Token: 0x0400117E RID: 4478
		public GameObject message;

		// Token: 0x0400117F RID: 4479
		public Transform content;

		// Token: 0x04001180 RID: 4480
		public GameObject assetItemPrefab;

		// Token: 0x04001181 RID: 4481
		public GameObject importerPrefab;

		// Token: 0x04001182 RID: 4482
		public int preloadedAssets;

		// Token: 0x04001183 RID: 4483
		private Visor _visor;

		// Token: 0x04001184 RID: 4484
		private UserAssetsController.AssetDescription _toBeDeletedAsset;
	}
}
