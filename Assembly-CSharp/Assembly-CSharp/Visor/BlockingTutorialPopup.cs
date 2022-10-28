using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200024D RID: 589
	public class BlockingTutorialPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0006E317 File Offset: 0x0006C517
		public string title
		{
			get
			{
				return this._gestalt.title;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0006E324 File Offset: 0x0006C524
		public Vector2 requiredSize
		{
			get
			{
				return this._gestalt.size;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0006E331 File Offset: 0x0006C531
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x0006E339 File Offset: 0x0006C539
		public bool canClose { get; private set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0006E342 File Offset: 0x0006C542
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x0006E34A File Offset: 0x0006C54A
		public object payload { get; private set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0006E353 File Offset: 0x0006C553
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x0006E35B File Offset: 0x0006C55B
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0006E364 File Offset: 0x0006C564
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0006E36C File Offset: 0x0006C56C
		public object closeEventPayload { get; private set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x0006E375 File Offset: 0x0006C575
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x0006E37D File Offset: 0x0006C57D
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x0006E386 File Offset: 0x0006C586
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0006E38D File Offset: 0x0006C58D
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0006E390 File Offset: 0x0006C590
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0006E394 File Offset: 0x0006C594
		public void Setup(object setupData)
		{

		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0006E433 File Offset: 0x0006C633
		public void OnReveal()
		{

		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0006E43C File Offset: 0x0006C63C
		public void OnFinishReveal()
		{
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0006E43E File Offset: 0x0006C63E
		public void OnConceal()
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0006E440 File Offset: 0x0006C640
		public void Close()
		{

		}

		// Token: 0x040011A7 RID: 4519
		public Image image;

		// Token: 0x040011A8 RID: 4520
		public TextMeshProUGUI text;

		// Token: 0x040011A9 RID: 4521
		private Visor _visor;

		// Token: 0x040011AA RID: 4522
		private BlockingTutorialGestalt _gestalt;
	}
}
