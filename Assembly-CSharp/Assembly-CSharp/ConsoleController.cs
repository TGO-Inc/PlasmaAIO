using System;
using QFSW.QC;
using UnityEngine;

// Token: 0x02000037 RID: 55
public class ConsoleController : Controller
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000162 RID: 354 RVA: 0x0000944D File Offset: 0x0000764D
	public bool hasConsole
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00009450 File Offset: 0x00007650
	public override void Init()
	{

	}

	// Token: 0x06000164 RID: 356 RVA: 0x0000945D File Offset: 0x0000765D
	public void ToggleConsole()
	{

	}

	// Token: 0x06000165 RID: 357 RVA: 0x00009478 File Offset: 0x00007678
	[Command("camera-smoothing", MonoTargetType.All, Platform.AllPlatforms)]
	public string SetCameraSmoothing(float value)
	{

        return default;
    }

	// Token: 0x06000166 RID: 358 RVA: 0x00009496 File Offset: 0x00007696
	[Command("camera-smoothing", MonoTargetType.All, Platform.AllPlatforms)]
	public string SetCameraSmoothing()
	{

        return default;
    }

	// Token: 0x06000167 RID: 359 RVA: 0x000094B4 File Offset: 0x000076B4
	[Command("lights-shadows", MonoTargetType.All, Platform.AllPlatforms)]
	public void SetLightsShadows(bool value)
	{

	}

	// Token: 0x06000168 RID: 360 RVA: 0x00009530 File Offset: 0x00007730
	[CommandDescription("Generates a list of all commands currently loaded by the Quantum Console Processor")]
	[Command("commands", Platform.AllPlatforms, MonoTargetType.Single)]
	[Command("all-commands", Platform.AllPlatforms, MonoTargetType.Single)]
	public string GenerateCommandList()
	{

        return default;
    }

	// Token: 0x06000169 RID: 361 RVA: 0x00009590 File Offset: 0x00007790
	[Command("build-replay-step", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetStepChange(float value)
	{

        return default;
    }

	// Token: 0x0600016A RID: 362 RVA: 0x000095C4 File Offset: 0x000077C4
	[Command("build-replay-step", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetStepChange()
	{

        return default;
    }

	// Token: 0x0600016B RID: 363 RVA: 0x000095F4 File Offset: 0x000077F4
	[Command("build-replay-camera", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetCamera(float value)
	{

        return default;
    }

	// Token: 0x0600016C RID: 364 RVA: 0x00009628 File Offset: 0x00007828
	[Command("build-replay-camera", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetCamera()
	{

        return default;
    }

	// Token: 0x0600016D RID: 365 RVA: 0x00009658 File Offset: 0x00007858
	[Command("build-replay-wait", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetWait(float value)
	{

        return default;
    }

	// Token: 0x0600016E RID: 366 RVA: 0x0000968C File Offset: 0x0000788C
	[Command("build-replay-wait", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetWait()
	{

        return default;
    }

	// Token: 0x0600016F RID: 367 RVA: 0x000096BC File Offset: 0x000078BC
	[Command("build-replay-delay", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetDelay(float value)
	{

        return default;
    }

	// Token: 0x06000170 RID: 368 RVA: 0x000096F0 File Offset: 0x000078F0
	[Command("build-replay-delay", MonoTargetType.All, Platform.AllPlatforms)]
	public string BuildReplaySetDelay()
	{

        return default;
    }

	// Token: 0x06000171 RID: 369 RVA: 0x00009720 File Offset: 0x00007920
	[Command("key-light-rotation", MonoTargetType.All, Platform.AllPlatforms)]
	public string SunRing()
	{

        return default;
    }

	// Token: 0x06000172 RID: 370 RVA: 0x00009748 File Offset: 0x00007948
	[Command("key-light-rotation", MonoTargetType.All, Platform.AllPlatforms)]
	public void SunRing(string rotation)
	{

	}

	// Token: 0x0400017B RID: 379
	private QuantumConsole _quantumConsole;
}
