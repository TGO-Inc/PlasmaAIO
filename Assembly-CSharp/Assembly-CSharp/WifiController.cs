using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x0200004F RID: 79
public class WifiController : Controller
{
	// Token: 0x06000292 RID: 658 RVA: 0x00013364 File Offset: 0x00011564
	public override void Init()
	{

	}

	// Token: 0x06000293 RID: 659 RVA: 0x000133B0 File Offset: 0x000115B0
	public void Purge()
	{

	}

	// Token: 0x06000294 RID: 660 RVA: 0x000133E0 File Offset: 0x000115E0
	private void OnDestroy()
	{

	}

	// Token: 0x06000295 RID: 661 RVA: 0x000133F4 File Offset: 0x000115F4
	private void HandleOnPreUpdateDevices()
	{

	}

	// Token: 0x06000296 RID: 662 RVA: 0x00013434 File Offset: 0x00011634
	public void Broadcast(int senderDeviceGuid, int frequency, WifiController.Channels channel, Data data)
	{

	}

	// Token: 0x06000297 RID: 663 RVA: 0x000134EC File Offset: 0x000116EC
	public Data FetchData(int deviceGuid, int frequency, WifiController.Channels channel)
	{

        return default;
    }

	// Token: 0x06000298 RID: 664 RVA: 0x000135A0 File Offset: 0x000117A0
	public void Log(string message)
	{

	}

	// Token: 0x06000299 RID: 665 RVA: 0x000135AF File Offset: 0x000117AF
	public void LogVerbose(string message)
	{

	}

	// Token: 0x0600029A RID: 666 RVA: 0x000135BE File Offset: 0x000117BE
	public void LogWarning(string message)
	{

	}

	// Token: 0x0600029B RID: 667 RVA: 0x000135CD File Offset: 0x000117CD
	public void LogError(string message)
	{

	}

	// Token: 0x04000375 RID: 885
	private Dictionary<int, WifiController.Packet[]> _dataBuffer1;

	// Token: 0x04000376 RID: 886
	private Dictionary<int, WifiController.Packet[]> _dataBuffer2;

	// Token: 0x04000377 RID: 887
	private Dictionary<int, WifiController.Packet[]> _queuedBroadcastData;

	// Token: 0x04000378 RID: 888
	private Dictionary<int, WifiController.Packet[]> _broadcastData;

	// Token: 0x020002F5 RID: 757
	public enum Channels
	{
		// Token: 0x04001A0F RID: 6671
		One,
		// Token: 0x04001A10 RID: 6672
		Two,
		// Token: 0x04001A11 RID: 6673
		Three
	}

	// Token: 0x020002F6 RID: 758
	private class Packet
	{
		// Token: 0x04001A12 RID: 6674
		public int deviceGuid;

		// Token: 0x04001A13 RID: 6675
		public Data data;
	}
}
