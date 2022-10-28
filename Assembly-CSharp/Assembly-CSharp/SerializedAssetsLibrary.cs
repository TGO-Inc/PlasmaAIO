using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;

namespace PlasmaAPI.GameClass {
// Token: 0x02000185 RID: 389
public class SerializedAssetsLibrary
{
	// Token: 0x06000E99 RID: 3737 RVA: 0x0004ACBC File Offset: 0x00048EBC
	public SerializedAssetsLibrary()
	{

	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x0004ACD0 File Offset: 0x00048ED0
	public bool AddAsset(UserAssetsController.AssetDescription assetDescription, byte[] data, string md5HashString, int resourceId, int referenceCount)
	{

        return default;
    }

	// Token: 0x04000C22 RID: 3106
	public Dictionary<string, SerializedAssetsLibrary.SerializedAsset> assets;

	// Token: 0x020003C2 RID: 962
	public class SerializedAsset
	{
		// Token: 0x04001D4B RID: 7499
		public byte[] data;

		// Token: 0x04001D4C RID: 7500
		public int savedResourceId;

		// Token: 0x04001D4D RID: 7501
		public int referenceCount;

		// Token: 0x04001D4E RID: 7502
		public UserAssetsController.AssetDescription assetDescription;
	}
}
}