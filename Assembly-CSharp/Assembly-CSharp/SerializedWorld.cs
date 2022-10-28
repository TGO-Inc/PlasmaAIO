using System;
using System.Runtime.Serialization;
using UnityEngine;

// Token: 0x02000189 RID: 393
public class SerializedWorld
{
	// Token: 0x06000EA4 RID: 3748 RVA: 0x0004B387 File Offset: 0x00049587
	public SerializedWorld()
	{

	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x0004B398 File Offset: 0x00049598
	[OnDeserialized]
	public void Defaults()
	{

	}

	// Token: 0x04000C56 RID: 3158
	public SerializedDevice[] devices;

	// Token: 0x04000C57 RID: 3159
	public string[] devicesMetaData;

	// Token: 0x04000C58 RID: 3160
	public int[] devicesSaveCounter;

	// Token: 0x04000C59 RID: 3161
	public SerializedAssetsLibrary assetsLibrary;

	// Token: 0x04000C5A RID: 3162
	public float timeOfDay;

	// Token: 0x04000C5B RID: 3163
	public float timeSpeed;

	// Token: 0x04000C5C RID: 3164
	public int assetControllerUniqueId;

	// Token: 0x04000C5D RID: 3165
	public Vector3 playerPosition;

	// Token: 0x04000C5E RID: 3166
	public Vector3 playerOrientation;

	// Token: 0x04000C5F RID: 3167
	public SerializedPropsManager dynamicPropsManager;

	// Token: 0x04000C60 RID: 3168
	public WorldController.WorldPermissions permissions;

	// Token: 0x04000C61 RID: 3169
	public WorldController.GlobalPermissions globalPermissions;

	// Token: 0x04000C62 RID: 3170
	public bool hasMountedDevice;

	// Token: 0x04000C63 RID: 3171
	public int mountedDeviceId;

	// Token: 0x04000C64 RID: 3172
	public int mountedComponentId;

	// Token: 0x04000C65 RID: 3173
	public BuildReplayCanvas.SerializedData buildReplaySerializedData;

	// Token: 0x04000C66 RID: 3174
	public float stagedTimeOfDay;

	// Token: 0x04000C67 RID: 3175
	public float stagedTimeSpeed;

	// Token: 0x04000C68 RID: 3176
	public Vector3 stagedPlayerPosition;

	// Token: 0x04000C69 RID: 3177
	public Vector3 stagedPlayerOrientation;

	// Token: 0x04000C6A RID: 3178
	public int version;

	// Token: 0x04000C6B RID: 3179
	[NonSerialized]
	private const int currentVersion = 2;
}
