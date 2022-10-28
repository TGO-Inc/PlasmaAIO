using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.IO;
using Sirenix.Serialization;
using Steamworks;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000050 RID: 80
public class WorkshopController : Controller
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x0600029D RID: 669 RVA: 0x000135E4 File Offset: 0x000117E4
	// (remove) Token: 0x0600029E RID: 670 RVA: 0x0001361C File Offset: 0x0001181C
	public event WorkshopController.ItemDownloaded OnItemDownloadedEvent;

	// Token: 0x0600029F RID: 671 RVA: 0x00013654 File Offset: 0x00011854
	public override void Init()
	{

	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00013778 File Offset: 0x00011978
	public void GetAllDeviceItems(WorkshopController.QueryCompleted handler, string searchText, bool modulesOnly, WorkshopController.Sorting sorting, uint page)
	{

	}

	// Token: 0x060002A1 RID: 673 RVA: 0x000137FC File Offset: 0x000119FC
	public void GetSubscribedDeviceItems(WorkshopController.QueryCompleted handler, bool modulesOnly, WorkshopController.Sorting sorting, uint page = 1U)
	{

	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0001387C File Offset: 0x00011A7C
	public void GetSpecificDeviceItem(WorkshopController.QueryCompleted handler, ulong publishedFileId)
	{

	}

	// Token: 0x060002A3 RID: 675 RVA: 0x000138D0 File Offset: 0x00011AD0
	public void ShareDevice(SerializedDeviceMetaData metaData, WorkshopController.ItemPublished handler)
	{

	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00013944 File Offset: 0x00011B44
	public void GetAllWorldItems(WorkshopController.QueryCompleted handler, string searchText, bool stagedOnly, WorkshopController.Sorting sorting, uint page)
	{

	}

	// Token: 0x060002A5 RID: 677 RVA: 0x000139E8 File Offset: 0x00011BE8
	public void GetSubscribedWorldItems(WorkshopController.QueryCompleted handler, bool stagedOnly, WorkshopController.Sorting sorting, uint page = 1U)
	{

	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00013A88 File Offset: 0x00011C88
	public void GetSpecificWorldItem(WorkshopController.QueryCompleted handler, ulong publishedFileId)
	{

	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00013ADC File Offset: 0x00011CDC
	public void ShareWorld(SerializedWorldMetaData metaData, WorkshopController.ItemPublished handler)
	{

	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00013B50 File Offset: 0x00011D50
	public void UnpublishItem(ulong publishedFileId, WorkshopController.ItemUnpublished handler)
	{

	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00013B80 File Offset: 0x00011D80
	public void SubscribeItem(ulong publishedFileId)
	{

	}

	// Token: 0x060002AA RID: 682 RVA: 0x00013BA8 File Offset: 0x00011DA8
	public void UnsubscribeItem(ulong publishedFileId)
	{

	}

	// Token: 0x060002AB RID: 683 RVA: 0x00013BD0 File Offset: 0x00011DD0
	public bool DoesSubscribedItemNeedUpdating(ulong publishedFileId)
	{

        return default;
    }

	// Token: 0x060002AC RID: 684 RVA: 0x00013BF6 File Offset: 0x00011DF6
	public bool IsItemSubscribed(ulong publishedFileId)
	{

        return default;
    }

	// Token: 0x060002AD RID: 685 RVA: 0x00013C03 File Offset: 0x00011E03
	public bool PrioritizeItemDownload(ulong publishedFileId)
	{

        return default;
    }

	// Token: 0x060002AE RID: 686 RVA: 0x00013C14 File Offset: 0x00011E14
	private void UpdatePublishedDeviceItem(ulong publishedFileId)
	{

	}

	// Token: 0x060002AF RID: 687 RVA: 0x00013E54 File Offset: 0x00012054
	private void UpdatePublishedWorldItem(ulong publishedFileId)
	{

	}

	// Token: 0x060002B0 RID: 688 RVA: 0x000140B0 File Offset: 0x000122B0
	private static EItemState GetItemState(ulong publishedFileId)
	{

        return default;
    }

	// Token: 0x060002B1 RID: 689 RVA: 0x000140C0 File Offset: 0x000122C0
	public static string GetLocalFilePathForItem(ulong publishedFileId)
	{

        return default;
    }

	// Token: 0x060002B2 RID: 690 RVA: 0x000140E8 File Offset: 0x000122E8
	private void OnRemoteStorageSubscribePublishedFileResult(RemoteStorageSubscribePublishedFileResult_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00014184 File Offset: 0x00012384
	private void OnRemoteStorageUnsubscribePublishedFileResult(RemoteStorageUnsubscribePublishedFileResult_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00014204 File Offset: 0x00012404
	private void OnSteamUGCQueryCompleted(SteamUGCQueryCompleted_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B5 RID: 693 RVA: 0x000143B4 File Offset: 0x000125B4
	private void OnSteamUGCSpecificQueryCompleted(SteamUGCQueryCompleted_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00014568 File Offset: 0x00012768
	private void OnCreateDeviceItemResult(CreateItemResult_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00014620 File Offset: 0x00012820
	private void OnCreateWorldItemResult(CreateItemResult_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B8 RID: 696 RVA: 0x000146D8 File Offset: 0x000128D8
	private void OnSubmitItemUpdateResult(SubmitItemUpdateResult_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002B9 RID: 697 RVA: 0x000147B0 File Offset: 0x000129B0
	private void OnDeleteItemResult(DeleteItemResult_t pCallback, bool bIOFailure)
	{

	}

	// Token: 0x060002BA RID: 698 RVA: 0x00014840 File Offset: 0x00012A40
	private void OnItemSubscribed(RemoteStoragePublishedFileSubscribed_t pCallback)
	{

	}

	// Token: 0x060002BB RID: 699 RVA: 0x0001489C File Offset: 0x00012A9C
	private void OnItemUnsubscribed(RemoteStoragePublishedFileUnsubscribed_t pCallback)
	{

	}

	// Token: 0x060002BC RID: 700 RVA: 0x000148E4 File Offset: 0x00012AE4
	private void OnItemInstalled(ItemInstalled_t pCallback)
	{

	}

	// Token: 0x060002BD RID: 701 RVA: 0x00014958 File Offset: 0x00012B58
	private void OnDownloadItemResult(DownloadItemResult_t pCallback)
	{

	}

	// Token: 0x060002BE RID: 702 RVA: 0x00014A38 File Offset: 0x00012C38
	private WorkshopController.WorkshopItemDetails ParseDetails(SteamUGCDetails_t details, uint index)
	{

        return default;
    }

	// Token: 0x060002BF RID: 703 RVA: 0x00014C18 File Offset: 0x00012E18
	private static void Log(string message)
	{

	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00014C27 File Offset: 0x00012E27
	private static void LogWarning(string message)
	{

	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00014C36 File Offset: 0x00012E36
	private static void LogError(string message)
	{

	}

	// Token: 0x0400037A RID: 890
	public Texture2D previewPlaceholder;

	// Token: 0x0400037B RID: 891
	public const string storyWorldTag = "Story World";

	// Token: 0x0400037C RID: 892
	public const string challengeWorldTag = "Challenge World";

	// Token: 0x0400037D RID: 893
	public const string adventureWorldTag = "Adventure World";

	// Token: 0x0400037E RID: 894
	private WorkshopController.ItemPublished _itemPublishedHandler;

	// Token: 0x0400037F RID: 895
	private WorkshopController.ItemUnpublished _itemUnpublishedHandler;

	// Token: 0x04000380 RID: 896
	private WorkshopController.QueryCompleted _workshopQueryHandler;

	// Token: 0x04000381 RID: 897
	private Callback<ItemInstalled_t> _itemInstalled;

	// Token: 0x04000382 RID: 898
	private Callback<DownloadItemResult_t> _downloadItemResult;

	// Token: 0x04000383 RID: 899
	private Callback<RemoteStoragePublishedFileSubscribed_t> _remoteStoragePublishedFileSubscribed;

	// Token: 0x04000384 RID: 900
	private Callback<RemoteStoragePublishedFileUnsubscribed_t> _remoteStoragePublishedFileUnsubscribed;

	// Token: 0x04000385 RID: 901
	private CallResult<SteamUGCQueryCompleted_t> OnSteamUGCQueryCompletedCallResult;

	// Token: 0x04000386 RID: 902
	private CallResult<SteamUGCQueryCompleted_t> OnSteamUGCSpecificQueryCompletedCallResult;

	// Token: 0x04000387 RID: 903
	private CallResult<CreateItemResult_t> OnCreateDeviceItemResultCallResult;

	// Token: 0x04000388 RID: 904
	private CallResult<CreateItemResult_t> OnCreateWorldItemResultCallResult;

	// Token: 0x04000389 RID: 905
	private CallResult<SubmitItemUpdateResult_t> OnSubmitItemUpdateResultCallResult;

	// Token: 0x0400038A RID: 906
	private CallResult<RemoteStorageSubscribePublishedFileResult_t> OnRemoteStorageSubscribePublishedFileResultCallResult;

	// Token: 0x0400038B RID: 907
	private CallResult<RemoteStorageUnsubscribePublishedFileResult_t> OnRemoteStorageUnsubscribePublishedFileResultCallResult;

	// Token: 0x0400038C RID: 908
	private CallResult<DeleteItemResult_t> OnDeleteItemResultCallResult;

	// Token: 0x0400038D RID: 909
	private SerializedDeviceMetaData _uploadingDeviceMetaData;

	// Token: 0x0400038E RID: 910
	private SerializedWorldMetaData _uploadingWorldMetaData;

	// Token: 0x0400038F RID: 911
	private const int _metaDataFields = 3;

	// Token: 0x04000390 RID: 912
	private UGCQueryHandle_t _UGCQueryHandle;

	// Token: 0x04000391 RID: 913
	private PublishedFileId_t _publishedFileId;

	// Token: 0x04000392 RID: 914
	private UGCUpdateHandle_t _UGCUpdateHandle;

	// Token: 0x04000393 RID: 915
	private const string _deviceTag = "Device";

	// Token: 0x04000394 RID: 916
	private const string _moduleTag = "Module";

	// Token: 0x04000395 RID: 917
	private const string _worldTag = "World";

	// Token: 0x020002F7 RID: 759
	// (Invoke) Token: 0x06001EBF RID: 7871
	public delegate void ItemPublished(bool success, WorkshopController.WorkshopItemPublishResult result);

	// Token: 0x020002F8 RID: 760
	// (Invoke) Token: 0x06001EC3 RID: 7875
	public delegate void ItemUnpublished(bool success);

	// Token: 0x020002F9 RID: 761
	// (Invoke) Token: 0x06001EC7 RID: 7879
	public delegate void QueryCompleted(bool success, WorkshopController.WorkshopQueryResult result);

	// Token: 0x020002FA RID: 762
	// (Invoke) Token: 0x06001ECB RID: 7883
	public delegate void ItemDownloaded(bool success, WorkshopController.WorkshopItemDownloadedResult result);

	// Token: 0x020002FB RID: 763
	public enum Sorting
	{
		// Token: 0x04001A15 RID: 6677
		Date,
		// Token: 0x04001A16 RID: 6678
		Alphabetical,
		// Token: 0x04001A17 RID: 6679
		Subscriptions
	}

	// Token: 0x020002FC RID: 764
	public class WorkshopQueryResult
	{
		// Token: 0x04001A18 RID: 6680
		public uint totalQueryResultsCount;

		// Token: 0x04001A19 RID: 6681
		public WorkshopController.WorkshopItemDetails[] items;
	}

	// Token: 0x020002FD RID: 765
	public class WorkshopItemDetails
	{
		// Token: 0x04001A1A RID: 6682
		public ulong authorSteamId;

		// Token: 0x04001A1B RID: 6683
		public ulong publishedFileId;

		// Token: 0x04001A1C RID: 6684
		public string previewUrl;

		// Token: 0x04001A1D RID: 6685
		public string title;

		// Token: 0x04001A1E RID: 6686
		public string description;

		// Token: 0x04001A1F RID: 6687
		public DateTime publishedDate;

		// Token: 0x04001A20 RID: 6688
		public DateTime updateDate;

		// Token: 0x04001A21 RID: 6689
		public EItemState itemState;

		// Token: 0x04001A22 RID: 6690
		public int numberOfComponents;

		// Token: 0x04001A23 RID: 6691
		public float mass;

		// Token: 0x04001A24 RID: 6692
		public bool isModule;

		// Token: 0x04001A25 RID: 6693
		public int numberOfDevices;

		// Token: 0x04001A26 RID: 6694
		public int biomeId;

		// Token: 0x04001A27 RID: 6695
		public bool isStaged;

		// Token: 0x04001A28 RID: 6696
		public string tag;
	}

	// Token: 0x020002FE RID: 766
	public class WorkshopItemPublishResult
	{
		// Token: 0x04001A29 RID: 6697
		public ulong publishedFileId;

		// Token: 0x04001A2A RID: 6698
		public bool userNeedsToAcceptLegalAgreement;
	}

	// Token: 0x020002FF RID: 767
	public class WorkshopItemDownloadedResult
	{
		// Token: 0x04001A2B RID: 6699
		public ulong publishedFileId;
	}
}
}