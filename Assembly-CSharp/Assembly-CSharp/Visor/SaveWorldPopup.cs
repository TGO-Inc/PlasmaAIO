using System;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x020002B3 RID: 691
	public class SaveWorldPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00089B8A File Offset: 0x00087D8A
		public string title
		{
			get
			{
				return "SAVE WORLD";
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00089B91 File Offset: 0x00087D91
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2074f, 1380f);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00089BA2 File Offset: 0x00087DA2
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x00089BAA File Offset: 0x00087DAA
		public bool canClose { get; private set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00089BB3 File Offset: 0x00087DB3
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x00089BBB File Offset: 0x00087DBB
		public object payload { get; private set; }

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00089BC4 File Offset: 0x00087DC4
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x00089BCC File Offset: 0x00087DCC
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00089BD5 File Offset: 0x00087DD5
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x00089BDD File Offset: 0x00087DDD
		public object closeEventPayload { get; private set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x00089BE6 File Offset: 0x00087DE6
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00089BEE File Offset: 0x00087DEE
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00089BF7 File Offset: 0x00087DF7
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00089BFE File Offset: 0x00087DFE
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00089C01 File Offset: 0x00087E01
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00089C04 File Offset: 0x00087E04
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00089D49 File Offset: 0x00087F49
		public void OnReveal()
		{

		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00089D52 File Offset: 0x00087F52
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00089D54 File Offset: 0x00087F54
		public void OnConceal()
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00089D56 File Offset: 0x00087F56
		public void Close()
		{

		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00089D6C File Offset: 0x00087F6C
		public void Save()
		{

		}

		// Token: 0x04001685 RID: 5765
		public TMP_InputField worldNameField;

		// Token: 0x04001686 RID: 5766
		public TMP_InputField descriptionField;

		// Token: 0x04001687 RID: 5767
		public BetterToggle saveAsNewToggle;

		// Token: 0x04001688 RID: 5768
		public TextMeshProUGUI numberOfDevices;

		// Token: 0x04001689 RID: 5769
		public TextMeshProUGUI biome;

		// Token: 0x0400168A RID: 5770
		public TextMeshProUGUI time;

		// Token: 0x0400168B RID: 5771
		public RawImage preview;

		// Token: 0x0400168C RID: 5772
		public GameObject stagedIcon;

		// Token: 0x0400168D RID: 5773
		public GameObject stagedDetail;

		// Token: 0x0400168E RID: 5774
		private Visor _visor;
	}
}
