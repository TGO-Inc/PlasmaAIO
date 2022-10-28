using System;
using System.Collections;
using System.IO;
using EasyFeedback;
using EasyFeedback.APIs;
using Tayx.Graphy;
using Tayx.Graphy.Utils;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x02000251 RID: 593
	public class FeedbackPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0006EF10 File Offset: 0x0006D110
		public string title
		{
			get
			{
				return "FEEDBACK";
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x0006EF17 File Offset: 0x0006D117
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1280f, 1500f);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0006EF28 File Offset: 0x0006D128
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0006EF30 File Offset: 0x0006D130
		public bool canClose { get; private set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0006EF39 File Offset: 0x0006D139
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0006EF41 File Offset: 0x0006D141
		public object payload { get; private set; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0006EF4A File Offset: 0x0006D14A
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x0006EF52 File Offset: 0x0006D152
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x0006EF5B File Offset: 0x0006D15B
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x0006EF63 File Offset: 0x0006D163
		public object closeEventPayload { get; private set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x0006EF6C File Offset: 0x0006D16C
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x0006EF74 File Offset: 0x0006D174
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x0006EF7D File Offset: 0x0006D17D
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x0006EF84 File Offset: 0x0006D184
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x0006EF87 File Offset: 0x0006D187
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0006EF8C File Offset: 0x0006D18C
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0006F0E4 File Offset: 0x0006D2E4
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0006F106 File Offset: 0x0006D306
		private void HandleTitleEndEdit(string text)
		{

		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0006F128 File Offset: 0x0006D328
		private void HandleContentEndEdit(string text)
		{

		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0006F14A File Offset: 0x0006D34A
		private void HandleContentChange(string text)
		{

		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0006F160 File Offset: 0x0006D360
		public void OnReveal()
		{

		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0006F180 File Offset: 0x0006D380
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0006F182 File Offset: 0x0006D382
		public void OnConceal()
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0006F184 File Offset: 0x0006D384
		public void Submit()
		{

		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0006F55A File Offset: 0x0006D75A
		private void HandleSubmitResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0006F569 File Offset: 0x0006D769
		private IEnumerator SubmitFeedback()
		{

            return default;
        }

		// Token: 0x0600160D RID: 5645 RVA: 0x0006F578 File Offset: 0x0006D778
		public void Close()
		{

		}

		// Token: 0x040011D0 RID: 4560
		public TMP_InputField titleField;

		// Token: 0x040011D1 RID: 4561
		public TMP_InputField contentField;

		// Token: 0x040011D2 RID: 4562
		public BetterButton submitButton;

		// Token: 0x040011D3 RID: 4563
		public EFConfig config;

		// Token: 0x040011D4 RID: 4564
		private Visor _visor;

		// Token: 0x040011D5 RID: 4565
		private Report _report;

		// Token: 0x040011D6 RID: 4566
		private Trello _trello;

		// Token: 0x040011D7 RID: 4567
		private const string _contentSection = "Content";

		// Token: 0x040011D8 RID: 4568
		private const string _timeSection = "Time and Date";

		// Token: 0x040011D9 RID: 4569
		private const string _versionSection = "Version";

		// Token: 0x040011DA RID: 4570
		private const string _additionalInfoSection = "Additional Info";

		// Token: 0x040011DB RID: 4571
		private const string _performanceSection = "Performance Data";

		// Token: 0x040011DC RID: 4572
		private const string _systemInfoSection = "System Info";
	}
}
