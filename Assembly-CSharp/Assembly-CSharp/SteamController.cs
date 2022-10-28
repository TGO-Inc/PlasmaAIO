using System;
using System.Text;
using Steamworks;
using UnityEngine;

// Token: 0x02000047 RID: 71
public class SteamController : Controller
{
	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600021C RID: 540 RVA: 0x0000F364 File Offset: 0x0000D564
	// (remove) Token: 0x0600021D RID: 541 RVA: 0x0000F39C File Offset: 0x0000D59C
	public event global::SteamController.UserInformationRetrieved OnUserInformationRetrieved;

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600021E RID: 542 RVA: 0x0000F3D1 File Offset: 0x0000D5D1
	public AppId_t appId
	{
		get
		{
			return this._appId;
		}
	}

	// Token: 0x0600021F RID: 543 RVA: 0x0000F3D9 File Offset: 0x0000D5D9
	private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{

	}

	// Token: 0x06000220 RID: 544 RVA: 0x0000F3EC File Offset: 0x0000D5EC
	public override void Init()
	{

	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000F520 File Offset: 0x0000D720
	private void OnEnable()
	{

	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000F550 File Offset: 0x0000D750
	private void Update()
	{

	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000F560 File Offset: 0x0000D760
	private void OnDestroy()
	{

	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000F570 File Offset: 0x0000D770
	public bool IsSteamEnabled()
	{

        return default;
    }

	// Token: 0x06000225 RID: 549 RVA: 0x0000F57B File Offset: 0x0000D77B
	public ulong GetPlayerSteamId()
	{

        return default;
    }

	// Token: 0x06000226 RID: 550 RVA: 0x0000F58E File Offset: 0x0000D78E
	private void SetRandomPlayerID()
	{

	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000F5A2 File Offset: 0x0000D7A2
	private void RestorePlayerID()
	{

	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
	public bool RequestUserInformation(ulong steamId, out string userName)
	{
        userName = default;

        return default;
    }

	// Token: 0x06000229 RID: 553 RVA: 0x0000F5DC File Offset: 0x0000D7DC
	private void OnPersonaStateChange(PersonaStateChange_t pCallback)
	{

	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000F614 File Offset: 0x0000D814
	private void Log(string message)
	{

	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000F623 File Offset: 0x0000D823
	private void LogWarning(string message)
	{

	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000F632 File Offset: 0x0000D832
	private void LogError(string message)
	{

	}

	// Token: 0x0400026C RID: 620
	public bool skipSteamInitialization;

	// Token: 0x0400026D RID: 621
	private bool _initialized;

	// Token: 0x0400026E RID: 622
	private SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	// Token: 0x0400026F RID: 623
	private AppId_t _appId;

	// Token: 0x04000270 RID: 624
	private bool _disableSteam;

	// Token: 0x04000271 RID: 625
	private ulong _playerSteamID;

	// Token: 0x04000272 RID: 626
	private const uint appIdInternal = 2146660U;

	// Token: 0x04000273 RID: 627
	private Callback<PersonaStateChange_t> m_PersonaStateChange;

	// Token: 0x020002E9 RID: 745
	// (Invoke) Token: 0x06001E92 RID: 7826
	public delegate void UserInformationRetrieved(ulong steamId, string userName);
}
