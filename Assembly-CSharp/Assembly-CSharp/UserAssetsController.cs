using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sirenix.Serialization;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000049 RID: 73
public class UserAssetsController : Controller
{
	// Token: 0x06000250 RID: 592 RVA: 0x000108F8 File Offset: 0x0000EAF8
	public override void Init()
	{

	}

	// Token: 0x06000251 RID: 593 RVA: 0x00010A0C File Offset: 0x0000EC0C
	public void ImportImage(string theName, string originalFilename, byte[] rawData, byte[] thumbnailRawData)
	{

	}

	// Token: 0x06000252 RID: 594 RVA: 0x00010B30 File Offset: 0x0000ED30
	public void AddExternalUserAsset(UserAssetsController.AssetDescription assetDescription, string md5, byte[] bytes)
	{

	}

	// Token: 0x06000253 RID: 595 RVA: 0x00010B8A File Offset: 0x0000ED8A
	public bool DoesAssetExist(string md5)
	{

        return default;
    }

	// Token: 0x06000254 RID: 596 RVA: 0x00010BA0 File Offset: 0x0000EDA0
	public UserAssetsController.AssetDescription GetAssetDescription(string md5)
	{

        return default;
    }

	// Token: 0x06000255 RID: 597 RVA: 0x00010BC4 File Offset: 0x0000EDC4
	public void DeleteAsset(string md5HashString, bool convertToExternalAsset)
	{

	}

	// Token: 0x06000256 RID: 598 RVA: 0x00010C8C File Offset: 0x0000EE8C
	public void UserAssetReachedZeroReferenceCount(string md5HashString)
	{

	}

	// Token: 0x06000257 RID: 599 RVA: 0x00010CD8 File Offset: 0x0000EED8
	public void PurgeAssets()
	{

	}

	// Token: 0x06000258 RID: 600 RVA: 0x00010DA8 File Offset: 0x0000EFA8
	private void SaveLibrary()
	{

	}

	// Token: 0x06000259 RID: 601 RVA: 0x00010E48 File Offset: 0x0000F048
	private void UpdateNameDescriptions()
	{

	}

	// Token: 0x0600025A RID: 602 RVA: 0x00010EE0 File Offset: 0x0000F0E0
	public void RenameAsset(UserAssetsController.AssetDescription assetDescription, string newName)
	{

	}

	// Token: 0x0600025B RID: 603 RVA: 0x00010EFC File Offset: 0x0000F0FC
	public List<UserAssetsController.AssetDescription> GetAssetsByName(string searchPattern)
	{

        return default;
    }

	// Token: 0x0600025C RID: 604 RVA: 0x00010F70 File Offset: 0x0000F170
	public List<UserAssetsController.AssetDescription> GetImagesByName(string searchPattern)
	{

        return default;
    }

	// Token: 0x0600025D RID: 605 RVA: 0x0001100C File Offset: 0x0000F20C
	private List<UserAssetsController.AssetDescription> GetAllAssets()
	{

        return default;
    }

	// Token: 0x0600025E RID: 606 RVA: 0x00011024 File Offset: 0x0000F224
	private List<UserAssetsController.AssetDescription> GetAllImages()
	{

        return default;
    }

	// Token: 0x0600025F RID: 607 RVA: 0x00011090 File Offset: 0x0000F290
	public Texture2D GetAssetTexture(UserAssetsController.AssetDescription assetDescription)
	{

        return default;
    }

	// Token: 0x06000260 RID: 608 RVA: 0x0001110C File Offset: 0x0000F30C
	public Texture2D GetAssetPreviewTexture(UserAssetsController.AssetDescription assetDescription)
	{

        return default;
    }

	// Token: 0x06000261 RID: 609 RVA: 0x0001117C File Offset: 0x0000F37C
	public byte[] GetAssetBytes(string md5hashString)
	{

        return default;
    }

	// Token: 0x06000262 RID: 610 RVA: 0x000111EC File Offset: 0x0000F3EC
	public byte[] GetAssetBytes(UserAssetsController.AssetDescription assetDescription)
	{

        return default;
    }

	// Token: 0x06000263 RID: 611 RVA: 0x0001126D File Offset: 0x0000F46D
	public void Log(string message)
	{

	}

	// Token: 0x06000264 RID: 612 RVA: 0x0001127D File Offset: 0x0000F47D
	public void LogVerbose(string message)
	{

	}

	// Token: 0x06000265 RID: 613 RVA: 0x0001128D File Offset: 0x0000F48D
	public void LogWarning(string message)
	{

	}

	// Token: 0x06000266 RID: 614 RVA: 0x0001129D File Offset: 0x0000F49D
	public void LogError(string message)
	{

	}

	// Token: 0x04000279 RID: 633
	public string subfolder;

	// Token: 0x0400027A RID: 634
	private string _libraryPath;

	// Token: 0x0400027B RID: 635
	private string _libraryFilePath;

	// Token: 0x0400027C RID: 636
	private UserAssetsController.AssetLibrary _library;

	// Token: 0x0400027D RID: 637
	private Dictionary<string, byte[]> _externalUserAssetsData;

	// Token: 0x0400027E RID: 638
	private Dictionary<string, List<UserAssetsController.AssetDescription>> _assetsByName;

	// Token: 0x020002F1 RID: 753
	[Serializable]
	public class AssetDescription
	{
		// Token: 0x04001A00 RID: 6656
		public string name;

		// Token: 0x04001A01 RID: 6657
		public string filename;

		// Token: 0x04001A02 RID: 6658
		public string originalFilename;

		// Token: 0x04001A03 RID: 6659
		public string previewName;

		// Token: 0x04001A04 RID: 6660
		public string md5HashString;

		// Token: 0x04001A05 RID: 6661
		public UserAssetsController.AssetDescription.Types type;

		// Token: 0x04001A06 RID: 6662
		public bool isExternalAsset;

		// Token: 0x020004BC RID: 1212
		public enum Types
		{
			// Token: 0x040020ED RID: 8429
			Image,
			// Token: 0x040020EE RID: 8430
			All = 100
		}
	}

	// Token: 0x020002F2 RID: 754
	[Serializable]
	private class AssetLibrary
	{
		// Token: 0x04001A07 RID: 6663
		public Dictionary<string, UserAssetsController.AssetDescription> assetDescriptions;
	}
}
}