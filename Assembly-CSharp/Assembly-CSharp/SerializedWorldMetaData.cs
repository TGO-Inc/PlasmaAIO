using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using Steamworks;

namespace PlasmaAPI.GameClass {
// Token: 0x0200018A RID: 394
public class SerializedWorldMetaData
{
	// Token: 0x06000EA6 RID: 3750 RVA: 0x0004B3E8 File Offset: 0x000495E8
	public SerializedWorldMetaData()
	{
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x0004B3F0 File Offset: 0x000495F0
	public SerializedWorldMetaData(SerializedWorldMetaData metaData)
	{

	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x0004B50C File Offset: 0x0004970C
	public static SerializedWorldMetaData CreateMetaData(WorkshopController.WorkshopItemDetails workshopItemDetails, SerializedWorldMetaData.Types type)
	{

        return default;
    }

	// Token: 0x04000C6C RID: 3180
	public SerializedWorldMetaData.Types type;

	// Token: 0x04000C6D RID: 3181
	public SerializedWorldMetaData.States state;

	// Token: 0x04000C6E RID: 3182
	public string name;

	// Token: 0x04000C6F RID: 3183
	public string description;

	// Token: 0x04000C70 RID: 3184
	public BiomeGestaltEnum biomeId;

	// Token: 0x04000C71 RID: 3185
	public bool isStaged;

	// Token: 0x04000C72 RID: 3186
	public int devices;

	// Token: 0x04000C73 RID: 3187
	public DateTime creationDate;

	// Token: 0x04000C74 RID: 3188
	public DateTime lastSaveDate;

	// Token: 0x04000C75 RID: 3189
	public ulong authorSteamId;

	// Token: 0x04000C76 RID: 3190
	public ulong publishedFileId;

	// Token: 0x04000C77 RID: 3191
	public DateTime publishedDate;

	// Token: 0x04000C78 RID: 3192
	public DateTime updateDate;

	// Token: 0x04000C79 RID: 3193
	public string publishedVersion;

	// Token: 0x04000C7A RID: 3194
	public byte[] previewImage;

	// Token: 0x04000C7B RID: 3195
	public bool userPreviewImage;

	// Token: 0x04000C7C RID: 3196
	public string filename;

	// Token: 0x04000C7D RID: 3197
	public bool isTemporary;

	// Token: 0x04000C7E RID: 3198
	public bool isWorldFileMissing;

	// Token: 0x04000C7F RID: 3199
	public string previewUrl;

	// Token: 0x04000C80 RID: 3200
	public string publishedTag;

	// Token: 0x04000C81 RID: 3201
	public const int screenshotWidth = 1014;

	// Token: 0x04000C82 RID: 3202
	public const int screenshotHeight = 624;

	// Token: 0x04000C83 RID: 3203
	public static Dictionary<SerializedWorldMetaData.States, string> statusLabels = new Dictionary<SerializedWorldMetaData.States, string>
	{
		{
			SerializedWorldMetaData.States.None,
			"NOT SHARED"
		},
		{
			SerializedWorldMetaData.States.Subscribed,
			"SUBSCRIBED"
		},
		{
			SerializedWorldMetaData.States.Published,
			"SHARED"
		},
		{
			SerializedWorldMetaData.States.Downloading,
			"DOWNLOADING"
		},
		{
			SerializedWorldMetaData.States.NeedsUpdate,
			"SHARED; CAN BE UPDATED"
		}
	};

	// Token: 0x020003C5 RID: 965
	public enum Types
	{
		// Token: 0x04001D5A RID: 7514
		Local,
		// Token: 0x04001D5B RID: 7515
		Discover,
		// Token: 0x04001D5C RID: 7516
		Subscribed
	}

	// Token: 0x020003C6 RID: 966
	public enum States
	{
		// Token: 0x04001D5E RID: 7518
		None,
		// Token: 0x04001D5F RID: 7519
		Published,
		// Token: 0x04001D60 RID: 7520
		NeedsUpdate,
		// Token: 0x04001D61 RID: 7521
		Subscribed,
		// Token: 0x04001D62 RID: 7522
		Downloading
	}
}
}