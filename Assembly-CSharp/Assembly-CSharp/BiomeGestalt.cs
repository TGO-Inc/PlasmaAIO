using System;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x02000166 RID: 358
[CreateAssetMenu(menuName = "Plasma/Biome Gestalt")]
public class BiomeGestalt : SerializedScriptableObject
{
	// Token: 0x06000E0D RID: 3597 RVA: 0x00047A10 File Offset: 0x00045C10
	private void SetAsInvalid()
	{

	}

	// Token: 0x04000B63 RID: 2915
	public string displayName;

	// Token: 0x04000B64 RID: 2916
	public string description;

	// Token: 0x04000B65 RID: 2917
	public string sceneName;

	// Token: 0x04000B66 RID: 2918
	public Vector3 position;

	// Token: 0x04000B67 RID: 2919
	public float radius;

	// Token: 0x04000B68 RID: 2920
	public float playableRadius;

	// Token: 0x04000B69 RID: 2921
	public Vector3 surfaceCenter;

	// Token: 0x04000B6A RID: 2922
	public Vector3 playerPosition;

	// Token: 0x04000B6B RID: 2923
	public Vector3 playerOrientation;

	// Token: 0x04000B6C RID: 2924
	public Vector3 deviceRespawnPosition;

	// Token: 0x04000B6D RID: 2925
	public float gravity;

	// Token: 0x04000B6E RID: 2926
	public Vector3 cameraPosition;

	// Token: 0x04000B6F RID: 2927
	public Vector3 cameraRotation;

	// Token: 0x04000B70 RID: 2928
	public float cameraSize;

	// Token: 0x04000B71 RID: 2929
	public Texture2D preview;

	// Token: 0x04000B72 RID: 2930
	public int listPosition;

	// Token: 0x04000B73 RID: 2931
	public bool hidden;

	// Token: 0x04000B74 RID: 2932
	public BiomeGestaltEnum id;
}
