using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200016C RID: 364
public class GlobalControllers : MonoBehaviour
{
	// Token: 0x06000E20 RID: 3616 RVA: 0x00047FEC File Offset: 0x000461EC
	private void Awake()
	{

	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00048058 File Offset: 0x00046258
	private static T Init<T>() where T : Controller
	{

        return default;
    }

	// Token: 0x04000BA0 RID: 2976
	public GameObject rewiredObject;

	// Token: 0x04000BA1 RID: 2977
	public static LoggerController loggerController;

	// Token: 0x04000BA2 RID: 2978
	public static DirectorController directorController;

	// Token: 0x04000BA3 RID: 2979
	public static SteamController steamController;

	// Token: 0x04000BA4 RID: 2980
	public static UserAssetsController userAssetsController;

	// Token: 0x04000BA5 RID: 2981
	public static StorageHelperController storageHelperController;

	// Token: 0x04000BA6 RID: 2982
	public static WorkshopController workshopController;

	// Token: 0x04000BA7 RID: 2983
	public static ConsoleController consoleController;
}
}