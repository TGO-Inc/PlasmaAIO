using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Steamworks;

namespace PlasmaAPI.GameClass {
// Token: 0x02000188 RID: 392
public class SerializedDeviceMetaData
{
	// Token: 0x06000EA0 RID: 3744 RVA: 0x0004B15D File Offset: 0x0004935D
	public SerializedDeviceMetaData()
	{
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x0004B168 File Offset: 0x00049368
	public SerializedDeviceMetaData(SerializedDeviceMetaData metaData)
	{

	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x0004B248 File Offset: 0x00049448
	public static SerializedDeviceMetaData CreateMetaData(WorkshopController.WorkshopItemDetails workshopItemDetails, SerializedDeviceMetaData.Types type)
	{

        return default;
    }

	// Token: 0x04000C43 RID: 3139
	public SerializedDeviceMetaData.Types type;

	// Token: 0x04000C44 RID: 3140
	public SerializedDeviceMetaData.States state;

	// Token: 0x04000C45 RID: 3141
	public string name;

	// Token: 0x04000C46 RID: 3142
	public string description;

	// Token: 0x04000C47 RID: 3143
	public int saveCounter;

	// Token: 0x04000C48 RID: 3144
	public DateTime creationDate;

	// Token: 0x04000C49 RID: 3145
	public DateTime lastSaveDate;

	// Token: 0x04000C4A RID: 3146
	public ulong authorSteamId;

	// Token: 0x04000C4B RID: 3147
	public ulong publishedFileId;

	// Token: 0x04000C4C RID: 3148
	public DateTime publishedDate;

	// Token: 0x04000C4D RID: 3149
	public DateTime updateDate;

	// Token: 0x04000C4E RID: 3150
	public int components;

	// Token: 0x04000C4F RID: 3151
	public float mass;

	// Token: 0x04000C50 RID: 3152
	public byte[] previewImage;

	// Token: 0x04000C51 RID: 3153
	public string filename;

	// Token: 0x04000C52 RID: 3154
	public bool isDeviceFileMissing;

	// Token: 0x04000C53 RID: 3155
	public string previewUrl;

	// Token: 0x04000C54 RID: 3156
	public bool isModule;

	// Token: 0x04000C55 RID: 3157
	public static Dictionary<SerializedDeviceMetaData.States, string> statusLabels = new Dictionary<SerializedDeviceMetaData.States, string>
	{
		{
			SerializedDeviceMetaData.States.None,
			"NOT SHARED"
		},
		{
			SerializedDeviceMetaData.States.Subscribed,
			"SUBSCRIBED"
		},
		{
			SerializedDeviceMetaData.States.Published,
			"SHARED"
		},
		{
			SerializedDeviceMetaData.States.Downloading,
			"DOWNLOADING"
		},
		{
			SerializedDeviceMetaData.States.NeedsUpdate,
			"SHARED; CAN BE UPDATED"
		}
	};

	// Token: 0x020003C3 RID: 963
	public enum Types
	{
		// Token: 0x04001D50 RID: 7504
		Local,
		// Token: 0x04001D51 RID: 7505
		Discover,
		// Token: 0x04001D52 RID: 7506
		Subscribed
	}

	// Token: 0x020003C4 RID: 964
	public enum States
	{
		// Token: 0x04001D54 RID: 7508
		None,
		// Token: 0x04001D55 RID: 7509
		Published,
		// Token: 0x04001D56 RID: 7510
		NeedsUpdate,
		// Token: 0x04001D57 RID: 7511
		Subscribed,
		// Token: 0x04001D58 RID: 7512
		Downloading
	}
}
}