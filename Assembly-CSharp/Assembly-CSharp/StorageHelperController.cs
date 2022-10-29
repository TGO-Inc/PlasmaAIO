using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Behavior;
using Sirenix.Serialization;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering;

namespace PlasmaAPI.GameClass {
// Token: 0x02000048 RID: 72
public class StorageHelperController : Controller
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600022E RID: 558 RVA: 0x0000F648 File Offset: 0x0000D848
	// (set) Token: 0x0600022F RID: 559 RVA: 0x0000F650 File Offset: 0x0000D850
	public int numberOfDevicesSerialized { get; private set; }

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000230 RID: 560 RVA: 0x0000F659 File Offset: 0x0000D859
	// (set) Token: 0x06000231 RID: 561 RVA: 0x0000F661 File Offset: 0x0000D861
	public bool worldSerialized { get; private set; }

	// Token: 0x06000232 RID: 562 RVA: 0x0000F66A File Offset: 0x0000D86A
	public override void Init()
	{

	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000F678 File Offset: 0x0000D878
	private static void PerformSanityCheckOnDeviceDirectory()
	{

	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000F844 File Offset: 0x0000DA44
	private static void PerformSanityCheckOnWorldDirectory()
	{

	}

	// Token: 0x06000235 RID: 565 RVA: 0x0000F9FC File Offset: 0x0000DBFC
	public static void SaveDeviceMetaData(SerializedDeviceMetaData serializedMetaData)
	{

	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000FA34 File Offset: 0x0000DC34
	public static SerializedDeviceMetaData LoadDeviceMetaData(string filename)
	{

        return default;
    }

	// Token: 0x06000237 RID: 567 RVA: 0x0000FA6E File Offset: 0x0000DC6E
	public void SaveDeviceToDiskAsync(Device device, string deviceName, string deviceDescription, bool overwrite, float rotationOffset)
	{

	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000FA84 File Offset: 0x0000DC84
	private IEnumerator SaveDeviceToDiskCoroutine(Device device, string deviceName, string deviceDescription, bool overwrite, float rotationOffset)
	{

        return default;
    }

	// Token: 0x06000239 RID: 569 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
	public static void SaveWorldMetaData(SerializedWorldMetaData serializedMetaData)
	{

	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
	public static SerializedWorldMetaData LoadWorldMetaData(string filename, WorldController.WorldTypes worldType)
	{

        return default;
    }

	// Token: 0x0600023B RID: 571 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
	public static SerializedWorld LoadWorld(string filename, WorldController.WorldTypes worldType)
	{

        return default;
    }

	// Token: 0x0600023C RID: 572 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
	public string SaveWorldToDiskAsync(StorageHelperController.SaveActions saveAction, bool resumeGame, Action handler = null)
	{

        return default;
    }

	// Token: 0x0600023D RID: 573 RVA: 0x0000FE1C File Offset: 0x0000E01C
	public void CloneWorldToDiskAsync(string title, Action handler = null)
	{

	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000FED8 File Offset: 0x0000E0D8
	public void SaveWorldToRamAsync(SerializedWorld serializedWorld)
	{

	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000FEE9 File Offset: 0x0000E0E9
	private IEnumerator SaveWorldToDiskCoroutine(SerializedWorld serializedWorld, Action onDone)
	{

        return default;
    }

	// Token: 0x06000240 RID: 576 RVA: 0x0000FF08 File Offset: 0x0000E108
	public string SaveEmptyWorld(BiomeGestalt biome, string worldName)
	{

        return default;
    }

	// Token: 0x06000241 RID: 577 RVA: 0x0001007C File Offset: 0x0000E27C
	public SerializedWorldMetaData GetProgressForWorld(string worldFilename)
	{

        return default;
    }

	// Token: 0x06000242 RID: 578 RVA: 0x000100C0 File Offset: 0x0000E2C0
	public void DeleteProgressForWorld(string worldFilename)
	{

	}

	// Token: 0x06000243 RID: 579 RVA: 0x000100EC File Offset: 0x0000E2EC
	private IEnumerator SaveSerializedDeviceAsyncCoroutine(Device device, SerializedDevice serializedDevice, SerializedAssetsLibrary serializedAssetsLibrary, bool saveRuntime)
	{

        return default;
    }

	// Token: 0x06000244 RID: 580 RVA: 0x00010118 File Offset: 0x0000E318
	public static void VisitComponent(ComponentHandler componentHandler, SerializedComponent serializedComponent)
	{

	}

	// Token: 0x06000245 RID: 581 RVA: 0x00010358 File Offset: 0x0000E558
	private void SaveUserAssets(Device device, SerializedAssetsLibrary serializedAssetsLibrary)
	{

	}

	// Token: 0x06000246 RID: 582 RVA: 0x00010500 File Offset: 0x0000E700
	public void LoadUserAssets(SerializedAssetsLibrary serializedAssetsLibrary, bool keepResoureceId = false)
	{

	}

	// Token: 0x06000247 RID: 583 RVA: 0x00010604 File Offset: 0x0000E804
	private IEnumerator SaveDeviceTexturesAsync(Device device, SerializedDevice serializedDevice, SerializedAssetsLibrary serializedTexturesLibrary)
	{

        return default;
    }

	// Token: 0x06000248 RID: 584 RVA: 0x00010628 File Offset: 0x0000E828
	private unsafe byte[] ExtractRawBuffer(NativeArray<Color32> buffer, int dataSize)
	{

        return default;
    }

	// Token: 0x06000249 RID: 585 RVA: 0x0001065C File Offset: 0x0000E85C
	public void UpdateUserAssetIndices(SerializedDevice serializedDevice, bool restoreRuntime)
	{

	}

	// Token: 0x0600024A RID: 586 RVA: 0x000106A8 File Offset: 0x0000E8A8
	private static void UpdateUserAssetIndicesInternal(Agent.Storage agentStorage)
	{

	}

	// Token: 0x0600024B RID: 587 RVA: 0x00010780 File Offset: 0x0000E980
	public void LoadDynamicAssetsForAgent(Agent agent, SerializedAgent serializedAgent, SerializedAssetsLibrary assetsLibrary)
	{

	}

	// Token: 0x0600024C RID: 588 RVA: 0x00010898 File Offset: 0x0000EA98
	private static byte[] GetMD5Hash(byte[] data)
	{

        return default;
    }

	// Token: 0x0600024D RID: 589 RVA: 0x000108A8 File Offset: 0x0000EAA8
	private static string GetMD5HashString(byte[] md5Hash)
	{

        return default;
    }

	// Token: 0x0600024E RID: 590 RVA: 0x000108E2 File Offset: 0x0000EAE2
	public static string GetMD5HashStringData(byte[] data)
	{

        return default;
    }

	// Token: 0x04000274 RID: 628
	public const string deviceExtension = "blueprint";

	// Token: 0x04000275 RID: 629
	public const string metaDataExtension = "metadata";

	// Token: 0x04000276 RID: 630
	private const string _worldExtension = "world";

	// Token: 0x020002EA RID: 746
	public enum SaveActions
	{
		// Token: 0x040019C4 RID: 6596
		New,
		// Token: 0x040019C5 RID: 6597
		Overwrite,
		// Token: 0x040019C6 RID: 6598
		Progress
	}
}
}