using System;
using TheraBytes.BetterUi;
using UnityEngine;

namespace Visor
{
	// Token: 0x020002B0 RID: 688
	public class FindWorldPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0008953C File Offset: 0x0008773C
		public string title
		{
			get
			{
				return "FIND WORLD";
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00089543 File Offset: 0x00087743
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1600f, 1000f);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x00089554 File Offset: 0x00087754
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0008955C File Offset: 0x0008775C
		public bool canClose { get; private set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x00089565 File Offset: 0x00087765
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0008956D File Offset: 0x0008776D
		public object payload { get; private set; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00089576 File Offset: 0x00087776
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0008957E File Offset: 0x0008777E
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00089587 File Offset: 0x00087787
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0008958F File Offset: 0x0008778F
		public object closeEventPayload { get; private set; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00089598 File Offset: 0x00087798
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x000895A0 File Offset: 0x000877A0
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000895A9 File Offset: 0x000877A9
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000895B0 File Offset: 0x000877B0
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000895B3 File Offset: 0x000877B3
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000895B6 File Offset: 0x000877B6
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000895C8 File Offset: 0x000877C8
		public void OnReveal()
		{

		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x000895D1 File Offset: 0x000877D1
		public void OnFinishReveal()
		{

		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000895DE File Offset: 0x000877DE
		public void OnConceal()
		{
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000895E0 File Offset: 0x000877E0
		public void Close()
		{

		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000895F0 File Offset: 0x000877F0
		public void Find()
		{

		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00089648 File Offset: 0x00087848
		private void HandleQuery(bool success, WorkshopController.WorkshopQueryResult result)
		{

		}

		// Token: 0x04001667 RID: 5735
		public BetterTextMeshProInputField inputField;

		// Token: 0x04001668 RID: 5736
		public GameObject loadingCircle;

		// Token: 0x04001669 RID: 5737
		public GameObject errorMessage;

		// Token: 0x0400166A RID: 5738
		public GameObject ownDeviceMessage;

		// Token: 0x0400166B RID: 5739
		private Visor _visor;
	}
}
