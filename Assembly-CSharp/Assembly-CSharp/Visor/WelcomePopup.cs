using System;
using TMPro;
using UnityEngine;

namespace Visor
{
	// Token: 0x0200025B RID: 603
	public class WelcomePopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000712FD File Offset: 0x0006F4FD
		public string title
		{
			get
			{
				return "WELCOME TO";
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00071304 File Offset: 0x0006F504
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2900f, 1800f);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00071315 File Offset: 0x0006F515
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x0007131D File Offset: 0x0006F51D
		public bool canClose { get; private set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00071326 File Offset: 0x0006F526
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x0007132E File Offset: 0x0006F52E
		public object payload { get; private set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00071337 File Offset: 0x0006F537
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x0007133F File Offset: 0x0006F53F
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00071348 File Offset: 0x0006F548
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00071350 File Offset: 0x0006F550
		public object closeEventPayload { get; private set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00071359 File Offset: 0x0006F559
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x00071361 File Offset: 0x0006F561
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x0007136A File Offset: 0x0006F56A
		public string exitKey
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x0007136D File Offset: 0x0006F56D
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00071370 File Offset: 0x0006F570
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00071374 File Offset: 0x0006F574
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000713C4 File Offset: 0x0006F5C4
		public void OnReveal()
		{

		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000713CD File Offset: 0x0006F5CD
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000713CF File Offset: 0x0006F5CF
		public void OnConceal()
		{
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x000713D1 File Offset: 0x0006F5D1
		public void Close()
		{

		}

		// Token: 0x0400124F RID: 4687
		public TextMeshProUGUI version;

		// Token: 0x04001250 RID: 4688
		private Visor _visor;
	}
}
