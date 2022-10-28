using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlasmaAPI.GameClass {
// Token: 0x02000039 RID: 57
public class DirectorController : Controller
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000176 RID: 374 RVA: 0x000097DC File Offset: 0x000079DC
	// (set) Token: 0x06000177 RID: 375 RVA: 0x000097E4 File Offset: 0x000079E4
	public DirectorController.Role role { get; set; }

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000178 RID: 376 RVA: 0x000097ED File Offset: 0x000079ED
	// (set) Token: 0x06000179 RID: 377 RVA: 0x000097F5 File Offset: 0x000079F5
	public float mainMenuLoadSceneProgress { get; set; }

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600017A RID: 378 RVA: 0x000097FE File Offset: 0x000079FE
	// (set) Token: 0x0600017B RID: 379 RVA: 0x00009806 File Offset: 0x00007A06
	public float worldLoadSceneProgress { get; set; }

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600017C RID: 380 RVA: 0x0000980F File Offset: 0x00007A0F
	public int worldIndex
	{
		get
		{
			return this._worldIndex;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600017D RID: 381 RVA: 0x00009817 File Offset: 0x00007A17
	public float time
	{
		get
		{
			return this._time;
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000981F File Offset: 0x00007A1F
	private void Update()
	{

	}

	// Token: 0x0600017F RID: 383 RVA: 0x00009833 File Offset: 0x00007A33
	public override void Init()
	{

	}

	// Token: 0x06000180 RID: 384 RVA: 0x00009855 File Offset: 0x00007A55
	public void GoToMainMenu()
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00009857 File Offset: 0x00007A57
	public bool IsHost()
	{

        return default;
    }

	// Token: 0x06000182 RID: 386 RVA: 0x00009862 File Offset: 0x00007A62
	public bool IsRemoteClient()
	{

        return default;
    }

	// Token: 0x06000183 RID: 387 RVA: 0x0000986D File Offset: 0x00007A6D
	private IEnumerator LoadMenuScene()
	{

        return default;
    }

	// Token: 0x06000184 RID: 388 RVA: 0x0000987C File Offset: 0x00007A7C
	private IEnumerator LoadWorldScene()
	{

        return default;
    }

	// Token: 0x06000185 RID: 389 RVA: 0x0000988B File Offset: 0x00007A8B
	public bool CommandLineContains(string value)
	{

        return default;
    }

	// Token: 0x04000181 RID: 385
	private int _worldIndex = -1;

	// Token: 0x04000182 RID: 386
	private float _time;

	// Token: 0x04000183 RID: 387
	private string _commandLine;

	// Token: 0x020002DF RID: 735
	public enum Role
	{
		// Token: 0x04001978 RID: 6520
		Host,
		// Token: 0x04001979 RID: 6521
		RemoteClient
	}
}
}