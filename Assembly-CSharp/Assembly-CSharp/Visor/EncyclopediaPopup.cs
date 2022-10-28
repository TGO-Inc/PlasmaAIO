using System;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

namespace Visor
{
	// Token: 0x0200024F RID: 591
	public class EncyclopediaPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0006E8B3 File Offset: 0x0006CAB3
		public string title
		{
			get
			{
				return "ENCYCLOPEDIA";
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0006E8BA File Offset: 0x0006CABA
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(3040f, 1710f);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0006E8CB File Offset: 0x0006CACB
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0006E8D3 File Offset: 0x0006CAD3
		public bool canClose { get; private set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x0006E8DC File Offset: 0x0006CADC
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
		public object payload { get; private set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x0006E8ED File Offset: 0x0006CAED
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x0006E8F5 File Offset: 0x0006CAF5
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x0006E8FE File Offset: 0x0006CAFE
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x0006E906 File Offset: 0x0006CB06
		public object closeEventPayload { get; private set; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0006E90F File Offset: 0x0006CB0F
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0006E917 File Offset: 0x0006CB17
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0006E920 File Offset: 0x0006CB20
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0006E927 File Offset: 0x0006CB27
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0006E92A File Offset: 0x0006CB2A
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0006E930 File Offset: 0x0006CB30
		public void Setup(object setupData)
		{

		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0006E97E File Offset: 0x0006CB7E
		public void OnReveal()
		{

		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0006E994 File Offset: 0x0006CB94
		public void OnFinishReveal()
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0006E996 File Offset: 0x0006CB96
		public void OnConceal()
		{
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0006E998 File Offset: 0x0006CB98
		public void GoBack()
		{

		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0006E9A5 File Offset: 0x0006CBA5
		public void GoHome()
		{

		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0006E9B9 File Offset: 0x0006CBB9
		public void Close()
		{

		}

		// Token: 0x040011B9 RID: 4537
		public string url;

		// Token: 0x040011BA RID: 4538
		private Visor _visor;

		// Token: 0x040011BB RID: 4539
		private Browser _browser;

		// Token: 0x040011BC RID: 4540
		private bool _justLoaded;
	}
}
