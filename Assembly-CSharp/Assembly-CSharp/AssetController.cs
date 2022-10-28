using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000035 RID: 53
public class AssetController : Controller
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000126 RID: 294 RVA: 0x00008550 File Offset: 0x00006750
	// (remove) Token: 0x06000127 RID: 295 RVA: 0x00008584 File Offset: 0x00006784
	public static event AssetController.AssetImageAddEvent OnImageAdded;

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000128 RID: 296 RVA: 0x000085B8 File Offset: 0x000067B8
	// (remove) Token: 0x06000129 RID: 297 RVA: 0x000085EC File Offset: 0x000067EC
	public static event AssetController.AssetImageRemoveEvent OnImagesRemoved;

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600012A RID: 298 RVA: 0x00008620 File Offset: 0x00006820
	// (remove) Token: 0x0600012B RID: 299 RVA: 0x00008654 File Offset: 0x00006854
	public static event AssetController.AssetImageAddEvent OnImageReferenceCountUpdated;

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600012C RID: 300 RVA: 0x00008687 File Offset: 0x00006887
	// (set) Token: 0x0600012D RID: 301 RVA: 0x0000868F File Offset: 0x0000688F
	public int uniqueAssetIndex
	{
		get
		{
			return this._uniqueAssetIndex;
		}
		set
		{
			this._uniqueAssetIndex = value;
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00008698 File Offset: 0x00006898
	public override void Init()
	{

	}

	// Token: 0x0600012F RID: 303 RVA: 0x00008774 File Offset: 0x00006974
	private Dictionary<AssetController.ResourceTypes, List<int>> ReserveIds(Dictionary<AssetController.ResourceTypes, int> description)
	{

        return default;
    }

	// Token: 0x06000130 RID: 304 RVA: 0x00008818 File Offset: 0x00006A18
	public int ReserveIdForDynamicProperty()
	{

        return default;
    }

	// Token: 0x06000131 RID: 305 RVA: 0x00008838 File Offset: 0x00006A38
	public Dictionary<AssetController.ResourceTypes, List<int>> ReserveResourceIdsForGestalt(AgentGestalt agentGestalt)
	{

        return default;
    }

	// Token: 0x06000132 RID: 306 RVA: 0x00008924 File Offset: 0x00006B24
	private int LoadImageAsset(UserAssetsController.AssetDescription assetDescription)
	{

        return default;
    }

	// Token: 0x06000133 RID: 307 RVA: 0x00008994 File Offset: 0x00006B94
	private Texture2D CreateImageAsset(int assetIndex, string info)
	{

        return default;
    }

	// Token: 0x06000134 RID: 308 RVA: 0x000089EC File Offset: 0x00006BEC
	public void LoadExternalUserAssetTexture(string md5, byte[] pixels, int existingResourceId)
	{

	}

	// Token: 0x06000135 RID: 309 RVA: 0x00008A82 File Offset: 0x00006C82
	private Texture2D LoadTexture(byte[] rawData)
	{

        return default;
    }

	// Token: 0x06000136 RID: 310 RVA: 0x00008AB0 File Offset: 0x00006CB0
	public string GetTextureInfo(int index)
	{

        return default;
    }

	// Token: 0x06000137 RID: 311 RVA: 0x00008AEC File Offset: 0x00006CEC
	public int GetTextureReferenceCount(int index)
	{

        return default;
    }

	// Token: 0x06000138 RID: 312 RVA: 0x00008B4E File Offset: 0x00006D4E
	public Texture GetTexture(int index)
	{

        return default;
    }

	// Token: 0x06000139 RID: 313 RVA: 0x00008B88 File Offset: 0x00006D88
	public Texture2D GetUserTexture(int index)
	{

        return default;
    }

	// Token: 0x0600013A RID: 314 RVA: 0x00008BB5 File Offset: 0x00006DB5
	public RenderTexture GetDynamicTexture(int index)
	{

        return default;
    }

	// Token: 0x0600013B RID: 315 RVA: 0x00008BE4 File Offset: 0x00006DE4
	public int GetTextureIndexForMD5(string md5)
	{

        return default;
    }

	// Token: 0x0600013C RID: 316 RVA: 0x00008C68 File Offset: 0x00006E68
	public bool DoesTextureExist(int index)
	{

        return default;
    }

	// Token: 0x0600013D RID: 317 RVA: 0x00008C78 File Offset: 0x00006E78
	public bool DoesTextureExist(string md5)
	{

        return default;
    }

	// Token: 0x0600013E RID: 318 RVA: 0x00008CE0 File Offset: 0x00006EE0
	public bool IsUserTexture(int index)
	{

        return default;
    }

	// Token: 0x0600013F RID: 319 RVA: 0x00008D20 File Offset: 0x00006F20
	public bool IsDynamicTexture(int index)
	{

        return default;
    }

	// Token: 0x06000140 RID: 320 RVA: 0x00008D60 File Offset: 0x00006F60
	public bool IsWebcamTexture(int index)
	{

        return default;
    }

	// Token: 0x06000141 RID: 321 RVA: 0x00008D9F File Offset: 0x00006F9F
	public IEnumerable<int> GetAllImageIndices()
	{

        return default;
    }

	// Token: 0x06000142 RID: 322 RVA: 0x00008DB4 File Offset: 0x00006FB4
	public RenderTexture CreateDynamicTexture(int index, int width, int height, string info, bool uiOnly = false)
	{

        return default;
    }

	// Token: 0x06000143 RID: 323 RVA: 0x00008E46 File Offset: 0x00007046
	public RenderTexture CreateDynamicTexture(int index, string info, bool uiOnly = false)
	{

        return default;
    }

	// Token: 0x06000144 RID: 324 RVA: 0x00008E60 File Offset: 0x00007060
	public WebCamTexture CreateWebcamTexture(int index, string info)
	{

        return default;
    }

	// Token: 0x06000145 RID: 325 RVA: 0x00008ED4 File Offset: 0x000070D4
	public void DestroyTexture(int index)
	{

	}

	// Token: 0x06000146 RID: 326 RVA: 0x00008F79 File Offset: 0x00007179
	public void PurgeAssets()
	{

	}

	// Token: 0x06000147 RID: 327 RVA: 0x00008F88 File Offset: 0x00007188
	private void KillZombieTextures()
	{

	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000905C File Offset: 0x0000725C
	private IEnumerator RunKillZombieTextures()
	{

        return default;
    }

	// Token: 0x06000149 RID: 329 RVA: 0x0000906C File Offset: 0x0000726C
	public void CopyRawDataToTexture(int index, byte[] rawData)
	{

	}

	// Token: 0x0600014A RID: 330 RVA: 0x000090E0 File Offset: 0x000072E0
	public void IncrementReferenceCountForTexture(int index)
	{

	}

	// Token: 0x0600014B RID: 331 RVA: 0x00009148 File Offset: 0x00007348
	public void DecrementReferenceCountForTexture(int index)
	{

	}

	// Token: 0x0600014C RID: 332 RVA: 0x000091BC File Offset: 0x000073BC
	private void OnDestroy()
	{

	}

	// Token: 0x0600014D RID: 333 RVA: 0x00009234 File Offset: 0x00007434
	private void Log(string message)
	{

	}

	// Token: 0x0600014E RID: 334 RVA: 0x00009243 File Offset: 0x00007443
	private void LogVerbose(string message)
	{

	}

	// Token: 0x0600014F RID: 335 RVA: 0x00009252 File Offset: 0x00007452
	private void LogWarning(string message)
	{

	}

	// Token: 0x06000150 RID: 336 RVA: 0x00009261 File Offset: 0x00007461
	private void LogError(string message)
	{

	}

	// Token: 0x0400015C RID: 348
	public int textureWidth;

	// Token: 0x0400015D RID: 349
	public int textureHeight;

	// Token: 0x0400015E RID: 350
	public int thumbnailWidth;

	// Token: 0x0400015F RID: 351
	public int thumbnailHeight;

	// Token: 0x04000160 RID: 352
	public int renderTextureDepth;

	// Token: 0x04000161 RID: 353
	public RenderTextureFormat renderTextureFormat;

	// Token: 0x04000162 RID: 354
	public TextureFormat userTextureFormat;

	// Token: 0x04000163 RID: 355
	public List<string> soundEvents;

	// Token: 0x04000164 RID: 356
	public const int emptyTextureIndex = 0;

	// Token: 0x04000165 RID: 357
	public const int runtimeTextureIndex = 1;

	// Token: 0x04000166 RID: 358
	public const int emptySoundIndex = 2;

	// Token: 0x04000167 RID: 359
	public const int firstAssetIndex = 3;

	// Token: 0x04000168 RID: 360
	public const string emptyLabel = "<EMPTY>";

	// Token: 0x04000169 RID: 361
	public const string currentLabel = "<CURRENT>";

	// Token: 0x0400016A RID: 362
	private Dictionary<int, AssetController.ImageAssetInfo> _textures;

	// Token: 0x0400016B RID: 363
	private Dictionary<int, AssetController.ImageAssetInfo> _zombieTextures;

	// Token: 0x0400016C RID: 364
	private int _uniqueAssetIndex;

	// Token: 0x020002DA RID: 730
	public enum ResourceTypes
	{
		// Token: 0x0400196B RID: 6507
		UserTexture,
		// Token: 0x0400196C RID: 6508
		DynamicTexture,
		// Token: 0x0400196D RID: 6509
		WebcamTexture,
		// Token: 0x0400196E RID: 6510
		LibrarySound
	}

	// Token: 0x020002DB RID: 731
	private class ImageAssetInfo
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x00096396 File Offset: 0x00094596
		public ImageAssetInfo(Texture texture, AssetController.ResourceTypes type, string info)
		{

		}

		// Token: 0x0400196F RID: 6511
		public Texture texture;

		// Token: 0x04001970 RID: 6512
		public AssetController.ResourceTypes type;

		// Token: 0x04001971 RID: 6513
		public string info;

		// Token: 0x04001972 RID: 6514
		public string md5;

		// Token: 0x04001973 RID: 6515
		public int referenceCount;
	}

	// Token: 0x020002DC RID: 732
	// (Invoke) Token: 0x06001E60 RID: 7776
	public delegate void AssetImageAddEvent(int index);

	// Token: 0x020002DD RID: 733
	// (Invoke) Token: 0x06001E64 RID: 7780
	public delegate void AssetImageRemoveEvent(List<int> indices);
}
}