using System;
using System.IO;
using UnityEngine;

// Token: 0x0200017E RID: 382
public static class Plasma
{
	// Token: 0x06000E84 RID: 3716 RVA: 0x0004A300 File Offset: 0x00048500
	public static void Log(string message)
	{

	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x0004A30F File Offset: 0x0004850F
	public static void LogWarning(string message)
	{

	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0004A31E File Offset: 0x0004851E
	public static void LogError(string message)
	{

	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x0004A32C File Offset: 0x0004852C
	public static bool ReadVersion(out string build, out string commit)
	{
        build = default;
        commit = default;

        return default;
    }

	// Token: 0x04000BEC RID: 3052
	private const string versionFileName = "version.txt";

	// Token: 0x04000BED RID: 3053
	private const string localBuild = "BETA 0.1.95";
}
