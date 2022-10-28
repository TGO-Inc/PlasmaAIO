using System;
using UnityEngine;

// Token: 0x0200016D RID: 365
public class GraphicsControllers : MonoBehaviour
{
	// Token: 0x06000E23 RID: 3619 RVA: 0x000480B2 File Offset: 0x000462B2
	private void Awake()
	{

	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x000480D4 File Offset: 0x000462D4
	private static T Init<T>() where T : Controller
	{

        return default;
    }

	// Token: 0x04000BA8 RID: 2984
	public static EnvironmentController environmentController;

	// Token: 0x04000BA9 RID: 2985
	public static VFXController vfxController;

	// Token: 0x04000BAA RID: 2986
	public static QualitySettingsController qualitySettingsController;
}
