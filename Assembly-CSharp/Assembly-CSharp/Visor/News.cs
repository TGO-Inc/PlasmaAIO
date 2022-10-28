using System;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000254 RID: 596
	public class News : MonoBehaviour, IGenericWindow
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x0006F710 File Offset: 0x0006D910
		public string title
		{
			get
			{
				return "NEWS!";
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x0006F717 File Offset: 0x0006D917
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1766f, 1720f);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x0006F728 File Offset: 0x0006D928
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x0006F730 File Offset: 0x0006D930
		public bool canClose { get; private set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x0006F739 File Offset: 0x0006D939
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x0006F741 File Offset: 0x0006D941
		public object payload { get; private set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x0006F74A File Offset: 0x0006D94A
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x0006F752 File Offset: 0x0006D952
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x0006F75B File Offset: 0x0006D95B
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x0006F763 File Offset: 0x0006D963
		public object closeEventPayload { get; private set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x0006F76C File Offset: 0x0006D96C
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x0006F774 File Offset: 0x0006D974
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x0006F77D File Offset: 0x0006D97D
		public string exitKey
		{
			get
			{
				return "NW_Toggle";
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x0006F784 File Offset: 0x0006D984
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x0006F787 File Offset: 0x0006D987
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0006F78A File Offset: 0x0006D98A
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0006F7A8 File Offset: 0x0006D9A8
		public void OnReveal()
		{

		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0006F7B1 File Offset: 0x0006D9B1
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0006F7B3 File Offset: 0x0006D9B3
		public void OnConceal()
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0006F7B5 File Offset: 0x0006D9B5
		public void Close()
		{

		}

		// Token: 0x040011EA RID: 4586
		private Visor _visor;
	}
}
