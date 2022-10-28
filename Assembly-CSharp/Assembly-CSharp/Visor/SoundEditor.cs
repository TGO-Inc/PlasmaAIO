using System;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x020002A3 RID: 675
	public class SoundEditor : DataEditor
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x00086D2A File Offset: 0x00084F2A
		public override TMP_InputField mainTextField
		{
			get
			{
				return this.searchField;
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00086D32 File Offset: 0x00084F32
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00086D56 File Offset: 0x00084F56
		public override void CleanUp()
		{

		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00086D6C File Offset: 0x00084F6C
		public void HandleChange(string text)
		{

		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00086DD0 File Offset: 0x00084FD0
		public void HandleSubmit(string text)
		{

		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00086E2C File Offset: 0x0008502C
		public void SetSound(SoundRow soundRow)
		{

		}

		// Token: 0x040015AC RID: 5548
		public TMP_InputField searchField;

		// Token: 0x040015AD RID: 5549
		public SoundBrowser broswer;
	}
}
